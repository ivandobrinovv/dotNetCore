using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudingWizardPro.DataAccess.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        public ICollection<RoleAccessRight> RoleAccessRights { get; set; }
    }
}
