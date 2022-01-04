using Microsoft.AspNetCore.Mvc;
using My_Amlak.Application.Services.Amlaks.Commands;
using My_Amlak.Application.Services.Amlaks.Commands.AddMelk;
using My_Amlak.Application.Services.Amlaks.Queries.GetAmlaks;
using My_Amlak.Application.Services.Amlaks.Queries.GetUpdate;
using My_Amlak.Application.Services.Amlaks.Queries.ShowFacilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Endpoint.Controllers
{
    public class Amlaks : Controller
    {
        public readonly IGetAmlaksService _getamlaks;
        public readonly IShowFacilitiesService _showFacilities;
        public readonly IDeleteAmlakService _deleteAmlak;
        public readonly IAddMelkService _addmelk;
        public readonly IGetUpdateAmlaksService _getupdate;
        public readonly ISetUpdateAmlaksService _setupdate;
        public Amlaks(IGetAmlaksService getamlaks,
            IShowFacilitiesService showFacilities,
            IDeleteAmlakService deleteAmlak,
            IAddMelkService addmelk,
            IGetUpdateAmlaksService getupdate,
            ISetUpdateAmlaksService setupdate
            )
        {
            _addmelk = addmelk;
            _getamlaks = getamlaks;
            _showFacilities = showFacilities;
            _deleteAmlak = deleteAmlak;
            _getupdate = getupdate;
            _setupdate = setupdate;
        }
        [HttpGet]
        public IActionResult Show(long id,string q)
        {
            var result = _getamlaks.Execute(new GetAmlaksRequestDto { UserId = id , Searchkey = q });
            return View(result);
        }
        [HttpGet]
        public IActionResult ShowFacilities(long melkid, long userid)
        {
            var result = _showFacilities.Execute(new ShowFacilitiesReqDto { MelkId = melkid, UserId = userid });
            return View(result);
        }
        [HttpDelete]
        public IActionResult Delete(long melkid)
        {
            var result = _deleteAmlak.Execute(new DeleteAmlakRequestDto { MelkId = melkid});
            return Json(result);
        }
        [HttpGet]
        public IActionResult Create(long userid)
        {
            long userId = userid;
            return View(userId);
        }
        [HttpPost]
        public IActionResult Create(long userid,string name,string address,string price,string area,string facilities)
        {
            var result = _addmelk.Execute(new AddMelkRequestDto {UserID=userid, Name = name, Address = address, Price = price, Area = area, Facilities = facilities });
            return Json(result);
        }
        [HttpGet]
        public IActionResult Update(long id)
        {
           var model = _getupdate.Execute(new GetUpdateAmlaksReqDto { Id = id });
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(long id, string name, string address, string price, string area, string facilities)
        {
            var res = _setupdate.Execute(new SetUpdateAmlaksReqDto { MelkId = id, Address = address, Name = name, Price = price, Area = area, Facilities = facilities });
            return Json(res);
        }
    }
}
