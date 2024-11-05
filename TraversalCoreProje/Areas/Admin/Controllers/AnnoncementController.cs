using AutoMapper;
using BusinessLayer.Abstract;

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;
namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnoncementController : Controller
    {
        private readonly IAnnoncementService _annoncementService;

        public AnnoncementController(IAnnoncementService annoncementService)
        {
            _annoncementService = annoncementService;
        }

        public IActionResult Index()
        {
            List<Annoncement> announcements = _annoncementService.TGetList();
            List<AnnoncementListViewModel> model = new List<AnnoncementListViewModel>();
            foreach(var item in announcements)
            {
                AnnoncementListViewModel annoncementListViewModel = new AnnoncementListViewModel();
                annoncementListViewModel.ID = item.AnnoncementID;
                annoncementListViewModel.Title = item.Title;
                annoncementListViewModel.Content = item.Content;

                model.Add(annoncementListViewModel);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnoncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnoncement(string x) 
        {
            return View();
        }
    }
}
