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
using PokemonDbCreator_APIProject.Models;
using System.Web.Http.Cors;
using PokemonDbCreator_APIProject.Database;

namespace PokemonDbCreator_APIProject.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TypesController : ApiController
    {
        private PokemonDatabase db = new PokemonDatabase();

        // GET: api/Types
        public IQueryable<Models.Type> GetTypes()
        {
            return db.Types;
        }

        // GET: api/Types/5
        [ResponseType(typeof(Models.Type))]
        public IHttpActionResult GetType(int id)
        {
            Models.Type type = db.Types.Find(id);
            if (type == null)
            {
                return NotFound();
            }

            return Ok(type);
        }

        // PUT: api/Types/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutType(int id, Models.Type type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != type.Type_id)
            {
                return BadRequest();
            }

            db.Entry(type).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeExists(id))
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

        // POST: api/Types
        [ResponseType(typeof(Models.Type))]
        public IHttpActionResult PostType(Models.Type type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Types.Add(type);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = type.Type_id }, type);
        }

        // DELETE: api/Types/5
        [ResponseType(typeof(Models.Type))]
        public IHttpActionResult DeleteType(int id)
        {
            Models.Type type = db.Types.Find(id);
            if (type == null)
            {
                return NotFound();
            }

            db.Types.Remove(type);
            db.SaveChanges();

            return Ok(type);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeExists(int id)
        {
            return db.Types.Count(e => e.Type_id == id) > 0;
        }
    }
}