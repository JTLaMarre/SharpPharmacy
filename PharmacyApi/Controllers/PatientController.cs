
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Storing;

namespace PharmacyApi.Controllers
{

[ApiController]
public class PatientController:ControllerBase
{
    private readonly PharmacyContext _ctx;

    public PatientController(PharmacyContext context)
    {
        _ctx=context;
    }

    [HttpGet("/patients")]
    public IActionResult GetPatients()
    {
        var patients = _ctx.Patients.ToList();
        return Ok(patients);
        
    }
}

}