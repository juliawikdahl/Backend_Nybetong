using Backend_Nybetong.Models;
using Backend_Nybetong.Models.MainModels;

namespace Backend_Nybetong.Services
{
    public interface IPlanDelivery
    {

        Task<List<AuthorizationModel>> AsyncGetAuthorizations();
        Task<List<CompanyModel>> AsyncGetCompanies();
        Task<List<CompanyTypeModel>> AsyncGetCompanyTypes();
        Task<List<ConcreteTypeModel>> AsyncGetConcreteTypes();
        Task<List<ContactCategoryModel>> AsyncGetContactCategories();
        Task<List<ContactInformationModel>> AsyncGetContactInformations();
        Task<List<FactoryModel>> AsyncGetFactories();
        Task<List<HallModel>> AsyncGetHalls();
        Task<List<LitteraModel>> AsyncGetLitteras();
        Task<List<PlanDeliveryModel>> AsyncGetPlanDeliveries();
        Task<List<ProductCategoryModel>> AsyncGetProductCategories();
        Task<List<ProjectContentModel>> AsyncGetProjectContents();
        Task<List<ProjectModel>> AsyncGetProjects();
        Task<List<RollModel>> AsyncGetRolls();
        Task<List<UnitModel>> AsyncGetUnits();
        Task<List<UserModel>> AsyncGetUsers();
    }
}
