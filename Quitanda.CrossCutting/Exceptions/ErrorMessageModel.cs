﻿namespace Quitanda.CrossCutting.Exceptions
{
    public class ErrorMessageModel
    {
        public ErrorMessageModel(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
