using AutoMapper;
using Core.Interfaces;
using Core.Entities;
using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room> roomRepo;
        private readonly IMapper mapper;

        public RoomService(IRepository<Room> roomRepo, IMapper mapper)
        {
            this.roomRepo = roomRepo;
            this.mapper = mapper;
        }

        public void Create(RoomDTO room)
        {
            roomRepo.Insert(mapper.Map<Room>(room));
            roomRepo.Save();
        }

        public void Delete(int id)
        {
            var film = roomRepo.GetByID(id);

            roomRepo.Delete(film);
            roomRepo.Save();
        }

        public void Edit(RoomDTO room)
        {
            roomRepo.Update(mapper.Map<Room>(room));
            roomRepo.Save();
        }

        public RoomDTO? Get(int id)
        {
            var room = roomRepo.GetByID(id);

         
            return mapper.Map<RoomDTO>(room);
        }

        public IEnumerable<RoomDTO> GetAll()
        {
            var room = roomRepo.GetAll();
            return mapper.Map<IEnumerable<RoomDTO>>(room);
        }
    }
}
