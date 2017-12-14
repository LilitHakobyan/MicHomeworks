namespace Saloon_Car
{
    partial class FormAddChangeCar
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtModelColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lBrand = new System.Windows.Forms.Label();
            this.lModelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cncel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(139, 33);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(231, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(139, 85);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(231, 22);
            this.txtModelName.TabIndex = 2;
            // 
            // txtModelColor
            // 
            this.txtModelColor.Location = new System.Drawing.Point(139, 145);
            this.txtModelColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelColor.Name = "txtModelColor";
            this.txtModelColor.Size = new System.Drawing.Size(231, 22);
            this.txtModelColor.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 194);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(231, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // lBrand
            // 
            this.lBrand.AutoSize = true;
            this.lBrand.Location = new System.Drawing.Point(16, 42);
            this.lBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBrand.Name = "lBrand";
            this.lBrand.Size = new System.Drawing.Size(44, 16);
            this.lBrand.TabIndex = 5;
            this.lBrand.Text = "Brand";
            // 
            // lModelName
            // 
            this.lModelName.AutoSize = true;
            this.lModelName.Location = new System.Drawing.Point(16, 94);
            this.lModelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lModelName.Name = "lModelName";
            this.lModelName.Size = new System.Drawing.Size(86, 16);
            this.lModelName.TabIndex = 6;
            this.lModelName.Text = "Model Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model Color";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(16, 203);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(39, 16);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cncel
            // 
            this.Cncel.Location = new System.Drawing.Point(212, 264);
            this.Cncel.Name = "Cncel";
            this.Cncel.Size = new System.Drawing.Size(140, 34);
            this.Cncel.TabIndex = 10;
            this.Cncel.Text = "Cancel";
            this.Cncel.UseVisualStyleBackColor = true;
            this.Cncel.Click += new System.EventHandler(this.Cncel_Click);
            // 
            // FormAddChangeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 321);
            this.Controls.Add(this.Cncel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lModelName);
            this.Controls.Add(this.lBrand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtModelColor);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtBrand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddChangeCar";
            this.Text = "FormAddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtModelColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lBrand;
        private System.Windows.Forms.Label lModelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cncel;
    }
}