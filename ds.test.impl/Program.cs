using System;
using lib;

namespace ds.test.impl
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Count plugins: {Plugins.PluginsCount()}");
                string[] str = Plugins.GetPluginNames();
                foreach (string s in str) Console.Write($"{s} ");
                Console.WriteLine();
                Console.WriteLine(Plugins.GetPlugin("Sum").Run(999999999, 999999999));
                Console.WriteLine(Plugins.GetPlugin("Fract").Run(123, 233));
                Console.WriteLine(Plugins.GetPlugin("Div").Run(77, 0));
                Console.WriteLine(Plugins.GetPlugin("Modd").Description);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
