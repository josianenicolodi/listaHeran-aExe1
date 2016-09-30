using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaHerançaExe1
{
    class Amigo : Pessoa 
    {
        string DiaDoAniversario;

        public Amigo(string nome, char sexo, int idade, string DiaDoAniversario)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.DiaDoAniversario = DiaDoAniversario;
        }


    }




}
