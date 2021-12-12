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

        private void GamePickerForm_Load(object sender, EventArgs e)
        {
            gp.GameDBCheck();
            lbl_info.Text = "";
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
    }
}
