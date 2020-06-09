using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using APP.Generators;
using DAL.SubMenuHelper;
using IDAL.IMenu;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL.Menu;
using MODEL.SubMenu;

namespace APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenu _menu;
        private SubMenuHelper subMenuHelper;
        private MenuInfo menuInfo;
        public MenuController(IMenu menu)
        {
            _menu = menu;
            subMenuHelper = new SubMenuHelper();
            menuInfo = new MenuInfo();
        }
        [HttpGet]
        public IActionResult GetAllMenu()
        {
            ClaimsPrincipal currentUser = this.User;

            //string userName = currentUser.FindFirst(ClaimTypes.Name).Value;
            string userRole = currentUser.FindFirst("RoleId").Value;
            List<Menu> menus = _menu.GetAllMenu();
            List<SubMenu> submenu = subMenuHelper.GetAllSubMenu();
            object navigation = menuInfo.GetNavigationData(menus, submenu, userRole);
            return Ok(navigation);
        }
    }
}