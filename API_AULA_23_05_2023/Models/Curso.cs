using System.ComponentModel.DataAnnotations.Schema;

namespace API_AULA_23_05_2023.Models
{
    [Table("Curso")]
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Nome")]
        public string Nome { get; set; }
        [Column(name: "Descricao")]
        public string Descricao { get; set; }
        [Column(name: "Valor")]
        public float Valor { get; set; }

        public Professor Professor { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
