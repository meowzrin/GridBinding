using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learningCore.Models
{
    public interface IMedicineRepos
    {
        
        IEnumerable<Medicines> GetAllMedicines();
        
      
    }
}
