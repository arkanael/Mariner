using System;
using System.ComponentModel.DataAnnotations;

namespace Mariner.Services.ViewModels
{
    public class FuncionarioEdicaoModel
    {
        [Required(ErrorMessage = "Campo Obrigatrio")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigátorio.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigátorio.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Campo Obrigátorio.")]
        public DateTime DataAdimissao { get; set; }
    }
}
