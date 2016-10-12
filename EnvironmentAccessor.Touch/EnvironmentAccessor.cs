
using System;

namespace EnvironmentAccessor.Touch
{
    public class EnvironmentAccessor : IEnvironmentAccessor
    {
        public string GetEnvironmentVariable(string envVarabileName)
        {
            return Environment.GetEnvironmentVariable(envVarabileName);
        }
    }
}
