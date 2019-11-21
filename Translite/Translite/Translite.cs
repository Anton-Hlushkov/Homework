using System;
namespace Translite
{
    public static class Translite
    {
        
        static string SwitchToEnglish(string s)
        {
            string ret = "";
            string[] rus = {"А","Б","В","Г","Д","Е","Ё","Ж", "З","И","Й","К","Л","М", "Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ","Ъ", "Ы","Ь",
          "Э","Ю", "Я" };
            string[] eng = {"A","B","V","G","D","E","YO","ZH","Z","I","Y","K","L","M","N",
          "O","P","R","S","T","U","F","KH","TS","CH","SH","SCH",null,"Y",null,
          "E","YU","YA"};

            for (int j = 0; j < s.Length; j++)
            {
                if (('Я' < s[j]) || ('А' > s[j]))
                { return "invalid symbol"; }
                for (int i = 0; i < rus.Length; i++)
                    if (s.Substring(j, 1) == rus[i]) ret += eng[i];
            }

            return ret;
        }
        static string SwitchToRussian(string s)
        {
            string ret = "";
            string[] rus = {"А","Б","В","Г","Д","Е","Ё","Ж", "З","И","Й","К","Л","М", "Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ","Ъ", "Ы","Ь",
          "Э","Ю", "Я" };
            string[] eng = {"A","B","V","G","D","E",null,null,"Z","I",null,"K","L","M","N",
          "O","P","R","S","T","U","F",null,null,null,null,null,null,"Y",null,
          null,null,null};
            for (int j = 0; j < s.Length; j++)
            {
                if (('Z' < s[j])||('A' > s[j]))
                { return "invalid symbol"; }
                if (s.Length - j > 2)
                {
                    switch (s.Substring(j, 3))
                    {
                        case "SCH":
                            j += 3;
                            ret += rus[26];
                            break;
                     
                        
                    }
                }
                if (s.Length - j > 1)
                {
                    switch (s.Substring(j, 2))
                    {
                        case "YA":
                            j += 2;
                            ret += rus[32];
                            break;
                        case "YU":
                            j += 2;
                            ret += rus[31];
                            break;
                        case "SH":
                            j += 2;
                            ret += rus[25];
                            break;
                        case "CH":
                            j += 2;
                            ret += rus[24];
                            break;
                        case "TS":
                            j += 2;
                            ret += rus[23];
                            break;
                        case "KH":
                            j += 2;
                            ret += rus[23];
                            break;
                        case "ZH":
                            j += 2;
                            ret += rus[7];
                            break;
                        case "YO":
                            j += 2;
                            ret += rus[6];
                            break;


                    }
                }

                for (int i = 0; i < rus.Length; i++)
                {
                    if ((s.Substring(j, 1) == "W")|| (s.Substring(j, 1) == "J") || (s.Substring(j, 1) == "C") || (s.Substring(j, 1) == "Q") || (s.Substring(j, 1) == "H"))
                    { return "invalid latin symbol"; }
                    if (s.Substring(j, 1) == eng[i]) { ret += rus[i];  }
                    
                }
                



            }
            return ret;


        }
        public static string SwitchToCurrent(string s)
        {
            if (('Z' >= s[0]) && ('A' <= s[0]))
            {
                return SwitchToRussian(s);
            }
            else return SwitchToEnglish(s);
        }
    }

}
