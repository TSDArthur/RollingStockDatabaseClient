namespace RailwayDatabaseClient
{
    partial class FrmLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoad));
            this.PicBoxLoading = new System.Windows.Forms.Label();
            this.LabelLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PicBoxLoading
            // 
            this.PicBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxLoading.Image = global::RailwayDatabaseClient.Properties.Resources.Loading;
            this.PicBoxLoading.Location = new System.Drawing.Point(1, 206);
            this.PicBoxLoading.Name = "PicBoxLoading";
            this.PicBoxLoading.Size = new System.Drawing.Size(37, 37);
            this.PicBoxLoading.TabIndex = 0;
            // 
            // LabelLoading
            // 
            this.LabelLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoading.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelLoading.Location = new System.Drawing.Point(37, 206);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.Size = new System.Drawing.Size(450, 37);
            this.LabelLoading.TabIndex = 1;
            this.LabelLoading.Text = "正在加载...";
            this.LabelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RailwayDatabaseClient.Properties.Resources.Preload;
            this.ClientSize = new System.Drawing.Size(490, 243);
            this.Controls.Add(this.LabelLoading);
            this.Controls.Add(this.PicBoxLoading);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoad";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PicBoxLoading;
        private System.Windows.Forms.Label LabelLoading;
    }
}