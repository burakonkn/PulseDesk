using PulseDesk.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulseDesk.Entities.Entities
{
    public class Message : BaseEntity
    { 
        public Guid SenderId { get; set; }
        public User Sender { get; set; } = null!;
        public Guid? ReceiverId { get; set; }
        public User? Receiver { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;
        public bool IsImportant { get; set; } = false;

        public Guid? ChannelId { get; set; }
        public Channel? Channel { get; set; }

        public List<Attachment> Attachments { get; set; } = new();
        public List<Notification> Notifications { get; set; } = new();
    }
}
