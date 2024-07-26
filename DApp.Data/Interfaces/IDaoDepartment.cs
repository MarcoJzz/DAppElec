
using DApp.Data.Entities;

namespace DApp.Data.Interfaces
{
    public interface IDaoDepartment
    {
        List<Department> GetDepartments();
        Department GetDepartment(int Id);
        void SaveDepartment(Department department);
        void UpdateDepartment(Department department);
        void RemoveDepartment(Department department);
    }
}
 