using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc03.Models{
    [Table("t_producto")]
    public class Solicitud{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{get; set;}
        [Required(ErrorMessage = "COLOQUE NOMBRE DEL PRODUCTO")]
        public string nombre{get; set;}
        [Required(ErrorMessage = "COLOQUE FOTO DEL PRODUCTO")]
        public string foto{get; set;}
        [Required(ErrorMessage = "COLOQUE DESCRIPCIÓN DEL PRODUCTO")]
        public string descripcion{get; set;}
        [Required(ErrorMessage = "COLOQUE PRECIO DEL PRODUCTO")]
        public decimal precio{get; set;}
        [Required(ErrorMessage = "COLOQUE NÚMERO DE CELULAR")]
        public string celular{get; set;}
        public DateTime fecha{get; set;}
        [Required(ErrorMessage = "COLOQUE LUGAR, POR FAVOR")]
        public string lugar{get; set;}
        [Required(ErrorMessage = "COLOQUE NOMBRE DEL COMPRADOR")]
        public string comprador{get; set;}
        public Categoria categoria{get; set;}
        public Solicitud(){
            this.fecha = DateTime.Now;
        }
    }
}