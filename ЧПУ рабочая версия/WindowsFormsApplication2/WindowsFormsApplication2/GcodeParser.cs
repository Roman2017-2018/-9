using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

class GcodeParser
{
    private List<double> m_data = new List<double>();
    private List<string> m_codes = new List<string>();
    List<ComandsAndValues> single = new List<ComandsAndValues>();
    List<ComandsAndValues> @double = new List<ComandsAndValues>();
    int i3 = 0;
    public GcodeParser(string path)
    {
            //try {
            m_codes = new List<string>(File.ReadAllText(path).Split('\n'));
            List<List<Tuple<char, string>>> list = new List<List<Tuple<char, string>>>();
            foreach (var item in m_codes)
                {   
                    parseFromString(item);
                }
            System.Threading.Thread.Sleep(100);
        //} catch { MessageBox.Show("Input File have a wrong format or it's damaged"); }
    }
    private void parseFromString(string sourse)
    {
            double @string;
            Regex regex = new Regex("^[xyzfg](?<Value1>[+-]?\\d+.\\d+)[xyzfg]?(?<Value2>[+-]?\\d+.\\d+)?",
                RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Regex checkRegex = new Regex("^[xy](?<V1>[+-]?\\d+.\\d+)[xy](?<Va>[+-]?\\d+.\\d+)", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            Regex checkRegexsingl = new Regex("^[xy](?<V1>[+-]?\\d+.\\d+$)", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            
            for (Match m1 = regex.Match(sourse); m1.Success; m1 = m1.NextMatch())
            {

                if (checkRegex.IsMatch(m1.Value))
                {
                    double Xdouble = double.Parse(
                        m1.Groups["Value1"].ToString(),
                        NumberStyles.Float,
                        CultureInfo.CreateSpecificCulture("en-US"));
                   
                    if (m1.Value.ToUpper()[0] == 'X')
                        @double.Add(
                            new ComandsAndValues()
                            {
                                X = double.Parse(
                                        m1.Groups["Value1"].ToString(),
                                        NumberStyles.Float,
                                        CultureInfo.CreateSpecificCulture("en-US")),
                                Y = double.Parse(
                                        m1.Groups["Value2"].ToString(),
                                        NumberStyles.Float,
                                        CultureInfo.CreateSpecificCulture("en-US"))
                            });
                    i3++;

                   
                }
                if (checkRegexsingl.IsMatch(m1.Value))
                {
                 

                    @double.Add(

                        new ComandsAndValues()
                        {
                            X = double.Parse(
                                    m1.Groups["Value1"].ToString(),
                                    NumberStyles.Float,
                                    CultureInfo.CreateSpecificCulture("en-US")),
                            Y = @double[i3 - 1].Y
                        });
                    i3++;
                }


            }

            Match m = regex.Match(sourse);
            string temp = m.Groups["Value1"].ToString();
            temp = Regex.Replace(temp, @"\.", ",");

          //  @string = double.Parse(m.Groups["Value1"].ToString(), NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-US"));
            //m_data.Add(@string);
        }
}
}
