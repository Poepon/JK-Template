using Abp.AutoMapper;
using JK.Roles.Dto;
using JK.Web.Models.Common;
using Abp.ObjectMapping;
namespace JK.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public EditRoleModalViewModel(GetRoleForEditOutput output, IObjectMapper objectMapper)
        {
            objectMapper.Map(output, this);
        }

        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
