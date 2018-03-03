namespace VideoPoint_WinFormsAsynAwait
{
    partial class MostEffectiveSalesPersonForm
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
            this.btnReportBuild = new System.Windows.Forms.Button();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.btnBackground = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportBuild
            // 
            this.btnReportBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReportBuild.Location = new System.Drawing.Point(12, 587);
            this.btnReportBuild.Name = "btnReportBuild";
            this.btnReportBuild.Size = new System.Drawing.Size(152, 41);
            this.btnReportBuild.TabIndex = 0;
            this.btnReportBuild.Text = "Raport Sekwencyjny";
            this.btnReportBuild.UseVisualStyleBackColor = true;
            this.btnReportBuild.Click += new System.EventHandler(this.btnReportBuild_Click);
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(12, 12);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.Size = new System.Drawing.Size(1186, 569);
            this.resultGrid.TabIndex = 1;
            // 
            // btnBackground
            // 
            this.btnBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackground.Location = new System.Drawing.Point(170, 587);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(152, 41);
            this.btnBackground.TabIndex = 0;
            this.btnBackground.Text = "Raport w Tle";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // MostEffectiveSalesPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 640);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnReportBuild);
            this.Name = "MostEffectiveSalesPersonForm";
            this.Text = "Most Effective Sales Person";
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportBuild;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Button btnBackground;
    }
}

