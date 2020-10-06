using System;

namespace lib
{
    /// <summary>
    /// plugin performs addition
    /// </summary>
    class PluginSum : APlugin
    {
        public override string PluginName => "Sum";

        public override string Description => "This plugin sub";

        public override int Run(int input1, int input2)
        {
            try
            {
                int res = input1 + input2;
                return res;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: OverFlowExeption");
                return 0;
            }
        }
    }
}
