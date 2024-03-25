using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoRazerPages.Data;
using DemoRazerPages.Models;

namespace DemoRazerPages.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly DemoRazerPages.Data.ApplicationDbContext _context;

        public IndexModel(DemoRazerPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Aluno = await _context.Aluno.ToListAsync();
        }
    }
}
