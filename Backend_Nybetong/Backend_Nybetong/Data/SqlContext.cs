using Backend_Nybetong.Models;
using Backend_Nybetong.Models.MainModels;
using Microsoft.EntityFrameworkCore;

namespace Backend_Nybetong.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AuthorizationModel> Authorizations { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<CompanyTypeModel> CompanyTypes { get; set; }
        public DbSet<ConcreteTypeModel> ConcreteTypes{ get; set; }
        public DbSet<ContactCategoryModel> ContactCategories { get; set; }
        public DbSet<ContactInformationModel> ContactInformations { get; set; }
        public DbSet<FactoryModel> Factories { get; set; }
        public DbSet<HallModel> Halls { get; set; }
        public DbSet<LitteraModel> Litteras { get; set; }
        public DbSet<PlanDeliveryModel> PlanDeliveries { get; set; }
        public DbSet<ProductCategoryModel> productCategories{ get; set; }
        public DbSet<ProjectContentModel> ProjectContents { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<RollModel> Rolls { get; set; }
        public DbSet<UnitModel> Units { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
