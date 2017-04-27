namespace Assignment_2_Mini_Keyboard
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.rtxt_Multipress = new System.Windows.Forms.RichTextBox();
            this.rtxt_WordBuilder = new System.Windows.Forms.RichTextBox();
            this.btn_SendPredicted = new System.Windows.Forms.Button();
            this.btn_Mode = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_null1 = new System.Windows.Forms.Button();
            this.btn_null2 = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.txt_Notepad = new System.Windows.Forms.TextBox();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_BottomLeft = new System.Windows.Forms.Button();
            this.btn_BottomRight = new System.Windows.Forms.Button();
            this.btn_BottomMiddle = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.withinTimer = new System.Windows.Forms.Timer(this.components);
            this.Panel2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.rtxt_Multipress);
            this.Panel2.Controls.Add(this.rtxt_WordBuilder);
            this.Panel2.Location = new System.Drawing.Point(89, 200);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(309, 58);
            this.Panel2.TabIndex = 5;
            // 
            // rtxt_Multipress
            // 
            this.rtxt_Multipress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxt_Multipress.Location = new System.Drawing.Point(229, 17);
            this.rtxt_Multipress.Name = "rtxt_Multipress";
            this.rtxt_Multipress.ReadOnly = true;
            this.rtxt_Multipress.Size = new System.Drawing.Size(57, 21);
            this.rtxt_Multipress.TabIndex = 3;
            this.rtxt_Multipress.Text = "Multi-Press";
            // 
            // rtxt_WordBuilder
            // 
            this.rtxt_WordBuilder.Location = new System.Drawing.Point(10, 17);
            this.rtxt_WordBuilder.Name = "rtxt_WordBuilder";
            this.rtxt_WordBuilder.Size = new System.Drawing.Size(203, 23);
            this.rtxt_WordBuilder.TabIndex = 1;
            this.rtxt_WordBuilder.Text = "";
            // 
            // btn_SendPredicted
            // 
            this.btn_SendPredicted.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_SendPredicted.Location = new System.Drawing.Point(229, 6);
            this.btn_SendPredicted.Name = "btn_SendPredicted";
            this.btn_SendPredicted.Size = new System.Drawing.Size(67, 55);
            this.btn_SendPredicted.TabIndex = 21;
            this.btn_SendPredicted.Text = "Send Predicted";
            this.btn_SendPredicted.UseVisualStyleBackColor = false;
            // 
            // btn_Mode
            // 
            this.btn_Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Mode.Location = new System.Drawing.Point(10, 6);
            this.btn_Mode.Name = "btn_Mode";
            this.btn_Mode.Size = new System.Drawing.Size(67, 55);
            this.btn_Mode.TabIndex = 20;
            this.btn_Mode.Text = "Mode";
            this.btn_Mode.UseVisualStyleBackColor = false;
            this.btn_Mode.Click += new System.EventHandler(this.btn_Mode_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Next.Location = new System.Drawing.Point(83, 6);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(67, 55);
            this.btn_Next.TabIndex = 19;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Previous.Location = new System.Drawing.Point(156, 6);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(67, 55);
            this.btn_Previous.TabIndex = 18;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            // 
            // btn_null1
            // 
            this.btn_null1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_null1.Location = new System.Drawing.Point(229, 67);
            this.btn_null1.Name = "btn_null1";
            this.btn_null1.Size = new System.Drawing.Size(67, 55);
            this.btn_null1.TabIndex = 16;
            this.btn_null1.UseVisualStyleBackColor = false;
            // 
            // btn_null2
            // 
            this.btn_null2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_null2.Location = new System.Drawing.Point(229, 128);
            this.btn_null2.Name = "btn_null2";
            this.btn_null2.Size = new System.Drawing.Size(67, 55);
            this.btn_null2.TabIndex = 17;
            this.btn_null2.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Gold;
            this.btn_Enter.Location = new System.Drawing.Point(229, 189);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(69, 116);
            this.btn_Enter.TabIndex = 15;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ConfigureToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(485, 24);
            this.MenuStrip1.TabIndex = 6;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ConfigureToolStripMenuItem
            // 
            this.ConfigureToolStripMenuItem.Name = "ConfigureToolStripMenuItem";
            this.ConfigureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ConfigureToolStripMenuItem.Text = "Configure";
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_7.Location = new System.Drawing.Point(10, 67);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(67, 55);
            this.btn_7.TabIndex = 11;
            this.btn_7.Text = "7\r\n. , \"";
            this.btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_4.Location = new System.Drawing.Point(10, 128);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(67, 55);
            this.btn_4.TabIndex = 14;
            this.btn_4.Text = "4\r\nG H I";
            this.btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_8.Location = new System.Drawing.Point(83, 67);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(67, 55);
            this.btn_8.TabIndex = 10;
            this.btn_8.Text = "8\r\nA B C";
            this.btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_5.Location = new System.Drawing.Point(83, 128);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(67, 55);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5\r\nJ K L";
            this.btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_9.Location = new System.Drawing.Point(156, 67);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(67, 55);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9\r\nD E F";
            this.btn_9.UseVisualStyleBackColor = false;
            // 
            // txt_Notepad
            // 
            this.txt_Notepad.BackColor = System.Drawing.Color.White;
            this.txt_Notepad.Location = new System.Drawing.Point(12, 36);
            this.txt_Notepad.Multiline = true;
            this.txt_Notepad.Name = "txt_Notepad";
            this.txt_Notepad.Size = new System.Drawing.Size(455, 148);
            this.txt_Notepad.TabIndex = 7;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_6.Location = new System.Drawing.Point(156, 128);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(67, 55);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6\r\nM N O";
            this.btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_1.Location = new System.Drawing.Point(10, 189);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(67, 55);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "1\r\nP Q R S";
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_2.Location = new System.Drawing.Point(83, 189);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(67, 55);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "2\r\nT U V";
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_3.Location = new System.Drawing.Point(156, 189);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(67, 55);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3\r\nW X Y Z";
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_BottomLeft
            // 
            this.btn_BottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_BottomLeft.Location = new System.Drawing.Point(10, 250);
            this.btn_BottomLeft.Name = "btn_BottomLeft";
            this.btn_BottomLeft.Size = new System.Drawing.Size(67, 55);
            this.btn_BottomLeft.TabIndex = 8;
            this.btn_BottomLeft.Text = "* - _";
            this.btn_BottomLeft.UseVisualStyleBackColor = false;
            // 
            // btn_BottomRight
            // 
            this.btn_BottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_BottomRight.Location = new System.Drawing.Point(156, 250);
            this.btn_BottomRight.Name = "btn_BottomRight";
            this.btn_BottomRight.Size = new System.Drawing.Size(67, 55);
            this.btn_BottomRight.TabIndex = 4;
            this.btn_BottomRight.Text = "#\r\n000";
            this.btn_BottomRight.UseVisualStyleBackColor = false;
            // 
            // btn_BottomMiddle
            // 
            this.btn_BottomMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_BottomMiddle.Location = new System.Drawing.Point(83, 250);
            this.btn_BottomMiddle.Name = "btn_BottomMiddle";
            this.btn_BottomMiddle.Size = new System.Drawing.Size(67, 55);
            this.btn_BottomMiddle.TabIndex = 5;
            this.btn_BottomMiddle.Text = "000 \r\n[ _ ]";
            this.btn_BottomMiddle.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btn_SendPredicted);
            this.Panel1.Controls.Add(this.btn_Mode);
            this.Panel1.Controls.Add(this.btn_Next);
            this.Panel1.Controls.Add(this.btn_Previous);
            this.Panel1.Controls.Add(this.btn_null1);
            this.Panel1.Controls.Add(this.btn_null2);
            this.Panel1.Controls.Add(this.btn_Enter);
            this.Panel1.Controls.Add(this.btn_7);
            this.Panel1.Controls.Add(this.btn_4);
            this.Panel1.Controls.Add(this.btn_8);
            this.Panel1.Controls.Add(this.btn_9);
            this.Panel1.Controls.Add(this.btn_5);
            this.Panel1.Controls.Add(this.btn_6);
            this.Panel1.Controls.Add(this.btn_1);
            this.Panel1.Controls.Add(this.btn_2);
            this.Panel1.Controls.Add(this.btn_3);
            this.Panel1.Controls.Add(this.btn_BottomLeft);
            this.Panel1.Controls.Add(this.btn_BottomMiddle);
            this.Panel1.Controls.Add(this.btn_BottomRight);
            this.Panel1.Location = new System.Drawing.Point(89, 258);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(309, 312);
            this.Panel1.TabIndex = 4;
            // 
            // withinTimer
            // 
            this.withinTimer.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 602);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.txt_Notepad);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel2.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.RichTextBox rtxt_Multipress;
        internal System.Windows.Forms.RichTextBox rtxt_WordBuilder;
        internal System.Windows.Forms.Button btn_SendPredicted;
        internal System.Windows.Forms.Button btn_Mode;
        internal System.Windows.Forms.Button btn_Next;
        internal System.Windows.Forms.Button btn_Previous;
        internal System.Windows.Forms.Button btn_null1;
        internal System.Windows.Forms.Button btn_null2;
        internal System.Windows.Forms.Button btn_Enter;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ConfigureToolStripMenuItem;
        internal System.Windows.Forms.Button btn_7;
        internal System.Windows.Forms.Button btn_4;
        internal System.Windows.Forms.Button btn_8;
        internal System.Windows.Forms.Button btn_5;
        internal System.Windows.Forms.Button btn_9;
        internal System.Windows.Forms.TextBox txt_Notepad;
        internal System.Windows.Forms.Button btn_6;
        internal System.Windows.Forms.Button btn_1;
        internal System.Windows.Forms.Button btn_2;
        internal System.Windows.Forms.Button btn_3;
        internal System.Windows.Forms.Button btn_BottomLeft;
        internal System.Windows.Forms.Button btn_BottomRight;
        internal System.Windows.Forms.Button btn_BottomMiddle;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Timer withinTimer;
    }
}

