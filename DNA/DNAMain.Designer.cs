namespace DNA
{
  partial class DNAMain
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
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.showCommandsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.consoleLog = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCommandsToolStripMenuItem1,
            this.reloadToolStripMenuItem1});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(178, 48);
      // 
      // showCommandsToolStripMenuItem1
      // 
      this.showCommandsToolStripMenuItem1.Name = "showCommandsToolStripMenuItem1";
      this.showCommandsToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
      this.showCommandsToolStripMenuItem1.Text = "Show Commands...";
      this.showCommandsToolStripMenuItem1.Click += new System.EventHandler(this.showCommandsToolStripMenuItem1_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(422, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCommandsToolStripMenuItem,
            this.reloadToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // showCommandsToolStripMenuItem
      // 
      this.showCommandsToolStripMenuItem.Name = "showCommandsToolStripMenuItem";
      this.showCommandsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.showCommandsToolStripMenuItem.Text = "Show Commands...";
      this.showCommandsToolStripMenuItem.Click += new System.EventHandler(this.showCommandsToolStripMenuItem_Click);
      // 
      // reloadToolStripMenuItem
      // 
      this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
      this.reloadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.reloadToolStripMenuItem.Text = "Reload";
      this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
      // 
      // reloadToolStripMenuItem1
      // 
      this.reloadToolStripMenuItem1.Name = "reloadToolStripMenuItem1";
      this.reloadToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
      this.reloadToolStripMenuItem1.Text = "Reload...";
      this.reloadToolStripMenuItem1.Click += new System.EventHandler(this.reloadToolStripMenuItem1_Click);
      // 
      // consoleLog
      // 
      this.consoleLog.ContextMenuStrip = this.contextMenuStrip1;
      this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.consoleLog.Location = new System.Drawing.Point(0, 24);
      this.consoleLog.Name = "consoleLog";
      this.consoleLog.Size = new System.Drawing.Size(422, 533);
      this.consoleLog.TabIndex = 0;
      this.consoleLog.Text = "";
      // 
      // DNAMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 557);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.Controls.Add(this.consoleLog);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "DNAMain";
      this.Text = "Alan";
      this.Load += new System.EventHandler(this.DNAMain_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showCommandsToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem showCommandsToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem1;
    private System.Windows.Forms.RichTextBox consoleLog;
  }
}

