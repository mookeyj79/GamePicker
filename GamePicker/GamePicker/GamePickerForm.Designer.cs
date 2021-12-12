
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
            this.lv_players.Size = new System.Drawing.Size(188, 189);
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
            this.btn_player_add.Location = new System.Drawing.Point(206, 247);
            this.btn_player_add.Name = "btn_player_add";
            this.btn_player_add.Size = new System.Drawing.Size(30, 30);
            this.btn_player_add.TabIndex = 2;
            this.btn_player_add.Text = "+";
            this.btn_player_add.UseVisualStyleBackColor = true;
            this.btn_player_add.Click += new System.EventHandler(this.btn_player_add_Click);
            // 
            // btn_player_rem
            // 
            this.btn_player_rem.Location = new System.Drawing.Point(206, 30);
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
            this.lbl_player_age.Location = new System.Drawing.Point(148, 240);
            this.lbl_player_age.Name = "lbl_player_age";
            this.lbl_player_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_player_age.TabIndex = 6;
            this.lbl_player_age.Text = "Age";
            // 
            // tb_player_name
            // 
            this.tb_player_name.Location = new System.Drawing.Point(15, 257);
            this.tb_player_name.Name = "tb_player_name";
            this.tb_player_name.Size = new System.Drawing.Size(130, 20);
            this.tb_player_name.TabIndex = 7;
            // 
            // tb_player_age
            // 
            this.tb_player_age.Location = new System.Drawing.Point(151, 257);
            this.tb_player_age.Name = "tb_player_age";
            this.tb_player_age.Size = new System.Drawing.Size(49, 20);
            this.tb_player_age.TabIndex = 8;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(9, 641);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 16);
            this.lbl_info.TabIndex = 9;
            // 
            // GamePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 663);
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
            this.Name = "GamePickerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GamePickerForm_Load);
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
    }
}

