using ChurrasApplication.ViewModel;
using ChurrasDomain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Churras.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Login(UserViewModel userViewModel)
        {
            if ((await _userService.Find(x=>x.Login == userViewModel.Login && x.Password == userViewModel.Password)).Count() > 0)
                return Ok(true);
            else
                return BadRequest(false);
        }
    }
}
