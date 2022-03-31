using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APLICACAO_FGF.Models
{   [Table("Produto")]
    public class Produto
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Ean")]
        [Column("Ean")]
        public string? Ean { get; set; }


    }
}
