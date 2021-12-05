namespace Diphda.Application.Controllers.Authentication
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Diphda.Domain.Account;
    using System.Collections.Generic;
    using Diphda.Domain.Abstractions;
   
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationApiController : Controller
    {
        private readonly IBaseService<User> userService;

        public AuthenticationApiController(IBaseService<User> userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<User>>> GetAllAsync()
        {
            return Ok(await userService.GetAllAsync()); // TODO: returns user DTO instead the entity.
        }
    }
}