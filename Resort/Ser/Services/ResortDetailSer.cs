using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ResortDetailSer : IResortDetailSer
    {
        private readonly IResortDetailRepo _resortDetailRepo;
        public ResortDetailSer(IResortDetailRepo resortDetailRepo)
        {
            _resortDetailRepo = resortDetailRepo;
        }
        public Task<bool> AddResortDetail(ResortDetail resortDetail)
        {
            return _resortDetailRepo.AddResortDetail(resortDetail);
        }

        public Task<ResortDetail> GetResortDetailByID(int id)
        {
            return _resortDetailRepo.GetResortDetailByID(id);
        }

        public Task<bool> UpdateResortDetail(ResortDetail resortDetail)
        {
            return _resortDetailRepo.UpdateResortDetail(resortDetail);
        }
    }
}
