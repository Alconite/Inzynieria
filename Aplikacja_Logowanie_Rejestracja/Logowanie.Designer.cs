
namespace Aplikacja_Logowanie_Rejestracja
{
    partial class Logowanie
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Rejestracja = new System.Windows.Forms.Label();
            this.Zaloguj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Rejestracja
            // 
            this.Rejestracja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rejestracja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestracja.ForeColor = System.Drawing.Color.White;
            this.Rejestracja.Location = new System.Drawing.Point(478, 310);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(75, 29);
            this.Rejestracja.TabIndex = 9;
            this.Rejestracja.Text = "Sign up";
            this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
            // 
            // Zaloguj
            // 
            this.Zaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Zaloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zaloguj.ForeColor = System.Drawing.Color.White;
            this.Zaloguj.Location = new System.Drawing.Point(352, 310);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(75, 29);
            this.Zaloguj.TabIndex = 8;
            this.Zaloguj.Text = "Sign in";
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Rejestracja;
        private System.Windows.Forms.Label Zaloguj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

