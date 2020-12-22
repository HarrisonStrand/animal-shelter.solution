using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      List<Animal> listByName = model.OrderBy(animal => animal.Name).ToList();
      return View(listByName);
    }

    public ActionResult Dogs()
    {
      List<Animal> model = _db.Animals.ToList();
      // line 27 example of how to order a property in alphabetical order
      List<Animal> listByName = model.OrderBy(animal => animal.Name).ToList();
      return View(listByName);
    }

    public ActionResult Cats()
    {
      List<Animal> model = _db.Animals.ToList();
      List<Animal> listByName = model.OrderBy(animal => animal.Name).ToList();
      return View(listByName);
    }

    public ActionResult Horses()
    {
      List<Animal> model = _db.Animals.ToList();
      List<Animal> listByName = model.OrderBy(animal => animal.Name).ToList();
      return View(listByName);
    }

    public ActionResult Types()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }


    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animals => animals.Id == id);
      return View(thisAnimal);
    }
  }
}