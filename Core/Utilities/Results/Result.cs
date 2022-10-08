using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }

        public Result(bool success, string message) : this(success) // Send the parameter to overloaded other method
        {   // Read only methods(get methods) just only be set in constructor methods.
            Message = message;
        }

        public Result(bool success)
        {
            Success=success;
        }
    }
}
