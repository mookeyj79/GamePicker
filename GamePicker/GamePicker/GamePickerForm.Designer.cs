
namespace GamePicker
{
    partial class GamePickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_players = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_players = new System.Windows.Forms.Label();
            this.btn_player_add = new System.Windows.Forms.Button();
            this.btn_player_rem = new System.Windows.Forms.Button();
            this.lbl_add_player = new System.Windows.Forms.Label();
            this.lbl_player_name = new System.Windows.Forms.Label();
            this.lbl_player_age = new System.Windows.Forms.Label();
            this.tb_player_name = new System.Windows.Forms.TextBox();
            this.tb_player_age = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_ttp = new System.Windows.Forms.Label();
            this.tb_ttp_h = new System.Windows.Forms.TextBox();
            this.lbl_ttp_colon = new System.Windows.Forms.Label();
            this.lbl_ttp_hh = new System.Windows.Forms.Label();
            this.lbl_ttp_mm = new System.Windows.Forms.Label();
            this.tb_ttp_m = new System.Windows.Forms.TextBox();
            this.btn_find_game = new System.Windows.Forms.Button();
            this.lbl_game_title = new System.Windows.Forms.Label();
            this.tb_game_descr = new System.Windows.Forms.TextBox();
            this.pb_game_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_game_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_players
            // 
            this.lv_players.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_players.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_age});
            this.lv_players.HideSelection = false;
            this.lv_players.HoverSelection = true;
            this.lv_players.Location = new System.Drawing.Point(12, 30);
            this.lv_players.MultiSelect = false;
            this.lv_players.Name = "lv_players";
            this.lv_players.Size = new System.Drawing.Size(204, 189);
            this.lv_players.TabIndex = 0;
            this.lv_players.UseCompatibleStateImageBehavior = false;
            this.lv_players.View = System.Windows.Forms.View.Details;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Name";
            this.ch_name.Width = 123;
            // 
            // ch_age
            // 
            this.ch_age.Text = "Age";
            // 
            // lbl_players
            // 
            this.lbl_players.AutoSize = true;
            this.lbl_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_players.Location = new System.Drawing.Point(12, 9);
            this.lbl_players.Name = "lbl_players";
            this.lbl_players.Size = new System.Drawing.Size(64, 18);
            this.lbl_players.TabIndex = 1;
            this.lbl_players.Text = "Players";
            // 
            // btn_player_add
            // 
            this.btn_player_add.Location = new System.Drawing.Point(222, 247);
            this.btn_player_add.Name = "btn_player_add";
            this.btn_player_add.Size = new System.Drawing.Size(30, 30);
            this.btn_player_add.TabIndex = 2;
            this.btn_player_add.Text = "+";
            this.btn_player_add.UseVisualStyleBackColor = true;
            this.btn_player_add.Click += new System.EventHandler(this.btn_player_add_Click);
            // 
            // btn_player_rem
            // 
            this.btn_player_rem.Location = new System.Drawing.Point(222, 30);
            this.btn_player_rem.Name = "btn_player_rem";
            this.btn_player_rem.Size = new System.Drawing.Size(30, 30);
            this.btn_player_rem.TabIndex = 3;
            this.btn_player_rem.Text = "-";
            this.btn_player_rem.UseVisualStyleBackColor = true;
            this.btn_player_rem.Click += new System.EventHandler(this.btn_player_rem_Click);
            // 
            // lbl_add_player
            // 
            this.lbl_add_player.AutoSize = true;
            this.lbl_add_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_player.Location = new System.Drawing.Point(12, 222);
            this.lbl_add_player.Name = "lbl_add_player";
            this.lbl_add_player.Size = new System.Drawing.Size(88, 18);
            this.lbl_add_player.TabIndex = 4;
            this.lbl_add_player.Text = "Add Player";
            // 
            // lbl_player_name
            // 
            this.lbl_player_name.AutoSize = true;
            this.lbl_player_name.Location = new System.Drawing.Point(12, 240);
            this.lbl_player_name.Name = "lbl_player_name";
            this.lbl_player_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_player_name.TabIndex = 5;
            this.lbl_player_name.Text = "Name";
            // 
            // lbl_player_age
            // 
            this.lbl_player_age.AutoSize = true;
            this.lbl_player_age.Location = new System.Drawing.Point(164, 240);
            this.lbl_player_age.Name = "lbl_player_age";
            this.lbl_player_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_player_age.TabIndex = 6;
            this.lbl_player_age.Text = "Age";
            // 
            // tb_player_name
            // 
            this.tb_player_name.BackColor = System.Drawing.Color.White;
            this.tb_player_name.Location = new System.Drawing.Point(15, 257);
            this.tb_player_name.Name = "tb_player_name";
            this.tb_player_name.Size = new System.Drawing.Size(146, 20);
            this.tb_player_name.TabIndex = 7;
            // 
            // tb_player_age
            // 
            this.tb_player_age.BackColor = System.Drawing.Color.White;
            this.tb_player_age.Location = new System.Drawing.Point(167, 257);
            this.tb_player_age.MaxLength = 3;
            this.tb_player_age.Name = "tb_player_age";
            this.tb_player_age.Size = new System.Drawing.Size(49, 20);
            this.tb_player_age.TabIndex = 8;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(12, 541);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(66, 16);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "Welcome";
            // 
            // lbl_ttp
            // 
            this.lbl_ttp.AutoSize = true;
            this.lbl_ttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttp.Location = new System.Drawing.Point(345, 9);
            this.lbl_ttp.Name = "lbl_ttp";
            this.lbl_ttp.Size = new System.Drawing.Size(109, 18);
            this.lbl_ttp.TabIndex = 10;
            this.lbl_ttp.Text = "Time-To-Play";
            // 
            // tb_ttp_h
            // 
            this.tb_ttp_h.BackColor = System.Drawing.Color.White;
            this.tb_ttp_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ttp_h.Location = new System.Drawing.Point(363, 34);
            this.tb_ttp_h.MaxLength = 2;
            this.tb_ttp_h.Name = "tb_ttp_h";
            this.tb_ttp_h.Size = new System.Drawing.Size(26, 22);
            this.tb_ttp_h.TabIndex = 11;
            this.tb_ttp_h.Text = "01";
            this.tb_ttp_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ttp_h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ttp_h_KeyDown);
            // 
            // lbl_ttp_colon
            // 
            this.lbl_ttp_colon.AutoSize = true;
            this.lbl_ttp_colon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttp_colon.Location = new System.Drawing.Point(395, 37);
            this.lbl_ttp_colon.Name = "lbl_ttp_colon";
            this.lbl_ttp_colon.Size = new System.Drawing.Size(12, 16);
            this.lbl_ttp_colon.TabIndex = 12;
            this.lbl_ttp_colon.Text = ":";
            // 
            // lbl_ttp_hh
            // 
            this.lbl_ttp_hh.AutoSize = true;
            this.lbl_ttp_hh.Location = new System.Drawing.Point(366, 59);
            this.lbl_ttp_hh.Name = "lbl_ttp_hh";
            this.lbl_ttp_hh.Size = new System.Drawing.Size(23, 13);
            this.lbl_ttp_hh.TabIndex = 14;
            this.lbl_ttp_hh.Text = "HH";
            // 
            // lbl_ttp_mm
            // 
            this.lbl_ttp_mm.AutoSize = true;
            this.lbl_ttp_mm.Location = new System.Drawing.Point(414, 59);
            this.lbl_ttp_mm.Name = "lbl_ttp_mm";
            this.lbl_ttp_mm.Size = new System.Drawing.Size(25, 13);
            this.lbl_ttp_mm.TabIndex = 15;
            this.lbl_ttp_mm.Text = "MM";
            // 
            // tb_ttp_m
            // 
            this.tb_ttp_m.BackColor = System.Drawing.Color.White;
            this.tb_ttp_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ttp_m.Location = new System.Drawing.Point(413, 34);
            this.tb_ttp_m.MaxLength = 2;
            this.tb_ttp_m.Name = "tb_ttp_m";
            this.tb_ttp_m.Size = new System.Drawing.Size(26, 22);
            this.tb_ttp_m.TabIndex = 16;
            this.tb_ttp_m.Text = "00";
            this.tb_ttp_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ttp_m.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ttp_m_KeyDown);
            // 
            // btn_find_game
            // 
            this.btn_find_game.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_find_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_game.Location = new System.Drawing.Point(317, 232);
            this.btn_find_game.Name = "btn_find_game";
            this.btn_find_game.Size = new System.Drawing.Size(137, 45);
            this.btn_find_game.TabIndex = 17;
            this.btn_find_game.Text = "Find Game";
            this.btn_find_game.UseVisualStyleBackColor = false;
            this.btn_find_game.Click += new System.EventHandler(this.btn_find_game_Click);
            // 
            // lbl_game_title
            // 
            this.lbl_game_title.AutoSize = true;
            this.lbl_game_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game_title.Location = new System.Drawing.Point(12, 312);
            this.lbl_game_title.Name = "lbl_game_title";
            this.lbl_game_title.Size = new System.Drawing.Size(161, 20);
            this.lbl_game_title.TabIndex = 18;
            this.lbl_game_title.Text = "Press \"Find Game\"";
            // 
            // tb_game_descr
            // 
            this.tb_game_descr.BackColor = System.Drawing.Color.White;
            this.tb_game_descr.Location = new System.Drawing.Point(12, 335);
            this.tb_game_descr.Multiline = true;
            this.tb_game_descr.Name = "tb_game_descr";
            this.tb_game_descr.ReadOnly = true;
            this.tb_game_descr.Size = new System.Drawing.Size(192, 203);
            this.tb_game_descr.TabIndex = 19;
            // 
            // pb_game_img
            // 
            this.pb_game_img.Location = new System.Drawing.Point(289, 391);
            this.pb_game_img.Name = "pb_game_img";
            this.pb_game_img.Size = new System.Drawing.Size(165, 147);
            this.pb_game_img.TabIndex = 20;
            this.pb_game_img.TabStop = false;
            // 
            // GamePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 563);
            this.Controls.Add(this.pb_game_img);
            this.Controls.Add(this.tb_game_descr);
            this.Controls.Add(this.lbl_game_title);
            this.Controls.Add(this.btn_find_game);
            this.Controls.Add(this.tb_ttp_m);
            this.Controls.Add(this.lbl_ttp_mm);
            this.Controls.Add(this.lbl_ttp_hh);
            this.Controls.Add(this.lbl_ttp_colon);
            this.Controls.Add(this.tb_ttp_h);
            this.Controls.Add(this.lbl_ttp);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.tb_player_age);
            this.Controls.Add(this.tb_player_name);
            this.Controls.Add(this.lbl_player_age);
            this.Controls.Add(this.lbl_player_name);
            this.Controls.Add(this.lbl_add_player);
            this.Controls.Add(this.btn_player_rem);
            this.Controls.Add(this.btn_player_add);
            this.Controls.Add(this.lbl_players);
            this.Controls.Add(this.lv_players);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GamePickerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GamePickerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_game_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_players;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_age;
        private System.Windows.Forms.Label lbl_players;
        private System.Windows.Forms.Button btn_player_add;
        private System.Windows.Forms.Button btn_player_rem;
        private System.Windows.Forms.Label lbl_add_player;
        private System.Windows.Forms.Label lbl_player_name;
        private System.Windows.Forms.Label lbl_player_age;
        private System.Windows.Forms.TextBox tb_player_name;
        private System.Windows.Forms.TextBox tb_player_age;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_ttp;
        private System.Windows.Forms.TextBox tb_ttp_h;
        private System.Windows.Forms.Label lbl_ttp_colon;
        private System.Windows.Forms.Label lbl_ttp_hh;
        private System.Windows.Forms.Label lbl_ttp_mm;
        private System.Windows.Forms.TextBox tb_ttp_m;
        private System.Windows.Forms.Button btn_find_game;
        private System.Windows.Forms.Label lbl_game_title;
        private System.Windows.Forms.TextBox tb_game_descr;
        private System.Windows.Forms.PictureBox pb_game_img;
    }
}

