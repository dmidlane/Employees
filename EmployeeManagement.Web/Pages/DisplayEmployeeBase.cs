using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Tribal.Components;

namespace EmployeeManagement.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }

        [Parameter]
        public EventCallback<bool> OnEmployeeSelected { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected ConfirmBase DeleteConfirmation { get; set; }
        
        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            await OnEmployeeSelected.InvokeAsync((bool)e.Value);
        }
        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
            }
        }
    }
}
