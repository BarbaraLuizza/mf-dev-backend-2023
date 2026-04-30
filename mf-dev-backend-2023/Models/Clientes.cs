using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório.")]
        public int Perfil { get; set; }

    }
    public enum Perfil
    {
        Admin,
        User
    }
}
