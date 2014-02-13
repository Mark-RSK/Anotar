using System;

namespace Anotar.Splat
{
    /// <summary>
    /// If an <see cref="Exception"/> occurs in the applied method then log it to <c>Fatal</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public class LogToFatalOnExceptionAttribute : Attribute
    {
    }
}