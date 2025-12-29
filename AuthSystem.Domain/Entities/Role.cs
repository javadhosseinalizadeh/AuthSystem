using System;
using System.Collections.Generic;
using System.Text;

namespace AuthSystem.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
    }
}
