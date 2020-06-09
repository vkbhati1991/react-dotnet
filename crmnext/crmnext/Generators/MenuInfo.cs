using APP.DTOS;
using Microsoft.AspNetCore.Http;
using MODEL.Menu;
using MODEL.SubMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace APP.Generators
{
    public class MenuInfo
    {
        private readonly Dictionary<string, object> navigationList;
        private readonly List<MenuDTO> navigation;
        private readonly List<int> tempMenuList;

        public MenuInfo()
        {
            navigationList = new Dictionary<string, object>();
            navigation = new List<MenuDTO>();
            tempMenuList = new List<int>();
        }
        public object GetNavigationData(List<Menu> menuList, List<SubMenu> subMenuList, string userRole)
        {
            int roleId = Convert.ToInt32(userRole);
            var roleSpeceficList = subMenuList.Where(item => item.RoleId == roleId);
            navigationList.Add("CurrentTab", "Student");
            navigationList.Add("NavigationsSubMenu", subMenuList);
            navigationList.Add("NavigationsMenu", menuList);

            foreach (var menuItem in roleSpeceficList)
            {
                if (!tempMenuList.Contains(menuItem.MenuId))
                {
                    tempMenuList.Add(menuItem.MenuId);
                }
            }

            foreach (var elem in tempMenuList)
            {
                List<MenuDTO> subMenuInnerList = new List<MenuDTO>();
                MenuDTO menuDTO = new MenuDTO();
                Menu menu = menuList.Find(item => item.MenuId == elem);
                menuDTO.Id = menu.MenuId;
                menuDTO.Name = menu.MenuName;
                menuDTO.Href = null;

                //Map Menu Id to SubMenu Id
                foreach (var submenu in roleSpeceficList)
                {
                    MenuDTO subMenuDTO = new MenuDTO();
                    subMenuDTO.Id = submenu.SubMenuId;
                    subMenuDTO.Name = submenu.SubMenuName;
                    subMenuDTO.Href = $"{submenu.ControllerName}";
                    if (elem == submenu.MenuId)
                    {
                        subMenuInnerList.Add(subMenuDTO);
                    }

                }
                menuDTO.Childrens = subMenuInnerList;
                navigation.Add(menuDTO);
            }
            return navigation;
        }
    }
}
