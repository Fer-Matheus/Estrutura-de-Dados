using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class Record
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }
        public Record Proximo { get; set; }
        public Record(int id = 1, string nome = "Teste", int idade = 1, string endereco = "Rua das Laranjeiras", int numero = 1, string complemento = "Altos", int cep = 1111111)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            CEP = cep;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Idade: {Idade}, \nEndereço: {Endereco}, Número: {Numero}, Complemento: {Complemento}, \nCEP: {CEP}";
        }
    }
}