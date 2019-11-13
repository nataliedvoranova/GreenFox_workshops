using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printerexercise.Models
{
    public class ConsoleLoggerMiddleware: IMiddleware
    {
        private Printer printer;
        public ConsoleLoggerMiddleware(Printer printer)
        {
            this.printer = printer;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            printer.Log("hello");
            return next(context);
        }
    }
}
