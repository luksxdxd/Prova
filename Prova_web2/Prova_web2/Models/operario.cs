using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova_web2.Models
{
    public class operario
    {
        
        [Key]
        public String Nome { get; set; }
        public String Sexo { get; set; }
        public string Endereco { get; set; }
        public int DataN { get; set; }
        public int CarteraT { get; set; }
        public int Fonef { get; set; }
        public int Fonec { get; set; }
        public string Email { get; set; }


    }
}
