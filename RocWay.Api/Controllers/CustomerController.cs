using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocWay.Application.DTO;
using RocWay.Application.Interface;

namespace RocWay.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerApplication customerApplication;

        public CustomerController(ICustomerApplication _customerApplication)
        {
            customerApplication = _customerApplication;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] CustomerDto customerDto)
        {
            if (customerDto == null)
            {
                return BadRequest();
            }
            var response = customerApplication.Insert(customerDto);
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CustomerDto customerDto)
        {
            if (customerDto == null)
            {
                return BadRequest();
            }
            var response = customerApplication.Update(customerDto);
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [HttpDelete("{customerId}")]
        public IActionResult Delete(int customerId)
        {
            if (string.IsNullOrEmpty(customerId.ToString()))
            {
                return BadRequest();
            }
            var response = customerApplication.Delete(customerId);
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [HttpGet("{customerId}")]
        public IActionResult Get(int customerId)
        {
            if (string.IsNullOrEmpty(customerId.ToString()))
            {
                return BadRequest();
            }
            var response = customerApplication.Get(customerId);
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = customerApplication.GetAll();
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }
    }
}
