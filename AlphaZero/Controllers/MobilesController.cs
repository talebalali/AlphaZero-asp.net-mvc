using AlphaZero.Data;
using AlphaZero.Data.Services;
using AlphaZero.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Controllers
{
    public class MobilesContoller : Controller
    {
          private readonly IMobilesService _service;

          public MobilesContoller(IMobilesService service)
          {
              _service = service;
          }
         public async Task<IActionResult> Index()
         {
             var data =await _service.GetAllAsync();
             return View(data);
         }
         public async Task<IActionResult> Index1()
         {
             var data = await _service.GetAllOrderModel();
             return View(data);

         }
         public async Task<IActionResult> Index2()
         {
             var data = await _service.GetAllOrderBrand();
             return View(data);

         }
         public async Task <IActionResult> Index3()
         {
             var data = await _service.GetAllOrderPrice();
             return View(data);

         }


        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PictureUrl,ModelName,WirelessCarrier,Brand,FormFactor," +
            "RamMemory,OperatingSystem,Color,CellularTechnology,Year,Resolution,AboutThisItem," +
            "InternalStorageMemory,Bio,Price,SIMCardSlotCount,SIMCardSize")] Mobile mobile)
        {
            if (!ModelState.IsValid)
            {
                return View(mobile);
            }
            await _service.AddAsync(mobile);
            return RedirectToAction(nameof(Index));

        }

        //Get: Actors/Details/1
        //[AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails =  await  _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var MobileDetails = await _service.GetByIdAsync(id);
            if (MobileDetails == null) return View("NotFound");
            return View(MobileDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PictureUrl,ModelName,WirelessCarrier,Brand,FormFactor," +
            "RamMemory,OperatingSystem,Color,CellularTechnology,Year,Resolution,AboutThisItem," +
            "InternalStorageMemory,Bio,Price,SIMCardSlotCount,SIMCardSize")] Mobile mobile)
        {
            if (!ModelState.IsValid)
            {
                return View(mobile);
            }
            await _service.UpdateAsync(id, mobile);
            return RedirectToAction(nameof(Index));
        }
        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var MobileDetails = await _service.GetByIdAsync(id);
            if (MobileDetails == null) return View("NotFound");
            return View(MobileDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var MobileDetails = await _service.GetByIdAsync(id);
            if (MobileDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
           
            return RedirectToAction(nameof(Index));
        }
        public ActionResult DarkLayoutPage()
        {
            return View();
        }
        public async Task<IActionResult> Filter(string searchString)
        {
            var allMobile = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allMobile.Where(n => string.Equals(n.ModelName, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Bio, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allMobile);
        }

    }
}
