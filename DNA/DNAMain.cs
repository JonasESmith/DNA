// I am rebuilding alan to make him more efficient and 
// user friendly. I would lik to have all data sources
// and vocabularies be defined by databases instead of 
// local files. 
// goo.gl/mDTIbW //MP3 sound capturing and recording
// Edit: 8/7 - getting ready to publish to github
// https://www.codeproject.com/answers/166212/recognizing-a-person-s-voice-using-c#answer2 // Differentiating voices 
// http://stackoverflow.com/questions/28470297/jarvis-speech-recognition-program-not-listening-to-voice-input

using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Reflection;
using DNA.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DNA
{
  public partial class DNAMain : Form
  {
    // I should make a library that both of the forms can use. 
    SpeechRecognitionEngine recEngine   = new SpeechRecognitionEngine();
    SpeechSynthesizer       synthesizer = new SpeechSynthesizer();
    ProcessStartInfo        start       = new ProcessStartInfo();


    Commands            comlist      = new Commands();
    static Choices      commands     = new Choices();
    static List<Vocab>  vocabList    = new List<Vocab>();
    static List<string> phraseInList = new List<string>();
    static bool         listen = true;
    string              ProcWindow;

    private const string         userName = "\n> User : ";
    private const string         botName  = "\n< Alan : ";
    private const string         version  = "Version 2.8";
    private const string INPUT_VOCAB_FILE = "Vocabulary.txt";


    // these are necessary for the select window & min/max
    [DllImport("user32")]     private static extern bool SetForegroundWindow(IntPtr hwnd);
    [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    public DNAMain()
    {
      InitializeComponent();
      InitStyles();
    }

    private void InitStyles()
    {
      consoleLogPanel.Dock = DockStyle.Fill;

    }

    private void DNAMain_Load(object sender, EventArgs e)
    {
      consoleLog.Text = version;
      consoleLog.Text += (botName + "Try \"show commands\" to get started");
      LoadGrammar();
      LoadSpeechEngine();
    }

    private void LoadGrammar()
    {
      // loads stored values from vocabulary.txt into a List of strings
      LoadVocab();

      LoadVoice();
    }

    private void LoadVoice()
    {
      recEngine.LoadGrammar(new Grammar
                           (new GrammarBuilder
                           (new Choices(commands))));
    }

    public void LoadVocab()
    {
      vocabList.Clear();

      foreach (var line in File.ReadLines(INPUT_VOCAB_FILE))
      {
        var words = line.Split(',');
        vocabList.Add(new Vocab(words[0], words[1], words[2], words[3]));
        phraseInList.Add(words[0].ToLower());
        commands.Add(words[0].ToLower());
      }
    }

    private void LoadSpeechEngine()
    {
      // boolean value to determine if there is a microphone currently detected. 
      bool micDetect;

      // selecting the default mic
      try { recEngine.SetInputToDefaultAudioDevice(); micDetect = true; }
      catch { MessageBox.Show("no audio input is supplied"); micDetect = false; }

      recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_recognizer_SpeechRecognized);

      // conditional statement here stops the program from crashing if mic is not detected
      if (micDetect)
        recEngine.RecognizeAsync(RecognizeMode.Multiple);
    }

    void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
      #region -- Vocabulary Check -- 

      string speech = e.Result.Text.ToLower();
      consoleLog.Text += (userName + speech);

      if ((speech == "alan listen") || (speech == "alan start listening"))
      { listen = true; }
      if ((speech == "alan stop listening") || (speech == "alan dont listen"))
      {
        listen = false;
        synthesizer.SpeakAsync("I am no longer listening");
      }

      if (listen == true)
      {
        switch (speech)
        {
          case "switch tabs":
          case "next tab":
            SendKeys.Send("^{TAB}");
            break;

          case "close tab":
            SendKeys.Send("^{w}");
            break;

          case "pause":
          case "play":
            SendKeys.Send(" ");
            break;

          case "show commands":
            comlist = new Commands();
            comlist.Show();
            break;

          case "reload":
            ReloadVocab();
            break;

          case "alan close please":
          case "alan close":
            this.Close();
            Application.Exit();
            break;
        }

        // Doing a binary search here to greatly improve the response time of the
        //  was O(N) now a O(logN)
        int i = phraseInList.BinarySearch(speech);

        if (i <= vocabList.Count && i != 0)
        {
          if (speech == vocabList[i].PhraseIn.ToLower())
          {
            // if the "response" is blank do nothing
            if (vocabList[i].PhraseOut != "")
              consoleLog.Text += (botName + vocabList[i].PhraseOut);

            // speak 
            synthesizer.SpeakAsync(vocabList[i].PhraseOut);

            // if there is a parallel link 
            if (!(string.IsNullOrWhiteSpace(vocabList[i].URL)))
            {
              try
              {
                System.Diagnostics.Process.Start(vocabList[i].URL);
              }
              catch (Exception)
              {
                MessageBox.Show(vocabList[i].URL + "\n does not exist in the current context", "Incorrect Path");
              }
            }
          }
        }

        if (speech.Contains("close"))
        {
          ProcWindow = speech.Replace("close ", "");
          StopWindow();
        }
        if (speech.Contains("select"))
        {
          ProcWindow = speech.Replace("select ", "");
          SelectWindow();
        }
        if (speech.Contains("minimize"))
        {
          ProcWindow = speech.Replace("minimize ", "");
          MinimizeWindow();
        }
      }
      #endregion
    }

    // to help with the application not closing properly. 
    protected override void OnClosed(EventArgs e)
    {
      Application.Exit();
      base.OnClosed(e);
    }


    // close/min/max applications that are currently open. Will close
    // the last selected application.
    #region min/max/close

    private void StopWindow()
    {
      System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName(ProcWindow);
      foreach (System.Diagnostics.Process proc in procs)
      { proc.CloseMainWindow(); }
    }

    private const int SW_SHOWMAXIMIZED = 3;
    private void SelectWindow()
    {
      System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName(ProcWindow);
      foreach (System.Diagnostics.Process proc in procs)
      {
        ShowWindow(proc.MainWindowHandle, SW_SHOWMAXIMIZED);
        SetForegroundWindow(proc.MainWindowHandle);
      }
    }

    private const int SW_FORCEMINIMIZE = 11;
    private void MinimizeWindow()
    {
      System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName(ProcWindow);
      foreach (System.Diagnostics.Process proc in procs)
      {
        ShowWindow(proc.MainWindowHandle, SW_FORCEMINIMIZE);
      }
    }

    #endregion

    private void ShowCommands()
    {
      comlist = new Commands();
      comlist.Show();
    }

    private void ReloadVocab()
    {
      consoleLog.Text = version;
      consoleLog.Text += "";
      LoadVocab();
      LoadVoice();
    }

    #region Contextmenu & mneu

    private void showCommandsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowCommands();
    }

    private void showCommandsToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ShowCommands();
    }

    private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ReloadVocab();
    }

    private void reloadToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ReloadVocab();
    }

    #endregion

    private void showCommandsButton_Click(object sender, EventArgs e)
    {
      showCommandsPanel.Controls.Clear();

      consoleLogPanel.Visible = false;
      addCommandPanel.Visible = false;

      commandPanel.Visible = true;
      showCommandsPanel.Visible = true;
      commandPanel.Dock = DockStyle.Fill;

      int CommandWidth = commandPanel.Width - 20;

      phraseinTitleButton.Width = (CommandWidth / 3);
      phraseinTitleButton.FlatAppearance.MouseOverBackColor = phraseinTitleButton.BackColor;

      phraseOutTitleButton.Width = CommandWidth / 2;
      phraseOutTitleButton.FlatAppearance.MouseOverBackColor = phraseOutTitleButton.BackColor;

      pathTitleButton.Width = commandPanel.Width - (phraseOutTitleButton.Width + phraseinTitleButton.Width + 20);
      pathTitleButton.FlatAppearance.MouseOverBackColor = phraseOutTitleButton.BackColor;

      fillerTitleBarPanel.BackColor = phraseOutTitleButton.BackColor;


      int topMargin = 0;

      for (int i = 0; i < vocabList.Count; i++)
      {
        Panel vocabPanel = new Panel();
        vocabPanel.Width = showCommandsPanel.Width - 20;
        vocabPanel.Top = topMargin;
        vocabPanel.Height = 30;
        vocabPanel.Name = "Panel" + i;


        Button phraseInButton = new Button();
        phraseInButton.Name = "InButton" + i;
        phraseInButton.Text = vocabList[i].PhraseIn.ToString();
        phraseInButton.Width = (vocabPanel.Width / 3);
        phraseInButton.Height = 30;
        phraseInButton.TextAlign = ContentAlignment.MiddleCenter;
        phraseInButton.FlatStyle = FlatStyle.Flat;
        phraseInButton.FlatAppearance.BorderSize = 0;
        phraseInButton.MouseEnter += InButton_MouseEnter;
        phraseInButton.MouseLeave += InButton_MouseLeave;
        phraseInButton.MouseClick += PhraseInButton_MouseClick;
        phraseInButton.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;


        Button phraseOutButton = new Button();
        string name = "OutButton" + i;
        phraseOutButton.Name = "OutButton" + i;
        phraseOutButton.Text = vocabList[i].PhraseOut.ToString();
        phraseOutButton.Width = vocabPanel.Width / 2;
        phraseOutButton.Height = 30;
        phraseOutButton.Left = phraseInButton.Width;
        phraseOutButton.TextAlign = ContentAlignment.MiddleCenter;
        phraseOutButton.FlatStyle = FlatStyle.Flat;
        phraseOutButton.FlatAppearance.BorderSize = 0;
        phraseOutButton.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
        phraseOutButton.MouseEnter += OutButton_MouseEnter;
        phraseOutButton.MouseLeave += OutButton_MouseLeave;
        phraseOutButton.MouseClick += PhraseOutButton_MouseClick;


        Button executableButton = new Button();
        executableButton.Name = "ExeButton" + i;
        executableButton.Width = vocabPanel.Width - (phraseInButton.Width + phraseOutButton.Width);
        executableButton.Height = 30;
        executableButton.Left = phraseInButton.Width + phraseOutButton.Width;
        executableButton.TextAlign = ContentAlignment.MiddleCenter;
        executableButton.FlatStyle = FlatStyle.Flat;
        executableButton.FlatAppearance.BorderSize = 0;
        if (String.IsNullOrEmpty(vocabList[i].URL))
        {
          executableButton.Enabled = false;
          executableButton.Text = "No path";
        }
        else
        {
          executableButton.Text = vocabList[i].URL;
        }

        topMargin += phraseOutButton.Height + 2;

        vocabPanel.Controls.Add(phraseInButton);
        vocabPanel.Controls.Add(phraseOutButton);
        vocabPanel.Controls.Add(executableButton);

        showCommandsPanel.Controls.Add(vocabPanel);
      }

      showCommandsPanel.AutoScroll = false;
      showCommandsPanel.HorizontalScroll.Enabled = false;
      showCommandsPanel.HorizontalScroll.Visible = false;
      showCommandsPanel.HorizontalScroll.Maximum = 0;
      showCommandsPanel.AutoScroll = true;
    }

    private void EditCommand(object sender)
    {
      addCommandLabel.Text = "Edit command";

      consoleLogPanel.Visible = false;
      addCommandPanel.Visible = true;
      commandPanel.Visible = false;

      addCommandPanel.Dock = DockStyle.Fill;

      Button button = sender as Button;

      int index = 0;
      string name;

      if (button.Name.Contains("In"))
      {
        name = button.Name.Replace("InButton", "");
        index = Convert.ToInt32(name);
      }
      else if (button.Name.Contains("Out"))
      {
        name = button.Name.Replace("OutButton", "");
        index = Convert.ToInt32(name);
      }
      else
      {

      }

      phraseInTextBox.Text = vocabList[index].PhraseIn;
      phraseOutTextBox.Text = vocabList[index].PhraseOut;
      if (!String.IsNullOrEmpty(vocabList[index].URL))
      {
        exeCheckBox.Checked = true;
        pathTextBox.Text = vocabList[index].URL;
      }
      else
      {
        exeCheckBox.Checked = false;
        pathTextBox.Text = "";
      }
    }

    private void PhraseOutButton_MouseClick(object sender, MouseEventArgs e)
    {
      EditCommand(sender);
    }

    private void PhraseInButton_MouseClick(object sender, MouseEventArgs e)
    {
      EditCommand(sender);
    }

    private void OutButton_MouseLeave(object sender, EventArgs e)
    {
      Button button = sender as Button;
      string name = button.Name.Replace("OutButton", "");
      int index = Convert.ToInt32(name);

      var panel = showCommandsPanel.Controls.OfType<Panel>().FirstOrDefault(b => b.Name == "Panel" + index);

      var InButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "InButton" + index);
      var pathButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "ExeButton" + index);

      pathButton.BackColor = panel.BackColor;
      button.BackColor = panel.BackColor;
      InButton.BackColor = panel.BackColor;
      InButton.Show();
    }

    private void OutButton_MouseEnter(object sender, EventArgs e)
    {
      Button button = sender as Button;
      button.BackColor = SystemColors.ScrollBar;
      string name = button.Name.Replace("OutButton", "");
      int index = Convert.ToInt32(name);

      var panel = showCommandsPanel.Controls.OfType<Panel>().FirstOrDefault(b => b.Name == "Panel" + index);

      var outButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "InButton" + index);
      var pathButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "ExeButton" + index);

      pathButton.BackColor = button.BackColor;
      outButton.BackColor = button.BackColor;
      outButton.Show();
    }

    private void InButton_MouseLeave(object sender, EventArgs e)
    {
      Button button = sender as Button;
      string name = button.Name.Replace("InButton", "");
      int index = Convert.ToInt32(name);

      var panel = showCommandsPanel.Controls.OfType<Panel>().FirstOrDefault(b => b.Name == "Panel" + index);
      var outButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "OutButton" + index);
      var pathButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "ExeButton" + index);

      pathButton.BackColor = panel.BackColor;
      button.BackColor = panel.BackColor;
      outButton.BackColor = panel.BackColor;
      outButton.Show();
    }

    private void InButton_MouseEnter(object sender, EventArgs e)
    {
      Button button = sender as Button;
      button.BackColor = SystemColors.ScrollBar;
      string name = button.Name.Replace("InButton", "");
      int index = Convert.ToInt32(name);

      var panel = showCommandsPanel.Controls.OfType<Panel>().FirstOrDefault(b => b.Name == "Panel" + index);
      var outButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "OutButton" + index);
      var pathButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "ExeButton" + index);

      pathButton.BackColor = button.BackColor;
      outButton.BackColor = button.BackColor;
      outButton.Show();
    }



    private void addCommandButton_Click(object sender, EventArgs e)
    {
      consoleLogPanel.Visible        = false;
      addCommandPanel.Visible   = true;
      commandPanel.Visible = false;

      addCommandLabel.Text = "New command";
      phraseInTextBox.Text = "";
      phraseOutTextBox.Text = "";
      pathTextBox.Text = "";
      exeCheckBox.Checked = false;

      addCommandPanel.Dock = DockStyle.Fill;

      int leftMargin = addCommandPanel.Width / 10;

      addCommandLabel.Left = leftMargin;

      phraseInLabel.Left    = leftMargin;
      phraseInTextBox.Left  = leftMargin;
      phraseInTextBox.Width = addCommandPanel.Width - ((addCommandPanel.Width / 10) * 2);

      phraseOutLabel.Left    = leftMargin;
      phraseOutTextBox.Left  = leftMargin;
      phraseOutTextBox.Width = addCommandPanel.Width - ((addCommandPanel.Width / 10) * 2);

      exeCheckBox.Left  = leftMargin + 1;
      pathLabel.Left    = leftMargin;
      pathTextBox.Left  = leftMargin;
      pathTextBox.Width = addCommandPanel.Width - ((addCommandPanel.Width / 10) * 2);


      saveCommandButton.Left = pathTextBox.Right - saveCommandButton.Width;
    }

    private void exeCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (exeCheckBox.Checked == true)
      {
        pathLabel.Enabled   = true;
        pathTextBox.Enabled = true;
      }
      else
      {
        pathLabel.Enabled   = false;
        pathTextBox.Enabled = false;
      }
    }

    private void showConsoleButton_Click(object sender, EventArgs e)
    {
      consoleLogPanel.Visible = true;
      commandPanel.Visible = false;
      addCommandPanel.Visible = false;
    }

    private void DNAMain_ResizeEnd(object sender, EventArgs e)
    {
      if (consoleLogPanel.Visible == true)
      {
        conversationLogButton.PerformClick();
      }
      else if (commandPanel.Visible == true)
      {
        showCommandsButton.PerformClick();
      }
      else if (addCommandPanel.Visible == true)
      {
        addCommandButton.PerformClick();
      }
    }
  }
}