using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamental
{
    public interface IBirthOperations
    {
        string DisplayInfo(Birth birth);
        void AddBirth(Birth birth);
        void RemoveBirth(Birth birth);
    }
}
