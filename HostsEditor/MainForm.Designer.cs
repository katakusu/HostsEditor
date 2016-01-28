namespace HostsEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNewsaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenToolStripMenuItem,
            this.FileSaveToolStripMenuItem,
            this.FileNewsaveToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // FileOpenToolStripMenuItem
            // 
            this.FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem";
            this.FileOpenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.FileOpenToolStripMenuItem.Text = "開く";
            // 
            // FileSaveToolStripMenuItem
            // 
            this.FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem";
            this.FileSaveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.FileSaveToolStripMenuItem.Text = "上書き保存";
            // 
            // FileNewsaveToolStripMenuItem
            // 
            this.FileNewsaveToolStripMenuItem.Name = "FileNewsaveToolStripMenuItem";
            this.FileNewsaveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.FileNewsaveToolStripMenuItem.Text = "名前を付けて保存";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HostsEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileNewsaveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

