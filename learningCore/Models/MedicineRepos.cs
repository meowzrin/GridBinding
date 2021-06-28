using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learningCore.Models
{
    public class MedicineRepos : IMedicineRepos
    {
        private readonly AppDbContext _dbContext;
        public MedicineRepos(AppDbContext context)
        {
            _dbContext = context;
        }
        public IEnumerable<Medicines> GetAllMedicines()
        {
            return _dbContext.medicine;
        }
    }
}
