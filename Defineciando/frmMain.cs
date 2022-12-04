using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnuciDictionary;

namespace Defineciando
{
    public partial class frmMain : Form
    {
        //form level variables: numwordstried, score, correct-definition, list of words
        //enum pickaword, choosedefinition, userwent
        private enum GameStateEnum {pickword, choosedefinition, userwent }
        GameStateEnum gamestate = GameStateEnum.pickword;
        int numwordstried = 0;
        int score = 0;
        int winningdefbox = 0;
        Random rndWord = new Random();
        Random rndDefBox = new Random();
        Word selectedword;
        List<Word> lstwords;
        List<Label> lstdefboxes;

        public frmMain()
        {
            InitializeComponent();
            btnPickword.Click += BtnPickword_Click;
            btnEnter.Click += BtnEnter_Click;
            btnGiveup.Click += BtnGiveup_Click;
            lstdefboxes = new List<Label>() { lblDef1, lblDef2, lblDef3 };
            lstwords = EnglishDictionary.GetAllWords().ToList();
            SetButtonsEnabled();
        }

  





        //procedure pick a word and fill 3 definition labels

        private void PickAWord()
        {
           int wordnum = rndWord.Next(1000, 100000);
            gamestate = GameStateEnum.choosedefinition;
            ClearHighlight();
            numwordstried += 1;
            DisplayScore();
            winningdefbox = rndDefBox.Next(0, 3);
            selectedword = lstwords[wordnum];
            lblWord.Text = selectedword.Value;

            lstdefboxes.ForEach(l => l.Text = "");
            lstdefboxes[winningdefbox].Text = selectedword.Definition;

            lstdefboxes.Where(l => l.Text == "").ToList().ForEach(l =>
             {
                 wordnum = rndWord.Next(0, 100000);
                 l.Text = lstwords[wordnum].Definition;
             });
            SetButtonsEnabled();

        }

        private void DisplayScore()
        {
            lblNumWords.Text = numwordstried.ToString();
            lblScore.Text = score.ToString();
        }
        private void DisplayMessage(string value)
        {
            lblMessage.Text = value;
        }

       private void CheckWinner()
        {
            int selectedradiobutton = 0;
            gamestate = GameStateEnum.userwent;
            if(optDef2.Checked == true)
            {
                selectedradiobutton = 1;
            }
            else if (optDef3.Checked == true)
            {
                selectedradiobutton = 2;
            }
            if (winningdefbox == selectedradiobutton)
            {
                score += 1;
                
               DisplayMessage("You got it!");
            }
            else
            {
                score = -1;
                DisplayMessage("You lost! Try again!");
            }
            DisplayScore();
            HighlightCorrectDefinition();
            SetButtonsEnabled();
        }

        private void GiveUp()
        {
            HighlightCorrectDefinition();
            gamestate = GameStateEnum.userwent;
            SetButtonsEnabled();
        }

        private void ClearHighlight()
        {
            lstdefboxes.ForEach(l => l.BackColor = Color.White);
        }

        private void HighlightCorrectDefinition()
        {
            lstdefboxes[winningdefbox].BackColor = Color.Lavender;
        }

        private void SetButtonsEnabled()
        {
            switch (gamestate)
            {
                case GameStateEnum.pickword:
                    btnEnter.Enabled = false;
                    btnPickword.Enabled = true;
                    btnGiveup.Enabled = false;
                    break;
                case GameStateEnum.choosedefinition:
                    btnEnter.Enabled = true;
                    btnPickword.Enabled = false;
                    btnGiveup.Enabled = true;
                    break;
                case GameStateEnum.userwent:
                    btnEnter.Enabled = false;
                    btnPickword.Enabled = true;
                    btnGiveup.Enabled = false;
                    break;
            }
        }

        private void BtnPickword_Click(object? sender, EventArgs e)
        {
            this.PickAWord();
        }
        private void BtnEnter_Click(object? sender, EventArgs e)
        {
            this.CheckWinner();
        }
        private void BtnGiveup_Click(object? sender, EventArgs e)
        {
           this.GiveUp();
        }
    }
}
