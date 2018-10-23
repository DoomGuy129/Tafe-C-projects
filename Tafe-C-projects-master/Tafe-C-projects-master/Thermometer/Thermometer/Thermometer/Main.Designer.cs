namespace Thermometer
{
    partial class Main
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
            this.lblcelsisus = new System.Windows.Forms.Label();
            this.lbfahrenheit = new System.Windows.Forms.Label();
            this.btnFreezing = new System.Windows.Forms.Button();
            this.btnboiling = new System.Windows.Forms.Button();
            this.lblcelsiusvalue = new System.Windows.Forms.Label();
            this.lblFahrenheitvalue = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcelsisus
            // 
            this.lblcelsisus.AutoSize = true;
            this.lblcelsisus.Location = new System.Drawing.Point(163, 450);
            this.lblcelsisus.Name = "lblcelsisus";
            this.lblcelsisus.Size = new System.Drawing.Size(78, 24);
            this.lblcelsisus.TabIndex = 0;
            this.lblcelsisus.Text = "Celsius";
            // 
            // lbfahrenheit
            // 
            this.lbfahrenheit.AutoSize = true;
            this.lbfahrenheit.Location = new System.Drawing.Point(294, 450);
            this.lbfahrenheit.Name = "lbfahrenheit";
            this.lbfahrenheit.Size = new System.Drawing.Size(111, 24);
            this.lbfahrenheit.TabIndex = 1;
            this.lbfahrenheit.Text = "Fahrenheit";
            // 
            // btnFreezing
            // 
            this.btnFreezing.Location = new System.Drawing.Point(144, 410);
            this.btnFreezing.Name = "btnFreezing";
            this.btnFreezing.Size = new System.Drawing.Size(97, 37);
            this.btnFreezing.TabIndex = 3;
            this.btnFreezing.Text = "Freezing";
            this.btnFreezing.UseVisualStyleBackColor = true;
            this.btnFreezing.Click += new System.EventHandler(this.btnFreezing_Click);
            // 
            // btnboiling
            // 
            this.btnboiling.Location = new System.Drawing.Point(298, 410);
            this.btnboiling.Name = "btnboiling";
            this.btnboiling.Size = new System.Drawing.Size(107, 37);
            this.btnboiling.TabIndex = 4;
            this.btnboiling.Text = "Boiling";
            this.btnboiling.UseVisualStyleBackColor = true;
            this.btnboiling.Click += new System.EventHandler(this.btnboiling_Click);
            // 
            // lblcelsiusvalue
            // 
            this.lblcelsiusvalue.AutoSize = true;
            this.lblcelsiusvalue.Location = new System.Drawing.Point(181, 383);
            this.lblcelsiusvalue.Name = "lblcelsiusvalue";
            this.lblcelsiusvalue.Size = new System.Drawing.Size(21, 24);
            this.lblcelsiusvalue.TabIndex = 5;
            this.lblcelsiusvalue.Text = "0";
            this.lblcelsiusvalue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFahrenheitvalue
            // 
            this.lblFahrenheitvalue.AutoSize = true;
            this.lblFahrenheitvalue.Location = new System.Drawing.Point(337, 383);
            this.lblFahrenheitvalue.Name = "lblFahrenheitvalue";
            this.lblFahrenheitvalue.Size = new System.Drawing.Size(21, 24);
            this.lblFahrenheitvalue.TabIndex = 6;
            this.lblFahrenheitvalue.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(247, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 460);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 484);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblFahrenheitvalue);
            this.Controls.Add(this.lblcelsiusvalue);
            this.Controls.Add(this.btnboiling);
            this.Controls.Add(this.btnFreezing);
            this.Controls.Add(this.lbfahrenheit);
            this.Controls.Add(this.lblcelsisus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Thermometer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcelsisus;
        private System.Windows.Forms.Label lbfahrenheit;
        private System.Windows.Forms.Button btnFreezing;
        private System.Windows.Forms.Button btnboiling;
        private System.Windows.Forms.Label lblcelsiusvalue;
        private System.Windows.Forms.Label lblFahrenheitvalue;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

