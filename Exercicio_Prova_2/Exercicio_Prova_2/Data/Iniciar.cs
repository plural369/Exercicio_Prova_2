using Exercicio_Prova_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Prova_2.Data
{
    public class Iniciar
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            if (context.aluno.Any())
            {
                return;
            }

            var aluno = new AlunoModel[]
            {
                new AlunoModel {Nome = "José",
                                Data_de_Nasc = "29/12/1999",
                                Telefone = 16994547873,
                                Endereco = "Rua amapa 55",
                                RG = 49768522636},
                new AlunoModel {Nome = "Carlos",
                                Data_de_Nasc = "25/11/2000",
                                Telefone = 16994578523,
                                Endereco = "Rua amapa 108",
                                RG = 49768652246},
                new AlunoModel {Nome = "Tete",
                                Data_de_Nasc = "23/12/1989",
                                Telefone = 16990457873,
                                Endereco = "Rua silva 572",
                                RG = 37768522626},
                new AlunoModel {Nome = "Maria",
                                Data_de_Nasc = "24/01/1998",
                                Telefone = 16900547873,
                                Endereco = "Rua roraima 87",
                                RG = 48568522666},
                new AlunoModel {Nome = "Silvia",
                                Data_de_Nasc = "21/08/1993",
                                Telefone = 16444547873,
                                Endereco = "Rua Santos 225",
                                RG = 43548522636},
                new AlunoModel {Nome = "Beatriz",
                                Data_de_Nasc = "26/10/2001",
                                Telefone = 16994456793,
                                Endereco = "Rua Tereza 475",
                                RG = 49768522636},
                new AlunoModel {Nome = "Tiago",
                                Data_de_Nasc = "23/12/1989",
                                Telefone = 16990457873,
                                Endereco = "Rua silva 272",
                                RG = 37768522626},
                new AlunoModel {Nome = "Rosa",
                                Data_de_Nasc = "24/01/1998",
                                Telefone = 16900547873,
                                Endereco = "Rua roraima 97",
                                RG = 47568322666},
                new AlunoModel {Nome = "Selena",
                                Data_de_Nasc = "21/08/1993",
                                Telefone = 16444547873,
                                Endereco = "Rua Santos 725",
                                RG = 43548533636},
                new AlunoModel {Nome = "Brunoo",
                                Data_de_Nasc = "26/10/2001",
                                Telefone = 16994456793,
                                Endereco = "Rua Tereza 25",
                                RG = 49768569636},
            };

            foreach (AlunoModel d in aluno)
            {
                context.aluno.Add(d);
            }

            context.SaveChanges();
        }
    }
}
