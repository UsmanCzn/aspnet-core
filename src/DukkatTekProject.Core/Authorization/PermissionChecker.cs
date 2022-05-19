using Abp.Authorization;
using DukkatTekProject.Authorization.Roles;
using DukkatTekProject.Authorization.Users;

namespace DukkatTekProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
