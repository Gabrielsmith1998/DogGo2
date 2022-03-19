using DogGo2.Models;
using DogGo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogGo2.Controllers
{
    public class WalksController : Controller
    {
        private readonly IWalksRepository _walksRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalksController(IWalksRepository walksRepository)
        {
            _walksRepo = walksRepository;
        }
        // GET: WalksController1
        public ActionResult Index()
        {
            List<Walks> walks = _walksRepo.GetAllWalks();

            return View(walks);
        }

        // GET: WalksController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WalksController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalksController1/Create
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

        // GET: WalksController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalksController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: WalksController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalksController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
