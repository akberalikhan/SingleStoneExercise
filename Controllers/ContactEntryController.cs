using Microsoft.AspNetCore.Mvc;
using SingleStoneExercise.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace SingleStoneExercise.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class ContactEntryController : ControllerBase
    {

        private readonly ContactEntryContext _context;

        public ContactEntryController(ContactEntryContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("~/contacts/")]
        public IEnumerable<Name> Get()
        {
            // due to some invetigative reasons that eager and lazy is not working in core 3.1 - i am using brute coding approach to load 
            // related objects in the graph. I tried include but did not work. it needs little investigation
            var ph = _context.Phones;
            foreach (Phone p in ph)
            {
            }

            var ad = _context.Address;
            foreach (Address a in ad)
            {
            }
            var nm = _context.Names;
            foreach (Name n in nm)
            {
            }
  
            return nm;
        }

        [HttpPost]
        [Route("~/contacts/")]
        public void Post([FromBody] DTO data)
        {
            // for the following code the best route is to create a service layer, perform some auto mapping etc.

            var ce = new Name();
            ce.First = data.name.First;
            ce.Middle = data.name.Middle;
            ce.Last = data.name.Last;

            _context.Names.Add(ce);
            _context.SaveChanges();

            var add = new Address();
            add.Street = data.address.Street;
            add.City = data.address.City;
            add.State = data.address.State;
            add.Zip = data.address.Zip;
            add.NameId = ce.NameId;
            add.email = data.email;

            add.Phones = new List<Phone>();
            
            add.Phones.Add(new Phone { Number = data.phone[0].Number, Type = data.phone[0].Type });
            add.Phones.Add(new Phone { Number = data.phone[1].Number, Type = data.phone[1].Type });

            _context.Add(add);
            _context.SaveChanges();

        }

        [HttpPut]
        [Route("~/contacts/{id}")]
        public string Put(int id)
        {
            // we will need to pass relevent updated object. some business logic will beed to be implemented here
            var nm = _context.Names.Find(id);
            nm.Last = "changed name";
            _context.Update(nm);
            _context.SaveChanges();
            return HttpStatusCode.OK.ToString();
        }

        [HttpGet]
        [Route("~/contacts/{id}")]
        public Name Get(int id)
        {
            // some how child entities are not loaded - 
            var nm = _context.Names.Where(x => x.NameId == id).FirstOrDefault();

            return nm;            
        }

        [HttpDelete]
        [Route("~/contacts/{id}")]
        public string Delete(int id)
        {

            var nm = _context.Names.Where(x => x.NameId == id).FirstOrDefault();
            _context.Entry(nm).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return HttpStatusCode.OK.ToString(); 
        }

        [HttpGet]
        [Route("~/contacts/call-list")]
        public List<Name> GetFilter()
        {

            var result = _context.Names
            .Select(p => new
            {
            Parent = p,
            Children = p.Address.Phones.Where(c => c.Type == "mobile1")
            }) .ToList();

            //return result.ToList<Name>();
            return null;

        }

    }
}