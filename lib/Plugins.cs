using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace lib
{
    /// <summary>
    /// Plugin Factory
    /// </summary>
    public static class Plugins
    {
        /// <summary>
        /// Calculates count of plugins
        /// </summary>
        /// <returns>Count plugins</returns>
        public static int PluginsCount()
        {
            try
            {
                IEnumerable<Type> list = GetTypes();
                return list.Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        /// <summary>
        /// returns all names plugins
        /// </summary>
        /// <returns>array string plugin names</returns>
        public static string[] GetPluginNames()
        {
            try
            {
                IEnumerable<Type> list = GetTypes();

                List<string> str = new List<string>();
                foreach (Type itm in list)
                {
                    IPlugin i = System.Activator.CreateInstance(itm) as IPlugin;
                    str.Add(i.PluginName);
                }
                return str.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        /// <summary>
        /// searches plugin by name
        /// </summary>
        /// <param name="pluginName">plugin name</param>
        /// <returns>IPlugin by plugin name</returns>
        public static IPlugin GetPlugin(string pluginName)
        {
            try
            {
                IEnumerable<Type> list = GetTypes();
                foreach (Type itm in list)
                {
                    IPlugin plugin = System.Activator.CreateInstance(itm) as IPlugin;
                    if (pluginName == plugin.PluginName)
                        return plugin;
                }
                return new PluginNull();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new PluginNull();
            }
            
        }
        /// <summary>
        /// finds all child classes 
        /// </summary>
        /// <returns>List of types</returns>
        private static IEnumerable<Type> GetTypes()
        {
            Type ourtype = typeof(APlugin);
            IEnumerable<Type> list = Assembly.GetAssembly(ourtype).GetTypes().Where(type => ourtype.IsAssignableFrom(type) && type != ourtype);
            return list;
        }
    }
}
