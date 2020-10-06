using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace lib
{
    class PluginNull: APlugin
    {
        public override string PluginName => "NotFound";

        public override string Description => "Not found plugin";

        public override int Run(int input1, int input2)
        {
            return 0;
        }
    }
}
