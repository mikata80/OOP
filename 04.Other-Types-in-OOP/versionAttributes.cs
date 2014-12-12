using System;
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface,  AllowMultiple = true)]

public class VersionsAttribute : System.Attribute
{
    public int major
    {
        get;
        set;
    }

    public int minor
    {
        get;
        set;
    }

    public VersionsAttribute(int major, int minor)
    {
        this.major = major;
        this.minor = minor;
    }

    public override string ToString()
    {
        return String.Format("{0}.{1}", major, minor);
    }
}