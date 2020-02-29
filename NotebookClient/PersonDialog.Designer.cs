namespace NotebookClient
{
    partial class PersonDialog
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
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.firstnameTxtBox = new System.Windows.Forms.TextBox();
            this.secondnameTxtBox = new System.Windows.Forms.TextBox();
            this.secondnameLbl = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Location = new System.Drawing.Point(9, 15);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(29, 13);
            this.firstnameLbl.TabIndex = 0;
            this.firstnameLbl.Text = "Имя";
            // 
            // firstnameTxtBox
            // 
            this.firstnameTxtBox.Location = new System.Drawing.Point(68, 12);
            this.firstnameTxtBox.Name = "firstnameTxtBox";
            this.firstnameTxtBox.Size = new System.Drawing.Size(188, 20);
            this.firstnameTxtBox.TabIndex = 1;
            // 
            // secondnameTxtBox
            // 
            this.secondnameTxtBox.Location = new System.Drawing.Point(68, 43);
            this.secondnameTxtBox.Name = "secondnameTxtBox";
            this.secondnameTxtBox.Size = new System.Drawing.Size(188, 20);
            this.secondnameTxtBox.TabIndex = 3;
            // 
            // secondnameLbl
            // 
            this.secondnameLbl.AutoSize = true;
            this.secondnameLbl.Location = new System.Drawing.Point(9, 46);
            this.secondnameLbl.Name = "secondnameLbl";
            this.secondnameLbl.Size = new System.Drawing.Size(56, 13);
            this.secondnameLbl.TabIndex = 2;
            this.secondnameLbl.Text = "Фамилия";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(99, 74);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(157, 20);
            this.birthdayPicker.TabIndex = 4;
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.Location = new System.Drawing.Point(9, 80);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(87, 13);
            this.birthdayLbl.TabIndex = 5;
            this.birthdayLbl.Text = "День рождения";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(155, 121);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 39);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 121);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 39);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // newContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 169);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.birthdayLbl);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.secondnameTxtBox);
            this.Controls.Add(this.secondnameLbl);
            this.Controls.Add(this.firstnameTxtBox);
            this.Controls.Add(this.firstnameLbl);
            this.Name = "newContact";
            this.Text = "newContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnameLbl;
        private System.Windows.Forms.TextBox firstnameTxtBox;
        private System.Windows.Forms.TextBox secondnameTxtBox;
        private System.Windows.Forms.Label secondnameLbl;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
    }
}