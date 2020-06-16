using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaWeb3.Models
{
    public class Aluno
    {
        [Key]
        public int Ra { get; set; }
        public string Nome { get; set; }
        public String Sexo { get; set; }
        public int DataN { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Curso { get; set; }
        public int AnoI { get; set; }
        
        
    }
}