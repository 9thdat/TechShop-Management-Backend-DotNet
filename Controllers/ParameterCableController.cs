﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneShopManagementBackend.Models;

namespace PhoneShopManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ParameterCableController : ControllerBase
    {
        private readonly TechShopContext _context;

        public ParameterCableController(TechShopContext context)
        {
            _context = context;
        }

        [HttpGet("ProductId={id}")]
        public ActionResult GetParameterCableByProductId(int id)
        {
            var parameterCable = _context.ParameterCables.Where(p => p.ProductId == id);
            if (parameterCable == null)
            {
                return Ok();
            }

            return Ok(parameterCable);
        }

        [HttpPost]
        public ActionResult CreateParameterCable(ParameterCable parameterCable)
        {
            _context.ParameterCables.Add(parameterCable);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateParameterCable(int id, ParameterCable parameterCable)
        {
            if (id != parameterCable.Id)
            {
                return BadRequest();
            }

            _context.Entry(parameterCable).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteParameterCable(int id)
        {
            var parameterCable = _context.ParameterCables.Find(id);
            if (parameterCable == null)
            {
                return NotFound();
            }

            _context.ParameterCables.Remove(parameterCable);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
