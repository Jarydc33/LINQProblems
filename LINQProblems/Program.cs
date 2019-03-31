using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////RETURNS ALL WORDS CONTAINING 'TH'////////////////////////////////////////
            //var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};
            //var solution = words.Where(w => w.Contains("th"));
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////RETURNS A COPY OF A LIST WITHOUT DUPLICATES////////////////////////////////
            //var names = new List<string>() { "Mike", "Brad", "Ian", "Nevin", "Mike" };
            //var solution = names.Distinct();
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////CALCULATES A CLASS AVERAGE AFTER DROPPING THE LOWEST GRADE/////////////////
            //var grades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            //double result = 0;
            //foreach (var studentgrades in grades)
            //{
            //    var splitString = studentgrades.Split(',').Select(int.Parse).ToList();
            //    var solved = splitString.Where(x => x != splitString.Min());
            //    result = result + solved.Average();
            //}
            //result /= 4;
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////ALPHABETICALLY ORDERS A STRING AND INCLUDES LETTER FREQUENCY//////////////
            //Please note that the program handles spaces by placing them at the beginning of the solution with the number of spaces next to it.
            //
            //Console.WriteLine("Please enter a string: ");
            //var solution = Console.ReadLine().OrderBy(s => s);
            //foreach (var letter in solution)
            //{
            //    var counter = solution.GroupBy(s => s).Where(s => s.Count() > 0).Select(s => s.Count()).ToList();
            //    var solved = solution.Distinct();
            //    solved = string.Concat(solved.Zip(counter, (first, second) => first + "" + second));
            //}
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
