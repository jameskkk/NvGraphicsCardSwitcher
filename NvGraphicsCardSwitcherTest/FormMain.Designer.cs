namespace NvGraphicsCardSwitcherTest
{
    partial class FormMain
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
            this.btnChangeNV = new System.Windows.Forms.Button();
            this.btnChangeIntel = new System.Windows.Forms.Button();
            this.btnChangeAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeNV
            // 
            this.btnChangeNV.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeNV.Location = new System.Drawing.Point(57, 52);
            this.btnChangeNV.Name = "btnChangeNV";
            this.btnChangeNV.Size = new System.Drawing.Size(214, 75);
            this.btnChangeNV.TabIndex = 0;
            this.btnChangeNV.Text = "Change NV";
            this.btnChangeNV.UseVisualStyleBackColor = true;
            this.btnChangeNV.Click += new System.EventHandler(this.btnChangeNV_Click);
            // 
            // btnChangeIntel
            // 
            this.btnChangeIntel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeIntel.Location = new System.Drawing.Point(57, 161);
            this.btnChangeIntel.Name = "btnChangeIntel";
            this.btnChangeIntel.Size = new System.Drawing.Size(214, 75);
            this.btnChangeIntel.TabIndex = 1;
            this.btnChangeIntel.Text = "Change Intel";
            this.btnChangeIntel.UseVisualStyleBackColor = true;
            this.btnChangeIntel.Click += new System.EventHandler(this.btnChangeIntel_Click);
            // 
            // btnChangeAuto
            // 
            this.btnChangeAuto.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeAuto.Location = new System.Drawing.Point(57, 268);
            this.btnChangeAuto.Name = "btnChangeAuto";
            this.btnChangeAuto.Size = new System.Drawing.Size(214, 75);
            this.btnChangeAuto.TabIndex = 2;
            this.btnChangeAuto.Text = "Change Auto";
            this.btnChangeAuto.UseVisualStyleBackColor = true;
            this.btnChangeAuto.Click += new System.EventHandler(this.btnChangeAuto_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 373);
            this.Controls.Add(this.btnChangeAuto);
            this.Controls.Add(this.btnChangeIntel);
            this.Controls.Add(this.btnChangeNV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "NvGraphicsCardSwitcher Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeNV;
        private System.Windows.Forms.Button btnChangeIntel;
        private System.Windows.Forms.Button btnChangeAuto;
    }
}

