using Microsoft.AspNetCore.Identity;

namespace Openskill.Domain.Entities
{
    public class RoleClaim : IdentityRoleClaim<int>
    {
        /// <summary>
        /// Identity role.
        /// </summary>
        public Role Role { get; set; }
    }
}