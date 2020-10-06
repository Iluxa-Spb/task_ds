using System;
using Xunit;
using lib;

namespace XUnitTests
{
    public class UnitTestPlugins
    {
        [Fact]
        public void Test_Sum()
        {
            // arrange 
            int arg1 = 2;
            int arg2 = 3;
            string pluginName = "Sum";
            int expected = 5;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Sub()
        {
            // arrange 
            int arg1 = 2;
            int arg2 = 3;
            string pluginName = "Sub";
            int expected = -1;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Mult()
        {
            // arrange 
            int arg1 = 6;
            int arg2 = 6;
            string pluginName = "Mult";
            int expected = 36;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Div_Identical_Number()
        {
            // arrange 
            int arg1 = 3;
            int arg2 = 3;
            string pluginName = "Div";
            int expected = 1;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Div_Zero()
        {
            // arrange 
            int arg1 = 3;
            int arg2 = 0;
            string pluginName = "Div";
            int expected = 3;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Div_Division_With_Remainder()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 4;
            string pluginName = "Div";
            int expected = 7;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Mod_Remainder()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 4;
            string pluginName = "Mod";
            int expected = 2;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Mod_Zero()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 0;
            string pluginName = "Mod";
            int expected = 0;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Mod_Not_Remainder()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 10;
            string pluginName = "Mod";
            int expected = 0;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Fract_Not_Remainder()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 10;
            string pluginName = "Fract";
            int expected = 0;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Fract_Remainder()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 12;
            string pluginName = "Fract";
            int expected = 5;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Fract_Zero()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 0;
            string pluginName = "Fract";
            int expected = 0;
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Wrong_Plugin()
        {
            // arrange 
            int arg1 = 30;
            int arg2 = 0;
            string pluginName = "Empty";
            int expected = 0;
            string expectedName = "NotFound";
            // act
            int result = Plugins.GetPlugin(pluginName).Run(arg1, arg2);
            string resultName = Plugins.GetPlugin(pluginName).PluginName;
            // assert            
            Assert.Equal(expected, result);
            Assert.Equal(expectedName, resultName);
        }
        [Fact]
        public void Test_Plugins_Count()
        {
            // arrange 
            int expected = 7;
            // act
            int result = Plugins.PluginsCount();
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Get_Plugin_Names()
        {
            // act
            string[] result = Plugins.GetPluginNames();
            // assert            
            Assert.NotNull(result);
        }
        [Fact]
        public void Test_Get_Version()
        {
            // arrange 
            string pluginName = "Sum";
            string expected = "1.0";
            // act
            string result = Plugins.GetPlugin(pluginName).Version;
            // assert            
            Assert.Equal(expected, result);
        }
    }
}
