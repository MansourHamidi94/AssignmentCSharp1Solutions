using System.Runtime.Serialization;
// IT CREATED THIS AS A SOLUTION, THIS IS NOT SOMETHING IVE DONE - MANSOUR.
[Serializable]
internal class CustomException : Exception
{
    public CustomException()
    {
    }

    public CustomException(string? message) : base(message)
    {
    }

    public CustomException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}