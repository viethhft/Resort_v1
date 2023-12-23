using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resort.Ser.IServices;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountryController : Controller
    {
        private readonly IProvinceSer _provinceSer;
        private readonly IDistrictSer _districtSer;
        private readonly ICommuneSer _communeSer;
       
        public CountryController(IProvinceSer provinceSer,ICommuneSer communeSer, IDistrictSer districtSer)
        {
            _provinceSer = provinceSer;
            _communeSer = communeSer;
            _districtSer= districtSer;
        }

        [Route("Admin/District")]
        public async Task<string> GetListDistrictByIdProvince(int id)
        {
            var districts=JsonConvert.SerializeObject(await _districtSer.GetDistrictByID(id));
            return districts;
        }

        [Route("Admin/Commune")]
        public async Task<string> GetListCommuneByIdDistrict(int id)
        {
            var commune = JsonConvert.SerializeObject(await _communeSer.GetCommuneByID(id));
            return commune;
        }
    }
}
