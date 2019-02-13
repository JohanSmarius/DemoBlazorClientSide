using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorDemo.JSInterop
{
    public class JSInterop
    {
        public static Task<bool> Confirm(string message)
        {
            return JSRuntime.Current.InvokeAsync<bool>("helperfunction.confirm", message);
        }
    }
}
