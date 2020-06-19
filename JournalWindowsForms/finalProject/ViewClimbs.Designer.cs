namespace finalProject
{
    partial class ViewClimbs
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
            this.dataGrid_climbs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_climbs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_climbs
            // 
            this.dataGrid_climbs.AllowUserToDeleteRows = false;
            this.dataGrid_climbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_climbs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_climbs.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_climbs.Name = "dataGrid_climbs";
            this.dataGrid_climbs.ReadOnly = true;
            this.dataGrid_climbs.RowHeadersVisible = false;
            this.dataGrid_climbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_climbs.Size = new System.Drawing.Size(692, 227);
            this.dataGrid_climbs.TabIndex = 0;
            this.dataGrid_climbs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_climbs_CellContentDoubleClick);
            // 
            // ViewClimbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 251);
            this.Controls.Add(this.dataGrid_climbs);
            this.Name = "ViewClimbs";
            this.Text = "ViewClimbs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_climbs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_climbs;
    }
}