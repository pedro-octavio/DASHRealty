using System;
using DASHRealty.Application.DTOs;
using DASHRealty.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DASHRealty.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyApplicationService _propertyApplicationService;

        public PropertyController(IPropertyApplicationService propertyApplicationService) => _propertyApplicationService = propertyApplicationService;

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            try
            {
                return Ok(_propertyApplicationService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(error: ex);
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get([FromRoute] Guid id)
        {
            try
            {
                var property = _propertyApplicationService.GetById(id);

                if (property == null) return BadRequest("This property dont exists.");

                return Ok(property);
            }
            catch (Exception ex)
            {
                return BadRequest(error: ex);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PropertyDTO propertyDTO)
        {
            try
            {
                _propertyApplicationService.Add(propertyDTO);

                return Ok("Property successfully created.");
            }
            catch (Exception ex)
            {
                return BadRequest(error: ex);
            }
        }

        [HttpPut]
        [Authorize]
        public IActionResult Put([FromBody] PropertyDTO propertyDTO)
        {
            try
            {
                _propertyApplicationService.Update(propertyDTO);

                return Ok("Property successfully updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(error: ex);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete([FromRoute] Guid id)
        {
            try
            {
                _propertyApplicationService.Remove(id);

                return Ok("Property successfully removed.");
            }
            catch (Exception ex)
            {
                return BadRequest(error: ex);
            }
        }
    }
}
