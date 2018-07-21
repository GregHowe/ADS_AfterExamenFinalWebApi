﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.application
{
    public class Error
    {
        public string message { get; set; }
        public Exception cause { get; set; }

        public Error(string message, Exception cause)
        {
            this.message = message;
            this.cause = cause;
        }
    }
}
