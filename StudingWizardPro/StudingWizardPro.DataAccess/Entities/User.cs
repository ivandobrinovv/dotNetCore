using DataAnnotationsExtensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudingWizardPro.DataAccess.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        [Email]
        public string Email { get; set; }

        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%&*()|+-=])(?=.*\d)[A-Za-z\d!@#$%&*()|+-=]{6,20}$")]
        public string Password { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
