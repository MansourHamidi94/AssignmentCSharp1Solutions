using System;
public class InvalidWeaponException : Exception
{
    public InvalidWeaponException(string message) : base(message) { }
}

public class InvalidArmorException : Exception
{
    public InvalidArmorException(string message) : base(message) { }
}

