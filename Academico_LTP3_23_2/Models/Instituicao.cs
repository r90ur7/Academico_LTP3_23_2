namespace Academico_LTP3_23_2.Models
{
    public class Instituicao
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public ICollection<Departamento>? Departamentos { get; set;}
    }
}
