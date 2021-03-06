using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PharmacyApi.Models;

namespace PharmacyApi.Storing
{
    public class PharmacyRepository
    {
        private PharmacyContext _ctx;

           public PharmacyRepository(PharmacyContext context)
        {
            _ctx = context;
        }

        // add ----------------------------------------------------------
        public void AddPatient(Patient patient)
        {
            _ctx.Patients.Add(patient);
            _ctx.SaveChanges();
        }
        public void AddDrug(Drug drug)
        {
            Drug toAdd = new Drug();
            toAdd = drug;
            _ctx.Drugs.Add(toAdd);
            _ctx.SaveChanges();
        }

        // Gets -----------------------------------------------------------
        public Patient GetPatient(string name)
        {
            return _ctx.Patients.Include(p => p.Drugs).FirstOrDefault(p => p.Name == name);
        }
        public List<Patient> GetPatientFirst(string name)
        {
            return _ctx.Patients.Where(p => p.Name == name).ToList();
        }
        public List<Patient> GetPatientLast(string name)
        {
            return _ctx.Patients.Where(p => p.LastName == name).ToList() ;
        }
        public List<Patient> GetPatients()
        {
            return _ctx.Patients.ToList();
        }
        public Drug GetDrug(long id)
        {
            return _ctx.Drugs.FirstOrDefault(p => p.EntityId == id);
        }
        public List<Drug> GetDrugs()
        {
            return _ctx.Drugs.ToList();
        }
        public IEnumerable<Drug> patientDrugs(long id)
        {
            return _ctx.Drugs.Where(d => d.PatientEntityId==id).ToList();
        }


        // update  --------------------------------------------
       
       public void Update()
       {
           _ctx.SaveChanges();
       }

        // Deletes --------------------------------------------------------
        public void RemoveDrug(long id)
        {
            var drug = _ctx.Drugs.FirstOrDefault(d => d.EntityId == id);
            _ctx.Drugs.Remove(drug);
            _ctx.SaveChanges();
        }




    }    
}