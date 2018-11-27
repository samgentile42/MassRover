﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassRoverApi.Errors
{
    public abstract class ErrorMessage
    {
        public ErrorCode Code { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
        public string Info { get; set; }
    }
}