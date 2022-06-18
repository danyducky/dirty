using Microsoft.AspNetCore.Identity;

namespace Openskill.Domain.Entities
{
    /// <summary>
    /// User to role associative entity.
    /// </summary>
    public class UserRole : IdentityUserRole<int>
    {
        /// <summary>
        /// Application user.
        /// </summary>
        public User User { get; set; }
        
        /// <summary>
        /// Identity role.
        /// </summary>
        public Role Role { get; set; }
    }
}