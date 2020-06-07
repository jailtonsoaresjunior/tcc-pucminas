using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SCA.Apresentacao.Data;
using SCA.Apresentacao.Models;

namespace SCA.Apresentacao.Pages.Ativos
{
    public class CreateModel : PageModel
    {
        private readonly SCA.Apresentacao.Data.SCAApresentacaoContext _context;

        public CreateModel(SCA.Apresentacao.Data.SCAApresentacaoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ativo Ativo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ativo.Add(Ativo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
