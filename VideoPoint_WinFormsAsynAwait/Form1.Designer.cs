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
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnIAsyncResult = new System.Windows.Forms.Button();
            this.btnNewThread = new System.Windows.Forms.Button();
            this.btnSynchronisationContext = new System.Windows.Forms.Button();
            this.btnBeginInvoke = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnAsync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportBuild
            // 
            this.btnReportBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReportBuild.Location = new System.Drawing.Point(12, 587);
            this.btnReportBuild.Name = "btnReportBuild";
            this.btnReportBuild.Size = new System.Drawing.Size(100, 40);
            this.btnReportBuild.TabIndex = 0;
            this.btnReportBuild.Text = "Raport Sekwencyjny";
            this.btnReportBuild.UseVisualStyleBackColor = true;
            this.btnReportBuild.Click += new System.EventHandler(this.btnReportBuild_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 41);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(1186, 540);
            this.grid.TabIndex = 1;
            // 
            // btnBackground
            // 
            this.btnBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackground.Location = new System.Drawing.Point(330, 588);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(100, 40);
            this.btnBackground.TabIndex = 0;
            this.btnBackground.Text = "Raport w Tle";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // btnIAsyncResult
            // 
            this.btnIAsyncResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIAsyncResult.Location = new System.Drawing.Point(224, 587);
            this.btnIAsyncResult.Name = "btnIAsyncResult";
            this.btnIAsyncResult.Size = new System.Drawing.Size(100, 40);
            this.btnIAsyncResult.TabIndex = 2;
            this.btnIAsyncResult.Text = "Raport Asynchroniczny";
            this.btnIAsyncResult.UseVisualStyleBackColor = true;
            this.btnIAsyncResult.Click += new System.EventHandler(this.btnIAsyncResult_Click);
            // 
            // btnNewThread
            // 
            this.btnNewThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewThread.Location = new System.Drawing.Point(118, 588);
            this.btnNewThread.Name = "btnNewThread";
            this.btnNewThread.Size = new System.Drawing.Size(100, 40);
            this.btnNewThread.TabIndex = 3;
            this.btnNewThread.Text = "Raport w nowym wątku";
            this.btnNewThread.UseVisualStyleBackColor = true;
            this.btnNewThread.Click += new System.EventHandler(this.btnNewThread_Click);
            // 
            // btnSynchronisationContext
            // 
            this.btnSynchronisationContext.Location = new System.Drawing.Point(437, 588);
            this.btnSynchronisationContext.Name = "btnSynchronisationContext";
            this.btnSynchronisationContext.Size = new System.Drawing.Size(100, 40);
            this.btnSynchronisationContext.TabIndex = 4;
            this.btnSynchronisationContext.Text = "Kontekst Synchronizacji";
            this.btnSynchronisationContext.UseVisualStyleBackColor = true;
            this.btnSynchronisationContext.Click += new System.EventHandler(this.btnSynchronisationContext_Click);
            // 
            // btnBeginInvoke
            // 
            this.btnBeginInvoke.Location = new System.Drawing.Point(544, 588);
            this.btnBeginInvoke.Name = "btnBeginInvoke";
            this.btnBeginInvoke.Size = new System.Drawing.Size(100, 40);
            this.btnBeginInvoke.TabIndex = 5;
            this.btnBeginInvoke.Text = "Synchronizacja z UI";
            this.btnBeginInvoke.UseVisualStyleBackColor = true;
            this.btnBeginInvoke.Click += new System.EventHandler(this.btnBeginInvoke_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Maximum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1186, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(651, 587);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(100, 40);
            this.btnAsync.TabIndex = 7;
            this.btnAsync.Text = "Async/Await";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // MostEffectiveSalesPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 640);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBeginInvoke);
            this.Controls.Add(this.btnSynchronisationContext);
            this.Controls.Add(this.btnNewThread);
            this.Controls.Add(this.btnIAsyncResult);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnReportBuild);
            this.Name = "MostEffectiveSalesPersonForm";
            this.Text = "Most Effective Sales Person";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportBuild;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnIAsyncResult;
        private System.Windows.Forms.Button btnNewThread;
        private System.Windows.Forms.Button btnSynchronisationContext;
        private System.Windows.Forms.Button btnBeginInvoke;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnAsync;
    }
}

