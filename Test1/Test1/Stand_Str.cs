using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public static class Stand_Str
    {
        public static string Stand(string s)
        {
            s = s.Trim();
           List<char> lst_str = new List<char>();
            bool XxX = true;
            foreach (char c in s)
            {
               
                if(c == ' ' && XxX == true)
                {
                    lst_str.Add(c);
                    XxX = false;
                }
                else if(c != ' ')
                {
                    lst_str.Add(c);
                    XxX = true;
                }
            }

            string str= "";

            foreach(char c in lst_str)
            {
                str += Convert.ToString(c);
            }


            return str.ToUpper();
        } 

       

    }
}
