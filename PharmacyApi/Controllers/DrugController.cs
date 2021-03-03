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
    [HttpGet("/Drugs/Drug/{id}")]
    public IActionResult GetDrug(long id)
    {
        var drugs = _repo.GetDrug(id);
        return Ok(drugs);
        
    }
    [HttpGet("/Drugs/{PatientEntityId}")]
    public IActionResult PatientDrugs(long PatientEntityId)
    {

      

        var drugs = _repo.patientDrugs(PatientEntityId);
        return Ok(drugs);
    }

    
    [HttpPost("/Drugs/Add")]
    public IActionResult AddDrug([FromBody]Drug json)
    {

        Drug drug = new Drug();
        drug= json;
              
        _repo.AddDrug(drug);
        
        return Ok();
    }

    [HttpPut("/Drugs/{id}/{dec}")]
    public IActionResult EditDrug(long id, int dec)
    {   Drug drug = _repo.GetDrug(id);
        drug.Amount= drug.Amount - dec;
        _repo.Update();
        return Ok();
    }
   
}

}