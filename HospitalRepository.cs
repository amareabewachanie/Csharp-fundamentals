using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamental
{
    public class HospitalRepository : IBirthOperations
    {
        private List<Birth> births = new();
        public IEnumerable<Birth> Births => births;
        public string DisplayInfo(Birth birth)
        {
            return $"Full Name : {birth.FirstName} {birth.MiddleName} {birth.LastName} \nSex: {birth.Sex} \nDate Of Birth {birth.DateOfBirth}\n";
        }

        public void RemoveBirth(Birth birth)
        {
            births = births.Where(x => x.FirstName != birth.FirstName).ToList();
        }
        public void AddBirth(Birth birth)
        {
            births.Add(birth);
        }
    }
}
