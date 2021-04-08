using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public Jogador2()
        {
        }
        //Chuta
        public string Chuta()
        {
            return "Maradona esta patenando";
        }
        //Corre
        public string Corre()
        {
            return "Maradona estas corriendo";
        }
        //Passar
        public string Passe()
        {
            return "Maradona esta pasando";
        }
    }
}