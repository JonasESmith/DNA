namespace DNA
{
  partial class Commands
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgvVocab = new System.Windows.Forms.DataGridView();
      this.phraseInCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phraseOutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vocabTab = new System.Windows.Forms.TabControl();
      this.Vocabulary = new System.Windows.Forms.TabPage();
      this.Paths = new System.Windows.Forms.TabPage();
      this.dgvPaths = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Dictation = new System.Windows.Forms.TabPage();
      this.dgvDictation = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Communication = new System.Windows.Forms.TabPage();
      this.dgvCommunication = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MostUsed = new System.Windows.Forms.TabPage();
      this.dgvMost = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvVocab)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.vocabTab.SuspendLayout();
      this.Vocabulary.SuspendLayout();
      this.Paths.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPaths)).BeginInit();
      this.Dictation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDictation)).BeginInit();
      this.Communication.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCommunication)).BeginInit();
      this.MostUsed.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMost)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvVocab
      // 
      this.dgvVocab.AllowUserToAddRows = false;
      this.dgvVocab.AllowUserToDeleteRows = false;
      this.dgvVocab.AllowUserToResizeColumns = false;
      this.dgvVocab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvVocab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phraseInCol,
            this.phraseOutCol,
            this.Path});
      this.dgvVocab.ContextMenuStrip = this.contextMenuStrip1;
      this.dgvVocab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvVocab.Location = new System.Drawing.Point(3, 3);
      this.dgvVocab.Name = "dgvVocab";
      this.dgvVocab.ReadOnly = true;
      this.dgvVocab.RowHeadersVisible = false;
      this.dgvVocab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvVocab.Size = new System.Drawing.Size(713, 480);
      this.dgvVocab.TabIndex = 0;
      // 
      // phraseInCol
      // 
      this.phraseInCol.HeaderText = "Phrase in";
      this.phraseInCol.Name = "phraseInCol";
      this.phraseInCol.ReadOnly = true;
      this.phraseInCol.Width = 320;
      // 
      // phraseOutCol
      // 
      this.phraseOutCol.HeaderText = "Phrase out";
      this.phraseOutCol.Name = "phraseOutCol";
      this.phraseOutCol.ReadOnly = true;
      this.phraseOutCol.Width = 333;
      // 
      // Path
      // 
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Path.DefaultCellStyle = dataGridViewCellStyle5;
      this.Path.HeaderText = "Path";
      this.Path.Name = "Path";
      this.Path.ReadOnly = true;
      this.Path.Width = 40;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.addToolStripMenuItem.Text = "Add...";
      this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.editToolStripMenuItem.Text = "Update...";
      this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
      // 
      // removeToolStripMenuItem
      // 
      this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
      this.removeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.removeToolStripMenuItem.Text = "Remove...";
      this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
      // 
      // vocabTab
      // 
      this.vocabTab.Controls.Add(this.Vocabulary);
      this.vocabTab.Controls.Add(this.Paths);
      this.vocabTab.Controls.Add(this.Dictation);
      this.vocabTab.Controls.Add(this.Communication);
      this.vocabTab.Controls.Add(this.MostUsed);
      this.vocabTab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.vocabTab.Location = new System.Drawing.Point(0, 0);
      this.vocabTab.Name = "vocabTab";
      this.vocabTab.SelectedIndex = 0;
      this.vocabTab.Size = new System.Drawing.Size(727, 512);
      this.vocabTab.TabIndex = 2;
      // 
      // Vocabulary
      // 
      this.Vocabulary.Controls.Add(this.dgvVocab);
      this.Vocabulary.Location = new System.Drawing.Point(4, 22);
      this.Vocabulary.Name = "Vocabulary";
      this.Vocabulary.Padding = new System.Windows.Forms.Padding(3);
      this.Vocabulary.Size = new System.Drawing.Size(719, 486);
      this.Vocabulary.TabIndex = 0;
      this.Vocabulary.Text = "All Vocabulary";
      this.Vocabulary.UseVisualStyleBackColor = true;
      // 
      // Paths
      // 
      this.Paths.Controls.Add(this.dgvPaths);
      this.Paths.Location = new System.Drawing.Point(4, 22);
      this.Paths.Name = "Paths";
      this.Paths.Padding = new System.Windows.Forms.Padding(3);
      this.Paths.Size = new System.Drawing.Size(719, 486);
      this.Paths.TabIndex = 1;
      this.Paths.Text = "Paths";
      this.Paths.UseVisualStyleBackColor = true;
      // 
      // dgvPaths
      // 
      this.dgvPaths.AllowUserToAddRows = false;
      this.dgvPaths.AllowUserToDeleteRows = false;
      this.dgvPaths.AllowUserToResizeColumns = false;
      this.dgvPaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPaths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dgvPaths.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvPaths.Location = new System.Drawing.Point(3, 3);
      this.dgvPaths.Name = "dgvPaths";
      this.dgvPaths.ReadOnly = true;
      this.dgvPaths.RowHeadersVisible = false;
      this.dgvPaths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvPaths.Size = new System.Drawing.Size(713, 480);
      this.dgvPaths.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "Phrase in";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 283;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Path";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 410;
      // 
      // Dictation
      // 
      this.Dictation.Controls.Add(this.dgvDictation);
      this.Dictation.Location = new System.Drawing.Point(4, 22);
      this.Dictation.Name = "Dictation";
      this.Dictation.Padding = new System.Windows.Forms.Padding(3);
      this.Dictation.Size = new System.Drawing.Size(719, 486);
      this.Dictation.TabIndex = 2;
      this.Dictation.Text = "Dictations";
      this.Dictation.UseVisualStyleBackColor = true;
      // 
      // dgvDictation
      // 
      this.dgvDictation.AllowUserToAddRows = false;
      this.dgvDictation.AllowUserToDeleteRows = false;
      this.dgvDictation.AllowUserToResizeColumns = false;
      this.dgvDictation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDictation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
      this.dgvDictation.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvDictation.Location = new System.Drawing.Point(3, 3);
      this.dgvDictation.Name = "dgvDictation";
      this.dgvDictation.ReadOnly = true;
      this.dgvDictation.RowHeadersVisible = false;
      this.dgvDictation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDictation.Size = new System.Drawing.Size(713, 480);
      this.dgvDictation.TabIndex = 2;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "Phrase in";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 693;
      // 
      // Communication
      // 
      this.Communication.Controls.Add(this.dgvCommunication);
      this.Communication.Location = new System.Drawing.Point(4, 22);
      this.Communication.Name = "Communication";
      this.Communication.Padding = new System.Windows.Forms.Padding(3);
      this.Communication.Size = new System.Drawing.Size(719, 486);
      this.Communication.TabIndex = 3;
      this.Communication.Text = "Communication";
      this.Communication.UseVisualStyleBackColor = true;
      // 
      // dgvCommunication
      // 
      this.dgvCommunication.AllowUserToAddRows = false;
      this.dgvCommunication.AllowUserToDeleteRows = false;
      this.dgvCommunication.AllowUserToResizeColumns = false;
      this.dgvCommunication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCommunication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
      this.dgvCommunication.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvCommunication.Location = new System.Drawing.Point(3, 3);
      this.dgvCommunication.Name = "dgvCommunication";
      this.dgvCommunication.ReadOnly = true;
      this.dgvCommunication.RowHeadersVisible = false;
      this.dgvCommunication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvCommunication.Size = new System.Drawing.Size(713, 480);
      this.dgvCommunication.TabIndex = 2;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.HeaderText = "Phrase in";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Width = 343;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.HeaderText = "Phrase Out";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 350;
      // 
      // MostUsed
      // 
      this.MostUsed.Controls.Add(this.dgvMost);
      this.MostUsed.Location = new System.Drawing.Point(4, 22);
      this.MostUsed.Name = "MostUsed";
      this.MostUsed.Padding = new System.Windows.Forms.Padding(3);
      this.MostUsed.Size = new System.Drawing.Size(719, 486);
      this.MostUsed.TabIndex = 4;
      this.MostUsed.Text = "Most Used";
      this.MostUsed.UseVisualStyleBackColor = true;
      // 
      // dgvMost
      // 
      this.dgvMost.AllowUserToAddRows = false;
      this.dgvMost.AllowUserToDeleteRows = false;
      this.dgvMost.AllowUserToResizeColumns = false;
      this.dgvMost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this.dgvMost.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvMost.Location = new System.Drawing.Point(3, 3);
      this.dgvMost.Name = "dgvMost";
      this.dgvMost.ReadOnly = true;
      this.dgvMost.RowHeadersVisible = false;
      this.dgvMost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvMost.Size = new System.Drawing.Size(713, 480);
      this.dgvMost.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Phrase in";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 320;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "Phrase out";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 333;
      // 
      // dataGridViewTextBoxColumn6
      // 
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
      this.dataGridViewTextBoxColumn6.HeaderText = "Path";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 40;
      // 
      // Commands
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 512);
      this.Controls.Add(this.vocabTab);
      this.Name = "Commands";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Commands";
      this.Load += new System.EventHandler(this.Commands_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvVocab)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.vocabTab.ResumeLayout(false);
      this.Vocabulary.ResumeLayout(false);
      this.Paths.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPaths)).EndInit();
      this.Dictation.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDictation)).EndInit();
      this.Communication.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCommunication)).EndInit();
      this.MostUsed.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvMost)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvVocab;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.TabControl vocabTab;
    private System.Windows.Forms.TabPage Vocabulary;
    private System.Windows.Forms.TabPage Paths;
    private System.Windows.Forms.DataGridView dgvPaths;
    private System.Windows.Forms.TabPage Dictation;
    private System.Windows.Forms.DataGridView dgvDictation;
    private System.Windows.Forms.TabPage Communication;
    private System.Windows.Forms.DataGridView dgvCommunication;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn phraseInCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn phraseOutCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn Path;
    private System.Windows.Forms.TabPage MostUsed;
    private System.Windows.Forms.DataGridView dgvMost;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
  }
}