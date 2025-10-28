using System.Globalization;

namespace revisao.c_.prova.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string nome { get; set; } = string.Empty;
    }
}
