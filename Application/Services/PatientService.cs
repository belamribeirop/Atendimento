using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;
namespace Application.Services;

public class PatientService : IPatientService
{
    private IPatientRepository _patientRepository { get; set; }
    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    public Patient Create(Patient patient)
    {
        return _patientRepository.Create(patient);
    }

    public bool Delete(int id)
    {
        return _patientRepository.Delete(id);
    }

    public IQueryable<Patient> Get()
    {
        return _patientRepository.Get();
    }

    public Patient Get(int id)
    {
        return _patientRepository.Get(id);
    }

    public Patient Update(Patient patient, int id)
    {
        return _patientRepository.Update(patient, id);
    }
}