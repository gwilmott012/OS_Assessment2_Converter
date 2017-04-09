namespace ConverterApp
{
    partial class frm_Main
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
            this.txt_UnitOfMeasure = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.lbl_Convert = new System.Windows.Forms.Label();
            this.txt_Convert = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.cbSelectCalculation = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_UnitOfMeasure
            // 
            this.txt_UnitOfMeasure.Location = new System.Drawing.Point(181, 34);
            this.txt_UnitOfMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UnitOfMeasure.Name = "txt_UnitOfMeasure";
            this.txt_UnitOfMeasure.Size = new System.Drawing.Size(76, 20);
            this.txt_UnitOfMeasure.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(467, 373);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(56, 19);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "&EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Display
            // 
            this.lbl_Display.Location = new System.Drawing.Point(24, 56);
            this.lbl_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Display.Size = new System.Drawing.Size(163, 20);
            this.lbl_Display.TabIndex = 5;
            this.lbl_Display.Text = "lbl_Display";
            this.lbl_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Convert
            // 
            this.lbl_Convert.AutoSize = true;
            this.lbl_Convert.Location = new System.Drawing.Point(260, 60);
            this.lbl_Convert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Convert.Name = "lbl_Convert";
            this.lbl_Convert.Size = new System.Drawing.Size(0, 13);
            this.lbl_Convert.TabIndex = 6;
            // 
            // txt_Convert
            // 
            this.txt_Convert.Location = new System.Drawing.Point(191, 56);
            this.txt_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Convert.Name = "txt_Convert";
            this.txt_Convert.ReadOnly = true;
            this.txt_Convert.Size = new System.Drawing.Size(54, 20);
            this.txt_Convert.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInstruction1);
            this.panel1.Controls.Add(this.txt_UnitOfMeasure);
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 58);
            this.panel1.TabIndex = 11;
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.Location = new System.Drawing.Point(2, 0);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(434, 32);
            this.lblInstruction1.TabIndex = 2;
            this.lblInstruction1.Text = "1. Input metric value to be converted";
            this.lblInstruction1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectCalculation
            // 
            this.cbSelectCalculation.FormattingEnabled = true;
            this.cbSelectCalculation.Location = new System.Drawing.Point(99, 58);
            this.cbSelectCalculation.Name = "cbSelectCalculation";
            this.cbSelectCalculation.Size = new System.Drawing.Size(232, 21);
            this.cbSelectCalculation.TabIndex = 12;
            this.cbSelectCalculation.SelectedIndexChanged += new System.EventHandler(this.cbSelectCalculation_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblInstruction2);
            this.panel2.Controls.Add(this.cbSelectCalculation);
            this.panel2.Location = new System.Drawing.Point(43, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 84);
            this.panel2.TabIndex = 13;
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(3, 0);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(433, 23);
            this.lblInstruction2.TabIndex = 13;
            this.lblInstruction2.Text = "2. Choose measurement to be converted by.";
            this.lblInstruction2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblInstruction3);
            this.panel3.Controls.Add(this.lbl_Display);
            this.panel3.Controls.Add(this.lbl_Convert);
            this.panel3.Controls.Add(this.txt_Convert);
            this.panel3.Location = new System.Drawing.Point(43, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 89);
            this.panel3.TabIndex = 3;
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction3.Location = new System.Drawing.Point(4, 0);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(433, 27);
            this.lblInstruction3.TabIndex = 8;
            this.lblInstruction3.Text = "3. Output imperial value";
            this.lblInstruction3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 413);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_UnitOfMeasure;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.Label lbl_Convert;
        private System.Windows.Forms.TextBox txt_Convert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSelectCalculation;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInstruction3;
    }
}

