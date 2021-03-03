

using PharmacyApi.Abstracts;

namespace PharmacyApi.Models
{
    public class Drug:AEntity
    {
        public Drug(){}
        public string Name {get;set;}
        public string Dose {get;set;}

        public int Amount{get;set;}        

        public bool isLiquid {get;set;}

        public string Presciber {get;set;}

        public long PatientEntityId {get;set;}
    }
}