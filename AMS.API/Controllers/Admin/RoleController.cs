using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AMS.API.Controllers.Admin
{
    [Route("admin/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="coreDbContext"></param>
        public RoleController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        /// <summary>
        /// 获取所有Role
        /// admin/Role/GetList
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<RoleModel> RoleGetList()
        {
            return _coreDbContext.Set<RoleModel>().ToList();
        }
    }
}