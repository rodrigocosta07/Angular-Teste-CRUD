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
    public class RespostasController : ApiController
    {
        private MobiSchoolEntities db = new MobiSchoolEntities();

        // GET: api/Respostas
        public IQueryable<Resposta> GetResposta()
        {
            return db.Resposta;
        }

        // GET: api/Respostas/5
        [ResponseType(typeof(Resposta))]
        public IHttpActionResult GetResposta(int id)
        {
            Resposta resposta = db.Resposta.Find(id);
            if (resposta == null)
            {
                return NotFound();
            }

            return Ok(resposta);
        }

        // PUT: api/Respostas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutResposta(int id, Resposta resposta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != resposta.Id)
            {
                return BadRequest();
            }

            db.Entry(resposta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespostaExists(id))
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

        // POST: api/Respostas
        [ResponseType(typeof(Resposta))]
        public IHttpActionResult PostResposta(Resposta resposta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Resposta.Add(resposta);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RespostaExists(resposta.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = resposta.Id }, resposta);
        }

        // DELETE: api/Respostas/5
        [ResponseType(typeof(Resposta))]
        public IHttpActionResult DeleteResposta(int id)
        {
            Resposta resposta = db.Resposta.Find(id);
            if (resposta == null)
            {
                return NotFound();
            }

            db.Resposta.Remove(resposta);
            db.SaveChanges();

            return Ok(resposta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RespostaExists(int id)
        {
            return db.Resposta.Count(e => e.Id == id) > 0;
        }
    }
}