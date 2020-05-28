
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.DTOS
{
    public class LinkInfoDTO
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string ExecutionMode { get; set; }
        public bool IsDisabled { get; set; }
        public string Icon { get; set; }
        public string Target { get; set; }
        public string ClassName { get; set; }
        public string ImageUrl { get; set; }
    }
}
