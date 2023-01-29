using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Business.Concrete;
using OnlineTutor.Core;
using OnlineTutor.Data.Concrete.EfCore.Contexts;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Entity.Concrete.Identity;
using OnlineTutor.Web.Models;

namespace OnlineTutor.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITeacherService _teacherManager;
        private readonly IStudentService _studentManager;
        private readonly OnlineTutorContext _context;
        //private readonly IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ITeacherService teacherManager, OnlineTutorContext context, IStudentService studentManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _teacherManager = teacherManager;
            _context = context;
            _studentManager = studentManager;
        }

        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginDto { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(loginDto);
                }

                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Email adresi ya da parola hatalı!");
            }
            return View(loginDto);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                if (registerDto.IsTeacher)
                {
                    var teacher = new Teacher
                    {
                        FirstName = registerDto.FirstName,
                        LastName = registerDto.LastName,
                        UserName = registerDto.UserName,
                        Email = registerDto.Email,
                        City = registerDto.LastName,
                        Url = registerDto.LastName
                    };
                    await _userManager.CreateAsync(teacher, registerDto.Password);
                    await _userManager.AddToRoleAsync(teacher, "Teacher");
                }
                else
                {
                    var student = new Student
                    {
                        FirstName = registerDto.FirstName,
                        LastName = registerDto.LastName,
                        UserName = registerDto.UserName,
                        Email = registerDto.Email,
                        City = registerDto.LastName,
                        Url = registerDto.LastName
                    };
                    await _userManager.CreateAsync(student, registerDto.Password);
                    await _userManager.AddToRoleAsync(student, "Student");
                }
                TempData["Message"] = Jobs.CreateMessage("Bilgi", "Başarıyla oluşturuldu", "success");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz");
                return View(registerDto);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
