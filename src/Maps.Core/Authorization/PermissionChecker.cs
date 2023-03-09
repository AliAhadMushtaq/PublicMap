using Abp.Authorization;
using Maps.Authorization.Roles;
using Maps.Authorization.Users;

namespace Maps.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
