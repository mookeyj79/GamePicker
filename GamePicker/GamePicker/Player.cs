using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    class Player
    {
        private string _name;
        private int _age;

        #region Constructors
        Player(string name, int age)
        {
            _name = name;
            _age = age;
        }

        Player(Player player)
        {
            _name = player.Name;
            _age = player.Age;
        }
        #endregion

        #region SettersAndGetters
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (_name.Length == 0)
                {
                    Random r = new Random();
                    _name = "Player " + (r.NextDouble() * r.Next(0, 100)).ToString();
                }
            }
        }

        public int Age 
        {
            get 
            {
                return _age;
            }
            set
            {
                _age = value;
                if (_age <= 0)
                {
                    _age = 1;
                }
            }
        }
        #endregion
    }
}
