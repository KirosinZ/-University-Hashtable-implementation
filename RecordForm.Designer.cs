
namespace STRIALG_HASH
{
    partial class RecordForm
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
            this.PersonnelNumberBox = new System.Windows.Forms.TextBox();
            this.PersonnelNumberLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonnelNumberBox
            // 
            this.PersonnelNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberBox.Location = new System.Drawing.Point(202, 45);
            this.PersonnelNumberBox.Name = "PersonnelNumberBox";
            this.PersonnelNumberBox.Size = new System.Drawing.Size(205, 27);
            this.PersonnelNumberBox.TabIndex = 0;
            // 
            // PersonnelNumberLabel
            // 
            this.PersonnelNumberLabel.AutoSize = true;
            this.PersonnelNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberLabel.Location = new System.Drawing.Point(33, 48);
            this.PersonnelNumberLabel.Name = "PersonnelNumberLabel";
            this.PersonnelNumberLabel.Size = new System.Drawing.Size(163, 20);
            this.PersonnelNumberLabel.TabIndex = 1;
            this.PersonnelNumberLabel.Text = "Табельный номер:";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(142, 87);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(54, 20);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "ФИО:";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryLabel.Location = new System.Drawing.Point(12, 123);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(184, 20);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Зарплата (в рублях):";
            // 
            // FIOBox
            // 
            this.FIOBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOBox.Location = new System.Drawing.Point(202, 84);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(205, 27);
            this.FIOBox.TabIndex = 4;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryBox.Location = new System.Drawing.Point(202, 120);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(205, 27);
            this.SalaryBox.TabIndex = 5;
            // 
            // label1
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionLabel.Location = new System.Drawing.Point(95, 9);
            this.InstructionLabel.Name = "label1";
            this.InstructionLabel.Size = new System.Drawing.Size(217, 29);
            this.InstructionLabel.TabIndex = 6;
            this.InstructionLabel.Text = "Создание записи";
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(146, 167);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(114, 44);
            this.MainButton.TabIndex = 7;
            this.MainButton.Text = "Создать";
            this.MainButton.UseVisualStyleBackColor = true;
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 223);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.PersonnelNumberLabel);
            this.Controls.Add(this.PersonnelNumberBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 268);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 268);
            this.Name = "RecordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Создание записи";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PersonnelNumberBox;
        private System.Windows.Forms.Label PersonnelNumberLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Button MainButton;
    }
}