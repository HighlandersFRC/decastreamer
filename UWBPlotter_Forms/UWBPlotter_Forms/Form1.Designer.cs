namespace UWBPlotter_Forms
{
    partial class Plot1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plot1));
            this.button1 = new System.Windows.Forms.Button();
            this.Anchor1 = new System.Windows.Forms.PictureBox();
            this.Anchor3 = new System.Windows.Forms.PictureBox();
            this.Anchor4 = new System.Windows.Forms.PictureBox();
            this.Anchor2 = new System.Windows.Forms.PictureBox();
            this.tag0 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag0)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Reading";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Anchor1
            // 
            this.Anchor1.AccessibleName = "0,0";
            this.Anchor1.Image = ((System.Drawing.Image)(resources.GetObject("Anchor1.Image")));
            this.Anchor1.Location = new System.Drawing.Point(850, 439);
            this.Anchor1.Name = "Anchor1";
            this.Anchor1.Size = new System.Drawing.Size(50, 50);
            this.Anchor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anchor1.TabIndex = 1;
            this.Anchor1.TabStop = false;
            // 
            // Anchor3
            // 
            this.Anchor3.AccessibleName = "13.78, 5.56";
            this.Anchor3.Image = ((System.Drawing.Image)(resources.GetObject("Anchor3.Image")));
            this.Anchor3.Location = new System.Drawing.Point(150, 700);
            this.Anchor3.Name = "Anchor3";
            this.Anchor3.Size = new System.Drawing.Size(50, 50);
            this.Anchor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anchor3.TabIndex = 2;
            this.Anchor3.TabStop = false;
            // 
            // Anchor4
            // 
            this.Anchor4.AccessibleName = "-2.25, 5.58";
            this.Anchor4.Image = ((System.Drawing.Image)(resources.GetObject("Anchor4.Image")));
            this.Anchor4.Location = new System.Drawing.Point(507, 354);
            this.Anchor4.Name = "Anchor4";
            this.Anchor4.Size = new System.Drawing.Size(50, 50);
            this.Anchor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anchor4.TabIndex = 3;
            this.Anchor4.TabStop = false;
            // 
            // Anchor2
            // 
            this.Anchor2.AccessibleName = "13.78, 0.53";
            this.Anchor2.Image = ((System.Drawing.Image)(resources.GetObject("Anchor2.Image")));
            this.Anchor2.Location = new System.Drawing.Point(173, 312);
            this.Anchor2.Name = "Anchor2";
            this.Anchor2.Size = new System.Drawing.Size(50, 50);
            this.Anchor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anchor2.TabIndex = 4;
            this.Anchor2.TabStop = false;
            // 
            // tag0
            // 
            this.tag0.Image = ((System.Drawing.Image)(resources.GetObject("tag0.Image")));
            this.tag0.Location = new System.Drawing.Point(377, 388);
            this.tag0.Name = "tag0";
            this.tag0.Size = new System.Drawing.Size(50, 50);
            this.tag0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tag0.TabIndex = 5;
            this.tag0.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop Reading";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(293, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 227);
            this.panel1.TabIndex = 7;
            // 
            // Plot1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tag0);
            this.Controls.Add(this.Anchor2);
            this.Controls.Add(this.Anchor4);
            this.Controls.Add(this.Anchor3);
            this.Controls.Add(this.Anchor1);
            this.Controls.Add(this.button1);
            this.Name = "Plot1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Plot_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Anchor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anchor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Anchor1;
        private System.Windows.Forms.PictureBox Anchor3;
        private System.Windows.Forms.PictureBox Anchor4;
        private System.Windows.Forms.PictureBox Anchor2;
        private System.Windows.Forms.PictureBox tag0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}

