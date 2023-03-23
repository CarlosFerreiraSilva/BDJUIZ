namespace ProvaSQL_ASPNETMVC.Models
{
    public class DocumentoJuiz
    {
        public int DocumentaçãoID { get; set; }
        public string Nome { get; set; }
        public string TipoJuiz { get; set; }
        public int Salario { get; set; }
        public bool CursoSuperior { get; set; }
    }
}
