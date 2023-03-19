using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private IPatientService _patientService { get; set; }
    public PatientController(IPatientService patientService)
    {
        _patientService = patientService;
    }
    [HttpGet]
    public ActionResult<IList<Patient>> Get()
    {
        try
        {
            return Ok(_patientService.Get());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpGet("{id}")]
    public ActionResult<Patient> Get(int id)
    {
        try
        {
            var patient = _patientService.Get(id);
            if (patient == null)
                return NoContent();
            return Ok(_patientService.Get(id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPost]
    public ActionResult Create(Patient patient)
    {
        try
        {
            return Ok(_patientService.Create(patient));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut("{id}")]
    public ActionResult Update(Patient patient, int id)
    {
        try
        {
            return Ok(_patientService.Update(patient, id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpDelete("{id}")]
    public ActionResult<bool> Delete(int id)
    {
        try
        {
            return Ok(_patientService.Delete(id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

}