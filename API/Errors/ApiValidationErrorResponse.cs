using System;

namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse() : base(404)
        {

        }
        public IEnumerable<string> Errors {get;set;}
        
    }
}
