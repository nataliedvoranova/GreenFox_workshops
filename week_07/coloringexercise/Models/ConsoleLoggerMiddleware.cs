using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coloringexercise.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer printer;
        private IColor color;
        public ConsoleLoggerMiddleware(Printer printer,IColor color)
        {
            this.printer = printer;
            this.color = color;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            printer.Log("hello");
            color.PrintColor();
            return next(context);
        }
    }
}
