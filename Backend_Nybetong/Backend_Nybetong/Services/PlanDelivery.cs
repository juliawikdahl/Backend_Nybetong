using Backend_Nybetong.Data;
using Backend_Nybetong.Models.MainModels;
using Microsoft.EntityFrameworkCore;

namespace Backend_Nybetong.Services
{
    public class PlanDelivery : IPlanDelivery
    {
        private readonly SqlContext _db;

        public PlanDelivery(SqlContext db)
        {
            _db = db;
        }

        public async Task<List<LitteraModel>> AsyncGetLitteras()
        {
            return await _db.Litteras.ToListAsync();
        }
    }
}
