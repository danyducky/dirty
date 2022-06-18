using Microsoft.AspNetCore.Identity;

namespace Openskill.Domain.Entities
{
    /// <summary>
    /// Custom application user entity.
    /// </summary>
    public class User : IdentityUser<int>
    {
        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represent user full name.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// Last login date.
        /// </summary>
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// Date when user data was updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// External logins associated with user.
        /// </summary>
        public ICollection<UserLogin> UserLogins { get; set; }

        /// <summary>
        /// User role entities associated with user.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// User claim entities associated with user.
        /// </summary>
        public ICollection<UserClaim> UserClaims { get; set; }

        /// <summary>
        /// User token entities associated with user.
        /// </summary>
        public ICollection<UserToken> UserTokens { get; set; }
    }
}