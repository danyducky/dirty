using Microsoft.AspNetCore.Identity;

namespace Openskill.Domain.Entities
{
    public class UserClaim : IdentityUserClaim<int>
    {
        /// <summary>
        /// Application user.
        /// </summary>
        public User User { get; set; }
    }
}