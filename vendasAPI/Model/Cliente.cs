using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vendasAPI.Model
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string nome { get; set; }
        [Column("cpf_cnpj")]
        public string cpf { get; set; }
        [Column("email")]
        public string email { get; set; }
        [Column("telefone")]
        public string telefone { get; set; }
        [Column("endereco")]
        public string endereco { get; set; }

    }
}
