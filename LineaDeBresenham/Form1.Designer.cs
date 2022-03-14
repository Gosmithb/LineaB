namespace LineaDeBresenham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butPrint = new System.Windows.Forms.Button();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(442, 199);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(136, 23);
            this.butPrint.TabIndex = 0;
            this.butPrint.Text = "Pintar linea";
            this.butPrint.UseVisualStyleBackColor = true;
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            this.butPrint.Paint += new System.Windows.Forms.PaintEventHandler(this.butPrint_Paint);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(478, 83);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 23);
            this.tbX1.TabIndex = 1;
            this.tbX1.Text = "0";
            this.tbX1.TextChanged += new System.EventHandler(this.tbX1_TextChanged);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(478, 112);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 23);
            this.tbX2.TabIndex = 2;
            this.tbX2.Text = "1";
            this.tbX2.TextChanged += new System.EventHandler(this.tbX2_TextChanged);
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(478, 141);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(100, 23);
            this.tbY1.TabIndex = 3;
            this.tbY1.Text = "0";
            this.tbY1.TextChanged += new System.EventHandler(this.tbY1_TextChanged);
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(478, 170);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(100, 23);
            this.tbY2.TabIndex = 4;
            this.tbY2.Text = "1";
            this.tbY2.TextChanged += new System.EventHandler(this.tbY2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "X1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "X2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(21, 83);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 400);
            this.panel.TabIndex = 9;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grafica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.butPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button butPrint;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbY1;
        private TextBox tbY2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel;
        private Label label5;
    }
}