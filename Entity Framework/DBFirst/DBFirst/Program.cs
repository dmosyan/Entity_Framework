using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            PlutoContext DBContext = new PlutoContext();
            ObjectResult<GetCourses_Result> courses = DBContext.GetCourses();
            foreach (var item in courses)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
