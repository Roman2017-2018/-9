using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
class SmartParser
{
private List<LineOfCommand> comands;
private List<Tuple<char, string>> error;
public string path {get { return path;}
    set {
        List<string> linesOfRowCommands = new List<string>(File.ReadAllText(value).Split('\r', '\n'));
        List<Tuple<char, double>> doubleList = new List<Tuple<char, double>>();
        List<List<Tuple<char, string>>> list = new List<List<Tuple<char, string>>>();
        error = new List<Tuple<char, string>>();
        comands = new List<LineOfCommand>();
        foreach (var item in linesOfRowCommands) {
            var temp = parse(item);
            if (temp != null && temp.Count != null && temp.Count != 0)
                list.Add(temp);
        }
        foreach (var item in list) {
            var line = new LineOfCommand();
            foreach (var index in item) {
                doubleList.Add(Tuple.Create(index.Item1, convertToDouble(index.Item2)));
                switch (index.Item1) {
                    case 'F':
                        line.F = new Comand(index.Item1, convertToDouble(index.Item2));
                        break;
                    case 'G':
                        line.G = new Comand(index.Item1, convertToDouble(index.Item2));
                        break;
                    case 'X':
                        line.X = new Comand(index.Item1, convertToDouble(index.Item2));
                        break;
                    case 'Y':
                        line.Y = new Comand(index.Item1, convertToDouble(index.Item2));
                        break;
                    case 'Z':
                        line.Z = new Comand(index.Item1, convertToDouble(index.Item2));
                        break;
                    default:
                        error.Add(Tuple.Create(index.Item1, index.Item2));
                        break;
                }
            }
            comands.Add(line);
        }
    }
}

//-----------------------------------------------------------------------------
public SmartParser(string path) {
    this.path = path;
}

//-----------------------------------------------------------------------------
private class LineOfCommand
{
    public Comand F { get; set; } = new Comand('F', null);
    public Comand G { get; set; } = new Comand('G', null);
    public Comand X { get; set; } = new Comand('X', null);
    public Comand Y { get; set; } = new Comand('Y', null);
    public Comand Z { get; set; } = new Comand('Z', null);
}

//-----------------------------------------------------------------------------
private class Comand {
    public Comand(char type, double? value) {
        this.type = type;
        this.value = value;
    }
    public char type {get;set;}
    public double? value {get;set;}
}

//-----------------------------------------------------------------------------
public dynamic parse(string sourse) 
{
    List<Tuple<char, string>> rowData = new List<Tuple<char, string>>();
    if (!(sourse.Length > 1))
        return null;
    try {
        var list = parseCharacter(sourse);
        var length = sourse.Length;
        list.Sort((a, b) => a.Item2.CompareTo(b.Item2));
        for (int i = 0; i < list.Count; i++) {
            if (i == list.Count - 1)
                rowData.Add(
                    Tuple.Create(list[i].Item1,
                    sourse.Substring(list[i].Item2 + 1,
                    ((length) - (list[i].Item2 + 1))))
                );
            else
                rowData.Add(
                    Tuple.Create(list[i].Item1, 
                    sourse.Substring(list[i].Item2 + 1, 
                    (list[i + 1].Item2 - (list[i].Item2 + 1))))
                );
        }
    }
    catch {}
        return rowData;
}

//-----------------------------------------------------------------------------
private List<Tuple<char, int>> parseCharacter(string sourse) {

    List<Tuple<char, int>> lst = new List<Tuple<char, int>>();
    for (int i = 0; i < sourse.Length; i++) {
                switch (sourse[i]) {
                    case 'F':
                        lst.Add(Tuple.Create('F', i));
                        break;
                    case 'G':
                        lst.Add(Tuple.Create('G', i));
                        break;
                    case 'X':
                        lst.Add(Tuple.Create('X', i));
                        break;
                    case 'Y':
                        lst.Add(Tuple.Create('Y', i));
                        break;
                    case 'Z':
                        lst.Add(Tuple.Create('Z', i));
                        break;
                }
                if (Regex.IsMatch(Convert.ToString(sourse[i]), "[A-Z-[XYZFG]]|[a-z-[xyzfg]]"))
                    lst.Add(Tuple.Create(sourse[i], i));
    }
    if (lst.Count < 1)
        throw new Exception("в строке найдены неверные данные");
    return lst;
}

//-----------------------------------------------------------------------------
private double convertToDouble(string sourse) {
    if (sourse == "" || sourse == " ")
        return 0.0;
    sourse = sourse.Trim();
    for (int i = 0; i < sourse.Length; i++)
        switch (sourse[i]) {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '+':
            case '-':
                break;
            default:
                sourse = sourse.Replace(
                    sourse[i], 
                    Convert.ToChar(
                        CultureInfo.
                        CurrentCulture.
                        NumberFormat.
                        NumberDecimalSeparator
                    )
                );
                break;
        }
    return Convert.ToDouble(sourse);
}

//-----------------------------------------------------------------------------
public override string ToString() {
    string output = "";
    foreach (var temp in comands) {
        if (temp.F.value.HasValue)
            output += "F = " + temp.F.value.Value.ToString("F3") + " ";
        if (temp.G.value.HasValue)
            output += "G = " + temp.G.value.Value.ToString("F3") + " ";
        if (temp.X.value.HasValue)
            output += "X = " + temp.X.value.Value.ToString("F3") + " ";
        if (temp.Y.value.HasValue)
            output += "Y = " + temp.Y.value.Value.ToString("F3") + " ";
        if (temp.Z.value.HasValue)
            output += "Z = " + temp.Z.value.Value.ToString("F3") + " ";
        output += "\r\n";
    }
    output += "******************Unknown commands**********************\r\n";
    foreach (var temp in error) {
        output += temp.Item1.ToString() + " = " + temp.Item2 + " \r\n";
    }
    return output;
}

}
}