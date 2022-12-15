using Abp.Authorization;
using insideNutri.Authorization.Roles;
using insideNutri.Authorization.Users;

namespace insideNutri.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
