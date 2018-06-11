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
    public class TICKET_DETAILController : ApiController
    {
        private Entities db = new Entities();

        public IEnumerable<PRODUCT> get(int id)
        {
           List<TICKET_DETAIL> t = db.TICKET_DETAIL.Where( e=> e.TICKET_ID==id).ToList();
           List<PRODUCT> p = new List<PRODUCT>();
            foreach (var value in t)
            {
                
                PRODUCT pr = db.PRODUCT.Find(value.PRODUCT_ID);
                p.Add(pr);
                
            }

            return p;
        }
        
    }
}
