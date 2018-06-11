using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using apiferreteria.Models;

namespace apiferreteria.Controllers
{
    public class TICKETSController : ApiController
    {
        private Entities db = new Entities();

        public IEnumerable<TICKET> get()
        {
            return db.TICKET.ToList();
        }
    }
}
