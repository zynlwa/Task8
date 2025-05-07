using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Text;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //int[] arr = { 1, -2, -3, -4, 5 };
            //int[] result = NegativeToPositive(arr);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);

            //}
            //---task2---
            //string word = "leve";
            //string n = Reverse(word);
            //if (n == word)
            //    Console.WriteLine("Palindrome-dur");
            //else
            //    Console.WriteLine("Palindrome deyil");
            //StringBuilder
            //string word = "level";
            //string n = Reversed(word);
            //if (n == word)
            //    Console.WriteLine("Uygun");
            //else
            //    Console.WriteLine("Uygun deyil");
            //----task3----
            //string word = "wooord";
            //Console.WriteLine(RemoveCharacter(word));
            //----task4--
            //string word = "salam necesiz sagol";
            //string[] newWords = word.Split(' ');
            //foreach (string s in newWords)
            //{
            //    Console.WriteLine(s);
            //}
            //----task5---
            //string word = "salamdjsh";
            //Console.WriteLine(word.Substring(0,4));
            //task6---
            //string email = "test@code.edu.az";
            //string n= Domain(email);
            //Console.WriteLine(n);
            //string word = "salam4";
            //bool k=IsLetter(word);
            //if (k)
            //    Console.WriteLine("Yalniz herflerden ibaretdir");
            //else 
            //    Console.WriteLine("deyil");
            //------------------
            //string word = "sALam NecesEn";
            //string result = New(word);
            //Console.WriteLine(result);





        }
        public static int[] NegativeToPositive(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }
            return arr;
        }
        public static string Reverse(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }        
            return result;
        }
        public static string Reversed(string word)
        {
            StringBuilder result = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result.Append(word[i]);
            }
            return result.ToString();
        }
        public static string RemoveCharacter(string word)
        {
            StringBuilder result=new StringBuilder();
            string n = "";
            foreach (char c in word)
            {
                if (!n.Contains(c))
                {
                    n += c;
                    result.Append(c);

                }

            }   
            return result.ToString();
        }
        public static string Domain(string email)
        {
            string result = email.Substring(email.IndexOf('@')+1);
            return result;

        }
        public static bool IsLetter(string word)
        {
            foreach (char c in word)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static string New(string text)
        {
            text = text.ToLower();
            string firsLetter = char.ToUpper(text[0]).ToString();
            string words=text.Substring(1);
            return firsLetter + words;
            
        }
    }
}
