using Backend_Nybetong.Data;
using Backend_Nybetong.Models;
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

       
        public async Task<List<AuthorizationModel>> AsyncGetAuthorizations()
        {
            return await _db.Authorizations.ToListAsync();
        }



        public async Task<List<CompanyModel>> AsyncGetCompanies()
        {
            return await _db.Companies.ToListAsync();
        }

        public async Task<List<CompanyTypeModel>> AsyncGetCompanyTypes()
        {
            return await _db.CompanyTypes.ToListAsync();
        }

        public async Task<List<ConcreteTypeModel>> AsyncGetConcreteTypes()
        {
            return await _db.ConcreteTypes.ToListAsync();
        }

        public async Task<List<ContactCategoryModel>> AsyncGetContactCategories()
        {
            return await _db.ContactCategories.ToListAsync();
        }

        public async Task<List<ContactInformationModel>> AsyncGetContactInformations()
        {
            return await _db.ContactInformations.ToListAsync();
        }

        public async Task<List<FactoryModel>> AsyncGetFactories()
        {
            return await _db.Factories.ToListAsync();
        }

        public async Task<List<HallModel>> AsyncGetHalls()
        {
            return await _db.Halls.ToListAsync();
        }
        public async Task<List<LitteraModel>> AsyncGetLitteras()
        {
            return await _db.Litteras.ToListAsync();
        }

        public async Task<List<PlanDeliveryModel>> AsyncGetPlanDeliveries()
        {
            return await _db.PlanDeliveries.ToListAsync();
        }

        public async Task<List<ProductCategoryModel>> AsyncGetProductCategories()
        {
            return await _db.ProductCategories.ToListAsync();
        }

        public async Task<List<ProjectContentModel>> AsyncGetProjectContents()
        {
            return await _db.ProjectContents.ToListAsync();
        }

        public async Task<List<ProjectModel>> AsyncGetProjects()
        {
            return await _db.Projects.ToListAsync();
        }

        public async Task<List<RollModel>> AsyncGetRolls()
        {
            return await _db.Rolls.ToListAsync();
        }
        public async Task<List<UnitModel>> AsyncGetUnits()
        {
            return await _db.Units.ToListAsync();
        }

        public async Task<List<UserModel>> AsyncGetUsers()
        {
            return await _db.Users.ToListAsync();
        }
    }
}
