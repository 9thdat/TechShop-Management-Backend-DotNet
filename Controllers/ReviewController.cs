﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneShopManagementBackend.Models;

namespace PhoneShopManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReviewController : ControllerBase
    {
        private readonly TechShopContext _context;

        public ReviewController(TechShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var reviews = _context.Reviews
                .OrderByDescending(r => r.Id)
                .ToList();
            return Ok(reviews);
        }

        [HttpPut("Id={id}&Content={content}")]
        public ActionResult Update(int id, string content)
        {
            var reviewToUpdate = _context.Reviews.Find(id);

            if (reviewToUpdate == null)
            {
                return NotFound();
            }

            reviewToUpdate.AdminReply = content;
            reviewToUpdate.UpdatedAt = DateTime.Now;

            _context.Reviews.Update(reviewToUpdate);
            _context.SaveChanges();

            return Ok();
        }
    }

}
