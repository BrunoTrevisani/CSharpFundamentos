using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class Pessoa
    {
        byte idade;
        string nome;

        public void SetIdade(byte idade)
        {
            this.idade = idade;
        }
        public byte GetIdade()
        {
            return this.idade;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;
        }
    }
}
