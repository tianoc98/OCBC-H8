using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Data;
using TodoAppWithJWT.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;


namespace TodoApp.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TodoController : ControllerBase{
        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context){
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
    }
}