using faqApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace faqApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Faq> faqs = new List<Faq>
            {
                new Faq(1,"Lorem Ipsum dolor?", "A bimürvət nağaresan siyəndər tutaşmıyın usuf bıy əzizin ölsün göyüz sortuxla ayna durinan qalet, çəkələy mamoğlu bıy dərdin alem qayır ağrın alem a bimürvət a qıvlasız nağaresan a bimürvət, qavağında ölöm yağlaşoy eşiy pırpız baş a bimürvət qağa covid mirəti həncərsən."),
                new Faq(2, "Qredit ağrın alem bıy əzizin ölsün qayır eşiy varıf qayır çəkələy?", "Haay sortuxla öydə otur eşiyə çıxma dınqı ağrın alem, çəkələy pırpız baş dayna siyəndər vızqırt əppəy, ağrın alem dığlatdın sortuxla vızqırt. Basırıx suruxvat döyğa covid mirəti sumsux çırtımına yiyə dursan?"),
                new Faq(3, "Cöngə haay qalet mamoğlu əppəy varıf yağlaşoy dana şöytəli, anarıdan-bəri a bimürvət.", "Çəkələy beyjə şöytəli haay qredit bıy dərdin alem sülöymən eşiy çəkələy mığı dana siyəndər, qağa ölüm çırtımına yiyə dursan"),
                new Faq(4, "Cöngə haay qalet mamoğlu əppəy varıf yağlaşoy dana şöytəli, anarıdan-bəri a bimürvət.", "Çəkələy beyjə şöytəli haay qredit bıy dərdin alem sülöymən eşiy çəkələy mığı dana siyəndər, qağa ölüm çırtımına yiyə dursan")
            };

            return View(faqs);
        }
    }
}
