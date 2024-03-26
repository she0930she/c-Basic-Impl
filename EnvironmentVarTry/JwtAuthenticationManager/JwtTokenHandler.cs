using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationManager.Model;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationManager;

public class JwtTokenHandler
{
    public const string JWT_SECURITY_KEY = "kngrghljytjqhdsfk5eyklajrk657kgslskbfh0khjyd";
    private const int JWT_TOKEN_VALIDITY_MINS = 20;
    private readonly List<UserAccount> userAccountList;

    public JwtTokenHandler()
    {
        userAccountList = new () // no need to declare type
        {
            new UserAccount(){ UserName = "admin", Password = "admin@123", Role = "Admin"},
            new UserAccount(){ UserName = "user", Password = "user@123", Role = "User"}
        }; 
    }

    // check userName and passW valid, if valid, return a token, otherwise return null
    public AuthenticationResponse GenerateToken(AuthenticationRequest authReq)
    {
        if (string.IsNullOrEmpty(authReq.UserName) || string.IsNullOrEmpty(authReq.Password))
            return null;
        // validate the user
        var user = userAccountList.Where(x =>
            x.UserName == authReq.UserName && x.Password == authReq.Password)
            .FirstOrDefault();
        
        if (user == null) return null;
        var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY); // encode the key
        var tokenExpireTimestamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);
        var claimsIdentity = new ClaimsIdentity(new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Name, authReq.UserName),
            new Claim("Role", user.Role)
        });
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(tokenKey),
            SecurityAlgorithms.HmacSha256Signature
            );
        var securityTokenDesciptor = new SecurityTokenDescriptor
        {
            Subject = claimsIdentity,
            Expires = tokenExpireTimestamp,
            SigningCredentials = signingCredentials
        };
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDesciptor);
        var token = jwtSecurityTokenHandler.WriteToken(securityToken);
    
        return new AuthenticationResponse
        {
            UserName = user.UserName,
            JWTToken = token,
            ExpiredIn = (int) tokenExpireTimestamp.Subtract(DateTime.Now).TotalSeconds
        };
    }



}