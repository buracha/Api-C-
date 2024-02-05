using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("id_cliente")]
        public int Id_cliente { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("cpf")]
        public int Cpf { get; set; }

        [Column("telefone")]
        public int Telefone { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("senha")]
        public string Senha { get; set; } = string.Empty;


    }
}
