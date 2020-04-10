using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudingWizardPro.DataAccess.Entities
{
    public class AccessRight : BaseEntity
    {
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        public ICollection<RoleAccessRight> RoleAccessRights { get; set; }
    }
}
