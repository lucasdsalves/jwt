using AutoMapper;
using System.Threading.Tasks;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.CC.Utils;
using Template.Domain.DTOs;
using Template.Domain.Interfaces;

namespace Template.Application.Services
{
    public class AuthenticationAppService : IAuthenticationAppService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public AuthenticationAppService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<AuthResponseViewModel> Authenticate(AuthRequestViewModel authData)
        {
            var user = await _userRepository.Get(_mapper.Map<UserDTO>(authData));

            if (user is null) return null;

            return new AuthResponseViewModel
            {
                Username = user.Username,
                Token = TokenService.GenerateToken(user.Username, user.Role)
            };
        }
    }
}
