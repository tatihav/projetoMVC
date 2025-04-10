
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuProjetoMVC.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id {get; set; }

        [Required(ErrorMessage = "Obrigatório inserir Nome!")]
        public string Nome {get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório inserir Placa!")]
        public string Placa {get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório inserir Ano de Fabricação!")]
        public int AnoFabricacao {get; set; }

        [Required(ErrorMessage = "Obrigatório inserir Ano de Modelo!")]
        public int AnoModelo {get; set; }

    }
}