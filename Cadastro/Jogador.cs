using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; } // Masculino ou Feminino
        public string Nacionalidade { get; set; }
        public Jogos Jogos { get; set; }


        public Jogador() // Quando eu crio um novo objeto do tipo Jogador
        { 
            Jogos = new Jogos(); // Eu crio um novo objeto do tipo Jogos
        }
    }
}
