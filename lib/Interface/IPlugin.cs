namespace lib
{
    /// <summary>
    /// interface plugin
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// plugin name
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Version plugin
        /// </summary>
        string Version { get; }
        //System.Drawing.Image Image { get; }
        /// <summary>
        /// Description plugin
        /// </summary>
        string Description { get; }
        /// <summary>
        /// run plugin
        /// </summary>
        /// <param name="input1">First digit</param>
        /// <param name="input2">Second digit</param>
        /// <returns></returns>
        int Run(int input1, int input2);
    }
}
