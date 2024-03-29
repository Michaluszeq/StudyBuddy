﻿using Back.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudyBuddyController : ControllerBase
    {
        private readonly ProjektDbContext _DbContext;

        public StudyBuddyController(ProjektDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        [HttpPost("opinion")]

        public ActionResult galeria([FromBody] Reviews review, [FromQuery] string  subject  )
        {

            var pom=  _DbContext.School_Subjects.Where(r => r.Subject == subject);
            if (pom.Count() == 0)
            {
                return Ok("Blad");
            }
            var pom2 = pom.ToArray();
            review.School_SubjectsId = pom2[0].Id;
            _DbContext.Reviews.Add(review);
            _DbContext.SaveChanges();


            return Ok("Dodano opinie");
        }

        [HttpPost("subject")]
        public ActionResult subject([FromBody] School_Subjects subject)
        {

            _DbContext.School_Subjects.Add(subject);
            _DbContext.SaveChanges();


            return Ok("Dodano przedmiot");
        }

        [HttpPost("corepetition")]
        public ActionResult corepetition([FromBody] Corepetition corepetition)
        {

            _DbContext.Corepetitions.Add(corepetition);
            _DbContext.SaveChanges();


            return Ok("Dodano przedmiot");
        }

        [HttpGet("corepetitionkox")]
        public ActionResult<Reviews> Getc([FromQuery] string subject)
        {


            return Ok(_DbContext.Corepetitions.Where(r => r.Subject == subject));
        }

        [HttpPost("gallery")]
        public ActionResult gallery([FromBody] Books book)
        {
            _DbContext.Books.Add(book);
            _DbContext.SaveChanges();

            return Ok("Dodano ogłoszenie");
        }

        [HttpGet("subjects")]
        public ActionResult<School_Subjects> Get() 
        { 
        return Ok(_DbContext.School_Subjects);
        }

     

        [HttpGet("opinionskox")]
        public ActionResult<Reviews> Get([FromQuery] string subject)
        {
           
       
            return Ok(_DbContext.Reviews.Where(r => r.Subject==subject));
        }

        [HttpGet("opinion")]
        public ActionResult<Reviews> Get3()
        {
            return Ok(_DbContext.Reviews);
        }

        [HttpGet("books")]
        public ActionResult<Books> Get2()
        {
            return Ok(_DbContext.Books);
        }
        [HttpGet("book")]
        public ActionResult<Books> Get2([FromQuery] int id)
        {
            return Ok(_DbContext.Books.Where(r=>r.Id==id));
        }
        [HttpGet("corepetitions")]
        public ActionResult<Corepetition> Get4()
        {
            return Ok(_DbContext.Corepetitions);
        }

    }
}
