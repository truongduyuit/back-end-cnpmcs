using Abp.Application.Services;
using Group4.AbpZeroTemplate.Web.Core.Services.LoaiXe.Dto;
using GSoft.AbpZeroTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4.AbpZeroTemplate.Web.Core.Services.LoaiXe
{
    
    public interface ILoaiXeGroup4AppService : IApplicationService
    {
        string getST();
        List<LoaiXeGroup4Dto> LOAIXE_Group4Search(LoaiXeGroup4Dto input);
    }
    public class LoaiXeGroup4AppService : BaseService, ILoaiXeGroup4AppService
    {
        public LoaiXeGroup4AppService()
        {

        }

        public string getST()
        {
            return "success";
        }

        public List<LoaiXeGroup4Dto> LOAIXE_Group4Search(LoaiXeGroup4Dto input)
        {
            return procedureHelper.GetData<LoaiXeGroup4Dto>("LOAIXE_Group4Search", input);
        }

    }
}
