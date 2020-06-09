using MODEL.Menu;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MenuHelper
{
    public static class MenuTranslator
    {
        public static Menu TranslateAsMenu(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;

                reader.Read();
            }

            Menu menu = new Menu();

            if (reader.IsColoumnExist("MenuId"))
                menu.MenuId = DataReader.GetNullableInt32(reader, "MenuId");

            if (reader.IsColoumnExist("MenuName"))
                menu.MenuName = DataReader.GetNullableString(reader, "MenuName");

            return menu;
        }

        public static List<Menu> TranslateAsSubMenuList(this SqlDataReader reader)
        {
            List<Menu> menuList = new List<Menu>();

            while (reader.Read())
            {
                menuList.Add(TranslateAsMenu(reader, true));
            }

            return menuList;
        }
    }
}
