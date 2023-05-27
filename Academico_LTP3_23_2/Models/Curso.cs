namespace Academico_LTP3_23_2.Models
{
    public class Curso
    {
        public string? Id { get; set; }
        public string nome { get; set; }
        public int CaragaHoraria { get; set; }
        public long? DepartamentoID { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
