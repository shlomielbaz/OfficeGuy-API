using OG.Domain.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace OG.Domain.DTOs
{
    public class Response<T> 
        where T: IResponse
    {
        public T Data { get; set; }
        public int? Status { get; set; }
        public string UserErrorMessage { get; set; }
        public string TechnicalErrorDetails { get; set; }
    }
}