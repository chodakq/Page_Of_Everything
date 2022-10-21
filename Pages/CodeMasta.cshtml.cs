using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Page_Of_Everything.Pages
{
    public class CodeMastaModel : PageModel
    {
        private readonly ILogger<CodeMastaModel> _logger;

        public CodeMastaModel(ILogger<CodeMastaModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}
