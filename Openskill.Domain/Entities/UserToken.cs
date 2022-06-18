using Microsoft.AspNetCore.Identity;

namespace Openskill.Domain.Entities
{
    public class UserToken : IdentityUserToken<int>
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Application user.
        /// </summary>
        public User User { get; set; }
    }
}