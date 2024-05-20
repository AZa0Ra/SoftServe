using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ISessionService
    {
        IEnumerable<SessionDTO> GetAll();
        SessionDTO? Get(int id);
        void Create(CreateSessionDTO session);
        void Edit(CreateSessionDTO session);
        void Delete(int id);
        IEnumerable<SessionDTO> GetSessions(DateTime? startDate = null, DateTime? endDate = null);
        IEnumerable<SessionDTO> GetSessionsByFilmName(string filmName);
    }
}
