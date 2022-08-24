using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse01
{
    internal class Pessoa
    {
        String nome { get; set; }
        String dataNasc { get; set; }
        String cpf { get; set; }
        String telefone { get; set; }
        
        public Pessoa(String nome, String dataNasc, String cpf, String telefone)
        {
            this.nome = nome;
            this.dataNasc = dataNasc;   
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public override string ToString()
        {
            return $"Nome: {nome} \nData Nasc: {dataNasc} \nCPF: {cpf} \nTelefone: {telefone}";
        }

    }
}
