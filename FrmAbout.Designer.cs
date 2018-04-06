namespace RailwayDatabaseClient
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.TxtBoxAbout = new System.Windows.Forms.RichTextBox();
            this.ButtLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxAbout
            // 
            this.TxtBoxAbout.BackColor = System.Drawing.Color.White;
            this.TxtBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxAbout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtBoxAbout.Location = new System.Drawing.Point(12, 207);
            this.TxtBoxAbout.Name = "TxtBoxAbout";
            this.TxtBoxAbout.ReadOnly = true;
            this.TxtBoxAbout.Size = new System.Drawing.Size(450, 79);
            this.TxtBoxAbout.TabIndex = 0;
            this.TxtBoxAbout.Text = "该车辆型号数据库由SWJTU的铁路爱好者收集，数据仅供参考。\n蒸汽，燃气轮机车：张目华\n内燃机车：耿昊然\n电力机车：耿昊然\n动车（包括普通和第六次大提速后的）：苏" +
    "启明\n客车：苏启明\n货车：吴承睿\n工程车，检测车类：苏启明\n城市轨道交通，市域动车组：吴承睿\n程序版本：0.1c";
            // 
            // ButtLogin
            // 
            this.ButtLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtLogin.Image = global::RailwayDatabaseClient.Properties.Resources.Help;
            this.ButtLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtLogin.Location = new System.Drawing.Point(340, 293);
            this.ButtLogin.Name = "ButtLogin";
            this.ButtLogin.Size = new System.Drawing.Size(122, 27);
            this.ButtLogin.TabIndex = 17;
            this.ButtLogin.Text = "确定";
            this.ButtLogin.UseVisualStyleBackColor = true;
            this.ButtLogin.Click += new System.EventHandler(this.ButtLogin_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RailwayDatabaseClient.Properties.Resources.Preload;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(474, 331);
            this.Controls.Add(this.ButtLogin);
            this.Controls.Add(this.TxtBoxAbout);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtBoxAbout;
        private System.Windows.Forms.Button ButtLogin;
    }
}