using AutoMapper;
using Automappingproj.Models.Viewmodel;
using Automappingproj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Automappingproj.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Userview()
        {
            
            var user = GetUserDetails();

            Userviewmodel userviewModel = _mapper.Map<Userviewmodel>(user);

            return View(userviewModel);
        }

        private static user GetUserDetails()
        {
            return new user()
            {
                Id = 25,
                Name = "Gayathri",
               
                Email = "Gayathri.Saravanan@gmail.com"
               
            };
        }
    }
}

