using RocWay.Application.DTO;
using RocWay.Application.Interface;
using RocWay.Domain.Entities;
using RocWay.Domain.Interface;
using AutoMapper;
using RocWay.Transversal.Common;
using RocWay.Application.Validator;

namespace RocWay.Application.Main
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomerDomain customerDomain;
        private readonly IMapper mapper;
        private readonly IAppLogger<CustomerApplication> logger;
        private readonly CustomerValidator validations;


        public CustomerApplication(ICustomerDomain CustomerDomain, IMapper Mapper, IAppLogger<CustomerApplication> Logger,CustomerValidator Validations)
        {
            customerDomain = CustomerDomain;
            mapper = Mapper;
            logger = Logger;
            validations = Validations;
        }

        public Response<bool> Delete(int customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = customerDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<CustomerDto> Get(int customerId)
        {
            var response = new Response<CustomerDto>();
            try
            {
                var customer = customerDomain.Get(customerId);
                response.Data = mapper.Map<CustomerDto>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<IEnumerable<CustomerDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomerDto>>();
            try
            {
                //var customers = mapper.Map<IEnumerable<CustomerDto>>(customerDomain.GetAll());
                var customers = customerDomain.GetAll();
                response.Data = mapper.Map<IEnumerable<CustomerDto>>(customers);
                if(response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message= "Consulta Exitosa!!!";
                    logger.LogInformation("Consulta Exitosa!!!");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                logger.LogError(ex.Message);
            }
            
            return response;
        }

        public Response<bool> Insert(CustomerDto customersDto)
        {
            //Ejemplo uso de FluentValidation
            var validation = validations.Validate(customersDto);
            var response = new Response<bool>();
            try
            {
                var customer = mapper.Map<Customer>(customersDto);
                response.Data = customerDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Update(CustomerDto customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = mapper.Map<Customer>(customersDto);
                response.Data = customerDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
