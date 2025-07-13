using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.IO;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var message = $"{DateTime.Now}: {exception.Message}{Environment.NewLine}";
        File.AppendAllText("exception_log.txt", message);

        context.Result = new ObjectResult("Internal server error")
        {
            StatusCode = 500
        };
        context.ExceptionHandled = true;
    }
}
