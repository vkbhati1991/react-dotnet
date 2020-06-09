using IDAL.IMenu;
using MODEL.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MenuHelper
{
    public class MenuHelper : IMenu
    {
        string connectionstring = ConnectionString.CName;
        public List<Menu> GetAllMenu()
        {
            List<Menu> menus = DALBase.ExtecuteProcedureReturnData(connectionstring, "spGetMenu", r => r.TranslateAsSubMenuList());
            return menus;
        }
    }
}
