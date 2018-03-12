using System;

namespace Task_4
{
    internal class MyString
    {
        private char[] letters;

        public MyString(string word)
        {
            if (!IsValid(word))
            {
                throw new Exception("Empty");
            }
            letters = word.ToCharArray();
        }

        private bool IsValid(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            string line = new string(letters);
            return line;
        }

        public static MyString operator +(MyString c1, MyString c2)
        {
            var s1 = c1.ToString();
            var s2 = c2.ToString();
            var s3 = s1 + s2;
            return new MyString(s3);
        }

        public static MyString operator -(MyString c1, MyString c2)
        {
            string copy1 = new string(c1.letters);
            string copy2 = new string(c2.letters);
            copy1 = copy1.Replace(copy2, String.Empty);
            return new MyString(copy1);
        }

        public static bool operator ==(MyString obj1, MyString obj2)
        {
            return obj1.ToString().Equals(obj2.ToString());
        }

        public static bool operator !=(MyString obj1, MyString obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object obj)
        {
            var mystring = obj as MyString;
            if (mystring != null)
            {
                return mystring == this;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return new string(letters).GetHashCode();
        }

        public char[] Letters
        {
            get
            {
                return letters;
            }
        }
    }
}