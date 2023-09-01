using AutoMapper;
using Automappingproj.Models;
using Automappingproj.Models.Viewmodel;

namespace Automappingproj
{
    public class Userprofile:Profile
    {
        public Userprofile()
        {
            CreateMap<user,Userviewmodel>();
        }
    }
}
