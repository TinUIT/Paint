namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_answer = new System.Windows.Forms.Button();
            this.listViewChat = new System.Windows.Forms.ListView();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.listViewAnswer = new System.Windows.Forms.ListView();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_elipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 128);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1002, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 35);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1002, 71);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 35);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::Paint.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(238, 122);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 6;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::Paint.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(891, 21);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(86, 82);
            this.btn_line.TabIndex = 4;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_rect.Location = new System.Drawing.Point(782, 21);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(103, 82);
            this.btn_rect.TabIndex = 4;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_elipse
            // 
            this.btn_elipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_elipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipse.ForeColor = System.Drawing.Color.White;
            this.btn_elipse.Image = global::Paint.Properties.Resources.circle;
            this.btn_elipse.Location = new System.Drawing.Point(690, 21);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(86, 82);
            this.btn_elipse.TabIndex = 4;
            this.btn_elipse.Text = "Elipse";
            this.btn_elipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elipse.UseVisualStyleBackColor = true;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraser.Location = new System.Drawing.Point(598, 21);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(86, 82);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::Paint.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pencil.Location = new System.Drawing.Point(506, 21);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(86, 82);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::Paint.Properties.Resources.bucket;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fill.Location = new System.Drawing.Point(414, 21);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(86, 82);
            this.btn_fill.TabIndex = 3;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_color
            // 
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Paint.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_color.Location = new System.Drawing.Point(322, 21);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(86, 82);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(244, 40);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(52, 43);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(302, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 100);
            this.panel3.TabIndex = 5;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 128);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1295, 658);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textname);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 658);
            this.panel4.TabIndex = 3;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(42, 79);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(196, 26);
            this.textname.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_chat);
            this.panel2.Controls.Add(this.btn_answer);
            this.panel2.Controls.Add(this.listViewChat);
            this.panel2.Controls.Add(this.textBoxChat);
            this.panel2.Controls.Add(this.listViewAnswer);
            this.panel2.Controls.Add(this.textBoxAnswer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(273, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 262);
            this.panel2.TabIndex = 4;
            // 
            // btn_chat
            // 
            this.btn_chat.Location = new System.Drawing.Point(902, 213);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(88, 37);
            this.btn_chat.TabIndex = 8;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = true;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_answer
            // 
            this.btn_answer.Location = new System.Drawing.Point(393, 213);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(88, 37);
            this.btn_answer.TabIndex = 3;
            this.btn_answer.Text = "Answer";
            this.btn_answer.UseVisualStyleBackColor = true;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // listViewChat
            // 
            this.listViewChat.HideSelection = false;
            this.listViewChat.Location = new System.Drawing.Point(509, 21);
            this.listViewChat.Name = "listViewChat";
            this.listViewChat.Size = new System.Drawing.Size(481, 169);
            this.listViewChat.TabIndex = 7;
            this.listViewChat.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxChat
            // 
            this.textBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChat.Location = new System.Drawing.Point(509, 215);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(376, 35);
            this.textBoxChat.TabIndex = 6;
            // 
            // listViewAnswer
            // 
            this.listViewAnswer.HideSelection = false;
            this.listViewAnswer.Location = new System.Drawing.Point(0, 21);
            this.listViewAnswer.Name = "listViewAnswer";
            this.listViewAnswer.Size = new System.Drawing.Size(481, 169);
            this.listViewAnswer.TabIndex = 2;
            this.listViewAnswer.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(0, 215);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(376, 35);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1264, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 396);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 786);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_answer;
        private System.Windows.Forms.ListView listViewAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.ListView listViewChat;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label1;
    }
}

