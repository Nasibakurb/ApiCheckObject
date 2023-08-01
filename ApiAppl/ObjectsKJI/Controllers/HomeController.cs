using Microsoft.AspNetCore.Mvc;
using ApiAppl.Controllers;
using ApiAppl.Domain.Interfaces;

namespace ObjectsKJI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IObjectsMIOCheckService _service;

        public HomeController(IObjectsMIOCheckService service)
        {
            _service = service;
        }
  
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateObject()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditObject()
        {
            return View();
        }
        //public async Task<ActionResult> CreateMIOObject(ObjectsMIOCheck objectsMIOCheck)
        //{
        //    try
        //    {
        //        await _service.CreateMIOObject(objectsMIOCheck);
        //        return RedirectToAction("Index");
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        TempData["ErrorMessage"] = "Ошибка, проверьте данные, пожалуйста";
        //        return RedirectToAction("Index");
        //    }   
        //}

        public IActionResult ChangeStatus(int id)
        {
            try
            {
                _service.ChangeStatus(id);
                return RedirectToAction("Index");
            }
            catch (InvalidOperationException)
            {
                TempData["ErrorMessage"] = "Object with ID " + id + " not found.";
                return RedirectToAction("Index");
            }
        }

        //public IActionResult UpdateMIOCheck(int id, ObjectsMIOCheck updateObjectsMIOCheck)
        //{
        //    try
        //    {
        //        _service.UpdateMIOCheck(id, updateObjectsMIOCheck);
        //        return RedirectToAction("Index");
        //    }
        //    catch 
        //    {
        //        TempData["ErrorMessage"] = "Ошибка, проверьте данные, пожалуйста";
        //        return RedirectToAction("Index");
        //    }
        }


    }
