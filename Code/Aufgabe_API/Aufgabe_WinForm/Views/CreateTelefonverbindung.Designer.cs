namespace Aufgabe_WinForm.Views
{
    partial class CreateTelefonverbindung
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
            telefonverbindungLbl = new Label();
            telefonverbindungTbx = new TextBox();
            saveBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // telefonverbindungLbl
            // 
            telefonverbindungLbl.AutoSize = true;
            telefonverbindungLbl.Location = new Point(12, 21);
            telefonverbindungLbl.Name = "telefonverbindungLbl";
            telefonverbindungLbl.Size = new Size(110, 15);
            telefonverbindungLbl.TabIndex = 0;
            telefonverbindungLbl.Text = "Telefonverbindung:";
            // 
            // telefonverbindungTbx
            // 
            telefonverbindungTbx.Location = new Point(150, 18);
            telefonverbindungTbx.Name = "telefonverbindungTbx";
            telefonverbindungTbx.Size = new Size(178, 23);
            telefonverbindungTbx.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(17, 96);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(105, 32);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(223, 98);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(105, 32);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // CreateTelefonverbindung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 140);
            Controls.Add(closeBtn);
            Controls.Add(saveBtn);
            Controls.Add(telefonverbindungTbx);
            Controls.Add(telefonverbindungLbl);
            Name = "CreateTelefonverbindung";
            Text = "CreateTelefonverbindung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label telefonverbindungLbl;
        private TextBox telefonverbindungTbx;
        private Button saveBtn;
        private Button closeBtn;
    }
}