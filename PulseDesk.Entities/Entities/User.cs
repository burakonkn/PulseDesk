using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulseDesk.Entities.Entities
{
    public class User : IdentityUser<Guid>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public Status Status { get; set; }


        public Guid DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public List<ChannelMember> ChannelMembers { get; set; } = new();
    }

    public enum Status
    {
        Aktif,
        Cevrimdisi,
        Bosta,
        Calisiyor
    }
}
