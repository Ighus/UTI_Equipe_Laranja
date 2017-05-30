using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebService.Conection;
using WebService.Models;

namespace WebService.Controllers
{
    public class temp_pressController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/temp_press
        public IQueryable<temp_press> Gettemp_press()
        {
            return db.temp_press;
        }

        // GET: api/temp_press/5
        [ResponseType(typeof(temp_press))]
        public IHttpActionResult Gettemp_press(long id)
        {
            temp_press temp_press = db.temp_press.Find(id);
            if (temp_press == null)
            {
                return NotFound();
            }

            return Ok(temp_press);
        }

        // PUT: api/temp_press/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttemp_press(long id, temp_press temp_press)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != temp_press.id)
            {
                return BadRequest();
            }

            db.Entry(temp_press).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!temp_pressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/temp_press
        [ResponseType(typeof(temp_press))]
        public IHttpActionResult Posttemp_press(temp_press temp_press)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.temp_press.Add(temp_press);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = temp_press.id }, temp_press);
        }

        // DELETE: api/temp_press/5
        [ResponseType(typeof(temp_press))]
        public IHttpActionResult Deletetemp_press(long id)
        {
            temp_press temp_press = db.temp_press.Find(id);
            if (temp_press == null)
            {
                return NotFound();
            }

            db.temp_press.Remove(temp_press);
            db.SaveChanges();

            return Ok(temp_press);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool temp_pressExists(long id)
        {
            return db.temp_press.Count(e => e.id == id) > 0;
        }
    }
}