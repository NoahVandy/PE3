namespace PE3
{
    partial class poundsConverter
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
            this.txtBox_pounds = new System.Windows.Forms.TextBox();
            this.txtBox_kilos = new System.Windows.Forms.TextBox();
            this.lbl_pounds = new System.Windows.Forms.Label();
            this.lbl_kilos = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_pounds
            // 
            this.txtBox_pounds.Location = new System.Drawing.Point(391, 128);
            this.txtBox_pounds.Name = "txtBox_pounds";
            this.txtBox_pounds.Size = new System.Drawing.Size(212, 38);
            this.txtBox_pounds.TabIndex = 0;
            // 
            // txtBox_kilos
            // 
            this.txtBox_kilos.Location = new System.Drawing.Point(391, 296);
            this.txtBox_kilos.Name = "txtBox_kilos";
            this.txtBox_kilos.Size = new System.Drawing.Size(212, 38);
            this.txtBox_kilos.TabIndex = 1;
            // 
            // lbl_pounds
            // 
            this.lbl_pounds.AutoSize = true;
            this.lbl_pounds.Font = new System.Drawing.Font("Impact", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pounds.ForeColor = System.Drawing.Color.White;
            this.lbl_pounds.Location = new System.Drawing.Point(52, 113);
            this.lbl_pounds.Name = "lbl_pounds";
            this.lbl_pounds.Size = new System.Drawing.Size(283, 60);
            this.lbl_pounds.TabIndex = 2;
            this.lbl_pounds.Text = "Enter pounds";
            // 
            // lbl_kilos
            // 
            this.lbl_kilos.AutoSize = true;
            this.lbl_kilos.Font = new System.Drawing.Font("Impact", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilos.ForeColor = System.Drawing.Color.White;
            this.lbl_kilos.Location = new System.Drawing.Point(29, 281);
            this.lbl_kilos.Name = "lbl_kilos";
            this.lbl_kilos.Size = new System.Drawing.Size(323, 60);
            this.lbl_kilos.TabIndex = 3;
            this.lbl_kilos.Text = "Pounds in kilos";
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.White;
            this.convertButton.Font = new System.Drawing.Font("Impact", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(391, 208);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(212, 51);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click_1);
            // 
            // poundsConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.lbl_kilos);
            this.Controls.Add(this.lbl_pounds);
            this.Controls.Add(this.txtBox_kilos);
            this.Controls.Add(this.txtBox_pounds);
            this.Name = "poundsConverter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_pounds;
        private System.Windows.Forms.TextBox txtBox_kilos;
        private System.Windows.Forms.Label lbl_pounds;
        private System.Windows.Forms.Label lbl_kilos;
        private System.Windows.Forms.Button convertButton;
    }
}

