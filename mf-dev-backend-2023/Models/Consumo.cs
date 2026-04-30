
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Consumo")]
    public class Consumo
    {
        [Key]
        public int Id { get; set;}

        [Required(ErrorMessage = "Obrigatório Informar a descrição")]
        [Display(Name = "Descrição")]
        public string Descrição { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a descrição")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Km")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set;}


        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório Informar o veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina, 
        Etanol
    }
}
