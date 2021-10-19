using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc03.Models{
    [Table("t_categoria")]
    public class Categoria{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{get; set;}
        public string nombre{get; set;}
        public ICollection<Solicitud> solicitud{get; set;}
    }
}