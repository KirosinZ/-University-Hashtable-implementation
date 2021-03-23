using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRIALG_HASH
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            HashSet<string, int> set = new HashSet<string, int>();

            set.Add("Ass", 1);
            set.Add("Bitch", 2);
            set.Add("Cum", 3);

            foreach (var entry in set)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            set.Add("Nigger", 4);
            set.Add("Sucker", 5);

            Console.WriteLine();

            foreach (var entry in set)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine(set["Penis"]?.Value ?? 0);

            Console.ReadKey(true);
        }
    }
}
