using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePicker
{
    public class Player
    {
        private string _name;
        private int _age;

        #region Constructors
        public Player(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Player(Player player)
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

        public ListViewItem GenerateListViewObject()
        {
            ListViewItem player = new ListViewItem(_name, 0);
            player.SubItems.Add(_age.ToString());
            return player;
        }

        public string Greeting()
        {
            List<string> greetings = new List<string>();
            greetings.Add("Welcome, {0}!");
            greetings.Add("Ahoy, {0}!");
            greetings.Add("Get ready to rumble. {0} is here!");
            greetings.Add("Look busy! {0} is here!");

            Random r = new Random();
            return String.Format(greetings[r.Next(greetings.Count())], _name);
        }

        public string Goodbye()
        {
            List<string> goodbyes = new List<string>();
            goodbyes.Add("Sorry to see ya go, {0}!");
            goodbyes.Add("Time to hit the ol' dusty trail, {0}!");
            goodbyes.Add("Don't tell me we left {0} behind!");
            goodbyes.Add("Hey, Where did {0} go?");

            Random r = new Random();
            return String.Format(goodbyes[r.Next(goodbyes.Count())], _name);
        }
    }
}
