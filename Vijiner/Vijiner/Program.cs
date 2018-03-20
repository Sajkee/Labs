using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vijiner
{
    class Program
    {
        public static string Encode(string input, string keyword,char[] characters)
        {
            input = input.ToUpper();
            keyword = keyword.ToUpper();
            string result = "";
            int N = characters.Length;
            int keyword_index = 0;
            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }
        static void Main(string[] args)
        {
            char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine(Encode(s1, s2, characters));
            Console.ReadKey();
           
        }
    }
}
