using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class FacultyService
    {
        private readonly StudentModel context = new StudentModel();

        public List<Faculty> GetAll()
        {
            return context.Faculty.ToList();
        }
    }
}
