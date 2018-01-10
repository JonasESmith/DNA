using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNA
{
  public partial class AddUpdateDialog : Form
  {
    private Vocab vocab;

    public AddUpdateDialog()
    {
      InitializeComponent();
    }

    private void AddUpdateDialog_Load(object sender, EventArgs e)
    {
      this.vocab = (Vocab) this.Tag;
      this.phraseInTxtBox.Text = this.vocab.PhraseIn.ToString();
      this.phraseOutTxtBox.Text = this.vocab.PhraseOut.ToString();
      if (!(string.IsNullOrWhiteSpace(vocab.URL)))
      {
        this.urlCheck.Checked = true;
        this.pathTxtBox.Text = this.vocab.URL.ToString();
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

      // updates form sizes to adjust for the textbox "hidden" if checkbox = true
      if(urlCheck.Checked)
      {
        this.Size = new Size(400, 190);
      }
      else
      {
        this.Size = new Size(400, 140);
      }
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;

      if (!(string.IsNullOrWhiteSpace(phraseInTxtBox.Text)))
      {
        this.vocab.PhraseIn  = phraseInTxtBox.Text;
        this.vocab.PhraseOut = phraseOutTxtBox.Text;

        if (!(string.IsNullOrWhiteSpace(vocab.URL)) && (urlCheck.Checked))
        {
          this.vocab.URL = pathTxtBox.Text;
        }
        else
        {
          this.vocab.URL = "";
        }

        // This takes care of catogorizing all values based on what the inputs are. 
        if (!(string.IsNullOrWhiteSpace(vocab.URL)) && (urlCheck.Checked))
        {
          vocab.Tag = "URL";
        } 
        else if (!(string.IsNullOrWhiteSpace(vocab.PhraseOut)))
        {
          vocab.Tag = "COM";
        }
        else
        {
          vocab.Tag = "DIC";
        }
      }
    }
  }
}
