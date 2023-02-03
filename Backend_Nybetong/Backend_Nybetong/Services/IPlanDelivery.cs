using Backend_Nybetong.Models.MainModels;

namespace Backend_Nybetong.Services
{
    public interface IPlanDelivery
    {
        Task<List<LitteraModel>> AsyncGetLitteras();
    }
}
