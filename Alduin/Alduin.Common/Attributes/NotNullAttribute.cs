using System;

namespace Alduin.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NotNullAttribute : Attribute
    { }
}
