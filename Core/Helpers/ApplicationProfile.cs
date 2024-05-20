using AutoMapper;
using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Film, FilmDTO>();
            CreateMap<FilmDTO, Film>();

            CreateMap<RoomDTO, Room>();
            CreateMap<Room, RoomDTO>();
        }
    }
}
