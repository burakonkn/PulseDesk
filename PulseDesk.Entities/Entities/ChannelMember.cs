using PulseDesk.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulseDesk.Entities.Entities
{
    public class ChannelMember : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public Guid ChannelId { get; set; }
        public Channel Channel { get; set; } = null!;

        public DateTime? JoinedAt { get; set; }
    }
}
