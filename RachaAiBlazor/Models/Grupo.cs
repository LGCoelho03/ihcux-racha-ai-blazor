namespace RachaAiBlazor.Models
{
    public class Grupo
    {
        public string Nome { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public decimal ValorPendente { get; set; }

        // true = devo | false = recebo
        public bool NoVermelho { get; set; }
    }
}