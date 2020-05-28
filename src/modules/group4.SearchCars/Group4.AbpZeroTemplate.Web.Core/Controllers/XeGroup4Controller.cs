using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group4.AbpZeroTemplate.Application.Share.Cars.Dto;
using Group4.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class XeGroup4Controller : AbpController
    {
        private readonly IXeGroup4AppService carAppService;

        public XeGroup4Controller(IXeGroup4AppService carAppService)
        {
            this.carAppService = carAppService;
        }

        [HttpGet]
        public string getST()
        {
            return carAppService.getST();
        }

        [HttpPost]
        public List<XeGroup4Dto> XE_Group4Search(int? Ma, string Xe_Ten, int? Xe_MaLoaiXe)
        {
            return carAppService.XE_Group4Search(Ma, Xe_Ten, Xe_MaLoaiXe);
        }
    }
}
