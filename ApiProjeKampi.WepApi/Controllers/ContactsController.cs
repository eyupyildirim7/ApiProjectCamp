using ApiProjeKampi.WepApi.Context;
using ApiProjeKampi.WepApi.Dtos.ContactDtos;
using ApiProjeKampi.WepApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;
        public ContactsController(ApiContext context) {
        _context= context;
        }
        [HttpGet]
        public IActionResult ContacList()
        {
            var values =_context.Contacs.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto) {
            Contact contact = new Contact();
            contact.Email=createContactDto.Email;
            contact.Adress=createContactDto.Adress;
            contact.Phone=createContactDto.Phone;
            contact.MapLocation=createContactDto.MapLocation;
            contact.Openhours=createContactDto.Openhours;
            _context.Contacs.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı");
        
        
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id) {
            var value = _context.Contacs.Find(id);
            _context.Contacs.Remove(value);
            _context.SaveChanges();
            return Ok("Silme islemi basarili");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id) {
        
        var value = _context.Contacs.Find(id);
            return Ok(value);
                }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto) {
            Contact contact=new Contact();
            contact.Email=updateContactDto.Email;
            contact.Adress= updateContactDto.Adress;
            contact.Phone=updateContactDto.Phone;
            contact.ContactId=updateContactDto.ContactId;
            contact.MapLocation = updateContactDto.MapLocation;
            contact.Openhours   = updateContactDto.Openhours;
            _context.Contacs.Update(contact);
            _context.SaveChanges();
            return Ok("Guncelleme islemi basarili");
        
        
        }
    }
}
