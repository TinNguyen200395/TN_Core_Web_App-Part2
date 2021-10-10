using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TN_Core_Web_App.Application.Interfaces;
using TN_Core_Web_App.Services;
using Microsoft.Extensions.Configuration;
using TN_Core_Web_App.Models;
using TN_Core_Web_App.Utilities.Constants;

namespace TN_Core_Web_App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IFeedbackService _feedbackService;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;
        private readonly IViewRenderService _viewRenderService;

        public ContactController(IContactService contactSerivce,
            IViewRenderService viewRenderService,
            IConfiguration configuration,
            IEmailSender emailSender, IFeedbackService feedbackService)
        {
            _contactService = contactSerivce;
            _feedbackService = feedbackService;
            _emailSender = emailSender;
            _configuration = configuration;
            _viewRenderService = viewRenderService;
        }
        [Route("contact.html")]
        [HttpGet]
        public IActionResult Index()
        {
            var contact = _contactService.GetById(CommonConstants.DefaultContactId);
            var model = new ContactPageViewModel { Contact = contact };
            return View(model);
        }

        [Route("contact.html")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Index(ContactPageViewModel model)
        {
            if (ModelState.IsValid)
            {
                _feedbackService.Add(model.Feedback);
                _feedbackService.SaveChanges();
                var content = await _viewRenderService.RenderToStringAsync("Contact/_ContactMail", model.Feedback);
                await _emailSender.SendEmailAsync(_configuration["MailSettings:AdminMail"], "Have new contact feedback", content);
                ViewData["Success"] = true;
            }

            model.Contact = _contactService.GetById("default");

            return View("Index", model);
        }
    }
}