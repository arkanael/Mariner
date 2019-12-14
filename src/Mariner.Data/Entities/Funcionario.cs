using System;

namespace Mariner.Data.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdimissao { get; set; }
    }
}
