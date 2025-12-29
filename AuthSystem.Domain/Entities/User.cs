using System;
using System.Collections.Generic;
using System.Text;

namespace AuthSystem.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public List<UserRole> Roles { get; set; } = new();
        public List<RefreshToken> RefreshTokens { get; set; } = new();
    }
}
