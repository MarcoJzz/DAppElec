using DApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DApp.Data.Interfaces
{
    public interface ICourseDb
    {
        List<Course> GetCourses();
        Course GetCourse(int Id);
        void SaveCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
    }
}
