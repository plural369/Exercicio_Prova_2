using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Prova_2.Models
{
    public class AlunoModel
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "*Insira o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*Insira a Data de Nascimento"),Display(Name = "Data de nascimento")]

        public string Data_de_Nasc { get; set; }

        [Required(ErrorMessage = "*Insira o Telefone")]

        public long Telefone { get; set; }

        [Required(ErrorMessage = "*Insira o Endereço"),Display(Name ="Endereço")]

        public string Endereco { get; set; }

        [Required(ErrorMessage = "*Insira o RG")]

        public long RG { get; set; }

    }
}
