using MODEL.SubMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL.ISubMenu
{
    public  interface ISubMenu
    {
        List<SubMenu> GetAllSubMenu();

        string CreateSubMenu(SubMenu subMenu);

    }
}
