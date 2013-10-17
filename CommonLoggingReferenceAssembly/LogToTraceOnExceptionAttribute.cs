using System;

namespace Anotar.CommonLogging
{
    /// <summary>
    /// If an <see cref="Exception"/> occurs in the applied method then log it to <c>Trace</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public class LogToTraceOnExceptionAttribute : Attribute
    {
    }
}