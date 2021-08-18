using System;

namespace Essentials.Notification.Domain.Models.Commons
{
    public class Server : BaseClass
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool Primary { get; set; }
        
    }
}