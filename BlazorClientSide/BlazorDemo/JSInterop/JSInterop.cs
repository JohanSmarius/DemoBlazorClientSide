using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorDemo.JSInterop
{
    public class JSInterop : IJSInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public JSInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Task<bool> Confirm(string message)
        {
            return _jsRuntime.InvokeAsync<bool>("helperfunction.confirm", message);
        }
    }
}
