using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HotelBookingAPI.Domain;
using HotelBookingAPI.Presentation;

namespace HotelBookingAPI.Application.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;

        public AuthService(IUserRepository userRepository, JwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }
        public async Task<AuthResponseDto> AuthenticateAsync(string email, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(email);

            if (user == null || user.PasswordHash != ComputeHash(password))
            {
                return null; 
            }

            var token = _jwtService.GenerateToken(user); // Gera o token JWT

    
            return new AuthResponseDto
            {
                Token = token, 
                Username = user.Username,
                Email = user.Email 
            };
        }
        public async Task<bool> RegisterUserAsync(User user)
        {

            var existingUser = await _userRepository.GetUserByUsernameAsync(user.Username);
            if (existingUser.Username != null) return false; 
      
            await _userRepository.AddUserAsync(user); 
            return true; 
        }

        private string ComputeHash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash); 
        }
    }
}
