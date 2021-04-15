using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Prova_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_Prova_2.Controllers
{
    public class AlunoController : Controller
    {

        private readonly Context _context;

        public AlunoController(Context context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {

            return View(await _context.aluno.ToListAsync());
        }
    }
}
