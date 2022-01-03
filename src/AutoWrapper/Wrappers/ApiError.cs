﻿using System.Collections.Generic;

namespace AutoWrapper.Wrappers
{
    public class ApiError
    {
        public object ExceptionMessage { get; set; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
        public ApiError(object message)
        {
           ExceptionMessage = message;
        }

        public ApiError(string message, IEnumerable<ValidationError> validationErrors)
        {
            ExceptionMessage = message;
            ValidationErrors = validationErrors;
        }
    }
}
