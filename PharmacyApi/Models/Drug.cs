

namespace PharmacyApi.Models
{
    public class Drug
    {
        public string Name {get;set;}
        public string Dose {get;set;}

        public int Amount {get;set;}

        public bool isLiquid {get;set;}
    }
}