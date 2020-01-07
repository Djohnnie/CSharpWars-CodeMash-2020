using System;

namespace CSharpWars.Common.Configuration.Interfaces
{
    public interface IConfigurationHelper
    {
        string ConnectionString { get; set; }
        int ArenaSize { get; set; }
    }
}