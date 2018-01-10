namespace DNA
{
  partial class AddUpdateDialog
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
      this.phraseInLabel = new System.Windows.Forms.Label();
      this.phraseOutLabel = new System.Windows.Forms.Label();
      this.phraseInTxtBox = new System.Windows.Forms.TextBox();
      this.phraseOutTxtBox = new System.Windows.Forms.TextBox();
      this.urlCheck = new System.Windows.Forms.CheckBox();
      this.pathLabel = new System.Windows.Forms.Label();
      this.pathTxtBox = new System.Windows.Forms.TextBox();
      this.okButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // phraseInLabel
      // 
      this.phraseInLabel.AutoSize = true;
      this.phraseInLabel.Location = new System.Drawing.Point(12, 9);
      this.phraseInLabel.Name = "phraseInLabel";
      this.phraseInLabel.Size = new System.Drawing.Size(52, 13);
      this.phraseInLabel.TabIndex = 0;
      this.phraseInLabel.Text = "Phrase In";
      // 
      // phraseOutLabel
      // 
      this.phraseOutLabel.AutoSize = true;
      this.phraseOutLabel.Location = new System.Drawing.Point(11, 48);
      this.phraseOutLabel.Name = "phraseOutLabel";
      this.phraseOutLabel.Size = new System.Drawing.Size(60, 13);
      this.phraseOutLabel.TabIndex = 1;
      this.phraseOutLabel.Text = "Phrase Out";
      // 
      // phraseInTxtBox
      // 
      this.phraseInTxtBox.Location = new System.Drawing.Point(12, 25);
      this.phraseInTxtBox.Name = "phraseInTxtBox";
      this.phraseInTxtBox.Size = new System.Drawing.Size(269, 20);
      this.phraseInTxtBox.TabIndex = 2;
      // 
      // phraseOutTxtBox
      // 
      this.phraseOutTxtBox.Location = new System.Drawing.Point(12, 64);
      this.phraseOutTxtBox.Name = "phraseOutTxtBox";
      this.phraseOutTxtBox.Size = new System.Drawing.Size(269, 20);
      this.phraseOutTxtBox.TabIndex = 3;
      // 
      // urlCheck
      // 
      this.urlCheck.AutoSize = true;
      this.urlCheck.Location = new System.Drawing.Point(305, 26);
      this.urlCheck.Name = "urlCheck";
      this.urlCheck.Size = new System.Drawing.Size(48, 17);
      this.urlCheck.TabIndex = 4;
      this.urlCheck.Text = "Path";
      this.urlCheck.UseVisualStyleBackColor = true;
      this.urlCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // pathLabel
      // 
      this.pathLabel.AutoSize = true;
      this.pathLabel.Location = new System.Drawing.Point(12, 104);
      this.pathLabel.Name = "pathLabel";
      this.pathLabel.Size = new System.Drawing.Size(122, 13);
      this.pathLabel.TabIndex = 5;
      this.pathLabel.Text = "Executable Path or URL";
      // 
      // pathTxtBox
      // 
      this.pathTxtBox.Location = new System.Drawing.Point(12, 121);
      this.pathTxtBox.Name = "pathTxtBox";
      this.pathTxtBox.Size = new System.Drawing.Size(269, 20);
      this.pathTxtBox.TabIndex = 6;
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(298, 61);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(63, 23);
      this.okButton.TabIndex = 7;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // AddUpdateDialog
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 101);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.pathTxtBox);
      this.Controls.Add(this.pathLabel);
      this.Controls.Add(this.urlCheck);
      this.Controls.Add(this.phraseOutTxtBox);
      this.Controls.Add(this.phraseInTxtBox);
      this.Controls.Add(this.phraseOutLabel);
      this.Controls.Add(this.phraseInLabel);
      this.MaximumSize = new System.Drawing.Size(400, 190);
      this.MinimumSize = new System.Drawing.Size(400, 140);
      this.Name = "AddUpdateDialog";
      this.Text = "AddUpdateDialog";
      this.Load += new System.EventHandler(this.AddUpdateDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label phraseInLabel;
    private System.Windows.Forms.Label phraseOutLabel;
    private System.Windows.Forms.TextBox phraseInTxtBox;
    private System.Windows.Forms.TextBox phraseOutTxtBox;
    private System.Windows.Forms.CheckBox urlCheck;
    private System.Windows.Forms.Label pathLabel;
    private System.Windows.Forms.TextBox pathTxtBox;
    private System.Windows.Forms.Button okButton;
  }
}