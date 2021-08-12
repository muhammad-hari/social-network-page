using System;
using System.Collections.Generic;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 12:27:46 AM 
*/

namespace Social.Network.Domain.Models
{
    public class Videos
    {
        public int? ID { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }

    }
}
