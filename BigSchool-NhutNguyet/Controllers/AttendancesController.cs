using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;
using BigSchool_NhutNguyet.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using Microsoft.AspNet.Identity;

namespace BigSchool_NhutNguyet.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbcontext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbcontext();
        }
        [HttpPost]
        public IHttpActionResult Attend ([FromBody]int courseId)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == courseId))
                return BadRequest("The Attendance already exists!");
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
