using PulseDesk.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulseDesk.Entities.Entities
{
    public class Notification : BaseEntity
    {
        public Guid TriggeredByUserId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;

        public Guid? MessageId { get; set; }
        public Message? Message { get; set; }

        public Guid? ChannelId { get; set; }
        public Channel? Channel { get; set; }
    }
}
