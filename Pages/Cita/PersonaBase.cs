using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using Tarea9._0.Models;
using Tarea9._0.Services;
using Tarea9._0.DAO;

namespace Tarea9._0.Pages.Cita
{
    public class PersonaBase: ComponentBase
    {
        public IEnumerable<SangreModel> Sangres { get; set; }
        public IEnumerable<ProvinciaModel> Provincias { get; set; }
        [Inject]
        protected IToastService toastService { get; set; }
        [Inject]
        protected PersonaDAO DAOP { get; set; }
        [Inject]
        protected SangreDAO DAOS { get; set; }
        [Inject]
        protected ProvinciaDAO DAOPR { get; set; }
        protected PersonaModel OPersona { get; set; } = new PersonaModel();
        protected string message { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            Sangres = await DAOS.GetSangres();
            Provincias = await DAOPR.GetProvincia();
        }

        protected async Task SubmitAppointment()
        {

            var success = await DAOP.SavePersona(OPersona);

            if (success)
            {
                toastService.ShowSuccess("Registro almanenado exitosamente!");
                sendMail();
                toastService.ShowSuccess("Verifica tu correo!");
            }
            else
                toastService.ShowError("Ya esta registrado en el sistema!");

        }
        protected void sendMail()
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("tucorreo");
                    mail.To.Add(OPersona.Correo);
                    mail.Subject = "Cita de Vacuna";
                    mail.Body = "<h3>Hola, se ha confirmado tu solicitud para vacunate en casa.</h3>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("tucorreo", "tucontrasenia");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }
    }
}
