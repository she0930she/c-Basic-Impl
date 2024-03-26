using JwtAuthenticationManager;
using JwtAuthenticationManager.Model;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly JwtTokenHandler _jwtTokenHandler;

    public AccountController(JwtTokenHandler jwtTokenHandler)
    {
        _jwtTokenHandler = jwtTokenHandler;
    }

    [HttpPost]
    public ActionResult<AuthenticationResponse> Login(AuthenticationRequest request)
    {
        var authResponse = _jwtTokenHandler.GenerateToken(request);
        if (authResponse == null) return Unauthorized();

        return authResponse;
    }
}