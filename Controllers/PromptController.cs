using Microsoft.AspNetCore.Mvc;

namespace ResumeManager.Controllers
{
    public class PromptController : Controller
    {
        // GET: /Prompt/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}