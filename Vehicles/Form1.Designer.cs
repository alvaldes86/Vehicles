namespace Vehicles
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWheels = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMessageOutput = new System.Windows.Forms.Label();
            this.txtWheels = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(107)))), ((int)(((byte)(223)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(72, 173);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblWheels
            // 
            this.lblWheels.AutoSize = true;
            this.lblWheels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheels.Location = new System.Drawing.Point(69, 50);
            this.lblWheels.Name = "lblWheels";
            this.lblWheels.Size = new System.Drawing.Size(62, 18);
            this.lblWheels.TabIndex = 1;
            this.lblWheels.Text = "Wheels:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(69, 115);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 18);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblMessageOutput
            // 
            this.lblMessageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessageOutput.Enabled = false;
            this.lblMessageOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageOutput.Location = new System.Drawing.Point(72, 483);
            this.lblMessageOutput.Name = "lblMessageOutput";
            this.lblMessageOutput.Size = new System.Drawing.Size(378, 98);
            this.lblMessageOutput.TabIndex = 3;
            // 
            // txtWheels
            // 
            this.txtWheels.Location = new System.Drawing.Point(201, 50);
            this.txtWheels.Name = "txtWheels";
            this.txtWheels.Size = new System.Drawing.Size(178, 22);
            this.txtWheels.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(201, 111);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(178, 22);
            this.txtColor.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(107)))), ((int)(((byte)(223)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(211, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(107)))), ((int)(((byte)(223)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(347, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(201, 333);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(178, 22);
            this.txtModel.TabIndex = 11;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(201, 272);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(178, 22);
            this.txtMake.TabIndex = 10;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(69, 337);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 18);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(69, 272);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(49, 18);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Make:";
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(107)))), ((int)(((byte)(223)))));
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuto.Location = new System.Drawing.Point(72, 393);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(103, 28);
            this.btnAuto.TabIndex = 12;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 647);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtWheels);
            this.Controls.Add(this.lblMessageOutput);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblWheels);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWheels;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMessageOutput;
        private System.Windows.Forms.TextBox txtWheels;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Button btnAuto;
    }
}

