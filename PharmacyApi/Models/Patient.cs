using System;
using System.Collections.Generic;
using PharmacyApi.Abstracts;

namespace PharmacyApi.Models
{
    public class Patient:AEntity
    {
        public string Name {get;set;}
        public int Age {get;set;}
        
        public string Sex{get;set;}

        public List<Drug> Drugs {get;set;}
    }

}