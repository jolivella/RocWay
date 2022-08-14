using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocWay.Api.Utils;
using RocWay.Application.DTO;
using RocWay.Application.Interface;
using RocWay.Domain.Entities;

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
        public IActionResult Insert([FromForm] CreateCustomerDto createCustomerDto)
        {
            if (createCustomerDto == null)
            {
                return BadRequest();
            }
            var response = customerApplication.Insert(createCustomerDto);
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
        public async Task<IActionResult> GetAll([FromQuery] PaginationDTO paginationDTO)
        {
            var response = customerApplication.GetAll();

            // Para paginacion
            var queryable = response.Data.AsQueryable();
            HttpContext.InsertPaginationParametersInHeader(queryable);
            var customer = queryable.OrderBy(x => x.CompanyName).Paginar(paginationDTO).ToList();

            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            return Ok(customer);
        }
    }
}
