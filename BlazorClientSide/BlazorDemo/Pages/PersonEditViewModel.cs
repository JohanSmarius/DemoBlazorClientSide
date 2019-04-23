using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Services;
using Core.Domain;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages
{
    public class PersonEditViewModel : ComponentBase
    {
        [Inject]
        private IPersonService UserService { get; set; }

        [Parameter]
        int Id { get; set; }

        public PersonEditViewModel()
        {
        }

        protected User Person { get; set; }

        protected override async Task OnInitAsync()
        {
            Person = UserService.AvailableUsers.First(person => person.Id == Id);
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
    }
}
