using ScriptCs.Contracts;
using System.Configuration;

namespace ScriptCs.ConfigurationPack
{
    public class Configx : IScriptPackContext
    {
        public static readonly string DefaultConfigurationFilename = "app.configx";

        public Configuration Get()
        {
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = DefaultConfigurationFilename };
            var cfg = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            return cfg;
        }

        public Configuration Get(string fileName)
        {
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = fileName };
            var cfg = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            return cfg;
        }
    }
}