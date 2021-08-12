using System;
using System.Collections.Generic;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 12:20:34 AM 
*/

namespace Social.Network.Domain.Models
{
    public class Activities
    {
        public int? ID { get; set; }
        public int? UserId { get; set; }
        public Users Users { get; set; }
        public string Activity { get; set; }
        //public DateTime? Date { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
