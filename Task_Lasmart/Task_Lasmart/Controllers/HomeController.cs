using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Lasmart.Models;

namespace Task_Lasmart.Controllers
{
    public class HomeController : Controller
    {
        PointContext db;
        public HomeController(PointContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {

            ViewData["PointId"] = new SelectList(db.Points, "Id", "Id");
            return View();
        }

        [HttpPost]
        public IActionResult AddNewPoint(int ox, int oy, int radius, string colour)
        {



            Point newpoint = new Point
            {

                Ox = ox,
                Oy = oy,
                Radius = radius,
                Colour = colour,
                Comments = new List<Comment>()

            };

            db.Add(newpoint);

            db.SaveChanges(); //id появляется автоматически


            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetPointComment()
        {

            var PointsComments = db.Points.Include(point => point.Comments).ToList();
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()// переводит в стиль наименования переменных как у JS (CamelCase)
            };// создали настройки, чтобы игнорировалось зацикливание ссылок.  
            var json = JsonConvert.SerializeObject(PointsComments, settings); // сериализуем наш список

            
            return Ok(json); // возвращаем наш Json со статусом 200. возвращаем обычный статус

        }

        [HttpPost]
        public IActionResult AddComment(int pointId, string Text, string backgroundColor)
        {

            Comment newcomment = new Comment
            {

                PointId = pointId,
                Text = Text,
                BackgroundColor = backgroundColor

            };

            db.Add(newcomment);

            db.SaveChanges();





            return NoContent();
        }

        public IActionResult RemovePoint(int pointid)
        {
            var point = db.Points.FirstOrDefault(q => q.Id == pointid);

            if (point != null)
            {
                db.Remove(point);

                db.SaveChanges();
            }

            return NoContent();

        }
    }
}
