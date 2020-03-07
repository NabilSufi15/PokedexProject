using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media;

namespace Pokedex
{
    class MiniGameLogic
    {
        private int _wins = 0;
        private int _draw = 0;
        private int _loss = 0;
        private string _userChoice;
        private string _cpuChoice;
        private MediaPlayer _music = new MediaPlayer();


        public string UserChoice
        {
            get { return _userChoice; }
            set { _userChoice = value; }
        }

        public string CpuChoice
        {
            get { return _cpuChoice; }
            set { _cpuChoice = value; }
        }

        public int Wins
        {
            get { return _wins; }
            set { _wins = value;  }
        }

        public int Draw
        {
            get { return _draw; }
            set { _draw = value; }
        }

        public int Loss
        {
            get { return _loss; }
            set { _loss = value; }
        }


        public void Logic()
        {
            
            Random random = new Random();
            List<string> choice = new List<string> { "water", "fire", "grass" };
            int index = random.Next(choice.Count);
            CpuChoice = choice[index];

            if(_cpuChoice == "water" && _userChoice == "fire" || _cpuChoice == "fire" && _userChoice == "grass" || _cpuChoice == "grass" && _userChoice == "water")
            {
                _loss += 1;
            }
            else if (_cpuChoice == "water" && _userChoice == "water" || _cpuChoice == "fire" && _userChoice == "fire" || _cpuChoice == "grass" && _userChoice == "grass")
            {
                _draw += 1;
            }
            else if (_cpuChoice == "water" && _userChoice == "grass" || _cpuChoice == "fire" && _userChoice == "water" || _cpuChoice == "grass" && _userChoice == "fire")
            {
                _wins += 1;
            }

            if (_wins >= 5)
            {
                _wins = 0;
                _loss = 0;
                _draw = 0;
            }
            else if (_loss >= 5)
            {
                _wins = 0;
                _loss = 0;
                _draw = 0;
            }
        }

        public void WinGame()
        {
            if(_wins >= 5)
            {
                _wins = 0;
                _loss = 0;
                _draw = 0;
            }
            else if(_loss >= 5)
            {
                _wins = 0;
                _loss = 0;
                _draw = 0;
            }
        }

        public void audio()
        {
            _music.Open(new Uri(@"C:\Users\Tech-W148Bir\source\repos\PokedexProject\Pokedex\Asset\Audio/BattleMusic.mp3", UriKind.RelativeOrAbsolute));
            _music.Play();
        }

    }
}
