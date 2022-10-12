﻿using System;

namespace Business.CCC
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
