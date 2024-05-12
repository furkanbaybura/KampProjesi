using AutoMapper;
using DTOs;
using KampYeri.BLL.Managers.Concrete;
using KampYeri.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Cryptography;

namespace KampYeri.Controllers
{
    public class KampBolgesiController : Controller
    {
        private IMapper _mapper;
        private KampBolgesiManager _managerKamp;
        private CadirManager _managerCadir;
        int _rowNum= 1;

        public KampBolgesiController(KampBolgesiManager managerKamp, CadirManager managerCadir)
        {
            _managerKamp = managerKamp;
            _managerCadir = managerCadir;

            MapperConfiguration config = new MapperConfiguration(config =>
            {
                config.CreateMap<KampBolgesiDto, KampBolgesiViewModel>().ForMember(x => x.Cadirlar, y => y.MapFrom(src => src.Cadirlar));
                config.CreateMap<CadirDto, CadirViewModel>().ReverseMap();
                config.CreateMap<KampBolgesiDto, KampBolgesiViewModel>().ReverseMap();

            });
            _mapper = config.CreateMapper();

        }

        public IActionResult Index()
        {
            List<KampBolgesiDto> dtos = _managerKamp.GetAll().ToList();
            List<KampBolgesiViewModel> models = new List<KampBolgesiViewModel>();

            foreach (KampBolgesiDto dto in dtos)
            {
                KampBolgesiViewModel model = new KampBolgesiViewModel();
                model = _mapper.Map<KampBolgesiViewModel>(dto);
                models.Add(model);
                model.RowNum = _rowNum++;
            }

            return View(models);




            return View(models);
        }
        [HttpGet]
        public IActionResult Create()
        {
            KampBolgesiViewModel model = new KampBolgesiViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(KampBolgesiViewModel model)
        {
            ModelState.Remove<KampBolgesiViewModel>(m => m.Cadirlar);

            if (ModelState.IsValid)
            {
                KampBolgesiDto dto = _mapper.Map<KampBolgesiDto>(model);
                _managerKamp.Add(dto);
                return RedirectToAction("Index");
            }
           
            return View(model);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            KampBolgesiDto dto = _managerKamp.Get(id);
            KampBolgesiViewModel model = _mapper.Map<KampBolgesiViewModel>(dto);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(KampBolgesiViewModel model)
        {
            if (ModelState.IsValid)
            {
                KampBolgesiDto dto = _mapper.Map<KampBolgesiDto>(model);
                _managerKamp.Update(dto);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            KampBolgesiDto dto = _managerKamp.Get(id);
            KampBolgesiViewModel model = _mapper.Map<KampBolgesiViewModel>(dto);
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(KampBolgesiViewModel model)
        {
            KampBolgesiDto dto = _mapper.Map<KampBolgesiDto>(model);
            _managerKamp.Delete(dto);
            return RedirectToAction("Index");
        }

       

    }
}
