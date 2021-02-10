
using System;

namespace api.Domain.ViewModel
{
    public record UserJwt
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
