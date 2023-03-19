using Domain.Interfaces;
using Domain.Models;
using Infra.Contexts;

namespace Infra.Repositories;

public class PatientRepository : IPatientRepository
{
    private AppDbContext _context;
    public PatientRepository(AppDbContext context)
    {
        _context = context;
    }
    public Patient Create(Patient patient)
    {
        _context.Patients.Add(patient);
        _context.SaveChanges();
        return patient;
    }

    public bool Delete(int id)
    {
        try
        {
            var patient = _context.Patients.Find(id);
            _context.Patients.Remove(patient);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }

    public IQueryable<Patient> Get()
    {
        return _context.Patients.AsQueryable();
    }

    public Patient Get(int id)
    {
        return _context.Patients.Find(id);
    }

    public Patient Update(Patient patient, int id)
    {
        var oldPatient = _context.Patients.Find(id);
        if (oldPatient != null)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }
        return patient;
    }
}