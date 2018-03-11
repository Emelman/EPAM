using System;

namespace Task_4
{
    internal class MyString
    {
        private char[] letters;
        double height, length, breadth;


        public MyString(string word)
        {
            IsValid(word);
            letters = word.ToCharArray();
        }

        private void IsValid(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new Exception("Empty");
            }
        }

        public new string ToString
        {
            get
            {
                string line = new string(letters);
                return line;
            }
        }

        public static MyString operator +(MyString c1, MyString c2)
        {
            char[] copy = new char[c1.letters.Length + c2.letters.Length];
            Array.Copy(c1.letters, copy, c1.letters.Length);
            Array.Copy(c2.letters, 0, copy, c1.letters.Length, c2.letters.Length);
            Console.WriteLine("Hello");
            string result = new string(copy);
            Console.WriteLine(result);
            Console.ReadKey();
            return new MyString(result);
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
            return (obj1.letters.Equals(obj2));
        }

        public static bool operator !=(MyString obj1, MyString obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((MyString)obj);
        }

        public override int GetHashCode()
        {
            return 10;
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