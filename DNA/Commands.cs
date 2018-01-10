using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Drawing;

namespace DNA
{
  public partial class Commands : Form
  {
    //static string fileName = "Vocabulary.txt";
    //string INPUT_VOCAB_FILE = Path.Combine(Environment.CurrentDirectory, fileName);
    private const string INPUT_VOCAB_FILE = "Vocabulary.txt";

    // private const string LST_FILE_NAME = "AgentSalesRpt.Txt";

    // Create vocab list of Vocab objects each of which has a phraseIn, phraseOut, and Path/Url
    private List<Vocab> vocabList = new List<Vocab>();

    public Commands()
    {
      InitializeComponent();
    }

    private void Commands_Load(object sender, EventArgs e)
    {
      // Loads Vocab File into List<Vocab>
      LoadVocab();

      // Updates&loads DGV with List<Vocab>
      LoadDataGV();
    }

    private void LoadVocab()
    {
      // bellow was used while I was trying to embed the textfile into the executable properties
      //    however it would not easily allow me to edit it. 
      //string[] lines = Properties.Resources.Vocabulary.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

      foreach (var line in File.ReadLines(INPUT_VOCAB_FILE))
      {
        var words = line.Split(',');

        vocabList.Add(new Vocab(words[0], words[1], words[2], words[3]));
      }

      // This is amazing and I love this sorting method <3
      vocabList.Sort((Vocab x, Vocab y) => x.PhraseIn.CompareTo(y.PhraseIn));
    }

    private void LoadDataGV()
    {
      // missing code
      // this returns the total number of columns 
      int colCount = this.dgvVocab.Columns.Count - 1;
      int pathCount = 0;
      int commCount = 0;
      int dictCount = 0; 
      dgvPaths.Rows.Clear();
      dgvCommunication.Rows.Clear();
      dgvDictation.Rows.Clear();
      dgvVocab.Rows.Clear();

      for (int j = 1; j <= vocabList.Count; j++)
      {
        dgvVocab.Rows.Add();
        dgvVocab.Rows[j - 1].Cells[0].Value = vocabList[j - 1].PhraseIn;
        dgvVocab.Rows[j - 1].Cells[1].Value = vocabList[j - 1].PhraseOut;

        // first conditional statement both loads the path tab & the tooltip "hint" in the dgv
        if(vocabList[j - 1].Tag == "URL")
        {
          // loads the paths dgv
          dgvPaths.Rows.Add();
          dgvPaths.Rows[pathCount].Cells[0].Value = vocabList[j - 1].PhraseIn;
          dgvPaths.Rows[pathCount++].Cells[1].Value = vocabList[j - 1].URL;

          // sets the visual elements for the main Dgv
          dgvVocab.Rows[j - 1].Cells[2].Value = "X";
          dgvVocab.Rows[j - 1].Cells[2].Style.BackColor = Color.LightGray;

          var cell = dgvVocab.Rows[j - 1].Cells[2];
          cell.ToolTipText = vocabList[j - 1].URL.ToString();
        }

        // Loads the communications tab with all values tagged communication
        else if(vocabList[j-1].Tag == "COM")
        {
          dgvCommunication.Rows.Add();
          dgvCommunication.Rows[commCount].Cells[0].Value = vocabList[j - 1].PhraseIn;
          dgvCommunication.Rows[commCount++].Cells[1].Value = vocabList[j - 1].PhraseOut;
        }

        // Loads the Dictation tab with all values tagged dictation
        else if (vocabList[j - 1].Tag == "DIC")
        {
          dgvDictation.Rows.Add();
          dgvDictation.Rows[dictCount++].Cells[0].Value = vocabList[j - 1].PhraseIn;
        }
      }
    }


    // here is my biggest problem currently. TO get this to work correctly I can have a few different things
    // but first 

    private void UpdateStorage()
    {
      // Clear current Text Document this is super inneffecient
      File.WriteAllText(INPUT_VOCAB_FILE, String.Empty);

      using (StreamWriter sw = File.AppendText(INPUT_VOCAB_FILE))
      {
        for (int i = 0; i < vocabList.Count; i++)
        { sw.WriteLine("{0},{1},{2},{3}",
                        vocabList[i].PhraseIn, vocabList[i].PhraseOut, 
                        vocabList[i].URL,      vocabList[i].Tag);   }   }
    }

    private void UpdateValues()
    {
      // Sort values of vocabList
      vocabList.Sort((Vocab x, Vocab y) => x.PhraseIn.CompareTo(y.PhraseIn));

      // load updated values into DGV
      LoadDataGV();

      // Update storage if it has been changed
      UpdateStorage();
    }

    private void UpdateSelection(Vocab vocabItem)
    {
      int listIndex;

      // search for location of itemAdded
      listIndex = vocabList.IndexOf(vocabList.Where(x => x.PhraseIn == vocabItem.PhraseIn).FirstOrDefault());
      dgvVocab.ClearSelection();
      dgvVocab.Rows[listIndex].Selected = true;

      // scroll down to selected dgv
      dgvVocab.FirstDisplayedScrollingRowIndex = dgvVocab.SelectedRows[0].Index;
    }

    // ContextMenu Items
    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {

      // What I can do here is have it createa a new blank vocab object. 
      AddUpdateDialog addDialog = new AddUpdateDialog();

      Vocab vocabItem = new Vocab();
      addDialog.Text = "Add Vocab";
      addDialog.Tag = vocabItem;     

      if (addDialog.ShowDialog(this) == DialogResult.OK)
      {
        if (!(string.IsNullOrWhiteSpace(vocabItem.PhraseIn)))
        {
          // add VocabList item into List
          vocabList.Add(new Vocab(vocabItem.PhraseIn, vocabItem.PhraseOut, vocabItem.URL, vocabItem.Tag));

          UpdateValues();

          UpdateSelection(vocabItem);
        }
      }

      addDialog.Dispose();
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int listIndex;
      Vocab vocabItem;

      // What I can do here is have it createa a new blank vocab object. 
      AddUpdateDialog updateDialog = new AddUpdateDialog();

      listIndex = this.dgvVocab.CurrentRow.Index;
      vocabItem = this.vocabList[listIndex];
      updateDialog.Text = "Update Vocab";
      updateDialog.Tag = vocabItem;

      if (updateDialog.ShowDialog(this) == DialogResult.OK)
      {
        UpdateValues();

        UpdateSelection(vocabItem);
      }

      updateDialog.Dispose();
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int listIndex;
      Vocab vocabItem;
      DialogResult dialogResult;

      listIndex = this.dgvVocab.CurrentRow.Index;
      vocabItem = this.vocabList[listIndex];

      dialogResult = MessageBox.Show("Delete " + vocabItem.PhraseIn.ToString(), "Delete Vocab",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dialogResult == DialogResult.Yes)
      {
        this.vocabList.RemoveAt(listIndex);

        UpdateValues();

        dgvVocab.ClearSelection();
        if (listIndex <= vocabList.Count)
        {
          dgvVocab.Rows[listIndex].Selected = true;
        }

        // scroll down to selected dgv
        dgvVocab.FirstDisplayedScrollingRowIndex = dgvVocab.SelectedRows[0].Index;
      }
    }
  }
}
