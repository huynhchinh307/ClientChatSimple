namespace ClientCTech
{
    partial class Client
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
            this.panel_move = new System.Windows.Forms.Panel();
            this.conStatus = new System.Windows.Forms.Label();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapGroup = new System.Windows.Forms.TabPage();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lstMesseger = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel_move.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tapGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_move.Controls.Add(this.conStatus);
            this.panel_move.Controls.Add(this.lbl_Minimize);
            this.panel_move.Controls.Add(this.lbl_Close);
            this.panel_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_move.Location = new System.Drawing.Point(0, 0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(398, 37);
            this.panel_move.TabIndex = 0;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_move_MouseDown);
            // 
            // conStatus
            // 
            this.conStatus.AutoSize = true;
            this.conStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conStatus.ForeColor = System.Drawing.Color.MistyRose;
            this.conStatus.Location = new System.Drawing.Point(12, 9);
            this.conStatus.Name = "conStatus";
            this.conStatus.Size = new System.Drawing.Size(51, 16);
            this.conStatus.TabIndex = 2;
            this.conStatus.Text = "Status";
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.AutoSize = true;
            this.lbl_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minimize.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_Minimize.Location = new System.Drawing.Point(350, 6);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Size = new System.Drawing.Size(16, 16);
            this.lbl_Minimize.TabIndex = 1;
            this.lbl_Minimize.Text = "_";
            this.lbl_Minimize.Click += new System.EventHandler(this.lbl_Minimize_Click);
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_Close.Location = new System.Drawing.Point(372, 9);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(17, 16);
            this.lbl_Close.TabIndex = 0;
            this.lbl_Close.Text = "X";
            this.lbl_Close.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_Text);
            this.panel2.Controls.Add(this.btn_Send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 49);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ClientCTech.Properties.Resources.microphone;
            this.pictureBox4.Location = new System.Drawing.Point(34, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ClientCTech.Properties.Resources.photo_camera;
            this.pictureBox3.Location = new System.Drawing.Point(3, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClientCTech.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(34, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientCTech.Properties.Resources.smile;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Text
            // 
            this.txt_Text.Enabled = false;
            this.txt_Text.Location = new System.Drawing.Point(62, 3);
            this.txt_Text.Multiline = true;
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(243, 43);
            this.txt_Text.TabIndex = 1;
            this.txt_Text.Text = "Trò chuyện với mọi người?";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Send.Enabled = false;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Location = new System.Drawing.Point(311, 14);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapGroup);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Location = new System.Drawing.Point(3, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 387);
            this.tabControl1.TabIndex = 2;
            // 
            // tapGroup
            // 
            this.tapGroup.Controls.Add(this.lstMesseger);
            this.tapGroup.Location = new System.Drawing.Point(4, 22);
            this.tapGroup.Name = "tapGroup";
            this.tapGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tapGroup.Size = new System.Drawing.Size(299, 361);
            this.tapGroup.TabIndex = 0;
            this.tapGroup.Text = "Public Chat";
            this.tapGroup.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(266, 361);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add Chat";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // lstMesseger
            // 
            this.lstMesseger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMesseger.FormattingEnabled = true;
            this.lstMesseger.Location = new System.Drawing.Point(3, 3);
            this.lstMesseger.Name = "lstMesseger";
            this.lstMesseger.ScrollAlwaysVisible = true;
            this.lstMesseger.Size = new System.Drawing.Size(293, 355);
            this.lstMesseger.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ClientCTech.Properties.Resources.group;
            this.pictureBox5.Location = new System.Drawing.Point(319, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 485);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tapGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label conStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapGroup;
        private System.Windows.Forms.ListBox lstMesseger;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

