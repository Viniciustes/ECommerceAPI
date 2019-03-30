using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Controllers
{
    [Route("ECommerceAPI/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
        }

        // GET: ECommerceAPI/Categorias
        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            return categoriaService.GetAll();
        }

        // GET: ECommerceAPI/Categorias/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoria([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoria = await categoriaService.GetByIdAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        // POST: ECommerceAPI/Categorias
        [HttpPost]
        public async Task<IActionResult> PostCategoria([FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await categoriaService.AddAsync(categoria);

            return CreatedAtAction("GetCategoria", new { id = categoria.Id }, categoria);
        }

        // PUT: ECommerceAPI/Categorias/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoria([FromRoute] int id, [FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoria.Id)
            {
                return BadRequest();
            }

            try
            {
                await categoriaService.UpdateAsync(categoria);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: ECommerceAPI/Categorias/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoria([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoria = await categoriaService.GetByIdAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            await categoriaService.DeleteAsync(categoria);

            return Ok(categoria);
        }

        private bool CategoriaExists(int id) => categoriaService.EntityExistsAny(id);
    }
}