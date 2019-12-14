using System;

namespace Mariner.Services.ViewModels
{
    public class FuncionarioConsultaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdimissao { get; set; }
    }
}
