using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Responses
{
    public class ProcessIncomeResponse : BaseResponse, IBaseResponse<object>
    {
        public object Data { get; set; }
    }
}