namespace Aufgabe_WinForm.Views
{
    partial class CreateAnschrift
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
            postleitzahlLbl = new Label();
            ortLbl = new Label();
            strasseLbl = new Label();
            hausnummerLbl = new Label();
            postleitzahlTxb = new TextBox();
            ortTbx = new TextBox();
            strasseTbx = new TextBox();
            hausnummerTbx = new TextBox();
            saveBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // postleitzahlLbl
            // 
            postleitzahlLbl.AutoSize = true;
            postleitzahlLbl.Location = new Point(26, 140);
            postleitzahlLbl.Name = "postleitzahlLbl";
            postleitzahlLbl.Size = new Size(70, 15);
            postleitzahlLbl.TabIndex = 0;
            postleitzahlLbl.Text = "Postleitzahl:";
            // 
            // ortLbl
            // 
            ortLbl.AutoSize = true;
            ortLbl.Location = new Point(26, 108);
            ortLbl.Name = "ortLbl";
            ortLbl.Size = new Size(27, 15);
            ortLbl.TabIndex = 1;
            ortLbl.Text = "Ort:";
            // 
            // strasseLbl
            // 
            strasseLbl.AutoSize = true;
            strasseLbl.Location = new Point(26, 41);
            strasseLbl.Name = "strasseLbl";
            strasseLbl.Size = new Size(43, 15);
            strasseLbl.TabIndex = 2;
            strasseLbl.Text = "Straße:";
            // 
            // hausnummerLbl
            // 
            hausnummerLbl.AutoSize = true;
            hausnummerLbl.Location = new Point(26, 75);
            hausnummerLbl.Name = "hausnummerLbl";
            hausnummerLbl.Size = new Size(83, 15);
            hausnummerLbl.TabIndex = 3;
            hausnummerLbl.Text = "Hausnummer:";
            // 
            // postleitzahlTxb
            // 
            postleitzahlTxb.Location = new Point(115, 132);
            postleitzahlTxb.Name = "postleitzahlTxb";
            postleitzahlTxb.Size = new Size(177, 23);
            postleitzahlTxb.TabIndex = 4;
            // 
            // ortTbx
            // 
            ortTbx.Location = new Point(115, 100);
            ortTbx.Name = "ortTbx";
            ortTbx.Size = new Size(177, 23);
            ortTbx.TabIndex = 3;
            // 
            // strasseTbx
            // 
            strasseTbx.Location = new Point(115, 33);
            strasseTbx.Name = "strasseTbx";
            strasseTbx.Size = new Size(177, 23);
            strasseTbx.TabIndex = 1;
            // 
            // hausnummerTbx
            // 
            hausnummerTbx.Location = new Point(115, 67);
            hausnummerTbx.Name = "hausnummerTbx";
            hausnummerTbx.Size = new Size(177, 23);
            hausnummerTbx.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(26, 209);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(109, 44);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Speichern";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(183, 209);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(109, 44);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Schließen";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // CreateAnschrift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 289);
            Controls.Add(closeBtn);
            Controls.Add(saveBtn);
            Controls.Add(hausnummerTbx);
            Controls.Add(strasseTbx);
            Controls.Add(ortTbx);
            Controls.Add(postleitzahlTxb);
            Controls.Add(hausnummerLbl);
            Controls.Add(strasseLbl);
            Controls.Add(ortLbl);
            Controls.Add(postleitzahlLbl);
            Name = "CreateAnschrift";
            Text = "CreateAnschrift";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label postleitzahlLbl;
        private Label ortLbl;
        private Label strasseLbl;
        private Label hausnummerLbl;
        private TextBox postleitzahlTxb;
        private TextBox ortTbx;
        private TextBox strasseTbx;
        private TextBox hausnummerTbx;
        private Button saveBtn;
        private Button closeBtn;
    }
}