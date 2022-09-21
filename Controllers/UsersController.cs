using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Models;
using Shop.SendMail;

namespace Shop.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataFashionContext _context;

        public UsersController(DataFashionContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var dataFashionContext = _context.Users.Include(u => u.Role);
            return View(await dataFashionContext.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Id");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Password,Fullname,Phone,Address,Status,RoleId")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Id", user.RoleId);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string? error)
        {

            var User = HttpContext.Session.GetString("user");
            int? checkOrderID = 0;
            if (User == null)
            {
                ViewData["orderdeatail"] = null;

            }
            else
            {
                try
                {
                    var dataFashionContext1 = _context.Orders.Include(o => o.User).Include(o => o.Voucher);
                    checkOrderID = dataFashionContext1.Where(s => s.UserId.Equals(Int32.Parse(User)) && s.Status.Equals(1)).FirstOrDefault()?.Id;
                    if (checkOrderID == 0)
                    {
                        ViewData["orderdeatail"] = null;

                    }
                    else
                    {
                        ViewData["orderdeatail"] = _context.OrderDetails.Include(o => o.Order).Include(o => o.Product).Where(s => s.OrderId == checkOrderID); ;

                    }

                }
                catch (Exception e)
                {
                    ViewData["orderdeatail"] = null;

                }

            }
            if (User == null)
            {
                return Redirect("/Login");
            }
            int id = Int32.Parse(User);
            if (id == null)
            {
                return Redirect("/Login");
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["ViewOrders"] = _context.Orders.Include(o => o.User).Include(o => o.Voucher).Where(s => s.UserId.Equals(Int32.Parse(User)) && s.Status >= 2);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Id", user.RoleId);

            if (error != null && error.Equals("current"))
                ViewBag.current = "false";
            else if (error != null && error.Equals("newpassword"))
                ViewBag.newpassword = "false";
            else if (error != null && error.Equals("comfirm"))
                ViewBag.comfirm = "false";

            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Fullname,Phone,Address,Status,RoleId,Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            var User = HttpContext.Session.GetString("user");
            if (ModelState.IsValid)
            {
                try
                {

                    user.Id = Int32.Parse(User);
                    user.Status = 1;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));
            }

            ViewData["ViewOrders"] = _context.Orders.Include(o => o.User).Include(o => o.Voucher).Where(s => s.UserId.Equals(Int32.Parse(User)) && s.Status >= 2);
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        [HttpPost]
        public IActionResult Updatepassword(string currentpassword, string newpassword, string comfirm)
        {
            var user = HttpContext.Session.GetString("user");

            var dataFashionContext = _context.Users.Include(u => u.Role).FirstOrDefault(x => x.Id == Int32.Parse(user));
            currentpassword = encryption(currentpassword);

            bool match = Regex.IsMatch(newpassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,20}$");

            if (!currentpassword.Equals(dataFashionContext.Password))
            {

                return RedirectToAction("Edit", new { error = "current" });
            }
            else if (!match)
            {
                return RedirectToAction("Edit", new { error = "newpassword" });
            }
            else if (comfirm != newpassword)
            {
                return RedirectToAction("Edit", new { error = "comfirm" });
            }
            else
            {
                dataFashionContext.Password = newpassword;
                _context.Update(dataFashionContext);
                _context.SaveChanges();
                return RedirectToAction(nameof(Edit));
            }
        }
        public IActionResult ContactUs()
        {
            int? checkOrderID = 0;
            var user = HttpContext.Session.GetString("user");
            if (user == null)
            {
                ViewData["orderdeatail"] = null;
            }
            else
            {
                try
                {
                    var dataFashionContext1 = _context.Orders.Include(o => o.User).Include(o => o.Voucher);
                    checkOrderID = dataFashionContext1.Where(s => s.UserId.Equals(Int32.Parse(user)) && s.Status.Equals(1)).FirstOrDefault()?.Id;
                    if (checkOrderID == 0)
                    {
                        ViewData["orderdeatail"] = null;
                    }
                    else
                    {
                        ViewData["orderdeatail"] = _context.OrderDetails.Include(o => o.Order).Include(o => o.Product).Where(s => s.OrderId == checkOrderID);
                    }
                }
                catch (Exception e)
                {
                    ViewData["orderdeatail"] = null;
                }
            }
            return View();
        }
        public IActionResult IndexForgotPassWord()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Forgotpassword()
        {
            String email = HttpContext.Request.Form["Email"];
            String btnLogin = HttpContext.Request.Form["login"];
            if (btnLogin != null)
            {
                var checkUser = _context.Users.Include(u => u.Role).Where(x => x.Email.Equals(email));
                if (checkUser.ToList().Count > 0)
                {
                    checkUser.FirstOrDefault().Password = GeneratePassword(3);
                    MailUtils.SendMailGoogleSmtp("aos.hk3@gmail.com", email, "RESET PASSWORD", "Password: " + checkUser.FirstOrDefault().Password + "  + Please do not share this to anyone.",
                                      "aos.hk3@gmail.com", "pkaxypowlzbtfvzr").Wait();
                    checkUser.FirstOrDefault().Password = encryption(checkUser.FirstOrDefault().Password);
                    _context.Update(checkUser.FirstOrDefault());
                    _context.SaveChanges();
                }
            }

            return Redirect("/Login");
        }
        public static string GeneratePassword(int passLength)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var charschu = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var charsso = "0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, passLength)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            var resultchu = new string(
                Enumerable.Repeat(charschu, passLength)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            var resultso = new string(
                Enumerable.Repeat(charsso, passLength)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            var resulttong = new String(result + resultchu + resultso);
            return resulttong;
        }
        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

    }
}
