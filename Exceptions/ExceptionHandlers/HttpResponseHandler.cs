using dotnet_api_test.Exceptions.ExceptionResponses;

namespace dotnet_api_test.Exceptions.ExceptionHandlers
{
    public static class HttpResponseHandler
    {
        public static ExceptionResponse Respond(HttpExceptionResponse e)
        {
            return new(e.StatusCode, e.Message, "HttpResponseException");
        }
    }
}