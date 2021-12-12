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

        #region GettersAndSetters
        public string SetupTime
        {
            get
            {
                return _setup_time.ToString();
            }
            set
            {
                _setup_time = TimeSpan.Parse(value);
            }
        }
        #endregion
    }
}
