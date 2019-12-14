namespace AI_Snake.GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_tocDo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.điềuKhiểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mazesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmtoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tocDo_lable = new System.Windows.Forms.ToolStripStatusLabel();
            this.tocDo_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.state_groupBox = new System.Windows.Forms.GroupBox();
            this.computer_lbl = new System.Windows.Forms.Label();
            this.computer_label = new System.Windows.Forms.Label();
            this.player_lbl = new System.Windows.Forms.Label();
            this.player_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.state_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_tocDo
            // 
            this.timer_tocDo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điềuKhiểnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // điềuKhiểnToolStripMenuItem
            // 
            this.điềuKhiểnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator2,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator3,
            this.mazesToolStripMenuItem,
            this.algorithmToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.điềuKhiểnToolStripMenuItem.Name = "điềuKhiểnToolStripMenuItem";
            this.điềuKhiểnToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.điềuKhiểnToolStripMenuItem.Text = "Điều khiển";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newGameToolStripMenuItem.Text = "Chơi lại";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.new_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.playToolStripMenuItem.Text = "Chơi";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.play_button_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pauseToolStripMenuItem.Text = "Tạm dừng";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.play_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // mazesToolStripMenuItem
            // 
            this.mazesToolStripMenuItem.Name = "mazesToolStripMenuItem";
            this.mazesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mazesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.mazesToolStripMenuItem.Text = "Mê cung";
            this.mazesToolStripMenuItem.Click += new System.EventHandler(this.mazesToolStripMenuItem_Click);
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmtoolStripComboBox});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.algorithmToolStripMenuItem.Text = "Thuật toán";
            // 
            // algorithmtoolStripComboBox
            // 
            this.algorithmtoolStripComboBox.Items.AddRange(new object[] {
            "BreadthFirstSearch",
            "DepthFirstSearch"});
            this.algorithmtoolStripComboBox.Name = "algorithmtoolStripComboBox";
            this.algorithmtoolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.algorithmtoolStripComboBox.Text = "BreadthFirstSearch";
            this.algorithmtoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmtoolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tocDo_lable,
            this.tocDo_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tocDo_lable
            // 
            this.tocDo_lable.Name = "tocDo_lable";
            this.tocDo_lable.Size = new System.Drawing.Size(105, 17);
            this.tocDo_lable.Text = "Tốc độ di chuyển: ";
            // 
            // tocDo_lbl
            // 
            this.tocDo_lbl.Name = "tocDo_lbl";
            this.tocDo_lbl.Size = new System.Drawing.Size(25, 17);
            this.tocDo_lbl.Text = "100";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 501);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.control_groupBox);
            this.panel2.Controls.Add(this.state_groupBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(501, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 501);
            this.panel2.TabIndex = 1;
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.exit_button);
            this.control_groupBox.Controls.Add(this.show_button);
            this.control_groupBox.Controls.Add(this.play_button);
            this.control_groupBox.Controls.Add(this.new_button);
            this.control_groupBox.Font = new System.Drawing.Font("MinhQuân 1.1", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_groupBox.Location = new System.Drawing.Point(7, 309);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(182, 181);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "Control";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Mouser Outline", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.exit_button.Location = new System.Drawing.Point(8, 142);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(169, 33);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // show_button
            // 
            this.show_button.Font = new System.Drawing.Font("Mouser Outline", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.show_button.Location = new System.Drawing.Point(8, 103);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(169, 33);
            this.show_button.TabIndex = 2;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // play_button
            // 
            this.play_button.Font = new System.Drawing.Font("Mouser Outline", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.play_button.Location = new System.Drawing.Point(8, 64);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(169, 33);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // new_button
            // 
            this.new_button.Font = new System.Drawing.Font("Mouser Outline", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.new_button.Location = new System.Drawing.Point(6, 25);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(169, 33);
            this.new_button.TabIndex = 0;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // state_groupBox
            // 
            this.state_groupBox.Controls.Add(this.computer_lbl);
            this.state_groupBox.Controls.Add(this.computer_label);
            this.state_groupBox.Controls.Add(this.player_lbl);
            this.state_groupBox.Controls.Add(this.player_label);
            this.state_groupBox.Font = new System.Drawing.Font("MinhQuân 1.1", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_groupBox.Location = new System.Drawing.Point(7, 192);
            this.state_groupBox.Name = "state_groupBox";
            this.state_groupBox.Size = new System.Drawing.Size(182, 118);
            this.state_groupBox.TabIndex = 2;
            this.state_groupBox.TabStop = false;
            this.state_groupBox.Text = "State";
            // 
            // computer_lbl
            // 
            this.computer_lbl.AutoSize = true;
            this.computer_lbl.BackColor = System.Drawing.Color.Coral;
            this.computer_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computer_lbl.Font = new System.Drawing.Font("MinhQuân 1.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_lbl.Location = new System.Drawing.Point(108, 78);
            this.computer_lbl.Name = "computer_lbl";
            this.computer_lbl.Size = new System.Drawing.Size(21, 21);
            this.computer_lbl.TabIndex = 0;
            this.computer_lbl.Text = "1";
            this.computer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computer_label
            // 
            this.computer_label.AutoSize = true;
            this.computer_label.Font = new System.Drawing.Font("MinhQuân 1.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_label.Location = new System.Drawing.Point(6, 78);
            this.computer_label.Name = "computer_label";
            this.computer_label.Size = new System.Drawing.Size(99, 19);
            this.computer_label.TabIndex = 0;
            this.computer_label.Text = "Computer:";
            // 
            // player_lbl
            // 
            this.player_lbl.AutoSize = true;
            this.player_lbl.BackColor = System.Drawing.Color.Coral;
            this.player_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_lbl.Font = new System.Drawing.Font("MinhQuân 1.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_lbl.Location = new System.Drawing.Point(108, 33);
            this.player_lbl.Name = "player_lbl";
            this.player_lbl.Size = new System.Drawing.Size(21, 21);
            this.player_lbl.TabIndex = 0;
            this.player_lbl.Text = "0";
            this.player_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_label
            // 
            this.player_label.AutoSize = true;
            this.player_label.Font = new System.Drawing.Font("MinhQuân 1.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_label.Location = new System.Drawing.Point(6, 33);
            this.player_label.Name = "player_label";
            this.player_label.Size = new System.Drawing.Size(79, 19);
            this.player_label.TabIndex = 0;
            this.player_label.Text = "Player:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Smart Snake!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AI_Snake.Properties.Resources.Snake;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Smart Snake";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.control_groupBox.ResumeLayout(false);
            this.state_groupBox.ResumeLayout(false);
            this.state_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_tocDo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox state_groupBox;
        private System.Windows.Forms.Label player_label;
        private System.Windows.Forms.Label computer_label;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Label computer_lbl;
        private System.Windows.Forms.Label player_lbl;
        private System.Windows.Forms.ToolStripMenuItem điềuKhiểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tocDo_lable;
        private System.Windows.Forms.ToolStripStatusLabel tocDo_lbl;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mazesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox algorithmtoolStripComboBox;

    }
}

