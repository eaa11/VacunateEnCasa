using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9._0.Config;

namespace Tarea9._0.Pages.Configuracion.ConfiguracionBlazorToast
{
    public partial class BlazoredToast
    {
        [CascadingParameter] private BlazoredToasts ToastsContainer { get; set; }

        [Parameter] public Guid ToastId { get; set; }
        [Parameter] public ToastSettings ToastSettings { get; set; }

        private void Close()
        {
            ToastsContainer.RemoveToast(ToastId);
        }
    }
}
