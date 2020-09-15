namespace _2D_Grid_based_Game
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
            this.upBtn1 = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.StatsBtn = new System.Windows.Forms.Label();
            this.Maptxt = new System.Windows.Forms.TextBox();
            this.attackBtn = new System.Windows.Forms.Button();
            this.Logtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // upBtn1
            // 
            this.upBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBtn1.Location = new System.Drawing.Point(589, 12);
            this.upBtn1.Name = "upBtn1";
            this.upBtn1.Size = new System.Drawing.Size(123, 41);
            this.upBtn1.TabIndex = 0;
            this.upBtn1.Text = "UP";
            this.upBtn1.UseVisualStyleBackColor = true;
            this.upBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // downBtn
            // 
            this.downBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBtn.Location = new System.Drawing.Point(589, 108);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(123, 41);
            this.downBtn.TabIndex = 1;
            this.downBtn.Text = "DOWN";
            this.downBtn.UseVisualStyleBackColor = true;
            // 
            // leftBtn
            // 
            this.leftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBtn.Location = new System.Drawing.Point(493, 62);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(100, 37);
            this.leftBtn.TabIndex = 2;
            this.leftBtn.Text = "LEFT";
            this.leftBtn.UseVisualStyleBackColor = true;
            // 
            // rightBtn
            // 
            this.rightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn.Location = new System.Drawing.Point(708, 62);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(114, 37);
            this.rightBtn.TabIndex = 3;
            this.rightBtn.Text = "RIGHT";
            this.rightBtn.UseVisualStyleBackColor = true;
            // 
            // StatsBtn
            // 
            this.StatsBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatsBtn.Location = new System.Drawing.Point(417, 317);
            this.StatsBtn.Name = "StatsBtn";
            this.StatsBtn.Size = new System.Drawing.Size(234, 124);
            this.StatsBtn.TabIndex = 4;
            this.StatsBtn.Text = "Player Stats";
            this.StatsBtn.Click += new System.EventHandler(this.StatsBtn_Click);
            // 
            // Maptxt
            // 
            this.Maptxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Maptxt.Location = new System.Drawing.Point(12, 12);
            this.Maptxt.Multiline = true;
            this.Maptxt.Name = "Maptxt";
            this.Maptxt.Size = new System.Drawing.Size(212, 273);
            this.Maptxt.TabIndex = 8;
            this.Maptxt.TextChanged += new System.EventHandler(this.Map_TextChanged);
            // 
            // attackBtn
            // 
            this.attackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackBtn.Location = new System.Drawing.Point(433, 192);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(86, 31);
            this.attackBtn.TabIndex = 9;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // Logtxt
            // 
            this.Logtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logtxt.Location = new System.Drawing.Point(12, 307);
            this.Logtxt.Multiline = true;
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.Size = new System.Drawing.Size(309, 118);
            this.Logtxt.TabIndex = 10;
            this.Logtxt.Text = "LOGS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.Logtxt);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.Maptxt);
            this.Controls.Add(this.StatsBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn1);
            this.Name = "Form1";
            this.Text = "2D Grid Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upBtn1;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Label StatsBtn;
        private System.Windows.Forms.TextBox Maptxt;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.TextBox Logtxt;
    }
}

