using System.Net;

namespace Kick.Api.Exceptions;

public class KickException : Exception
{
    public readonly HttpStatusCode _httpStatusCode;
    public KickException(string message, HttpStatusCode httpStatusCode) : base(message)
    {
        _httpStatusCode = httpStatusCode;
    }
}