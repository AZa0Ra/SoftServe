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
using System.Linq.Expressions;

namespace Core.Services
{
    public class SessionService : ISessionService
    {
        private readonly IRepository<Session> sessionRepo;
        private readonly IMapper mapper;

        public SessionService(IRepository<Session> sessionRepo, IMapper mapper)
        {
            this.sessionRepo = sessionRepo;
            this.mapper = mapper;
        }

        public void Create(CreateSessionDTO session)
        {
            sessionRepo.Insert(mapper.Map<Session>(session));
            sessionRepo.Save();
        }

        public void Delete(int id)
        {
            var film = sessionRepo.GetByID(id);

            sessionRepo.Delete(film);
            sessionRepo.Save();
        }

        public void Edit(CreateSessionDTO session)
        {
            sessionRepo.Update(mapper.Map<Session>(session));
            sessionRepo.Save();
        }

        public SessionDTO? Get(int id)
        {
          
            var session = sessionRepo.GetByID(id, s => s.Film, s => s.Room);

            return mapper.Map<SessionDTO>(session);

        }

        public IEnumerable<SessionDTO> GetAll()
        {
            var sessions = sessionRepo.Get(includeProperties: $"{nameof(Session.Film)},{nameof(Session.Room)}");
            return mapper.Map<IEnumerable<SessionDTO>>(sessions);
        }

       
        public IEnumerable<SessionDTO> GetSessions(DateTime? startDate = null, DateTime? endDate = null)
        {
            Expression<Func<Session, bool>> filter = s =>
                (!startDate.HasValue || s.DateTime.Date >= startDate.Value.Date) &&
                (!endDate.HasValue || s.DateTime.Date <= endDate.Value.Date);

            var sessions = sessionRepo.Get(filter, includeProperties: $"{nameof(Session.Film)},{nameof(Session.Room)}");
            return mapper.Map<IEnumerable<SessionDTO>>(sessions);
        }
        public IEnumerable<SessionDTO> GetSessionsByFilmName(string filmName)
        {
            Expression<Func<Session, bool>> filter = s => s.Film.Title.Contains(filmName);
            var sessions = sessionRepo.Get(filter, includeProperties: $"{nameof(Session.Film)},{nameof(Session.Room)}");
            return mapper.Map<IEnumerable<SessionDTO>>(sessions);
        }
    }

}