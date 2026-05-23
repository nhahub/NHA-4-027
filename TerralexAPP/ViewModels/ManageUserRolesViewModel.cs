namespace TerralexAPP.ViewModels
{
    public class ManageUserRolesViewModel
    {
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public List<RoleCheckboxViewModel> Roles { get; set; } = new List<RoleCheckboxViewModel>();
    }
}
