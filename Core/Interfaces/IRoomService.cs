using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRoomService
    {
        IEnumerable<RoomDTO> GetAll();
        RoomDTO? Get(int id);
        void Create(RoomDTO room);
        void Edit(RoomDTO room);
        void Delete(int id);
    }
}
