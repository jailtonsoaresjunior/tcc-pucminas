using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SCA.Apresentacao.Data;
using SCA.Apresentacao.Models;

namespace SCA.Apresentacao.Pages.Ativos
{
    public class DetailsModel : PageModel
    {
        private readonly SCA.Apresentacao.Data.SCAApresentacaoContext _context;

        public DetailsModel(SCA.Apresentacao.Data.SCAApresentacaoContext context)
        {
            _context = context;
        }

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
    }
}
