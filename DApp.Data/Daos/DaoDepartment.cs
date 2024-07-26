using DApp.Data.Entities;
using DApp.Data.Interfaces;
using DApp.Data.Context;
using DApp.Data.Exceptions;


namespace DApp.Data.Daos
{
    public class DaoDepartment : IDaoDepartment
    {
        private readonly DAppContext context;

        public DaoDepartment(DAppContext context)
        {
            this.context = context;
            CargarDatos();
        }
        public Department GetDepartment(int Id)
        {
            if (Id == 0)
                throw new DepartmentGetExeptionId("Se requiere codigo del departamento.");


            return this.context.Departments.Find(Id);
        }

        public List<Department> GetDepartments()
        {
            return this.context.Departments.ToList();
        }

        public void RemoveDepartment(Department department)
        {
            //if (department is null) 
            //{
            //    throw new ArgumentNullException("El departamento no puede ser nulo.");
            //}

            ArgumentNullException.ThrowIfNull(department, "No puede ser nulo.");

            this.context.Departments.Remove(department);
            this.context.SaveChanges();
        }

        public void SaveDepartment(Department department)
        {
            if (department is null)
                throw new DepartmentSaveException("No puede ser nulo.");

            if (string.IsNullOrEmpty(department.Name))
                throw new DepartmentSaveNameException("Se requiere el nombre el departamento");

            if (this.context.Departments.Any(cd => cd.Name == department.Name))
                throw new DepartmentExistsException("El departamento esta registrado.");

            this.context.Departments.Add(department);
            this.context.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {


            if (department is null)
            {
                throw new ArgumentNullException("El departamento no puede ser nulo.");
            }

            ArgumentNullException.ThrowIfNullOrEmpty(department.Name, "El nombre del departamento es requerido.");


            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(department.Budget, "El Budget no puede ser negativo o cero");


            this.context.Departments.Update(department);
            this.context.SaveChanges();
        }

        private void CargarDatos()
        {

            if (!this.context.Departments.Any())
            {
                List<Department> asientos = new List<Department>()
            {
                new Department()
                {
                     Administrator= 1, Budget = 200, Id= 1,  Name ="Depto 1", StartDate = DateTime.Now
                },
                 new Department()
                {
                     Administrator= 1, Budget = 300, Id= 2,  Name ="Depto 2", StartDate = DateTime.Now
                },
                 new Department()
                {
                     Administrator= 1, Budget = 400, Id= 3,  Name ="Depto 3", StartDate = DateTime.Now
                },
                new Department()
                {
                     Administrator= 1, Budget = 300, Id= 4,  Name ="Depto 4", StartDate = DateTime.Now
                },
            };


                this.context.Departments.AddRange(asientos);
                this.context.SaveChanges();
            }


        }
}
