namespace BrokenApplication
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTxtGeneratedNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerate.Location = new System.Drawing.Point(0, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(288, 47);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate random number";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTxtGeneratedNumber
            // 
            this.lblTxtGeneratedNumber.AutoSize = true;
            this.lblTxtGeneratedNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTxtGeneratedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtGeneratedNumber.Location = new System.Drawing.Point(0, 47);
            this.lblTxtGeneratedNumber.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lblTxtGeneratedNumber.Name = "lblTxtGeneratedNumber";
            this.lblTxtGeneratedNumber.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblTxtGeneratedNumber.Size = new System.Drawing.Size(69, 50);
            this.lblTxtGeneratedNumber.TabIndex = 1;
            this.lblTxtGeneratedNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(0, 97);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(288, 26);
            this.txtNumber.TabIndex = 2;
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddToList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.Location = new System.Drawing.Point(0, 123);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(288, 47);
            this.btnAddToList.TabIndex = 4;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(0, 170);
            this.lbNumbers.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(288, 88);
            this.lbNumbers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 258);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label1.Size = new System.Drawing.Size(72, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Average:";
            // 
            // txtAverage
            // 
            this.txtAverage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAverage.Enabled = false;
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(0, 308);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(288, 26);
            this.txtAverage.TabIndex = 7;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(138, 268);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveSelected.TabIndex = 8;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 354);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblTxtGeneratedNumber);
            this.Controls.Add(this.btnGenerate);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTxtGeneratedNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.CheckedListBox lbNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}

