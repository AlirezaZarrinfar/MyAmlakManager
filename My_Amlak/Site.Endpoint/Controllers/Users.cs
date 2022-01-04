using Microsoft.AspNetCore.Mvc;
using My_Amlak.Application.Services.Users.Commands.AddUsers;
using My_Amlak.Application.Services.Users.Commands.DeleteUsers;
using My_Amlak.Application.Services.Users.Commands.SetUsersUpdate;
using My_Amlak.Application.Services.Users.Queries.GetUsers;
using My_Amlak.Application.Services.Users.Queries.GetUsersUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Endpoint.Controllers
{
    public class Users : Controller
    {
        public readonly IGetUsersService _getUsers;
        public readonly IAddUsersService _addUsers;
        public readonly IDeleteUsersService _deleteUsers;
        public readonly IGetUsersUpdateService _getupdate;
        public readonly ISetUsersUpdateService _setupdate;
        public Users(IGetUsersService getUsers ,
            IAddUsersService addUsers,
            IDeleteUsersService deleteUsers,
            IGetUsersUpdateService getupdate,
            ISetUsersUpdateService setupdate)
        {
            _deleteUsers = deleteUsers;
            _getUsers = getUsers;
            _addUsers = addUsers;
            _getupdate = getupdate;
            _setupdate = setupdate;
        }
        [HttpGet]
        public IActionResult Show(string q)
        {
           GetUsersResultDto resultDto = _getUsers.Execute(new GetUsersRequestDto {Searchkey = q});
           return View(resultDto);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name, string lastname, string nationalcode)
        {
                AddUsersRequestDto requestDto = new AddUsersRequestDto { Name = name, LastName = lastname, NationalCode = nationalcode };
                var result = _addUsers.Execute(requestDto);
                return Json(result);
        }
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            var result = _deleteUsers.Execute(new DeleteUsersRequestDto { Id=id});
            return Json(result);
        }
        [HttpGet]
        public IActionResult Update(long id)
        {
            return View(_getupdate.Execute(new GetUsersUpdateReqDto { Id = id }));
        }
        [HttpPost]
        public IActionResult Update(long id,string name,string lastname,string nationalcode)
        {
            var result = _setupdate.Execute(new SetUsersUpdateReqDto { Id = id, Name = name, LastName = lastname, NationalCode = nationalcode });
            return Json(result);
        }
    }
}
