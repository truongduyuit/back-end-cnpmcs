using Abp.AspNetCore.Mvc.Controllers;
using Group4.AbpZeroTemplate.Web.Core.Services.LoaiXe;
using Group4.AbpZeroTemplate.Web.Core.Services.LoaiXe.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4.AbpZeroTemplate.Application.Controllers
{
    
    [Route("api/[controller]/[action]")]
    public class LoaiXeGroup4Controller : AbpController
    {
        private readonly ILoaiXeGroup4AppService carModelAppService;

        public LoaiXeGroup4Controller(ILoaiXeGroup4AppService carModelAppService)
        {
            this.carModelAppService = carModelAppService;
        }

        [HttpGet]
        public string getST()
        {
            return carModelAppService.getST();
        }

        [HttpPost]
        public List<LoaiXeGroup4Dto> LOAIXE_Group4Search(LoaiXeGroup4Dto input)
        {
            return carModelAppService.LOAIXE_Group4Search(input);
        }
    }
}
