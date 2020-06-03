using APP.DTOS;
using MODEL.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.Generators
{
    public static class StudentListInfo
    {
        public static object GetStudentListInfo(List<Student> students)
        {
            List<ColumnInfo> studentsCells = new List<ColumnInfo>();

            List<string> studentColumns = new ListingInfo().GetListingInfo<Student>();

            foreach (var cell in studentColumns)
            {
                ColumnInfo columnInfo = new ColumnInfo(cell);
                columnInfo.Name = cell;
                studentsCells.Add(columnInfo);
            }

            object studentListingInfo = new ListingInfo().GetListingInfoComplete<Student>(studentsCells, students);

            return studentListingInfo;
        }
    }

}
