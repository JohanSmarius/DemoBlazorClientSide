using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.JSInterop
{
    public interface IJSInterop
    {
        Task<bool> Confirm(string message);
    }
}
