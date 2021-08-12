using System;
using System.Collections.Generic;
using System.Linq;

/**
* @author HariLab
* @date - 8/11/2021 12:59:06 AM 
*/

namespace Social.Network.Domain.Models
{
    public class RestResponse<T>
    {
        public DateTime ResponseAt { get; set; }
        public DateTime RequestAt { get; set; }
        public List<T> Data { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; } = 200;
        public int TotalItems
        {
            get
            {
                return Data.Count();
            }
        }
    }
}
