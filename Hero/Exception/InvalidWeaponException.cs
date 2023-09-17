
namespace DungeonMaster.Exceptions;

public class InvalidWeaponException : Exception
{
    public InvalidWeaponException() : base() { }

    public InvalidWeaponException(string message) : base(message) { }

    public InvalidWeaponException(string message, Exception innerException) : base(message, innerException) { }
}
