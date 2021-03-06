﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using RazorEngine;
using RazorEngine.Templating;
using FFilms.Services.Abstractions;

namespace FFilms.Services
{
    /// <summary>
    /// Represents service for working with mail
    /// </summary>
    public class MailService : IMailService
    {
        protected readonly IMailClient mailClient;
        private const string contactMessagePath = "~/Views/Mail/ContactMessage.cshtml";

        public MailService(IMailClient ImailClient)
        {
            mailClient = ImailClient;
        }

        public async Task<bool> SendMessage(string userEmail, string userName, string message, string subject = "Message", string path = contactMessagePath)
        {
            var result = false;

            try
            {
                var model = new
                {
                    UserEmail = userEmail,
                    UserMessage = message,
                    UserName = userName
                };

                var serverPath = HttpContext.Current.Server.MapPath(contactMessagePath);
                var template = File.ReadAllText(serverPath);
                var body = Engine.Razor.RunCompile(template, DateTime.UtcNow.Ticks.ToString(), null, model);
                result = await mailClient.SendEmailAsync(ConfigurationManager.AppSettings["adminEmail"], subject, body);
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return result;
        }
    }
}