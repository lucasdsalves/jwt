using System.Threading.Tasks;
using Template.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface IAuthenticationAppService
    {
        Task<AuthResponseViewModel> Authenticate(AuthRequestViewModel authData);
    }
}
