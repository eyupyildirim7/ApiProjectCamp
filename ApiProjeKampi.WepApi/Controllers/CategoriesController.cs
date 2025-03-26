﻿using ApiProjeKampi.WepApi.Context;
using ApiProjeKampi.WepApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContext _context;
        public CategoriesController(ApiContext context) { 
        _context = context;
        }
        [HttpGet]

        public IActionResult CategoryList()
        {
            var values=_context.Categories.ToList();
            return Ok(values);
        }



        [HttpPost]
        public IActionResult CreateCategory(Category category) {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategori ekleme islemi basarili");
        
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id) {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("Kategori Silme Basarili");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _context.Categories.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category) { 
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Kategori Günceleme İşlemi Başarılı.");
        }
    }
}
