using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnvironmentAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // all API here need authorized, [Authorize("Admin")]
//[Authorize("Admin")]
//[Authorize("Admin,User")] both need authorize 
public class RegionController: ControllerBase
{
    private readonly IRegionRepoAsync<Region> _regRepoAsync;

    public RegionController(IRegionRepoAsync<Region> regRepoAsync)
    {
        _regRepoAsync = regRepoAsync;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRegion()
    {
        return Ok( await _regRepoAsync.GetAll() );
    }

    [HttpPost]
    public async Task<IActionResult> AddRegion(Region obj)
    {
        try
        {
            var res = await _regRepoAsync.Insert(obj);
            return Ok(res);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}