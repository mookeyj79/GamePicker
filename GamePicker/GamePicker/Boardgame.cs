using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    class Boardgame: Game
    {
        private TimeSpan _setup_time;
        private TimeSpan _total_time;

        #region GettersAndSetters
        public string SetupTime
        {
            get
            {
                return _setup_time.ToString();
            }
            set
            {
                _setup_time = TimeSpan.ParseExact(value, @"hh\:mm", null);
                _total_time = _setup_time.Add(TimeSpan.ParseExact(TimeToPlay, @"hh\:mm", null));
            }
        }

        public string TotalTime
        {
            get
            {
                return (_total_time).ToString(@"hh\:mm");
            }
        }
        #endregion
    }
}
