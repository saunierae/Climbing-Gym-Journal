namespace finalProject
{
    partial class mainWindow
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addClimb = new System.Windows.Forms.Button();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Climbing Journal";
            // 
            // btn_addClimb
            // 
            this.btn_addClimb.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClimb.Location = new System.Drawing.Point(28, 78);
            this.btn_addClimb.Name = "btn_addClimb";
            this.btn_addClimb.Size = new System.Drawing.Size(124, 48);
            this.btn_addClimb.TabIndex = 1;
            this.btn_addClimb.Text = "Add Climb";
            this.btn_addClimb.UseVisualStyleBackColor = true;
            this.btn_addClimb.Click += new System.EventHandler(this.btn_addClimb_Click);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(finalProject.Data);
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(158, 78);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(124, 48);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View Climbs";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(318, 174);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_addClimb);
            this.Controls.Add(this.label1);
            this.Name = "mainWindow";
            this.Text = "Climbing Journal";
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addClimb;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.Button btn_view;
    }
}

