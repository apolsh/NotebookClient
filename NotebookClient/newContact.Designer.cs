namespace NotebookClient
{
    partial class NewContact
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
            this.typeCBox = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.valueTBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeCBox
            // 
            this.typeCBox.FormattingEnabled = true;
            this.typeCBox.Location = new System.Drawing.Point(12, 41);
            this.typeCBox.Name = "typeCBox";
            this.typeCBox.Size = new System.Drawing.Size(225, 21);
            this.typeCBox.TabIndex = 1;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(9, 25);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(75, 13);
            this.typeLbl.TabIndex = 2;
            this.typeLbl.Text = "Тип контакта";
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Location = new System.Drawing.Point(9, 75);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(104, 13);
            this.valueLbl.TabIndex = 3;
            this.valueLbl.Text = "Значение контакта";
            // 
            // valueTBox
            // 
            this.valueTBox.Location = new System.Drawing.Point(12, 91);
            this.valueTBox.Name = "valueTBox";
            this.valueTBox.Size = new System.Drawing.Size(225, 20);
            this.valueTBox.TabIndex = 4;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(36, 136);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 35);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "Сохранить";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(137, 136);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 35);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // newContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 195);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.valueTBox);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.typeCBox);
            this.Name = "newContact";
            this.Text = "newContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeCBox;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.TextBox valueTBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}