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
            PersonDataGrid.Size = new Size(601, 23);
            PersonDataGrid.TabIndex = 0;
            // 
            // AnschriftenDataGrid
            // 
            AnschriftenDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnschriftenDataGrid.Location = new Point(12, 85);
            AnschriftenDataGrid.Name = "AnschriftenDataGrid";
            AnschriftenDataGrid.Size = new Size(601, 150);
            AnschriftenDataGrid.TabIndex = 1;
            // 
            // TelefonDataGrid
            // 
            TelefonDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TelefonDataGrid.Location = new Point(12, 262);
            TelefonDataGrid.Name = "TelefonDataGrid";
            TelefonDataGrid.Size = new Size(601, 150);
            TelefonDataGrid.TabIndex = 2;
            // 
            // PersonDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}