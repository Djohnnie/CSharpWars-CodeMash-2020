using System;
using CSharpWars.Common.Configuration.Interfaces;

namespace CSharpWars.Common.Configuration
{
    public class ConfigurationHelper : IConfigurationHelper
    {
        public string ConnectionString { get; set; }
        public int ArenaSize { get; set; }
    }
}