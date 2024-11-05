using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnoncementDTOs;
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
        private readonly IMapper _mapper;

        public AnnoncementController(IAnnoncementService annoncementService, IMapper mapper)
        {
            _annoncementService = annoncementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnoncementListDto>>(_annoncementService.TGetList());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnoncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnoncement(AnnoncementAddDto model) 
        {
            if (ModelState.IsValid) 
            {
                _annoncementService.TAdd(new Annoncement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteAnnoncement(int id)
        {
            var values = _annoncementService.TGetById(id);
            _annoncementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnoncementUpdateDto>(_annoncementService.TGetById(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnoncementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _annoncementService.TUpdate(new Annoncement
                {
                    AnnoncementID = model.AnnoncementID,
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
