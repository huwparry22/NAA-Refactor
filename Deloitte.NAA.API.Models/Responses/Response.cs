using Deloitte.NAA.API.Models.Common.Enums;
using System.Collections.Generic;

namespace Deloitte.NAA.API.Models.Responses
{
    public class Response<T> where T : class
    {
        public ResponseStatus ResponseStatus { get; set; }

        public IList<string> ErrorMessages { get; set; }

        public T ResponseData { get; set; }
    }
}
