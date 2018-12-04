
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Cliente
    {
        //propriedades  

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        //construtor defaul
        public Cliente()
        {

        }

        //sobrecarga de construtores 
        public Cliente(int idCliente, string nome, string endereco, string cEP, string bairro, string cidade, string uF, string telefone, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Endereco = endereco;
            CEP = cEP;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Telefone = telefone;
            Email = email;
        }


        //sobrescrita de método ToString()..
        public override string ToString()
        {
            return $"Id: {IdCliente}, Nome: {Nome}, Endereco: {Endereco}, CEP: {CEP}," +
            $"  Bairro: {Bairro}, Cidade: {Cidade}, UF: {UF}, Telefone: {Telefone}, Email: {Email}";
        }
    }
}
