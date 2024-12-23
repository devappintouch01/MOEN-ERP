using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
    public class ApiResultsModel
    {
        public object? Data { get; set; }
        public string Message { get; set; }
        public string MessageSub { get; set; }
        public string Type { get; set; }
        public string? ReturnUrl { get; set; }
        public bool Success { get; set; }
        public int? Id { get; set; }
        public int? SubId { get; set; }
        public string Text { get; set; }

    }

    public enum ApiResultsType
    {
        success,
        error,
    }
}
