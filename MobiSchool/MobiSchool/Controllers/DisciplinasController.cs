using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using MobiSchool.Models;

namespace MobiSchool.Controllers
{
    public class DisciplinasController : ApiController
    {
        private MobiSchoolEntities db = new MobiSchoolEntities();

        // GET: api/Disciplinas
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        public IQueryable<Disciplina> GetDisciplina()
        {
            return db.Disciplina;
        }

        // GET: api/Disciplinas/5
        [ResponseType(typeof(Disciplina))]
        public IHttpActionResult GetDisciplina(int id)
        {
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return NotFound();
            }

            return Ok(disciplina);
        }

        // PUT: api/Disciplinas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDisciplina(int id, Disciplina disciplina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != disciplina.Id)
            {
                return BadRequest();
            }

            db.Entry(disciplina).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DisciplinaExists(id))
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

        // POST: api/Disciplinas
        [ResponseType(typeof(Disciplina))]
        public IHttpActionResult PostDisciplina(Disciplina disciplina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Disciplina.Add(disciplina);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = disciplina.Id }, disciplina);
        }

        // DELETE: api/Disciplinas/5
        [ResponseType(typeof(Disciplina))]
        public IHttpActionResult DeleteDisciplina(int id)
        {
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return NotFound();
            }

            db.Disciplina.Remove(disciplina);
            db.SaveChanges();

            return Ok(disciplina);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DisciplinaExists(int id)
        {
            return db.Disciplina.Count(e => e.Id == id) > 0;
        }
    }
}