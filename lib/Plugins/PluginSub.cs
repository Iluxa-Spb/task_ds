using System;

namespace lib
{
    /// <summary>
    /// plugin performs subtraction
    /// </summary>
    class PluginSub : APlugin
    {
        public override string PluginName => "Sub";

        public override string Description => "This plugin sub";

        public override int Run(int input1, int input2)
        {
            try
            {
                int res = input1 - input2;
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
