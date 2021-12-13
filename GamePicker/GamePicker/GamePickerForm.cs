using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePicker
{
    public partial class GamePickerForm : Form
    {

        GamePicker gp = new GamePicker();

        #region Contructors
        public GamePickerForm()
        {
            InitializeComponent();
        }
        #endregion

        #region HelperFunctions
        private string WelcomeMessage()
        {
            List<string> messages = new List<string>();
            messages.Add("Well, hello there!");
            messages.Add("Welcome back, Traveler!");
            messages.Add("It's dangerous to go alone....");
            messages.Add("Do a barrel roll!");
            messages.Add("AAAAAaaaaaAAAAaaAAAAaaaHHHHH!!!");

            Random r = new Random();
            return messages[r.Next(messages.Count())];
        }
        #endregion

        #region GUIComponents
        private void GamePickerForm_Load(object sender, EventArgs e)
        {
            gp.GameDBCheck();
            gp.PopulateGames();
            lbl_info.Text = WelcomeMessage();
        }

        private void btn_player_add_Click(object sender, EventArgs e)
        {
            if (tb_player_name.Text.Length > 0 && tb_player_age.Text.Length > 0)
            {
                string name = tb_player_name.Text;
                int age = Int32.Parse(tb_player_age.Text);

                Player new_player = new Player(name, age);

                bool unique_name = false;
                int loop_count = 0;
                while (!unique_name)
                {
                    List<Player> test_list = gp.players.Where(x => x.Name == new_player.Name && x.Age == new_player.Age).ToList();
                    if(test_list.Count() > 0)
                    {
                        Random r = new Random();
                        string[] split_name = new_player.Name.Split('_');
                        new_player.Name = string.Format("{0}_{1}", split_name[0], r.Next(0, 100).ToString());
                    }
                    else
                    {
                        unique_name = true;
                    }
                    if(loop_count > 100) { break; }
                    loop_count++;
                }
                if( loop_count <= 100)
                {
                    gp.players.Add(new_player);
                    lv_players.Items.Add(new_player.GenerateListViewObject());
                    lbl_info.Text = new_player.Greeting();
                }
            }
        }

        private void btn_player_rem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = lv_players.SelectedItems[0].Text;
                int age = Int32.Parse(lv_players.SelectedItems[0].SubItems[1].Text);
                lbl_info.Text = string.Format("Name: {0} Age: {1}", name, age.ToString());
                Player rem_player = gp.players.Single(x => x.Name == name && x.Age == age);
                gp.players.RemoveAll(x => x.Name == name && x.Age == age);
                lv_players.SelectedItems[0].Remove();
                lbl_info.Text = rem_player.Goodbye();
            }
            catch(ArgumentOutOfRangeException)
            {
                // Do nothing
            }
        }
        

        private void btn_find_game_Click(object sender, EventArgs e)
        {
            List<Game> found_games = new List<Game>();
            int num_players = gp.players.Count();
            string ttp = String.Format("{0}:{1}", tb_ttp_h.Text, tb_ttp_m.Text);
            int lowest_age = 0;
            if (gp.players.Count() > 0)
            {
                lowest_age = gp.players.Min(x => x.Age);
            }

            if(num_players == 0)
            {
                lbl_game_title.Text = "You Gotta Add Some Players!";
            }
            else if(ttp == "00:00")
            {
                lbl_game_title.Text = "You Don't Have Time To Play?";
            }
            else
            {
                found_games = gp.games.Where(x => x.MinPlayers <= num_players && x.MaxPlayers >= num_players && x.MinAge <= lowest_age && x.HaveEnoughTime(ttp)).ToList();
                if (found_games.Count() == 0)
                {
                    lbl_game_title.Text = "Sorry, Mate. Couldn't find a game for ya.";
                    tb_game_descr.Text = "";
                    lbl_info.Text = "Try checking your settings.....or finding more friends....";
                }
                else
                {
                    Random r = new Random();
                    Game found_game = found_games[r.Next(found_games.Count())];
                    lbl_game_title.Text = found_game.Title;
                    tb_game_descr.Text = found_game.Description;
                    pb_game_img.Image = Image.FromFile(found_game.ImgPath);
                    lbl_info.Text = String.Format("Hey! Look! I found a game! If you don't like it, try searching again.", found_games.Count().ToString());
                }
            }
        }

        private void tb_ttp_h_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void tb_ttp_m_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }
        #endregion
    }
}
