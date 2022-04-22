using Aeroclub.Cargo.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Core
{
    public class ServiceResponse<T> where T : class
    {
        public ServiceResponse(T? response = null, string? message = null, ServiceResponseStatus? status = ServiceResponseStatus.Success)
        {
            Response = response;
            Message = message;
            Status = status;
        }

        public string? Message { get; set; }
        public ServiceResponseStatus? Status { get; set; }
        public T? Response { get; set; }
    }
}
