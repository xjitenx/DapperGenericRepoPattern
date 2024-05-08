using DapperGenericRepoPattern.Model;
using DapperGenericRepoPattern.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace DapperGenericRepoPattern.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private ResponseDto _response;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
            _response = new ResponseDto();
        }
        
        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            try
            {
                _response.Result = await _userService.GetAll();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ResponseDto> Get(Guid id)
        {
            try
            {
                _response.Result = await _userService.GetById(id);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] User user)
        {
            try
            {
                _response.Result = await _userService.Add(user);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        public async Task<ResponseDto> Put([FromBody] User user)
        {
            try
            {
                _response.Result = await _userService.Update(user);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        public async Task<ResponseDto> Delete([FromBody] User user)
        {
            try
            {
                _response.Result = await _userService.Delete(user);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
