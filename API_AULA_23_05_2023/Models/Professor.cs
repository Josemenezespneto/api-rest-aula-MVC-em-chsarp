using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_AULA_23_05_2023.Models
{
    [Table("Professor")]
    public class Professor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column(name:"Nome")]
        public string Nome { get; set; }
        [Column(name: "Cpf")]
        public string Cpf { get; set; }

        [Column(name: "Titulacao")]
        public string Titulacao { get; set; }
    }
}
