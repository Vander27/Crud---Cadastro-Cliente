using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

//faz tratamento de entrada e saída de dados..
//validamos os dados de entrada  que são utilizados nos formulários das páginas..
namespace Projeto.Presentation.Models
{

    public class ClienteCadastroViewModel
    {
        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o nome do cliente.")]
        public string Nome { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o endereço do cliente.")]
        public string Endereco { get; set; }


        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o CEP do cliente.")]
        public string CEP { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o bairro do cliente.")]
        public string Bairro { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe a cidade do cliente.")]
        public string Cidade { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o estado do cliente.")]
        public string UF { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o telefone do cliente.")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Informe o email do cliente.")]
        public string Email { get; set; }
    }
}