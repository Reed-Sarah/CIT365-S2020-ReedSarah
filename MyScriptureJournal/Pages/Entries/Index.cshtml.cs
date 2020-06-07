using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        
        public SelectList Books { get; private set; }
        public IList<JournalEntry> JournalEntry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedBook { get; set; }
       
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> noteQuery = from e in _context.JournalEntry
                                            orderby e.Book
                                            select e.Book;

           


            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<JournalEntry> entries = from s in _context.JournalEntry
                                             select s;

            switch (sortOrder)
            {
                case "book_desc":
                    entries = entries.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    entries = entries.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    entries = entries.OrderByDescending(s => s.Date);
                    break;
                default:
                    entries = entries.OrderBy(s => s.Book);
                    break;
            }


            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Notes.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SelectedBook))
            {
                entries = entries.Where(x => x.Book == SelectedBook);
            }

            JournalEntry = await entries.AsNoTracking().ToListAsync();

            Books = new SelectList(await noteQuery.Distinct().ToListAsync());
            JournalEntry = await entries.ToListAsync();
        }
    }
}
