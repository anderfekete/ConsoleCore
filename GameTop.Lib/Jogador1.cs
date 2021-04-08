
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
        //Chuta
        public string Chuta()
        {
            return ($"{_Nome} está chutando");
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está correndo";
        }
        //Passar
        public string Passe()
        {
            return $"{_Nome} está passando";
        }


    }
}