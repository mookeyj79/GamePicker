using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    class Game
    {
        private string _title;
        private int _min_num_players = 1;
        private int _max_num_players = 1;
        private TimeSpan _time_to_play;
        private string _description;
        private string _img_path;
        private int _min_age;

        #region Constuctors
        public Game(){ }

        public Game(string title, 
            int min_p, 
            int max_p, 
            string ttp,
            string descr,
            int min_age)
        {
            _title = title;
            _time_to_play = TimeSpan.Parse(ttp);
            _description = descr;

            if (min_p <= 0)
            {
                _min_num_players = 1;
            }
            else
            {
                _min_num_players = min_p;
            }
            
            if (max_p <= 0 || max_p <= _min_num_players)
            {
                _max_num_players = _min_num_players;
            }
            else
            {
                _max_num_players = min_p;
            }

            if (min_age <= 0)
            {
                _min_age = 1;
            }
            else
            {
                _min_age = min_age;
            }
        }

        public Game(Game game)
        {
            _title = game.Title;
            _min_num_players = game.MinPlayers;
            _max_num_players = game.MaxPlayers;
            _time_to_play = TimeSpan.Parse(game.TimeToPlay);
            _description = game.Description;
            _img_path = game.ImgPath;
            _min_age = game.MinAge;
        }
        #endregion

        #region GettersAndSetters
        public string Title { 
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        
        public int MinPlayers {
            get 
            {
                return _min_num_players;
            }
            set
            {
                _min_num_players = value;

                if (_min_num_players <= 0)
                {
                    _min_num_players = 1;
                }
                
                if (_min_num_players > _max_num_players)
                {
                    _max_num_players = _min_num_players;
                }
            }
        }

        public int MaxPlayers {
            get
            {
                return _max_num_players;
            }
            set
            {
                _max_num_players = value;
                
                if (_max_num_players <= 0)
                {
                    _max_num_players = 1;
                }

                if (_max_num_players < _min_num_players)
                {
                    _min_num_players = _max_num_players;
                }
            }
        }

        public String TimeToPlay { 
            get {
                return _time_to_play.ToString();
            } 
            set
            {
                _time_to_play = TimeSpan.Parse(value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string ImgPath {
            get
            {
                return _img_path;
            }
            set
            {
                _img_path = value;
            }
        }

        public int MinAge {
            get
            {
                return _min_age;
            }
            set
            {
                _min_age = value;
                if (_min_age <= 0)
                {
                    _min_age = 1;
                }
            }
        }
        #endregion

        public bool HaveEnoughTime(string time)
        {
            if (_time_to_play > TimeSpan.Parse(time))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
