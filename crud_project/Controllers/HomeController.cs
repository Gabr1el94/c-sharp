using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly CandidatoContexto _context;

        public HomeController(CandidatoContexto context){
            _context=context;
        }

        [HttpGet]
        [Route("ObterCandidatos")]
        public async Task<IEnumerable<Candidato>> obter(){
            return await _context.Candidato.ToListAsync();
        }

        [HttpPost]
        [Route("AdicionarCandidato")]
        public async Task<int> adicionarPost([FromBody] Candidato candidato){
            await _context.Candidato.AddAsync(candidato);
            await _context.SaveChangesAsync();
            return candidato.Id;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> get(){
            return new string[] {"value1","value2"};
        }

        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<string> get(int id){
            return "value";
        }

         // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
