using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarApp.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CarApp.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public CarsController(CarDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            return View("CRUD/Index", await _context.Cars.ToListAsync());
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View("CRUD/Create");
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null && image.Length > 0)
                {
                    var filePath = Path.Combine(_environment.WebRootPath, "images", image.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    car.ImagePath = "/images/" + image.FileName;
                }

                car.CreatedAt = DateTime.Now;
                car.ModifiedAt = DateTime.Now;

                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("CRUD/Create", car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View("CRUD/Edit", car);
        }

        // POST: Cars/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Car car, IFormFile image)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (image != null && image.Length > 0)
                    {
                        var filePath = Path.Combine(_environment.WebRootPath, "images", image.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }
                        car.ImagePath = "/images/" + image.FileName;
                    }

                    car.ModifiedAt = DateTime.Now;
                    _c
