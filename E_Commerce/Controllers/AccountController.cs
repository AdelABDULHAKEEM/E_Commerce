using E_Commerce.Models;
using E_Commerce.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;

namespace E_Commerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly SignInManager<Customer> _signInManager;
      

        public AccountController(UserManager<Customer> userManager,
                                      SignInManager<Customer> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            var userExists = await _userManager.FindByNameAsync(vm.Email);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Error = "Error", Message = "User already exists!" });

            Customer user = new Customer
                {
                    Name = vm.Email,
                    EmailAddress = vm.Email,
                };

                var result = await _userManager.CreateAsync(user, vm.Password);

                if (!result.Succeeded)
                {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

                return Ok(new Response { Status = "Success", Message = "User created successfully!" });
            }

      

            
            return View(vm);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }


    }
}