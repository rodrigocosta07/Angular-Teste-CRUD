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

namespace MobiSchool.Controllers
{
    public class PerguntasController : ApiController
    {
        private MobiSchoolEntities db = new MobiSchoolEntities();

        // GET: api/Perguntas
        public IQueryable<Pergunta> GetPergunta()
        {
            return db.Pergunta;
        }

        // GET: api/Perguntas/5
        [ResponseType(typeof(Pergunta))]
        public IHttpActionResult GetPergunta(int id)
        {
            Pergunta pergunta = db.Pergunta.Find(id);
            if (pergunta == null)
            {
                return NotFound();
            }

            return Ok(pergunta);
        }

        // PUT: api/Perguntas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPergunta(int id, Pergunta pergunta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pergunta.Id)
            {
                return BadRequest();
            }

            db.Entry(pergunta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerguntaExists(id))
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

        // POST: api/Perguntas
        [ResponseType(typeof(Pergunta))]
        public IHttpActionResult PostPergunta(Pergunta pergunta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pergunta.Add(pergunta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pergunta.Id }, pergunta);
        }

        // DELETE: api/Perguntas/5
        [ResponseType(typeof(Pergunta))]
        public IHttpActionResult DeletePergunta(int id)
        {
            Pergunta pergunta = db.Pergunta.Find(id);
            if (pergunta == null)
            {
                return NotFound();
            }

            db.Pergunta.Remove(pergunta);
            db.SaveChanges();

            return Ok(pergunta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PerguntaExists(int id)
        {
            return db.Pergunta.Count(e => e.Id == id) > 0;
        }
    }
}