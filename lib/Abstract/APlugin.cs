namespace lib
{
    /// <summary>
    /// Abstract plugin class
    /// </summary>
    abstract class APlugin : IPlugin
    {
        abstract public string PluginName { get; }
        public string Version => "1.0";
        abstract public string Description { get; } 
        abstract public int Run(int input1, int input2);
    }
}
