using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OurFirstApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }

        public string Lab6WantToLearn { get; set; }

        public void OnGet()
        {
            Message = $"Hello World ~  {DateTime.Now.ToLongTimeString()}  ~  {DateTime.Now.ToLongDateString()}";

            Lab6WantToLearn = "I have a basic understanding of using HTML and CSS in web development. I need to learn A LOT MORE about back-end development, providing the functionality to web pages. I want to learn more about connecting to databases. The shopping website that we develop this semester should help with that. I also need to learn more of the terminology. Sometimes the videos and downloadable exercises are confusing because I'm not 100% sure what they mean.";
        }
    }
}