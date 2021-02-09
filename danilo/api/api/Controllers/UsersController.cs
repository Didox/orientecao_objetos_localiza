using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Domain.ViewModel;
using api.Domain.Entities;
using api.Infra.Database;
using api.Domain.UseCase.UserService;
using api.Domain.Infra.Database;

namespace api.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserFactory _userFactory;
        private readonly ILogger<HomeController> _logger;

        public UsersController(EntityContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _userFactory = new UserFactory(new UserRepository(context));
        }

        [HttpGet]
        [Route("/users")]
        public async Task<ICollection<UserView>> Index()
        {
            return await _userFactory.All();
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> Create([FromForm] User user)
        {
            try
            {
                await _userFactory.Save(user);
                return StatusCode(201);
            }
            catch(UserUniqMail err)
            {
                return StatusCode(401, new {
                    Message = err.Message
                });
            }
        }

        [HttpPut]
        [Route("/users/{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] User user)
        {
            user.Id = id;
            try
            {
                await _userFactory.Save(user);
                return StatusCode(204);
            }
            catch(UserUniqMail err)
            {
                return StatusCode(401, new {
                    Message = err.Message
                });
            }
        }

        [HttpDelete]
        [Route("/users/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _userFactory.Delete(id);
                return StatusCode(204);
            }
            catch(UserEmptyId err)
            {
                return StatusCode(401, new {
                    Message = err.Message
                });
            }
            catch(UserNotFound err)
            {
                return StatusCode(404, new {
                    Message = err.Message
                });
            }
        }
    }
}
