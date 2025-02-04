using ASP_MVC.Mappers;
using ASP_MVC.Models.User;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_MVC.Controllers
{
    public class UserController : Controller
    {
        private UserService _userService;
        public UserController()
        {
            _userService= new UserService();
        }

        // GET: UserController
        public ActionResult Index()
        {
            IEnumerable<UserListItem> model = new List<UserListItem>();
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(Guid id)
        {
            try
            {
                UserEditForm model = _userService.Get(id).ToEditForm();
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction("Error","Home");
            }
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, UserEditForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new ArgumentException("form");
                _userService.Update(id, form.ToBLL());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(Guid id)
        {
            try
            {
                UserDelete model = _userService.Get(id).ToDelete();
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home");
            }
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, UserDelete form)
        {
            try
            {
                _userService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
