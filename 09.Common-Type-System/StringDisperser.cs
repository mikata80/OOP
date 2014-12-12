using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class StringDisperser : ICloneable, IComparable, IEnumerable
    {

        private string[] strings;

        public string[] Strings
        {
            get
            {
                return this.strings;
            }
            set
            {
                this.strings = value;
            }
        }

        public StringDisperser()
        {

        }

        public StringDisperser(params string[] strs)
        {
            this.Strings = strs;
        }

        public override string ToString()
        {
            string res = "";
            foreach (var s in Strings)
            {
                res += s;
            }
            return String.Format("{0}", res);
        }

        public int getLength()
        {
            return this.Strings.Length;
        }

        public override bool Equals(object obj)
        {
            bool res = false;
            if (obj is StringDisperser && obj != null)
            {

                StringDisperser tempStr;
                tempStr = (StringDisperser)obj;

                if (tempStr.getLength() != this.getLength())
                {
                    res = false;
                }
                else
                {
                    for (int i = 0; i < tempStr.getLength(); i++)
                    {
                        if (tempStr.Strings[i] == this.Strings[i])
                        {
                            res = true;
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                }

            }
            else
            {
                throw new NullReferenceException();
            }

            return res;
        }

        public static bool operator ==(StringDisperser str1, StringDisperser str2)
        {
            return str1.Equals(str1);
        }

        public static bool operator !=(StringDisperser str1, StringDisperser str2)
        {
            return !str1.Equals(str1);
        }

        public override int GetHashCode()
        {
            int len = Strings.Length;
            int res = 0;
            for (int i = 0; i < len - 1; i++)
            {
                res += Strings[i].GetHashCode() ^ Strings[i + 1].GetHashCode();
            }
            return res;
        }

        public object Clone()
        {
            return new StringDisperser(
                this.Strings
           );
        }

        public int CompareTo(object obj)
        {
            StringDisperser tempStr = obj as StringDisperser;
            if (tempStr != null)
            {
                if (tempStr.ToString() == obj.ToString())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public char[] strToChar(string str)
        {
            char[] res = str.ToCharArray();

            return res;
        }

        public IEnumerator GetEnumerator()
        {
            string[] allStrings = this.Strings;
            for (int i = 0; i < allStrings.Length; i++)
            {
                char[] res = allStrings[i].ToCharArray();
                for (int j = 0; j < res.Length; j++)
                {
                    yield return res[j];
                }
            }
        }
    }
}
