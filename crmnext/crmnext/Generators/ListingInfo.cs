using APP.DTOS;
using MODEL.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace APP.Generators
{
    public class ListingInfo
    {
        private readonly Dictionary<string, object> listingInfo;
        private readonly Dictionary<string, object> listinfocomplete;

        public ListingInfo()
        {
            listingInfo = new Dictionary<string, object>();
            listinfocomplete = new Dictionary<string, object>();
        }
        public List<string> GetListingInfo<TList>()
        {
            Type studentType = typeof(TList);

            List<string> columninfo = new List<string>();

            PropertyInfo[] props = studentType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            for (int i = 0; i < props.Length; i++)
            {
                columninfo.Add(props[i].Name);
            }

            return columninfo;
        }

        private void CreateListingInfo<T>(List<ColumnInfo> cells, List<T> rows)
        {
            listingInfo.Add("Cells", cells);
            listingInfo.Add("Rows", rows);
        }

        public object GetListingInfoComplete<T>(List<ColumnInfo> cells, List<T> rows)
        {
            CreateListingInfo(cells, rows);
            listinfocomplete.Add("ListInfo", listingInfo);

            return listinfocomplete;
        }
    }
   
}
