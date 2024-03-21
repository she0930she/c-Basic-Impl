using Microsoft.AspNetCore.Mvc;
using ProductAPI;

namespace RegionResponseAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegionResponseController:ControllerBase
{
    
    private readonly HttpClient _httpClient;

    public RegionResponseController(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://host.docker.internal:1432");
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        HttpResponseMessage res = await _httpClient.GetAsync("/api/region");
        if (res.IsSuccessStatusCode)
        {
            string jsonRes = await res.Content.ReadAsStringAsync();
           
            // regionResponse format
            var regionResponse = await res.Content.ReadFromJsonAsync<IEnumerable<RegionResponse>>();
            //var resObj = JsonConvert.DeserializeObject<Object>(jsonRes);
            return Ok(regionResponse);
        }

        return BadRequest(res.StatusCode);
    }
}