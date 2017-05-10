using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "2659-211B17-01";

            test = "2659-210217-01";

            var result = GetOrderDate(test);

            Console.WriteLine(string.Format("Input: {0}; Output: {1}", test, result));

            Console.WriteLine("Any key ..."); Console.ReadKey(true);
        }

        static public string GetOrderDate(string orderno)
        {
            string result = orderno.Replace(" ", "").Replace("-", "").Substring(4);

            string yyyy = "20" + result.Substring(4, 2);
            string mm = result.Substring(2, 2);
            string dd = result.Substring(0, 2);

            try {
                DateTime dt = new DateTime(int.Parse(yyyy), int.Parse(mm), int.Parse(dd));

                result = dt.ToString("yyyyMMdd");
            }
            catch {
                result = null;
            }

            return result;
        }
    }
}
