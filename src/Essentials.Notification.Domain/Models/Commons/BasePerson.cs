using System;

namespace Essentials.Notification.Domain.Models.Commons
{
    public class BasePerson : BaseClass
    {
        public int Sequence { get; set; }
        public Guid ServerId { get; set; }
        public Guid ChurchId { get; set; }
        public string LastUpdate { get; set; }
        public int Type { get; set; }
        
    }
}