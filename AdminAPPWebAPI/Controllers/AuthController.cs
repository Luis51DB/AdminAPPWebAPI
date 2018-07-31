using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Entities.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Contracts;

namespace AdminAPPWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("auth")]
    public class AuthController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public AuthController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost, Route("login")]
        public IActionResult Login([FromBody]Usuario user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }

            var usuario = _repository.Usuario.GetUsuarioByEmail(user);

            if (usuario.id_usuario.Equals(0))
            {
                _logger.LogError($"Usuario con correo: {user.email}, no fue encontrado.");
                return Unauthorized();
            }
            else
            {
                _logger.LogError($"Login Usuario {user.email}.");
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5000",
                    audience: "http://localhost:5000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }            
        }

        [HttpPost, Route("logout")]
        public IActionResult Logout()
        {
            //if (user == null)
            //{
            //    return BadRequest("Invalid client request");
            //}
            //else
            //{
                return Ok();
            //}

            //if (user.email == "johndoe@test.com" && user.password == "def@123")
            //{
            //    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            //    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            //    var tokeOptions = new JwtSecurityToken(
            //        issuer: "http://localhost:5000",
            //        audience: "http://localhost:5000",
            //        claims: new List<Claim>(),
            //        expires: DateTime.Now.AddMinutes(5),
            //        signingCredentials: signinCredentials
            //    );

            //    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            //    return Ok(new { Token = tokenString });
            //}
            //else
            //{
            //    return Unauthorized();
            //}
        }
    }
}