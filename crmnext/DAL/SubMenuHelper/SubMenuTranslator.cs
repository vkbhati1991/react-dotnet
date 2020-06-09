using MODEL.SubMenu;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubMenuHelper
{
    public static class SubMenuTranslator
    {
        public static SubMenu TranslateAsSubMenu(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;

                reader.Read();
            }

            SubMenu subMenu = new SubMenu();

            if (reader.IsColoumnExist("SubMenuId"))
                subMenu.SubMenuId = DataReader.GetNullableInt32(reader, "SubMenuId");

            if (reader.IsColoumnExist("SubMenuName"))
                subMenu.SubMenuName = DataReader.GetNullableString(reader, "SubMenuName");

            if (reader.IsColoumnExist("ActionName"))
                subMenu.ActionName = DataReader.GetNullableString(reader, "ActionName");

            if (reader.IsColoumnExist("ControllerName"))
                subMenu.ControllerName = DataReader.GetNullableString(reader, "ControllerName");

            if (reader.IsColoumnExist("MenuId"))
                subMenu.MenuId = DataReader.GetNullableInt32(reader, "MenuId");

            if (reader.IsColoumnExist("RoleId"))
                subMenu.RoleId = DataReader.GetNullableInt32(reader, "RoleId");

            return subMenu;
        }

        public static List<SubMenu> TranslateAsSubMenuList(this SqlDataReader reader)
        {
            List<SubMenu> subMenuList = new List<SubMenu>();

            while (reader.Read())
            {
                subMenuList.Add(TranslateAsSubMenu(reader, true));
            }

            return subMenuList;
        }
    }
}
