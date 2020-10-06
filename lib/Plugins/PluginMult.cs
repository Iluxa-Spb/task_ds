using System;

namespace lib
{
    /// <summary>
    /// plugin performs multiplication
    /// </summary>
    class PluginMult : APlugin
    {
        public override string PluginName => "Mult";

        public override string Description => "This plugin mult";

        public override int Run(int input1, int input2)
        {
            try
            {
                int res = input1 * input2;
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
