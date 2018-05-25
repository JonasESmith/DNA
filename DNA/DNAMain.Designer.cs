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
      this.reloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.backPanel = new System.Windows.Forms.Panel();
      this.leftPanel = new System.Windows.Forms.Panel();
      this.showCommandsButton = new System.Windows.Forms.Button();
      this.addCommandButton = new System.Windows.Forms.Button();
      this.consoleLog = new System.Windows.Forms.RichTextBox();
      this.rightPanel = new System.Windows.Forms.Panel();
      this.consoleLogPanel = new System.Windows.Forms.Panel();
      this.showCommandsPanel = new System.Windows.Forms.Panel();
      this.contextMenuStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.backPanel.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.consoleLogPanel.SuspendLayout();
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
      // reloadToolStripMenuItem1
      // 
      this.reloadToolStripMenuItem1.Name = "reloadToolStripMenuItem1";
      this.reloadToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
      this.reloadToolStripMenuItem1.Text = "Reload...";
      this.reloadToolStripMenuItem1.Click += new System.EventHandler(this.reloadToolStripMenuItem1_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(963, 24);
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
      // backPanel
      // 
      this.backPanel.Controls.Add(this.rightPanel);
      this.backPanel.Controls.Add(this.leftPanel);
      this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.backPanel.Location = new System.Drawing.Point(0, 24);
      this.backPanel.Name = "backPanel";
      this.backPanel.Size = new System.Drawing.Size(963, 618);
      this.backPanel.TabIndex = 2;
      // 
      // leftPanel
      // 
      this.leftPanel.Controls.Add(this.addCommandButton);
      this.leftPanel.Controls.Add(this.showCommandsButton);
      this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftPanel.Location = new System.Drawing.Point(0, 0);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(200, 618);
      this.leftPanel.TabIndex = 1;
      // 
      // showCommandsButton
      // 
      this.showCommandsButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.showCommandsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.showCommandsButton.Location = new System.Drawing.Point(0, 0);
      this.showCommandsButton.Name = "showCommandsButton";
      this.showCommandsButton.Size = new System.Drawing.Size(200, 32);
      this.showCommandsButton.TabIndex = 0;
      this.showCommandsButton.TabStop = false;
      this.showCommandsButton.Text = "Show Commands";
      this.showCommandsButton.UseVisualStyleBackColor = true;
      this.showCommandsButton.Click += new System.EventHandler(this.showCommandsButton_Click);
      // 
      // addCommandButton
      // 
      this.addCommandButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.addCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addCommandButton.Location = new System.Drawing.Point(0, 32);
      this.addCommandButton.Name = "addCommandButton";
      this.addCommandButton.Size = new System.Drawing.Size(200, 32);
      this.addCommandButton.TabIndex = 1;
      this.addCommandButton.TabStop = false;
      this.addCommandButton.Text = "Add Command";
      this.addCommandButton.UseVisualStyleBackColor = true;
      this.addCommandButton.Click += new System.EventHandler(this.addCommandButton_Click);
      // 
      // consoleLog
      // 
      this.consoleLog.ContextMenuStrip = this.contextMenuStrip1;
      this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.consoleLog.Location = new System.Drawing.Point(0, 0);
      this.consoleLog.Name = "consoleLog";
      this.consoleLog.Size = new System.Drawing.Size(763, 618);
      this.consoleLog.TabIndex = 0;
      this.consoleLog.Text = "";
      // 
      // rightPanel
      // 
      this.rightPanel.Controls.Add(this.showCommandsPanel);
      this.rightPanel.Controls.Add(this.consoleLogPanel);
      this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rightPanel.Location = new System.Drawing.Point(200, 0);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.Size = new System.Drawing.Size(763, 618);
      this.rightPanel.TabIndex = 2;
      // 
      // consoleLogPanel
      // 
      this.consoleLogPanel.Controls.Add(this.consoleLog);
      this.consoleLogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.consoleLogPanel.Location = new System.Drawing.Point(0, 0);
      this.consoleLogPanel.Name = "consoleLogPanel";
      this.consoleLogPanel.Size = new System.Drawing.Size(763, 618);
      this.consoleLogPanel.TabIndex = 1;
      // 
      // showCommandsPanel
      // 
      this.showCommandsPanel.Dock = System.Windows.Forms.DockStyle.Right;
      this.showCommandsPanel.Location = new System.Drawing.Point(401, 0);
      this.showCommandsPanel.Name = "showCommandsPanel";
      this.showCommandsPanel.Size = new System.Drawing.Size(362, 618);
      this.showCommandsPanel.TabIndex = 2;
      this.showCommandsPanel.Visible = false;
      // 
      // DNAMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(963, 642);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.Controls.Add(this.backPanel);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "DNAMain";
      this.Text = "Alan";
      this.Load += new System.EventHandler(this.DNAMain_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.backPanel.ResumeLayout(false);
      this.leftPanel.ResumeLayout(false);
      this.rightPanel.ResumeLayout(false);
      this.consoleLogPanel.ResumeLayout(false);
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
    private System.Windows.Forms.Panel backPanel;
    private System.Windows.Forms.Panel leftPanel;
    private System.Windows.Forms.Button addCommandButton;
    private System.Windows.Forms.Button showCommandsButton;
    private System.Windows.Forms.Panel rightPanel;
    private System.Windows.Forms.Panel consoleLogPanel;
    private System.Windows.Forms.RichTextBox consoleLog;
    private System.Windows.Forms.Panel showCommandsPanel;
  }
}

