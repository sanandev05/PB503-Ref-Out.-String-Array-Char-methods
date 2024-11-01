namespace PB503_Ref__Out._String__Array__Char_methods
{
    internal class Program
    {
        /*  TASK 1
         * 1. ValidatePassword(string password) - methodunuz olur, parameter olaraq qebul etdiyi stringin
         * uzunlugu minimum 8, böyük hərflə başlamalı, tərkibində minimum 1 rəqəm olmalı və minimum
         * 1 karakter (hərf və ya rəqəm olmayan: misal  ?, !, @) olmalıdır. Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır.
            TASK 2
        2. String`in Replace(), Substring(),Trim() methodlarını custom şəkildə yazmaq. 
        Yəni sizin custom yazdığınız methodlarla stringin methodları eyni işi görməlidir.

         */
        static void Main(string[] args)
        {
            string name = "     l    l    .";
            char a = 'a';

            // Console.WriteLine(Substring(name,44));
            //  Console.WriteLine(Substring(name, 5,6));

            //  Console.WriteLine(name.Substring(5,6));
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(Trim(name));
            Console.WriteLine(ValidatePassword("secureKey91@"));
        }
        static bool ValidatePassword(string password)
        {
            bool isNumberExsists=false,isUpperCase=false,isPunctuation = false;
            int correctCount=0;
            if (password.Length > 7)
            {
                correctCount++;
                foreach (char item in password)
                {
                    if (Char.IsNumber(item))
                    {
                        isNumberExsists = true;
                    }
                    if (Char.IsUpper(item))
                    {
                        isUpperCase = true;
                    }
                    if (Char.IsPunctuation(item))
                    {
                        isPunctuation=true;
                    }
                }
            } else return false;
            if (isNumberExsists && isPunctuation && isUpperCase)
            {
                return true;
            }
            else return false;
        }
        static string Trim(string word)
        {
            string newStr = "";
            int startIndex = 0;
            int endIndex = word.Length;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                    startIndex++;
                else {  break; }
            }
            for (int i = word.Length-1; i > 0; i--)
            {
                if (word[i] == ' ')
                    endIndex--;
                else { break; }
            }
            newStr=Substring(word,startIndex,endIndex-startIndex);
            return newStr;
        }
        static string Substring(string word, int startIndex,int length)
        {
            string newStr = "";
            for (int i = startIndex; i < startIndex+length; i++)
            {
                newStr += word[i];
            }
            return newStr;
        }
        static string Substring(string word, int startIndex)
        {
            string newStr = "";
            for (int i = startIndex; i < word.Length; i++)
            {
                newStr += word[i];
            }
            return newStr;
        }
        static string Replace(string value, char oldchar, char newchar)
        {
            string newvalue = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == oldchar)
                {
                    newvalue += newchar;
                }
                else
                {
                    newvalue += value[i];
                }
            }
            return newvalue;
        }
      
    }
}
