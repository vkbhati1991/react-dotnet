using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDAL.ISubMenu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL.SubMenu;

namespace APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubMenuController : ControllerBase
    {
        private readonly ISubMenu _subMenu;

        public SubMenuController(ISubMenu subMenu)
        {
            _subMenu = subMenu;
        }

        [HttpGet]
        public ActionResult GetAllSubMenu()
        {
            List<SubMenu> subMenuList = _subMenu.GetAllSubMenu();

            return Ok(subMenuList);
        }
    }
}