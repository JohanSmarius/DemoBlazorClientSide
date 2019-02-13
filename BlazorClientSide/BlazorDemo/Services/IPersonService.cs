using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;

namespace BlazorDemo.Services
{
    public interface IPersonService
    {
        List<User> AvailableUsers { get; }
        Task LoadUsers();
    }
}
