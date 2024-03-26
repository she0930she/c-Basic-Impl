namespace JwtAuthenticationManager.Model;

public class AuthenticationResponse
{
    public string UserName { get; set; }
    public string JWTToken { get; set; }
    public int ExpiredIn { get; set; }
}