using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9._0.Data;

namespace Tarea9._0.Services
{
    public interface IToastService
    {
        event Action<ToastLevel, string, string> OnShow;
        void ShowInfo(string message, string heading = "");
        void ShowSuccess(string message, string heading = "");
        void ShowWarning(string message, string heading = "");
        void ShowError(string message, string heading = "");
        void ShowToast(ToastLevel level, string message, string heading = "");
    }
}
