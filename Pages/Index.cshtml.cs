using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Page_Of_Everything.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }


        [BindProperty]
        public static string? Name { get; set; } 

        public void OnGet()
        {
            Name = "To the Page Of Everything";
        }

        public void OnPost()
        {

        }
    }
}