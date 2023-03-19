using Domain.Models;

namespace Application.Interfaces;
public interface IPatientService
{
    IQueryable<Patient> Get();
    Patient Get(int id);
    Patient Create(Patient patient);
    Patient Update(Patient patient, int id);
    bool Delete(int id);
}