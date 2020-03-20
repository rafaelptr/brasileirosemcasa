﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Database;
using Web.Model;

namespace Web.Repository
{
    public class EstadoRepository : UnitOfWork<Estado>, IEstadoRepository
    {
        public EstadoRepository(ISession session) : base(session)
        {
        }
    }
}
