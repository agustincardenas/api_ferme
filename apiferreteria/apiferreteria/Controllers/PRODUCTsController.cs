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
using System.Web.Http.Cors;

namespace apiferreteria.Controllers
{
    [EnableCors(origins: "http://localhost:36551", headers:"*",methods:"*")]
    public class PRODUCTsController : ApiController
    {
        private Entities db = new Entities();

        public void Post([FromBody] PRODUCT producto)
        {
            db.PRODUCT.Add(producto);
            db.SaveChanges();
        }

        public IEnumerable<PRODUCT> get()
        {
            return db.PRODUCT.ToList();
            
        }

        public PRODUCT get(int id)
        {
            return db.PRODUCT.Find(id);    
        }

        public void delete(int id)
        {
            PRODUCT productDelete = db.PRODUCT.Find(id);
            db.PRODUCT.Remove(productDelete);
            db.SaveChanges();
        }

        public void put([FromBody] PRODUCT product)
        {
            
            PRODUCT productoUpdate = db.PRODUCT.Find(product.PRODUCT_ID);
            productoUpdate.DESCRIPTION = product.DESCRIPTION;
            productoUpdate.PRICE = product.PRICE;
            productoUpdate.STOCK = product.STOCK;
            productoUpdate.CRITICAL_STOCK = product.CRITICAL_STOCK;
            db.SaveChanges();
        }
    }
}
