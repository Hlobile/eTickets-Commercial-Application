using eTicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicketsApplication.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            //pass the data to the actors views
            return View(data);
        }
    }
}
