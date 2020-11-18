using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDBContext;

        public EmployeeRepository(AppDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDBContext.Employees.AddAsync(employee);
            await appDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId)
        {
            var result = await appDBContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (result != null)
            {
                appDBContext.Employees.Remove(result);
                await appDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await appDBContext.Employees
                .Include(e => e.Department)
                .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await appDBContext.Employees
                .FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDBContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = appDBContext.Employees;

            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }

            if(gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }

            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDBContext.Employees
                    .FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await appDBContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
