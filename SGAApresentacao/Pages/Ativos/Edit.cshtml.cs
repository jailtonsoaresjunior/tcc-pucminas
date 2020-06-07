using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SCA.Apresentacao.Data;
using SCA.Apresentacao.Models;

namespace SCA.Apresentacao.Pages.Ativos
{
    public class EditModel : PageModel
    {
        private readonly SCA.Apresentacao.Data.SCAApresentacaoContext _context;

        public EditModel(SCA.Apresentacao.Data.SCAApresentacaoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ativo Ativo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ativo = await _context.Ativo.FirstOrDefaultAsync(m => m.Id == id);

            if (Ativo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ativo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtivoExists(Ativo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AtivoExists(int id)
        {
            return _context.Ativo.Any(e => e.Id == id);
        }
    }
}
