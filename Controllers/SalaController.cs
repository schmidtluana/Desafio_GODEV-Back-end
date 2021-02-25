using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using treinamento.Models;

namespace treinamento.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers:"*", methods:"*")]
    public class SalaController : ApiController
    {
        programa_GODEVEntities bd = new programa_GODEVEntities();

        // GET: api/Sala
        public IEnumerable<dynamic> Get()
        {
            var salas = from sa in bd.sala
                        select new { sa.id, sa.nome, sa.lotacao };
            return salas;
        }

        // GET: api/Sala/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sala
        public string Post([FromBody]sala sal)
        {
            bd.sala.Add(sal);
            bd.SaveChanges();
            return "Salvo com sucesso";
        }

        // PUT: api/Sala/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sala/5
        public void Delete(int id)
        {
        }
    }
}
