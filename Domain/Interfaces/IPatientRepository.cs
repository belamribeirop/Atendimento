using Domain.Models;

namespace Domain.Interfaces;
public interface IPatientRepository
{
    IQueryable<Patient> Get();
    Patient Get(int id);
    Patient Create(Patient patient);
    Patient Update(Patient patient, int id);
    bool Delete(int id);
}