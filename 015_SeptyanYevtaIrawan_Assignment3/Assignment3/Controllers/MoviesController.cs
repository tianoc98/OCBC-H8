using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Data;
using Assignment3.Models;

namespace Assignment3.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase{
        private readonly ApiDbContext _context;

        public MoviesController(ApiDbContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> getItems(){
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data){
            if(ModelState.IsValid){
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetItem", new {data.Id},data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getItem(int id){
            var items = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
            if(items == null){
                return NotFound();
            }
            return Ok(items);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> DeleteItem(int id){
            var items = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
            if(items == null){
                return NotFound();
            }
            _context.Items.Remove(items);
            await _context.SaveChangesAsync();
            return Ok(items);
        }

        [HttpPost("update/{id}")]
        public async Task<IActionResult> UpdateItem(ItemData data,int id){
            var items = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
             _context.Entry(items).CurrentValues.SetValues(data);
             await _context.SaveChangesAsync();
            return Ok(data);
            
        }
    }
}