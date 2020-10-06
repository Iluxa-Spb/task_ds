using System;

namespace lib
{
    /// <summary>
    /// plugin performs remainder of the division
    /// </summary>
    class PluginMod : APlugin
    {
        public override string PluginName => "Mod";

        public override string Description => "This plugin mod";

        public override int Run(int input1, int input2)
        {
            try
            {
                int res = input1 % input2;
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
