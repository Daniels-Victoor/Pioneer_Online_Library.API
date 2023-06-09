﻿using Microsoft.AspNetCore.Mvc;
using Pioneer_Online_Library.API.ViewModels;
using Pioneer_Online_Library.Domain.Model;
using Pioneer_Online_Library.MVC.Interface;
using Pioneer_Online_Library.MVC.Services;

namespace Pioneer_Online_Library.MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(_authenticationService));

        }

        public async Task<ActionResult> DeleteUser(AppUser user)
        {
            try
            {
                var users = await _authenticationService.DeleteUser(user);
                return View(user);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult DeleteUser()
        {
            return View();
        }

        [Route("Login")]
        public async Task<ActionResult> Login(LoginModel user)
        {
            try
            {
                var users = await _authenticationService.Login(user);
                return View(user);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<ActionResult> RegisterAdminAsync(RegisterModel user)
        {
            try
            {
                var users = await _authenticationService.RegisterAdminAsync(user);
                return View(user);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult RegisterAdminAsync()
        {
            return View();
        }

        [Route("Register")]
        public async Task<ActionResult> Register(RegisterModel user)
        {
            try
            {
                var users = await _authenticationService.RegisterAsync(user);
                return View(user);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult Register()
        {
            return View();
        }


        public async Task<ActionResult> UpdateUser(AppUser user)
        {
            try
            {
                var users = await _authenticationService.UpdateUser(user);
                return View(user);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult UpdateUser()
        {
            return View();
        }

    }
}
