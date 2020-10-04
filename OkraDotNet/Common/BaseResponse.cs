using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Common
{
    public class BaseResponse
    {
        public string Status { get; set; }

        public string Message { get; set; }
    }

    public interface IBaseResponse<TData> : IBaseResponse
    {
        TData Data { get; set; }
    }

    public interface IBaseResponse
    {
        string Status { get; set; }

        string Message { get; set; }
    }

    public static class ResponseExtensions
    {
        public static Result<TData, OkraError> ToResult<TData>(this IBaseResponse<TData> response)
        {
            var result = response.Status != "success" ?
                Result.Failure<TData, OkraError>(new OkraError { Status = response.Status, Message = response.Message }) : Result.Success<TData, OkraError>(response.Data);
            return result;
        }
    }

    public class OkraError
    {
        public string Status { get; set; }

        public string Message { get; set; }
    }
}