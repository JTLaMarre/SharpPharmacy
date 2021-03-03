using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Models;
using PharmacyApi.Storing;

namespace PharmacyApi.Controllers
{

[ApiController]
public class DrugController:ControllerBase
{
    private readonly PharmacyContext _ctx;

    private readonly PharmacyRepository _repo;
        public DrugController(PharmacyRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("/Drugs")]
    public IActionResult GetDrugs()
    {
        var drugs = _repo.GetDrugs();
        return Ok(drugs);
        
    }
    [HttpGet("/Drugs/{PatientEntityId}")]
    public IActionResult PatientDrugs(long PatientEntityId)
    {

      

        var drugs = _repo.patientDrugs(PatientEntityId);
        return Ok(drugs);
    }

    // Todo Add Drug Post method
    [HttpPost("/Drugs/Add")]
    public IActionResult AddDrug([FromBody]Drug json)
    {

        Drug drug = new Drug();
        drug= json;
              
        _repo.AddDrug(drug);
        
        return Ok();
    }
   
}

}