using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Capstone4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Capstone4.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UsersContext _context;
        public UserController(UsersContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var user = User.Identity;
            return View(user);
        }

        public IActionResult TaskList()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var stuff = _context.Tasks.Where(x => x.UserId == id).ToList();
            return View(stuff);
        }
        
       
        public IActionResult MarkComplete(int id)
        {
            Tasks found = _context.Tasks.Find(id);
            if(found != null)
            {
                found.TaskComplete = !found.TaskComplete;
                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("TaskList", new { id = found.Id });
        }

        public IActionResult Delete(int id)
        {
            Tasks found = _context.Tasks.Find(id);
            if (found != null)
            {
                _context.Tasks.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("TaskList", new { id = found.Id });
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            if (ModelState.IsValid)
            {
                newTask.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
            }
            return RedirectToAction("TaskList", new { id = newTask.Id });
        }

        public IActionResult Sort(string order)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var newsort = _context.Tasks.Where(x => x.UserId == userid);
            if(order == "asc")
            {
               newsort = newsort.OrderBy(x => x.TaskDue);
            }
            else
            {
                newsort = newsort.OrderByDescending(x => x.TaskDue);
            }
            HttpContext.Session.SetString("Order", order);
            return View("TaskList", newsort.ToList());
        }

        public IActionResult Sort2(string complete)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var newsort = _context.Tasks.Where(x => x.UserId == userid);
            if (complete == "true")
            {
                newsort = newsort.OrderBy(x => x.TaskComplete);
            }
            else
            {
                newsort = newsort.OrderByDescending(x => x.TaskComplete);
            }
            HttpContext.Session.SetString("Complete", complete);
            return View("TaskList", newsort.ToList());
        }

        public IActionResult FindTask(string TDescription)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var newsort = from x in _context.Tasks where x.TaskDescription.Contains(TDescription) &&  x.UserId == userid select x;
            return View("TaskList", newsort.ToList());
        }
    }
}
