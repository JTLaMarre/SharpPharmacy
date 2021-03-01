using System;
using System.Collections.Generic;

namespace PharmacyApi.Models
{
    public class Patient
    {
        public string Name {get;set;}
        public int Age {get;set;}
        
        public string Sex{get;set;}

        public List<Drug> Drugs {get;set;}
    }

}