
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Models;
using PharmacyApi.Storing;

namespace PharmacyApi.Controllers
{

[ApiController]
public class PatientController:ControllerBase
{
    
    private readonly PharmacyRepository _repo;

    public PatientController(PharmacyRepository repo)
    {
        _repo=repo;
    }

    [HttpGet("/patients")]
    public IActionResult GetPatients()
    {
        var patients = _repo.GetPatients();
        return Ok(patients);
        
    }
    [HttpPost("/patients/add")]
    public IActionResult AddPatient([FromBody]Patient json)
    {
        Patient pt = new Patient();
        pt= json;
              
        _repo.AddPatient(pt);
        
        return Ok();
    }
}

}