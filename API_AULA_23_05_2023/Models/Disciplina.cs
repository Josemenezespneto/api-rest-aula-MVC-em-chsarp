using System.ComponentModel.DataAnnotations.Schema;

namespace API_AULA_23_05_2023.Models
{
    [Table("Disciplina")]
    public class Disciplina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Nome")]
        public string Nome { get; set; }
        [Column(name: "Ementa")]
        public string Ementa { get; set; }
        [Column(name: "Duracao")]
        public int Duracao { get; set; }
    }
}
