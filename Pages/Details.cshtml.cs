using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MicroBlog.Models;
using MicroBlog.Services;

namespace MicroBlog.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly PostStore _store;

        public DetailsModel(PostStore store) => _store = store;

        public Post? Post { get; private set; }

        public IActionResult OnGet(int id)
        {
            Post = _store.GetById(id);
            if (Post is null) return NotFound();
            return Page();
        }
    }
}
