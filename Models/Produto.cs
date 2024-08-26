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
        public string? Nome { get; set; }

        [Display(Name = "Status do produto")]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public bool Status { get; set; }

        [Display(Name = "Código do produto")]
        [MaxLength(12)]
        public string? Codigo { get; set; }

        [Display(Name = "Código do produto pelo fornecedor")]
        [MaxLength(12)]
        public string? CodigoProdutoFornecedor { get; set; }

        [Display(Name = "Data de cadastro")]
        [DataType(DataType.Date)]
        public DateTime? DataDeCadastro { get; set; }

        [Display(Name = "Custo padrão")]
        [Column(TypeName = "decimal(8,4)")]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public decimal CustoPadrao { get; set; }

        [Display(Name = "Preço final")]
        [Column(TypeName = "decimal(8,4)")]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public decimal PrecoFinal { get; set; }

        [Display(Name = "Margem de lucro (R$)")]
        [Column(TypeName = "decimal(8,4)")]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}!")]
        public decimal MargemDeLucroEmReais { get; set; }

        [Display(Name = "Peso líquido")]
        [Column(TypeName = "decimal(8,3)")]
        public decimal? PesoLiquido { get; set; }

        [Display(Name = "Peso bruto")]
        [Column(TypeName = "decimal(8,3)")]
        public decimal? PesoBruto { get; set; }

    }
}
