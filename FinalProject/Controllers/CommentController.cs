using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly AppDbContext _db;
      
        public CommentController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var models = _db.comment.ToList();
            return View(models);
        }
        public IActionResult Create()
        {
            
            return View();
        }

        public IActionResult Save(Comment model) {
        
            _db.comment.Add(model);
            _db.SaveChanges();
            return View(model);
        }
    }
}
