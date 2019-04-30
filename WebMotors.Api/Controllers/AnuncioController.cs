using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebMotors.Application.Abstractions;
using WebMotors.Application.ViewModels;

namespace WebMotors.Api.Controllers
{
    [RoutePrefix("api/anuncio")]
    public class AnuncioController : ApiController
    {
        private readonly IAnuncioAppService _appService;

        public AnuncioController(IAnuncioAppService appService)
        {
            _appService = appService;
        }
        // GET: api/Anuncio
        public IEnumerable<AnuncioViewModel> Get()
        {
            return _appService.FindAll();
        }

        // GET: api/Anuncio/5
        public AnuncioViewModel Get(int id)
        {
            return _appService.FindById(id);
        }

        // POST: api/Anuncio
        public IHttpActionResult Post([FromBody]AnuncioViewModel value)
        {
            try
            {
                _appService.Add(value);
                _appService.Save();
                return Ok(new { ok = true });
            }
            catch (Exception e)
            {

                return Ok(new { ok = false, msg = e.Message });

            }
        }

        // PUT: api/Anuncio/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]AnuncioViewModel value)
        {
            try
            {
                _appService.Update(value);
                _appService.Save();

                return Ok(new { ok = true });
            }
            catch (Exception e)
            {

                return Ok(new { ok = false,msg = e.Message });

            }
        }

        // DELETE: api/Anuncio/5
        public IHttpActionResult Delete(int id)
        {
            
            try
            {
                var value = _appService.FindById(id);
                _appService.Delete(value);
                _appService.Save();

                return Ok(new { ok = true });
            }
            catch (Exception e)
            {

                return Ok(new { ok = false, msg = e.Message });

            }
        }
    }
}
