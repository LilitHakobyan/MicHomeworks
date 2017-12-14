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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddChangeCar));
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
            this.txtBrand.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBrand.Location = new System.Drawing.Point(156, 33);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(259, 26);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModelName
            // 
            this.txtModelName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtModelName.Location = new System.Drawing.Point(156, 85);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(259, 26);
            this.txtModelName.TabIndex = 2;
            // 
            // txtModelColor
            // 
            this.txtModelColor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtModelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtModelColor.Location = new System.Drawing.Point(156, 145);
            this.txtModelColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelColor.Name = "txtModelColor";
            this.txtModelColor.Size = new System.Drawing.Size(259, 26);
            this.txtModelColor.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(156, 193);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaximumSize = new System.Drawing.Size(259, 26);
            this.txtPrice.MinimumSize = new System.Drawing.Size(259, 26);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(259, 26);
            this.txtPrice.TabIndex = 4;
            // 
            // lBrand
            // 
            this.lBrand.AutoSize = true;
            this.lBrand.Location = new System.Drawing.Point(18, 42);
            this.lBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBrand.Name = "lBrand";
            this.lBrand.Size = new System.Drawing.Size(49, 16);
            this.lBrand.TabIndex = 5;
            this.lBrand.Text = "Brand";
            // 
            // lModelName
            // 
            this.lModelName.AutoSize = true;
            this.lModelName.Location = new System.Drawing.Point(18, 94);
            this.lModelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lModelName.Name = "lModelName";
            this.lModelName.Size = new System.Drawing.Size(96, 16);
            this.lModelName.TabIndex = 6;
            this.lModelName.Text = "Model Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model Color";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(18, 203);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 16);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(30, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cncel
            // 
            this.Cncel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cncel.Location = new System.Drawing.Point(238, 264);
            this.Cncel.Name = "Cncel";
            this.Cncel.Size = new System.Drawing.Size(158, 34);
            this.Cncel.TabIndex = 10;
            this.Cncel.Text = "Cancel";
            this.Cncel.UseVisualStyleBackColor = false;
            this.Cncel.Click += new System.EventHandler(this.Cncel_Click);
            // 
            // FormAddChangeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(492, 321);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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