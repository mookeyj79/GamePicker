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
        private int _min_num_players;
        private int _max_num_players;
        private DateTime _time_to_play;
        private string _description;
        private string _img_path;
        private int _min_age;

        Game(string name, 
            int min_p, 
            int max_p, 
            DateTime ttp,
            string descr,
            int min_age)
        {

        }

        Game(Game game)
        {

        }

        public string Title { get; set; }
        
        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set; }

        public DateTime TimeToPlay { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public int MinAge { get; set; }

        public string GetInfo()
        {
            return "";
        }

        public Player GetFirstPlayer()
        {
            return null;
        }
    }
}
