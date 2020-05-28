using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using GSoft.AbpZeroTemplate.Helpers;
using GSoft.AbpZeroTemplate.Sessions;
using Group4.AbpZeroTemplate.Application.Share.Cars.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using GSoft.AbpZeroTemplate.Sessions;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Group4.AbpZeroTemplate.Web.Core.Services.LoaiXe.Dto;

namespace Group4.AbpZeroTemplate.Web.Core.Cars
{
    public interface IXeGroup4AppService : IApplicationService
    {
        string getST();

        List<XeGroup4Dto> XE_Group4Search(int? ma, string xe_Ten, int? xe_LoaiXe);
    }
    public class XeGroup4AppService : BaseService, IXeGroup4AppService
    {
        public XeGroup4AppService()
        {
            
        }

        public string getST()
        {
            return "success";
        }

        public List<XeGroup4Dto> XE_Group4Search(int? ma, string xe_Ten, int? xe_LoaiXe)
        {
            return procedureHelper.GetData<XeGroup4Dto>("XE_Group4Search", new
            {
                Xe_Ten = xe_Ten,
                Xe_LoaiXe = xe_LoaiXe,
                Ma = ma
            });
        }


    }
}
