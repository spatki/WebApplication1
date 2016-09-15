using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {
        IClientService service;

        public TestController()
        {
            service = new ClientService();
        }

        public TestController(IClientService srv)
        {
            service = srv;
        }

        public IHttpActionResult Get()
        {
            return Ok(service.GetAll());
        }

        public IHttpActionResult Post (mstr_client person)
        {
            if (ModelState.IsValid)
            {
                person = service.Add(person);
                return CreatedAtRoute("Default", new { id = person.ID }, person);
            }
            else
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Mandatory Fields not entered")),
                    ReasonPhrase = "Mandatory fields not Found"
                };
                throw new HttpResponseException(resp);
            }
        }

        public IHttpActionResult Put(mstr_client person)
        {
            service.Update(person);
            return Ok(person);
        }

        public IHttpActionResult Delete(mstr_client person)
        {
            var personToDelete = DbCon.mstr_client.Where(o => o.ID == person.ID).SingleOrDefault();
            DbCon.mstr_client.Remove(personToDelete);
            DbCon.SaveChanges();
            return Ok();
        }
    }
}