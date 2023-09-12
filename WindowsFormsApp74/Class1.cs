using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp74
{
    class cValid
    {
     public int lenght
        {
            get;
            set;
        }

        private string ct;
        public string Text
        {
            get
            {
                return ct;
            }

            set
            {
                if (value.Length <= lenght)
                {
                    char[] c;
                    c = value.ToCharArray();
                    string temp = "";
                    foreach (char t in c)
                    {
                        if (char.IsLetter(t))
                            temp = temp + t.ToString();
                    }
                }
            }
        }

    }
}
