using Microsoft.AspNetCore.Mvc;
using Pioneer_Online_Library.API.ViewModels;
using Pioneer_Online_Library.Domain.Model;

namespace Pioneer_Online_Library.MVC.Interface
{
    public interface IAuthenticationService
    {
        Task<RegisterModel>RegisterAsync(RegisterModel registerModel);
        Task<RegisterModel> RegisterAdminAsync(RegisterModel model);
        Task<LoginModel> Login(LoginModel model);

        Task<AppUser> DeleteUser(AppUser user);
        Task<AppUser> UpdateUser(AppUser user);
    }
}
