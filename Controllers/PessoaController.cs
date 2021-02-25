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
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class PessoaController : ApiController
    {
        programa_GODEVEntities bd = new programa_GODEVEntities();
        // GET: api/Pessoa
        public IEnumerable<dynamic> Get()
        {
            var pessoas = from pesso in bd.pessoa
                        select new { pesso.id, pesso.nome, pesso.sobrenome };
            return pessoas;
        }

        // GET: api/Pessoa/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pessoa
        public string Post([FromBody] pessoa pe)
        {
            bd.pessoa.Add(pe);
            bd.SaveChanges();
            return "Salvo com sucesso";
        }

        // PUT: api/Pessoa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pessoa/5
        public void Delete(int id)
        {
        }
    }
}
