using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MajorService
    {
        private readonly StudentModel context = new StudentModel();
        public List<Major> GetAllByFaculty(int facultyID)
        {
            return context.Major.Where(p=>p.FacultyID == facultyID).ToList();
        }
    }
}
