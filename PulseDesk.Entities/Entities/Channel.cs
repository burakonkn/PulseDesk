using PulseDesk.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulseDesk.Entities.Entities
{
    public class Channel : BaseEntity
    {
        public Guid CreatedByUserId { get; set; }
        public User CreatedBy { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPrivate { get; set; } = false;


        public List<Message> Messages { get; set; } = new();
        public List<ChannelMember> ChannelMembers { get; set; } = new();
        public List<Notification> Notifications { get; set; } = new();
    }
}
