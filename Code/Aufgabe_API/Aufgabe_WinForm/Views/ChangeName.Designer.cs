namespace Aufgabe_WinForm.Views
{
    partial class ChangeName
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
            nameTxb = new TextBox();
            vornameTxb = new TextBox();
            nameLbl = new Label();
            vornameLbl = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // nameTxb
            // 
            nameTxb.Location = new Point(124, 36);
            nameTxb.Name = "nameTxb";
            nameTxb.Size = new Size(100, 23);
            nameTxb.TabIndex = 0;
            // 
            // vornameTxb
            // 
            vornameTxb.Location = new Point(124, 78);
            vornameTxb.Name = "vornameTxb";
            vornameTxb.Size = new Size(100, 23);
            vornameTxb.TabIndex = 1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(12, 44);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(42, 15);
            nameLbl.TabIndex = 2;
            nameLbl.Text = "Name:";
            // 
            // vornameLbl
            // 
            vornameLbl.AutoSize = true;
            vornameLbl.Location = new Point(12, 81);
            vornameLbl.Name = "vornameLbl";
            vornameLbl.Size = new Size(57, 15);
            vornameLbl.TabIndex = 3;
            vornameLbl.Text = "Vorname:";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 155);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(88, 38);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Speichern";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(147, 155);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(88, 38);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Schließen";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // ChangeName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 258);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(vornameLbl);
            Controls.Add(nameLbl);
            Controls.Add(vornameTxb);
            Controls.Add(nameTxb);
            Name = "ChangeName";
            Text = "ChangeName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTxb;
        private TextBox vornameTxb;
        private Label nameLbl;
        private Label vornameLbl;
        private Button saveBtn;
        private Button cancelBtn;
    }
}