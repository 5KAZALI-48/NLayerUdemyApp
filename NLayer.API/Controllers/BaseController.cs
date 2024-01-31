using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> responseDto)
        {
            if (responseDto.StatusCode == 204)
            {
                return new ObjectResult(null) { StatusCode = responseDto.StatusCode };
            }

            return new ObjectResult(responseDto)
            {
                StatusCode = responseDto.StatusCode
            };
        }

    }
}
