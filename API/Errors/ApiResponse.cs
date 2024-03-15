using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statuscode, string message = null)
        {
            StatusCode = statuscode;
            Message = message ?? GetDefaultMessageForStatusCode(statuscode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statuscode)
        {
            return statuscode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "resource found, it was not",
                500 => "Errors are the path to the dark side. Error lead to anger. Anger leads to hate. Hate lead to carrer change. ",
                _=> null
            };
        }
    }
}