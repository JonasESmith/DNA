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
      this.backPanel = new System.Windows.Forms.Panel();
      this.rightPanel = new System.Windows.Forms.Panel();
      this.commandPanel = new System.Windows.Forms.Panel();
      this.showCommandsPanel = new System.Windows.Forms.Panel();
      this.showCommandsTitlePanel = new System.Windows.Forms.Panel();
      this.fillerTitleBarPanel = new System.Windows.Forms.Panel();
      this.pathTitleButton = new System.Windows.Forms.Button();
      this.phraseOutTitleButton = new System.Windows.Forms.Button();
      this.phraseinTitleButton = new System.Windows.Forms.Button();
      this.addCommandPanel = new System.Windows.Forms.Panel();
      this.addCommandLabel = new System.Windows.Forms.Label();
      this.saveCommandButton = new System.Windows.Forms.Button();
      this.exeCheckBox = new System.Windows.Forms.CheckBox();
      this.pathLabel = new System.Windows.Forms.Label();
      this.pathTextBox = new System.Windows.Forms.TextBox();
      this.phraseInLabel = new System.Windows.Forms.Label();
      this.phraseOutLabel = new System.Windows.Forms.Label();
      this.phraseOutTextBox = new System.Windows.Forms.TextBox();
      this.phraseInTextBox = new System.Windows.Forms.TextBox();
      this.consoleLogPanel = new System.Windows.Forms.Panel();
      this.consoleLog = new System.Windows.Forms.RichTextBox();
      this.leftPanel = new System.Windows.Forms.Panel();
      this.addCommandButton = new System.Windows.Forms.Button();
      this.showCommandsButton = new System.Windows.Forms.Button();
      this.conversationLogButton = new System.Windows.Forms.Button();
      this.contextMenuStrip1.SuspendLayout();
      this.backPanel.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.commandPanel.SuspendLayout();
      this.showCommandsTitlePanel.SuspendLayout();
      this.addCommandPanel.SuspendLayout();
      this.consoleLogPanel.SuspendLayout();
      this.leftPanel.SuspendLayout();
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
      // backPanel
      // 
      this.backPanel.Controls.Add(this.rightPanel);
      this.backPanel.Controls.Add(this.leftPanel);
      this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.backPanel.Location = new System.Drawing.Point(0, 0);
      this.backPanel.Name = "backPanel";
      this.backPanel.Size = new System.Drawing.Size(901, 543);
      this.backPanel.TabIndex = 2;
      // 
      // rightPanel
      // 
      this.rightPanel.Controls.Add(this.commandPanel);
      this.rightPanel.Controls.Add(this.addCommandPanel);
      this.rightPanel.Controls.Add(this.consoleLogPanel);
      this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rightPanel.Location = new System.Drawing.Point(160, 0);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.Size = new System.Drawing.Size(741, 543);
      this.rightPanel.TabIndex = 2;
      // 
      // commandPanel
      // 
      this.commandPanel.Controls.Add(this.showCommandsPanel);
      this.commandPanel.Controls.Add(this.showCommandsTitlePanel);
      this.commandPanel.Dock = System.Windows.Forms.DockStyle.Right;
      this.commandPanel.Location = new System.Drawing.Point(606, 0);
      this.commandPanel.Name = "commandPanel";
      this.commandPanel.Size = new System.Drawing.Size(135, 543);
      this.commandPanel.TabIndex = 4;
      this.commandPanel.Visible = false;
      // 
      // showCommandsPanel
      // 
      this.showCommandsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.showCommandsPanel.Location = new System.Drawing.Point(0, 32);
      this.showCommandsPanel.Name = "showCommandsPanel";
      this.showCommandsPanel.Size = new System.Drawing.Size(135, 511);
      this.showCommandsPanel.TabIndex = 2;
      this.showCommandsPanel.Visible = false;
      // 
      // showCommandsTitlePanel
      // 
      this.showCommandsTitlePanel.Controls.Add(this.fillerTitleBarPanel);
      this.showCommandsTitlePanel.Controls.Add(this.pathTitleButton);
      this.showCommandsTitlePanel.Controls.Add(this.phraseOutTitleButton);
      this.showCommandsTitlePanel.Controls.Add(this.phraseinTitleButton);
      this.showCommandsTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.showCommandsTitlePanel.Location = new System.Drawing.Point(0, 0);
      this.showCommandsTitlePanel.Name = "showCommandsTitlePanel";
      this.showCommandsTitlePanel.Size = new System.Drawing.Size(135, 32);
      this.showCommandsTitlePanel.TabIndex = 3;
      // 
      // fillerTitleBarPanel
      // 
      this.fillerTitleBarPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.fillerTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fillerTitleBarPanel.Location = new System.Drawing.Point(500, 0);
      this.fillerTitleBarPanel.Name = "fillerTitleBarPanel";
      this.fillerTitleBarPanel.Size = new System.Drawing.Size(0, 32);
      this.fillerTitleBarPanel.TabIndex = 3;
      // 
      // pathTitleButton
      // 
      this.pathTitleButton.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.pathTitleButton.Dock = System.Windows.Forms.DockStyle.Left;
      this.pathTitleButton.FlatAppearance.BorderSize = 0;
      this.pathTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.pathTitleButton.Location = new System.Drawing.Point(380, 0);
      this.pathTitleButton.Name = "pathTitleButton";
      this.pathTitleButton.Size = new System.Drawing.Size(120, 32);
      this.pathTitleButton.TabIndex = 2;
      this.pathTitleButton.Text = "Executable";
      this.pathTitleButton.UseVisualStyleBackColor = false;
      // 
      // phraseOutTitleButton
      // 
      this.phraseOutTitleButton.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.phraseOutTitleButton.Dock = System.Windows.Forms.DockStyle.Left;
      this.phraseOutTitleButton.FlatAppearance.BorderSize = 0;
      this.phraseOutTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.phraseOutTitleButton.Location = new System.Drawing.Point(157, 0);
      this.phraseOutTitleButton.Name = "phraseOutTitleButton";
      this.phraseOutTitleButton.Size = new System.Drawing.Size(223, 32);
      this.phraseOutTitleButton.TabIndex = 1;
      this.phraseOutTitleButton.Text = "Phrase out";
      this.phraseOutTitleButton.UseVisualStyleBackColor = false;
      // 
      // phraseinTitleButton
      // 
      this.phraseinTitleButton.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.phraseinTitleButton.Dock = System.Windows.Forms.DockStyle.Left;
      this.phraseinTitleButton.FlatAppearance.BorderSize = 0;
      this.phraseinTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.phraseinTitleButton.Location = new System.Drawing.Point(0, 0);
      this.phraseinTitleButton.Name = "phraseinTitleButton";
      this.phraseinTitleButton.Size = new System.Drawing.Size(157, 32);
      this.phraseinTitleButton.TabIndex = 0;
      this.phraseinTitleButton.Text = "Phrase in";
      this.phraseinTitleButton.UseVisualStyleBackColor = false;
      // 
      // addCommandPanel
      // 
      this.addCommandPanel.Controls.Add(this.addCommandLabel);
      this.addCommandPanel.Controls.Add(this.saveCommandButton);
      this.addCommandPanel.Controls.Add(this.exeCheckBox);
      this.addCommandPanel.Controls.Add(this.pathLabel);
      this.addCommandPanel.Controls.Add(this.pathTextBox);
      this.addCommandPanel.Controls.Add(this.phraseInLabel);
      this.addCommandPanel.Controls.Add(this.phraseOutLabel);
      this.addCommandPanel.Controls.Add(this.phraseOutTextBox);
      this.addCommandPanel.Controls.Add(this.phraseInTextBox);
      this.addCommandPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.addCommandPanel.Location = new System.Drawing.Point(10, 0);
      this.addCommandPanel.Name = "addCommandPanel";
      this.addCommandPanel.Size = new System.Drawing.Size(482, 543);
      this.addCommandPanel.TabIndex = 3;
      this.addCommandPanel.Visible = false;
      // 
      // addCommandLabel
      // 
      this.addCommandLabel.AutoSize = true;
      this.addCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addCommandLabel.Location = new System.Drawing.Point(73, 32);
      this.addCommandLabel.Name = "addCommandLabel";
      this.addCommandLabel.Size = new System.Drawing.Size(139, 24);
      this.addCommandLabel.TabIndex = 8;
      this.addCommandLabel.Text = "New command";
      // 
      // saveCommandButton
      // 
      this.saveCommandButton.BackColor = System.Drawing.Color.MediumAquamarine;
      this.saveCommandButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
      this.saveCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.saveCommandButton.Location = new System.Drawing.Point(512, 464);
      this.saveCommandButton.Name = "saveCommandButton";
      this.saveCommandButton.Size = new System.Drawing.Size(113, 32);
      this.saveCommandButton.TabIndex = 7;
      this.saveCommandButton.Text = "Save command";
      this.saveCommandButton.UseVisualStyleBackColor = false;
      // 
      // exeCheckBox
      // 
      this.exeCheckBox.AutoSize = true;
      this.exeCheckBox.Location = new System.Drawing.Point(78, 242);
      this.exeCheckBox.Name = "exeCheckBox";
      this.exeCheckBox.Size = new System.Drawing.Size(220, 17);
      this.exeCheckBox.TabIndex = 6;
      this.exeCheckBox.Text = "Does the phrase execute an application?";
      this.exeCheckBox.UseVisualStyleBackColor = true;
      this.exeCheckBox.CheckedChanged += new System.EventHandler(this.exeCheckBox_CheckedChanged);
      // 
      // pathLabel
      // 
      this.pathLabel.AutoSize = true;
      this.pathLabel.Enabled = false;
      this.pathLabel.Location = new System.Drawing.Point(75, 292);
      this.pathLabel.Name = "pathLabel";
      this.pathLabel.Size = new System.Drawing.Size(96, 13);
      this.pathLabel.TabIndex = 5;
      this.pathLabel.Text = "Path to executable";
      // 
      // pathTextBox
      // 
      this.pathTextBox.Enabled = false;
      this.pathTextBox.Location = new System.Drawing.Point(78, 308);
      this.pathTextBox.Name = "pathTextBox";
      this.pathTextBox.Size = new System.Drawing.Size(547, 20);
      this.pathTextBox.TabIndex = 4;
      // 
      // phraseInLabel
      // 
      this.phraseInLabel.AutoSize = true;
      this.phraseInLabel.Location = new System.Drawing.Point(75, 89);
      this.phraseInLabel.Name = "phraseInLabel";
      this.phraseInLabel.Size = new System.Drawing.Size(66, 13);
      this.phraseInLabel.TabIndex = 3;
      this.phraseInLabel.Text = "Input phrase";
      // 
      // phraseOutLabel
      // 
      this.phraseOutLabel.AutoSize = true;
      this.phraseOutLabel.Location = new System.Drawing.Point(75, 173);
      this.phraseOutLabel.Name = "phraseOutLabel";
      this.phraseOutLabel.Size = new System.Drawing.Size(74, 13);
      this.phraseOutLabel.TabIndex = 2;
      this.phraseOutLabel.Text = "Output phrase";
      // 
      // phraseOutTextBox
      // 
      this.phraseOutTextBox.Location = new System.Drawing.Point(78, 189);
      this.phraseOutTextBox.Name = "phraseOutTextBox";
      this.phraseOutTextBox.Size = new System.Drawing.Size(547, 20);
      this.phraseOutTextBox.TabIndex = 1;
      // 
      // phraseInTextBox
      // 
      this.phraseInTextBox.Location = new System.Drawing.Point(78, 105);
      this.phraseInTextBox.Name = "phraseInTextBox";
      this.phraseInTextBox.Size = new System.Drawing.Size(547, 20);
      this.phraseInTextBox.TabIndex = 0;
      // 
      // consoleLogPanel
      // 
      this.consoleLogPanel.Controls.Add(this.consoleLog);
      this.consoleLogPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.consoleLogPanel.Location = new System.Drawing.Point(0, 0);
      this.consoleLogPanel.Name = "consoleLogPanel";
      this.consoleLogPanel.Size = new System.Drawing.Size(10, 543);
      this.consoleLogPanel.TabIndex = 1;
      // 
      // consoleLog
      // 
      this.consoleLog.ContextMenuStrip = this.contextMenuStrip1;
      this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.consoleLog.Location = new System.Drawing.Point(0, 0);
      this.consoleLog.Name = "consoleLog";
      this.consoleLog.Size = new System.Drawing.Size(10, 543);
      this.consoleLog.TabIndex = 0;
      this.consoleLog.Text = "";
      // 
      // leftPanel
      // 
      this.leftPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.leftPanel.Controls.Add(this.addCommandButton);
      this.leftPanel.Controls.Add(this.showCommandsButton);
      this.leftPanel.Controls.Add(this.conversationLogButton);
      this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftPanel.Location = new System.Drawing.Point(0, 0);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(160, 543);
      this.leftPanel.TabIndex = 1;
      // 
      // addCommandButton
      // 
      this.addCommandButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.addCommandButton.FlatAppearance.BorderSize = 0;
      this.addCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addCommandButton.Location = new System.Drawing.Point(0, 64);
      this.addCommandButton.Name = "addCommandButton";
      this.addCommandButton.Size = new System.Drawing.Size(160, 32);
      this.addCommandButton.TabIndex = 1;
      this.addCommandButton.TabStop = false;
      this.addCommandButton.Text = "Add Command";
      this.addCommandButton.UseVisualStyleBackColor = true;
      this.addCommandButton.Click += new System.EventHandler(this.addCommandButton_Click);
      // 
      // showCommandsButton
      // 
      this.showCommandsButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.showCommandsButton.FlatAppearance.BorderSize = 0;
      this.showCommandsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.showCommandsButton.Location = new System.Drawing.Point(0, 32);
      this.showCommandsButton.Name = "showCommandsButton";
      this.showCommandsButton.Size = new System.Drawing.Size(160, 32);
      this.showCommandsButton.TabIndex = 0;
      this.showCommandsButton.TabStop = false;
      this.showCommandsButton.Text = "Show Commands";
      this.showCommandsButton.UseVisualStyleBackColor = true;
      this.showCommandsButton.Click += new System.EventHandler(this.showCommandsButton_Click);
      // 
      // conversationLogButton
      // 
      this.conversationLogButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.conversationLogButton.FlatAppearance.BorderSize = 0;
      this.conversationLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.conversationLogButton.Location = new System.Drawing.Point(0, 0);
      this.conversationLogButton.Name = "conversationLogButton";
      this.conversationLogButton.Size = new System.Drawing.Size(160, 32);
      this.conversationLogButton.TabIndex = 2;
      this.conversationLogButton.TabStop = false;
      this.conversationLogButton.Text = "Conversation Log";
      this.conversationLogButton.UseVisualStyleBackColor = true;
      this.conversationLogButton.Click += new System.EventHandler(this.showConsoleButton_Click);
      // 
      // DNAMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(901, 543);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.Controls.Add(this.backPanel);
      this.MinimumSize = new System.Drawing.Size(600, 580);
      this.Name = "DNAMain";
      this.Text = "DNA";
      this.Load += new System.EventHandler(this.DNAMain_Load);
      this.ResizeEnd += new System.EventHandler(this.DNAMain_ResizeEnd);
      this.contextMenuStrip1.ResumeLayout(false);
      this.backPanel.ResumeLayout(false);
      this.rightPanel.ResumeLayout(false);
      this.commandPanel.ResumeLayout(false);
      this.showCommandsTitlePanel.ResumeLayout(false);
      this.addCommandPanel.ResumeLayout(false);
      this.addCommandPanel.PerformLayout();
      this.consoleLogPanel.ResumeLayout(false);
      this.leftPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem showCommandsToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem1;
    private System.Windows.Forms.Panel backPanel;
    private System.Windows.Forms.Panel leftPanel;
    private System.Windows.Forms.Button addCommandButton;
    private System.Windows.Forms.Button showCommandsButton;
    private System.Windows.Forms.Panel rightPanel;
    private System.Windows.Forms.Panel consoleLogPanel;
    private System.Windows.Forms.RichTextBox consoleLog;
    private System.Windows.Forms.Panel showCommandsPanel;
    private System.Windows.Forms.Panel addCommandPanel;
    private System.Windows.Forms.Label phraseInLabel;
    private System.Windows.Forms.Label phraseOutLabel;
    private System.Windows.Forms.TextBox phraseOutTextBox;
    private System.Windows.Forms.TextBox phraseInTextBox;
    private System.Windows.Forms.Label pathLabel;
    private System.Windows.Forms.TextBox pathTextBox;
    private System.Windows.Forms.CheckBox exeCheckBox;
    private System.Windows.Forms.Button conversationLogButton;
    private System.Windows.Forms.Button saveCommandButton;
    private System.Windows.Forms.Panel commandPanel;
    private System.Windows.Forms.Panel showCommandsTitlePanel;
    private System.Windows.Forms.Button pathTitleButton;
    private System.Windows.Forms.Button phraseOutTitleButton;
    private System.Windows.Forms.Button phraseinTitleButton;
    private System.Windows.Forms.Panel fillerTitleBarPanel;
    private System.Windows.Forms.Label addCommandLabel;
  }
}

