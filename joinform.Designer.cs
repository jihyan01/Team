namespace Teamproject1
{
    partial class joinform
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("나눔바른펜", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(21, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔바른펜", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(105, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "회원가입";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(69, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 33);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "아이디";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("나눔바른펜", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(69, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 30);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "비밀번호";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("나눔바른펜", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(69, 429);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 30);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "비밀번호 재확인";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("나눔바른펜", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(69, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(392, 30);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 334);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(392, 25);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(69, 479);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(392, 25);
            this.textBox7.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔바른펜", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(245, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 62);
            this.button2.TabIndex = 8;
            this.button2.Text = "가입하기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(566, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(25, 673);
            this.vScrollBar1.TabIndex = 9;
            // 
            // joinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 720);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "joinform";
            this.Text = "joinform";
            this.Load += new System.EventHandler(this.joinform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}