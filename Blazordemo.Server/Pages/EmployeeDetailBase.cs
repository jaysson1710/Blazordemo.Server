using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazordemo.Shared;
using Microsoft.AspNetCore.Components;

namespace Blazordemo.Server.Pages
{
    public class EmployeeDetailBase: ComponentBase
    {
        private List<Employee> Employes { get; set; }

        public Employee empleado { get; set; }

        [Parameter]
        public string Id { get; set; }
        protected override Task OnInitializedAsync()
        {
            Cargadatos();

            empleado = Employes.Where(x => x.Id == int.Parse(Id)).FirstOrDefault();

            return base.OnInitializedAsync();
        }

        private void Cargadatos()
        {
            Employes = new List<Employee>
            {
                new Employee { Id=1, City="Bogota", FirstName="jason", LastName="avenda", PhoneNumber="555-56412" },
                new Employee { Id=2, City="Cali", FirstName="andrea", LastName="Snachez", PhoneNumber="1234-515" }
            };
        }
    }
}
