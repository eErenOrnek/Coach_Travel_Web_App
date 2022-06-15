using BusinessLayer.Abstract;
using Coach_Travel_Web_App.EmailServices;
using Coach_Travel_Web_App.Identity;
using Coach_Travel_Web_App.Models;
using CoreLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _eMailSender;
        private readonly ICardService _cardService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender eMailSender, ICardService cardService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _eMailSender = eMailSender;
            _cardService = cardService;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            return View(
                new LoginModel()
                {
                    ReturnUrl = ReturnUrl
                }
            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "No user found.");
                return View(model);
            }

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Your account is not verified! Please check your mail address and verify your account.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("", "Username or password is wrong!");
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                await _eMailSender.SendEmailAsync(model.Email, "Transit Express Account Verification", $"Please <a href = 'https://localhost:44357{url}'>click</a> to verify your account.");
                return RedirectToAction("Login", "Account");
            }

            TempData["Message"] = JobManager.CreateMessage("ERROR", "An error occured, please try again.", "danger");
            return View(model);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    _cardService.InitializeCard(userId);
                    TempData["Message"] = JobManager.CreateMessage("", "Your account has been verified.", "success");
                    return View();
                }
            }

            TempData["Message"] = JobManager.CreateMessage("", "Your account could not be verified. Please check your information and try again.", "warning");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = JobManager.CreateMessage("", "Please enter your e-mail address.", "warning");
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                TempData["Message"] = JobManager.CreateMessage("", "The e-mail address that has been entered could not be found. Please check e-mail address and try again.", "warning");
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            await _eMailSender.SendEmailAsync(
                email,
                "Transit Express Reset Password",
                $"<a href = 'https://localhost:44357{url}'>Click</a> link to reset your password "
                );

            TempData["Message"] = JobManager.CreateMessage("", "The mail to reset your password has been sent to your e-mail address.", "warning");
            return Redirect("~/");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = JobManager.CreateMessage("", "Undefined process", "danger");
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel()
            {
                Token = token
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                TempData["Message"] = JobManager.CreateMessage("", "The user not found!", "warning");
                return Redirect("~/");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = JobManager.CreateMessage("", "Reset password operation has been done successfully.", "success");
                return RedirectToAction("Login");
            }
            TempData["Message"] = JobManager.CreateMessage("", "The process failed, please try again later!", "danger");
            return View(model);
        }

    }
}
