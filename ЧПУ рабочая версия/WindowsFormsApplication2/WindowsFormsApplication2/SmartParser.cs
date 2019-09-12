using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    class SmartParser {
public Tuple<bool, string> errorStatus { get {
        if (error.Count > 1) {
            return Tuple.Create(false, "******************Unknown commands**********************\r\n");
        }
        else {
            return Tuple.Create(true, "******************All commands processed **********************\r\n");
        }
    }

    set { }
}
public string errorLsit { get {
        var str = "";
        if (error.Count > 1) {
            foreach (var temp in error) {
                str += temp.Item1.ToString() + " = " + temp.Item2 + " \r\n";
            }
        }
        return str;
    } }
private List<LineOfCommand> comands;
private List<Tuple<char, string>> error;
private List<LineOfCommand> universalCommands;

public string path {get { return path;}
    set {
        var sourse = File.ReadAllText(value);
        regularExpParse(sourse);
        //List<string> linesOfRowCommands = new List<string>(sourse.Split('\r', '\n'));
        //List<Tuple<char, double>> doubleList = new List<Tuple<char, double>>();
        //List<List<Tuple<char, string>>> list = new List<List<Tuple<char, string>>>();
        //error = new List<Tuple<char, string>>();
        //comands = new List<LineOfCommand>();
        //foreach (var item in linesOfRowCommands) {
        //    var temp = parse(item);
        //    if (temp != null && temp.Count != null && temp.Count != 0)
        //        list.Add(temp);
        //}
        //foreach (var item in list) {
        //    var line = new LineOfCommand();
        //    foreach (var index in item) {
        //        doubleList.Add(Tuple.Create(index.Item1, convertToDouble(index.Item2)));
        //        switch (index.Item1) {
        //            case 'F':
        //                line.F = new Comand(index.Item1, convertToDouble(index.Item2));
        //                break;
        //            case 'G':
        //                line.G = new Comand(index.Item1, convertToDouble(index.Item2));
        //                break;
        //            case 'X':
        //                line.X = new Comand(index.Item1, convertToDouble(index.Item2));
        //                break;
        //            case 'Y':
        //                line.Y = new Comand(index.Item1, convertToDouble(index.Item2));
        //                break;
        //            case 'Z':
        //                line.Z = new Comand(index.Item1, convertToDouble(index.Item2));
        //                break;
        //            default:
        //                error.Add(Tuple.Create(index.Item1, index.Item2));
        //                break;
        //        }
        //    }
        //    comands.Add(line);
        //}
    }
}

//-----------------------------------------------------------------------------
public void regularExpParse(string sourse) {
    Regex regex = new Regex(
        @"[a-z][+-]?\d+[,.]?\d*",
        RegexOptions.Multiline | RegexOptions.IgnoreCase
    );
    universalCommands = new List<LineOfCommand>();
    List<Tuple<char, double>> list = new List<Tuple<char, double>>();
    error = new List<Tuple<char, string>>();
    for (Match match = regex.Match(sourse); match.Success; match = match.NextMatch()) {
        var tempVal = match.Value.ToUpper();
                switch (tempVal[0]) {
                    case 'F':
                        list.Add(Tuple.Create(tempVal[0], toDouble(tempVal)));
                        break;
                    case 'G':
                        list.Add(Tuple.Create(tempVal[0], toDouble(tempVal)));
                        break;
                    case 'X':
                        list.Add(Tuple.Create(tempVal[0], toDouble(tempVal)));
                        break;
                    case 'Y':
                        list.Add(Tuple.Create(tempVal[0], toDouble(tempVal)));
                        break;
                    case 'Z':
                        list.Add(Tuple.Create(tempVal[0], toDouble(tempVal)));
                        break;
                    default:
                        error.Add(Tuple.Create(tempVal[0], tempVal.Substring(1, tempVal.Length - 1)));
                        break;
                } 
    }
    int completedItems = 0; Tuple<int, LineOfCommand> result = Tuple.Create(0,new LineOfCommand());
    for (int i = 0; i < list.Count; i++) {
        if (completedItems == list.Count)
            return;
        result = findLineOfCommand(list.GetRange(completedItems, list.Count - completedItems));
        completedItems += result.Item1;
        universalCommands.Add(result.Item2);   
    }


}
//-----------------------------------------------------------------------------
private Tuple<int, LineOfCommand> findLineOfCommand(List<Tuple<char, double>> list) {
            if (list.Count > 5) {

                LineOfCommand command = new LineOfCommand();
                for (int i = 0; i < 5; i++) {
                    switch (list[i].Item1) {
                        case 'F':
                            if (!command.F.value.HasValue) {
                                command.F.type = list[i].Item1;
                                command.F.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'G':
                            if (!command.G.value.HasValue) {
                                command.G.type = list[i].Item1;
                                command.G.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'X':
                            if (!command.X.value.HasValue) {
                                command.X.type = list[i].Item1;
                                command.X.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'Y':
                            if (!command.Y.value.HasValue) {
                                command.Y.type = list[i].Item1;
                                command.Y.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'Z':
                            if (!command.Z.value.HasValue) {
                                command.Z.type = list[i].Item1;
                                command.Z.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                    }

                }
                return Tuple.Create(5, command);
            }
            else {

                LineOfCommand command = new LineOfCommand();
                for (int i = 0; i < list.Count; i++) {
                    switch (list[i].Item1) {
                        case 'F':
                            if (!command.F.value.HasValue) {
                                command.F.type = list[i].Item1;
                                command.F.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'G':
                            if (!command.G.value.HasValue) {
                                command.G.type = list[i].Item1;
                                command.G.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'X':
                            if (!command.X.value.HasValue) {
                                command.X.type = list[i].Item1;
                                command.X.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'Y':
                            if (!command.Y.value.HasValue) {
                                command.Y.type = list[i].Item1;
                                command.Y.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                        case 'Z':
                            if (!command.G.value.HasValue) {
                                command.G.type = list[i].Item1;
                                command.G.value = list[i].Item2;
                            }
                            else
                                return Tuple.Create(i, command);
                            break;
                    }

                }
                return Tuple.Create(list.Count, command);

            }
        }

//-----------------------------------------------------------------------------
private double toDouble(string sourse) {

    foreach (var item in sourse) {
        if (item == '.' || item == ',')
            sourse = sourse.Replace(
                item,
                Convert.ToChar(
                    CultureInfo.
                    CurrentCulture.
                    NumberFormat.
                    NumberDecimalSeparator
                )
            );     
    }
    return Convert.ToDouble(sourse.Substring(1, sourse.Length - 1));
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
    foreach (var temp in universalCommands) {
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
            //if (error.Count > 1) {
            //    output += "******************Unknown commands**********************\r\n";
            //    foreach (var temp in error) {
            //        output += temp.Item1.ToString() + " = " + temp.Item2 + " \r\n";
            //    }
            //}
            //else {
            //    output += "******************All commands processed **********************\r\n";
            //}
    return output;
}

}
}