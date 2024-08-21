using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstruturaDoProduto.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome do produto")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public string Nome { get; set; }

        [Display(Name = "Status do produto")]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public bool Status { get; set; }

        [Display(Name = "Código do produto")]
        [MaxLength(10)]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public string Codigo { get; set; }

        public decimal CustoPadrao { get; set; }

        public decimal PesoLiquido { get; set; }

        public decimal PropPesoBruto { get; set; }

    }
}
