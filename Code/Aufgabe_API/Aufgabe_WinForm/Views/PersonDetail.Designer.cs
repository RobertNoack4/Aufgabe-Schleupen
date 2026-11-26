namespace Aufgabe_WinForm
{
    partial class PersonDetail
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
            PersonDataGrid = new DataGridView();
            AnschriftenDataGrid = new DataGridView();
            TelefonDataGrid = new DataGridView();
            nameChangeBtn = new Button();
            createAnschriftBtn = new Button();
            createTelefonverbindungBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnschriftenDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TelefonDataGrid).BeginInit();
            SuspendLayout();
            // 
            // PersonDataGrid
            // 
            PersonDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonDataGrid.Location = new Point(12, 30);
            PersonDataGrid.Name = "PersonDataGrid";
            PersonDataGrid.Size = new Size(601, 66);
            PersonDataGrid.TabIndex = 0;
            // 
            // AnschriftenDataGrid
            // 
            AnschriftenDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnschriftenDataGrid.Location = new Point(12, 102);
            AnschriftenDataGrid.Name = "AnschriftenDataGrid";
            AnschriftenDataGrid.Size = new Size(601, 154);
            AnschriftenDataGrid.TabIndex = 1;
            AnschriftenDataGrid.CellContentClick += AnschriftenDataGrid_CellContentClick;
            // 
            // TelefonDataGrid
            // 
            TelefonDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TelefonDataGrid.Location = new Point(12, 262);
            TelefonDataGrid.Name = "TelefonDataGrid";
            TelefonDataGrid.Size = new Size(601, 150);
            TelefonDataGrid.TabIndex = 2;
            TelefonDataGrid.CellContentClick += TelefonDataGrid_CellContentClick;
            // 
            // nameChangeBtn
            // 
            nameChangeBtn.Location = new Point(658, 30);
            nameChangeBtn.Name = "nameChangeBtn";
            nameChangeBtn.Size = new Size(130, 40);
            nameChangeBtn.TabIndex = 3;
            nameChangeBtn.Text = "Name ändern";
            nameChangeBtn.UseVisualStyleBackColor = true;
            nameChangeBtn.Click += nameChangeBtn_Click;
            // 
            // createAnschriftBtn
            // 
            createAnschriftBtn.Location = new Point(658, 89);
            createAnschriftBtn.Name = "createAnschriftBtn";
            createAnschriftBtn.Size = new Size(130, 42);
            createAnschriftBtn.TabIndex = 4;
            createAnschriftBtn.Text = "Anschrift erstellen";
            createAnschriftBtn.UseVisualStyleBackColor = true;
            createAnschriftBtn.Click += createAnschriftBtn_Click;
            // 
            // createTelefonverbindungBtn
            // 
            createTelefonverbindungBtn.Location = new Point(658, 151);
            createTelefonverbindungBtn.Name = "createTelefonverbindungBtn";
            createTelefonverbindungBtn.Size = new Size(130, 49);
            createTelefonverbindungBtn.TabIndex = 5;
            createTelefonverbindungBtn.Text = "Telefonverbindung erstellen";
            createTelefonverbindungBtn.UseVisualStyleBackColor = true;
            createTelefonverbindungBtn.Click += createTelefonverbindungBtn_Click;
            // 
            // PersonDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createTelefonverbindungBtn);
            Controls.Add(createAnschriftBtn);
            Controls.Add(nameChangeBtn);
            Controls.Add(TelefonDataGrid);
            Controls.Add(AnschriftenDataGrid);
            Controls.Add(PersonDataGrid);
            Name = "PersonDetail";
            Text = "PersonDetail";
            ((System.ComponentModel.ISupportInitialize)PersonDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnschriftenDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TelefonDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PersonDataGrid;
        private DataGridView AnschriftenDataGrid;
        private DataGridView TelefonDataGrid;
        private Button nameChangeBtn;
        private Button createAnschriftBtn;
        private Button createTelefonverbindungBtn;
    }
}