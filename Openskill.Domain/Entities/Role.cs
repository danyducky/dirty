using Friendly.Domain.Structs;
using Microsoft.AspNetCore.Identity;

namespace Openskill.Domain.Entities
{
    /// <summary>
    /// Custom application role entity.
    /// </summary>
    public class Role : IdentityRole<int>
    {
        /// <summary>
        /// User role entities associated with role.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Constructor for <see cref="RoleManager{TRole}"/>.
        /// </summary>
        public Role()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="role">UserRole enum.</param>
        public Role(UserRole role) : base(role.ToString())
        {
        }

        public UserRoles UserRole => (UserRoles)Id;
    }
}