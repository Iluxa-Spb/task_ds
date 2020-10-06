using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    class PluginFract : APlugin
    {
        public override string PluginName => "Fract";

        public override string Description => "This plugin Fract";

        public override int Run(int input1, int input2)
        {
            try
            {
                int res = input1 / input2;
                float floatRes =(float) input1 / input2;
                if (floatRes % 1 != 0)
                {
                    int fractLength = floatRes.ToString().Split(',')[1].Length;
                    return (int)((floatRes - res) * Math.Pow(10, fractLength));
                }
                else return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
