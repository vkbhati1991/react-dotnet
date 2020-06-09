using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.DTOS
{
    public class MenuDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
        public List<MenuDTO> Childrens { get; set; }

    }
}
