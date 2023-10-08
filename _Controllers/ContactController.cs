using Microsoft.AspNetCore.Mvc;
using MyProject._Models;
using MyProject._Services;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.ActionResults;
using Umbraco.Cms.Web.Website.Controllers;

namespace MyProject._Controllers
{
    public class ContactController : SurfaceController
    {
        public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        
        [HttpPost]
        public async Task<IActionResult> Index(ContactForm form)
         {

             if (!ModelState.IsValid)
                 return CurrentUmbracoPage();
            
            /*using var mail = new MailService("no-reply@crito.se", "smtp.websuport.se", 465, "umbraco@crito.com", "Password");

            //To sender
            await mail.SendAsync(form.Email, "Message received.", "Your message has been received, we will contact you shortly.").ConfigureAwait(false);

            //To receiver
           await mail.SendAsync("umbraco@crito.com", $"{form.Name} sent you a message", form.Message).ConfigureAwait(false);*/

            return LocalRedirect(form.RedirectUrl ?? "/");

 
        }

       
    }
}
