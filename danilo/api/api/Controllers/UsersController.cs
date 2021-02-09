using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Domain.ViewModel;
using api.Domain.Entities;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;
using api.Domain.UseCase.UserService;

namespace api.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly EntityContext _context;
        private readonly ILogger<HomeController> _logger;

        public UsersController(EntityContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("/users")]
        public async Task<ICollection<UserView>> Index()
        {
            return await _context.Users.Select( u => new UserView {
                        Id = u.Id, Name = u.Name, Email = u.Email
                    }).ToListAsync();
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> Create([FromForm] User user)
        {
            try
            {
                await new UserRepository(_context).Save(user);
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
                await new UserRepository(_context).Save(user);
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
                await new UserRepository(_context).Delete(id);
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
