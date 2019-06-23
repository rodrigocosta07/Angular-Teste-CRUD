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
using MobiSchool.Models;
using System.Web.Http.Cors;


namespace MobiSchool.Controllers
{
    public class TipoDificuldadesController : ApiController
    {
        private MobiSchoolEntities db = new MobiSchoolEntities();

        // GET: api/TipoDificuldades
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        public IQueryable<TipoDificuldade> GetTipoDificuldade()
        {
            return db.TipoDificuldade;
        }

        // GET: api/TipoDificuldades/5
        [ResponseType(typeof(TipoDificuldade))]
        public IHttpActionResult GetTipoDificuldade(int id)
        {
            TipoDificuldade tipoDificuldade = db.TipoDificuldade.Find(id);
            if (tipoDificuldade == null)
            {
                return NotFound();
            }

            return Ok(tipoDificuldade);
        }

        // PUT: api/TipoDificuldades/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoDificuldade(int id, TipoDificuldade tipoDificuldade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoDificuldade.Id)
            {
                return BadRequest();
            }

            db.Entry(tipoDificuldade).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDificuldadeExists(id))
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

        // POST: api/TipoDificuldades
        [ResponseType(typeof(TipoDificuldade))]
        public IHttpActionResult PostTipoDificuldade(TipoDificuldade tipoDificuldade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoDificuldade.Add(tipoDificuldade);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipoDificuldade.Id }, tipoDificuldade);
        }

        // DELETE: api/TipoDificuldades/5
        [ResponseType(typeof(TipoDificuldade))]
        public IHttpActionResult DeleteTipoDificuldade(int id)
        {
            TipoDificuldade tipoDificuldade = db.TipoDificuldade.Find(id);
            if (tipoDificuldade == null)
            {
                return NotFound();
            }

            db.TipoDificuldade.Remove(tipoDificuldade);
            db.SaveChanges();

            return Ok(tipoDificuldade);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoDificuldadeExists(int id)
        {
            return db.TipoDificuldade.Count(e => e.Id == id) > 0;
        }
    }
}