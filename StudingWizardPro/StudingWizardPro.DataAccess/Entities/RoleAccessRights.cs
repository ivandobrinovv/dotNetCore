using System;
using System.Collections.Generic;
using System.Text;

namespace StudingWizardPro.DataAccess.Entities
{
    public class RoleAccessRight
    {
        public int AccessRightID { get; set; }
        public AccessRight AccessRight { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
