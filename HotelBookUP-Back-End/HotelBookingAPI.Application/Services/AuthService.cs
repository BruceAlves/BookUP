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
                return null; // Retorna null se as credenciais forem inválidas
            }

            var token = _jwtService.GenerateToken(user); // Gera o token JWT

            // Retorna o DTO com o token e os dados do usuário
            return new AuthResponseDto
            {
                Token = token, 
                Username = user.Username,
                Email = user.Email 
            };
        }
        public async Task<bool> RegisterUserAsync(User user)
        {
            // Verifica se o usuário já existe
            var existingUser = await _userRepository.GetUserByUsernameAsync(user.Username);
            if (existingUser.Username != null) return false; // Retorna falso se o usuário já existir

            // Adiciona o novo usuário ao repositório
            await _userRepository.AddUserAsync(user); // Você deve implementar esse método no repositório
            return true; // Retorna verdadeiro se o registro for bem-sucedido
        }

        private string ComputeHash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash); // Retorna o hash em Base64
        }
    }
}
