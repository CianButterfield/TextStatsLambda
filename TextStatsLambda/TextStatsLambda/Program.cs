using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStatsLambda("Once upon a midnight dreary, while I pondered, weak and weary, \nOver many a quaint and curious volume of forgotten lore— \nWhile I nodded, nearly napping, suddenly there came a tapping, \nAs of some one gently rapping, rapping at my chamber door. \n\"'Tis some visiter,\" I muttered, \"tapping at my chamber door— \nOnly this and nothing more.\" \n\nAh, distinctly I remember it was in the bleak December; \nAnd each separate dying ember wrought its ghost upon the floor.");
            Console.ReadKey();
        }

        static void TextStatsLambda(string input)
        {
            Console.WriteLine("Number of characters: " + input.Length);
            Console.WriteLine("Number of words: " + input.Split(' ').ToList().Count);
            Console.WriteLine("Number of vowels: " + input.ToCharArray().Where(x => "aeiouAEIOU".Contains(x)).Count());
            Console.WriteLine("Number of consonants: " + input.ToLower().ToCharArray().Where(x => "bcdfghjklmnpqrstvwxyz".Contains(x)).Count());
            Console.WriteLine("Number of special characters: " + input.ToLower().ToCharArray().Where(x => " ',.!?-\"".Contains(x)).Count());
            Console.WriteLine("Longest Word: " + input.Split(' ').ToList().OrderBy(x => x.Length).Last());
            Console.WriteLine("Shortest Word: " + input.Split(' ').ToList().OrderBy(x => x.Length).First());
        }
    }
}
