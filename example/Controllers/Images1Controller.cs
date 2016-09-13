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
using example.Models;
using example.DAL;

namespace example.Controllers
{
    public class Images1Controller : ApiController
    {
        private WebContext db = new WebContext();

        // GET: api/Images1
        //Order by Modified date 
        public IQueryable<Images> GetImages()
        {
            var image = from m in db.Images select m;
            image = image.OrderBy(s => s.imageModifiedDate);

            return (image);
        }

        // GET: api/Images1/5
        [ResponseType(typeof(Images))]
        public IHttpActionResult GetImages(int id)
        {
            Images images = db.Images.Find(id);
            if (images == null)
            {
                return NotFound();
            }

            return Ok(images);
        }

        // PUT: api/Images1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImages(int id, Images images)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != images.Id)
            {
                return BadRequest();
            }

            db.Entry(images).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagesExists(id))
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

        // POST: api/Images1
        [ResponseType(typeof(Images))]
        public IHttpActionResult PostImages(Images images)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Images.Add(images);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = images.Id }, images);
        }

        // DELETE: api/Images1/5
        [ResponseType(typeof(Images))]
        public IHttpActionResult DeleteImages(int id)
        {
            Images images = db.Images.Find(id);
            if (images == null)
            {
                return NotFound();
            }

            db.Images.Remove(images);
            db.SaveChanges();

            return Ok(images);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImagesExists(int id)
        {
            return db.Images.Count(e => e.Id == id) > 0;
        }
    }
}