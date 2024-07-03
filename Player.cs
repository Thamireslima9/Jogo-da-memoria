using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Player
    {
        //Atributos
        private string _name;
        private int _score;
        private TimeSpan _gameTime;

        //Métodos
        public Player(string name)
        {
            Name = name;
            _score = 0;
            GameTime = TimeSpan.FromSeconds(0);
        }
        //propriedade
        public string Name
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _name = value;
            }

            get { return _name; }
        }
        public int Score
        {
            set
            {
                if (value > 0)
                    _score = value;
            }

            get { return _score; }
        }
        public TimeSpan GameTime
        {
            get { return _gameTime; }
            set
            {
                _gameTime += value;
            }
        }

        public override string ToString()
        {
            return "Nome: " + Name +
            "\nPontuação: " + Score +
            $"\nTempo de Partida: {GameTime:hh\\:mm\\:ss}";
        }
    }
}
