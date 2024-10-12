using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        private readonly StudentModel context = new StudentModel();
        public List<Student> GetAll()
        {
            return context.Student.ToList();
        }

        public string AddStudent(Student student)
        {
            try
            {
                if (context.Student.Any(s => s.StudentID == student.StudentID))
                {
                    return "Mã sinh viên đã tồn tại.";
                }
                context.Student.Add(student);
                context.SaveChanges();
                return "Thêm sinh viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi thêm sinh viên: {ex.Message}";
            }
        }
        public Student GetStudentById(string studentId)
        {
            return context.Student.FirstOrDefault(s => s.StudentID == studentId);
        }


        public string UpdateStudent(Student student)
        {
            try
            {
                var existingStudent = context.Student.FirstOrDefault(s => s.StudentID == student.StudentID);
                if (existingStudent == null)
                {
                    return "Sinh viên không tồn tại.";
                }
                Console.WriteLine($"Old Avatar: {existingStudent.Avatar}, New Avatar: {student.Avatar}");

                // Update student properties
                existingStudent.StudentName = student.StudentName;
                existingStudent.FacultyID = student.FacultyID;
                existingStudent.AverageScore = student.AverageScore;
                existingStudent.Avatar = student.Avatar;

                context.SaveChanges();
                return "Cập nhật thông tin sinh viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi cập nhật sinh viên: {ex.Message}";
            }
        }

        public string DeleteStudent(string studentId)
        {
            try
            {
                var existingStudent = context.Student.FirstOrDefault(s => s.StudentID == studentId);
                if (existingStudent == null)
                {
                    return "Sinh viên không tồn tại.";
                }

                context.Student.Remove(existingStudent);
                context.SaveChanges();
                return "Xóa sinh viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi xóa sinh viên: {ex.Message}";
            }
        }
    }
}
