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
        private string _age;

        Player(string name, int age)
        {

        }

        Player(Player player)
        {

        }

        public string Name{ get; set; }

        public int Age { get; set; }
    }
}
