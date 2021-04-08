using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _JogadorA;
        private readonly IJogador _JogadorB;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;

        }
        public void IniciarJogo()
        {
            Console.WriteLine(_JogadorA.Corre());
            Console.WriteLine(_JogadorA.Chuta());
            Console.WriteLine(_JogadorA.Passe());

            Console.WriteLine(_JogadorB.Corre());
            Console.WriteLine(_JogadorB.Chuta());
            Console.WriteLine(_JogadorB.Passe());
        }

    }
}