namespace Oyun_Projesi
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyunalani = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.PictureBox();
            this.raket = new System.Windows.Forms.PictureBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.skor_button = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.oyunalani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // oyunalani
            // 
            this.oyunalani.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.oyunalani.Controls.Add(this.top);
            this.oyunalani.Controls.Add(this.raket);
            this.oyunalani.Location = new System.Drawing.Point(0, 56);
            this.oyunalani.Name = "oyunalani";
            this.oyunalani.Size = new System.Drawing.Size(1218, 635);
            this.oyunalani.TabIndex = 2;
            this.oyunalani.Paint += new System.Windows.Forms.PaintEventHandler(this.oyunalani_Paint_1);
            this.oyunalani.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oyunalani_MouseClick);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Olive;
            this.top.Location = new System.Drawing.Point(597, 257);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(20, 20);
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            // 
            // raket
            // 
            this.raket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.raket.BackColor = System.Drawing.Color.SlateBlue;
            this.raket.Location = new System.Drawing.Point(485, 605);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(240, 20);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_lbl.Location = new System.Drawing.Point(73, 22);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(21, 24);
            this.time_lbl.TabIndex = 3;
            this.time_lbl.Text = "0";
            // 
            // skor_button
            // 
            this.skor_button.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.skor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_button.Location = new System.Drawing.Point(312, 12);
            this.skor_button.Name = "skor_button";
            this.skor_button.Size = new System.Drawing.Size(221, 35);
            this.skor_button.TabIndex = 2;
            this.skor_button.Text = "YÜKSEK SKORLAR";
            this.skor_button.UseVisualStyleBackColor = false;
            this.skor_button.Click += new System.EventHandler(this.skor_button_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1218, 692);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.oyunalani);
            this.Controls.Add(this.skor_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.oyunalani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel oyunalani;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Button skor_button;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer2;
    }
}

