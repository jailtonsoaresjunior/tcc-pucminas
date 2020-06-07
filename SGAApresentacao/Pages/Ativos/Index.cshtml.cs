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
    public class IndexModel : PageModel
    {
        private readonly SCA.Apresentacao.Data.SCAApresentacaoContext _context;

        public IndexModel(SCA.Apresentacao.Data.SCAApresentacaoContext context)
        {
            _context = context;
        }

        public IList<Ativo> Ativo { get;set; }

        public async Task OnGetAsync()
        {
            Ativo = await _context.Ativo.ToListAsync();
        }
    }
}
