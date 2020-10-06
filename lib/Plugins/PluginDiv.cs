using System;

namespace lib
{
    /// <summary>
    /// plugin performs division without remainder
    /// </summary>
    class PluginDiv : APlugin
    {
        public override string PluginName => "Div";

        public override string Description => "This plugin Div";

        public override int Run(int input1, int input2)
        {
            try
            {
                int res = input1 / input2;
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return input1;
            }
        }
    }
}
