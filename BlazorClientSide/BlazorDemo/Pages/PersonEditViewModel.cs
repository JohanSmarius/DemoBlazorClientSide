using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Services;
using Core.Domain;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorDemo.Pages
{
    public class PersonEditViewModel : BlazorComponent
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
    }
}
