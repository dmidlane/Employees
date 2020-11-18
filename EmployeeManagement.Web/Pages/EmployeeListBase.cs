using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        
        public IEnumerable<Employee> Employees { get; set; }
        public bool ShowFooter { get; set; } = true;

        public int SelectedEmployeesCount { get; set; }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        protected async Task EmployeeDeleted()
        {
            // keeping it simple - just passing the list of employees back to the component
            // without the deleted one. We are passing the id to this method in the child component
            // but we're not doing anything with it
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
    }
}
