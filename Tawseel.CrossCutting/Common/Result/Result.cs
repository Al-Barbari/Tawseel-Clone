using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.CrossCutting.Common.Result
{
    public class Result
    {        
        public bool IsSuccess { get; private set; }
   
        public string ErrorMessage { get; private set; }
        
        public string ErrorCode { get; private set; }
        
        public object Data { get; private set; }

        private Result(bool isSuccess, string errorMessage = null, string errorCode = null, object data = null)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
            Data = data;
        }
        
        public static Result Success(object data = null)
        {
            return new Result(true, data: data);
        }
        
        public static Result Failure(string errorMessage, string errorCode)
        {
            return new Result(false, errorMessage, errorCode);
        }
    }
}
