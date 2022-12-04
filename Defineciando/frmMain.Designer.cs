namespace Defineciando
{
    partial class frmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnPickword = new System.Windows.Forms.Button();
            this.btnGiveup = new System.Windows.Forms.Button();
            this.optDef1 = new System.Windows.Forms.RadioButton();
            this.optDef2 = new System.Windows.Forms.RadioButton();
            this.optDef3 = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tblLayArea = new System.Windows.Forms.TableLayoutPanel();
            this.tblDefinitions = new System.Windows.Forms.TableLayoutPanel();
            this.lblWordcaption = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblDef1caption = new System.Windows.Forms.Label();
            this.lblDef1 = new System.Windows.Forms.Label();
            this.lblDef2caption = new System.Windows.Forms.Label();
            this.lblDef2 = new System.Windows.Forms.Label();
            this.lblDef3caption = new System.Windows.Forms.Label();
            this.lblDef3 = new System.Windows.Forms.Label();
            this.lblNumWordscaption = new System.Windows.Forms.Label();
            this.lblNumWords = new System.Windows.Forms.Label();
            this.lblScorecaption = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblControls.SuspendLayout();
            this.tblLayArea.SuspendLayout();
            this.tblDefinitions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblMessage, 0, 0);
            this.tblMain.Controls.Add(this.tblControls, 0, 1);
            this.tblMain.Controls.Add(this.tblLayArea, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Azure;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(794, 45);
            this.lblMessage.TabIndex = 0;
            // 
            // tblControls
            // 
            this.tblControls.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tblControls.ColumnCount = 6;
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.Controls.Add(this.btnPickword, 0, 0);
            this.tblControls.Controls.Add(this.btnGiveup, 1, 0);
            this.tblControls.Controls.Add(this.optDef1, 2, 0);
            this.tblControls.Controls.Add(this.optDef2, 3, 0);
            this.tblControls.Controls.Add(this.optDef3, 4, 0);
            this.tblControls.Controls.Add(this.btnEnter, 5, 0);
            this.tblControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControls.Location = new System.Drawing.Point(3, 48);
            this.tblControls.Name = "tblControls";
            this.tblControls.RowCount = 1;
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblControls.Size = new System.Drawing.Size(794, 61);
            this.tblControls.TabIndex = 1;
            // 
            // btnPickword
            // 
            this.btnPickword.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPickword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPickword.ForeColor = System.Drawing.Color.White;
            this.btnPickword.Location = new System.Drawing.Point(3, 3);
            this.btnPickword.Name = "btnPickword";
            this.btnPickword.Size = new System.Drawing.Size(126, 55);
            this.btnPickword.TabIndex = 0;
            this.btnPickword.Text = "Pick a Word";
            this.btnPickword.UseVisualStyleBackColor = false;
            // 
            // btnGiveup
            // 
            this.btnGiveup.BackColor = System.Drawing.Color.White;
            this.btnGiveup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiveup.Location = new System.Drawing.Point(135, 3);
            this.btnGiveup.Name = "btnGiveup";
            this.btnGiveup.Size = new System.Drawing.Size(126, 55);
            this.btnGiveup.TabIndex = 1;
            this.btnGiveup.Text = "I Give Up";
            this.btnGiveup.UseVisualStyleBackColor = false;
            // 
            // optDef1
            // 
            this.optDef1.AutoSize = true;
            this.optDef1.BackColor = System.Drawing.Color.Blue;
            this.optDef1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optDef1.ForeColor = System.Drawing.Color.White;
            this.optDef1.Location = new System.Drawing.Point(267, 3);
            this.optDef1.Name = "optDef1";
            this.optDef1.Size = new System.Drawing.Size(126, 55);
            this.optDef1.TabIndex = 2;
            this.optDef1.TabStop = true;
            this.optDef1.Text = "Definition 1";
            this.optDef1.UseVisualStyleBackColor = false;
            // 
            // optDef2
            // 
            this.optDef2.AutoSize = true;
            this.optDef2.BackColor = System.Drawing.Color.DarkBlue;
            this.optDef2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optDef2.ForeColor = System.Drawing.Color.White;
            this.optDef2.Location = new System.Drawing.Point(399, 3);
            this.optDef2.Name = "optDef2";
            this.optDef2.Size = new System.Drawing.Size(126, 55);
            this.optDef2.TabIndex = 3;
            this.optDef2.TabStop = true;
            this.optDef2.Text = "Definition 2";
            this.optDef2.UseVisualStyleBackColor = false;
            // 
            // optDef3
            // 
            this.optDef3.AutoSize = true;
            this.optDef3.BackColor = System.Drawing.Color.DarkBlue;
            this.optDef3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optDef3.ForeColor = System.Drawing.Color.White;
            this.optDef3.Location = new System.Drawing.Point(531, 3);
            this.optDef3.Name = "optDef3";
            this.optDef3.Size = new System.Drawing.Size(126, 55);
            this.optDef3.TabIndex = 4;
            this.optDef3.TabStop = true;
            this.optDef3.Text = "Definition 3";
            this.optDef3.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(663, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 55);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // tblLayArea
            // 
            this.tblLayArea.ColumnCount = 5;
            this.tblLayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblLayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblLayArea.Controls.Add(this.tblDefinitions, 0, 0);
            this.tblLayArea.Controls.Add(this.lblNumWordscaption, 1, 0);
            this.tblLayArea.Controls.Add(this.lblNumWords, 2, 0);
            this.tblLayArea.Controls.Add(this.lblScorecaption, 3, 0);
            this.tblLayArea.Controls.Add(this.lblScore, 4, 0);
            this.tblLayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayArea.Location = new System.Drawing.Point(3, 115);
            this.tblLayArea.Name = "tblLayArea";
            this.tblLayArea.RowCount = 1;
            this.tblLayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayArea.Size = new System.Drawing.Size(794, 332);
            this.tblLayArea.TabIndex = 2;
            // 
            // tblDefinitions
            // 
            this.tblDefinitions.BackColor = System.Drawing.Color.Transparent;
            this.tblDefinitions.ColumnCount = 2;
            this.tblDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDefinitions.Controls.Add(this.lblWordcaption, 0, 0);
            this.tblDefinitions.Controls.Add(this.lblWord, 1, 0);
            this.tblDefinitions.Controls.Add(this.lblDef1caption, 0, 1);
            this.tblDefinitions.Controls.Add(this.lblDef1, 1, 1);
            this.tblDefinitions.Controls.Add(this.lblDef2caption, 0, 2);
            this.tblDefinitions.Controls.Add(this.lblDef2, 1, 2);
            this.tblDefinitions.Controls.Add(this.lblDef3caption, 0, 3);
            this.tblDefinitions.Controls.Add(this.lblDef3, 1, 3);
            this.tblDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDefinitions.Location = new System.Drawing.Point(3, 3);
            this.tblDefinitions.Name = "tblDefinitions";
            this.tblDefinitions.RowCount = 4;
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.Size = new System.Drawing.Size(491, 326);
            this.tblDefinitions.TabIndex = 0;
            // 
            // lblWordcaption
            // 
            this.lblWordcaption.AutoSize = true;
            this.lblWordcaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWordcaption.Location = new System.Drawing.Point(3, 0);
            this.lblWordcaption.Name = "lblWordcaption";
            this.lblWordcaption.Size = new System.Drawing.Size(58, 25);
            this.lblWordcaption.TabIndex = 0;
            this.lblWordcaption.Text = "Word";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.White;
            this.lblWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWord.Location = new System.Drawing.Point(119, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(369, 81);
            this.lblWord.TabIndex = 1;
            // 
            // lblDef1caption
            // 
            this.lblDef1caption.AutoSize = true;
            this.lblDef1caption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDef1caption.Location = new System.Drawing.Point(3, 81);
            this.lblDef1caption.Name = "lblDef1caption";
            this.lblDef1caption.Size = new System.Drawing.Size(110, 25);
            this.lblDef1caption.TabIndex = 2;
            this.lblDef1caption.Text = "Definition 1";
            // 
            // lblDef1
            // 
            this.lblDef1.BackColor = System.Drawing.Color.White;
            this.lblDef1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDef1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDef1.Location = new System.Drawing.Point(119, 81);
            this.lblDef1.Name = "lblDef1";
            this.lblDef1.Size = new System.Drawing.Size(369, 81);
            this.lblDef1.TabIndex = 3;
            // 
            // lblDef2caption
            // 
            this.lblDef2caption.AutoSize = true;
            this.lblDef2caption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDef2caption.Location = new System.Drawing.Point(3, 162);
            this.lblDef2caption.Name = "lblDef2caption";
            this.lblDef2caption.Size = new System.Drawing.Size(110, 25);
            this.lblDef2caption.TabIndex = 4;
            this.lblDef2caption.Text = "Definition 2";
            // 
            // lblDef2
            // 
            this.lblDef2.BackColor = System.Drawing.Color.White;
            this.lblDef2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDef2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDef2.Location = new System.Drawing.Point(119, 162);
            this.lblDef2.Name = "lblDef2";
            this.lblDef2.Size = new System.Drawing.Size(369, 81);
            this.lblDef2.TabIndex = 5;
            // 
            // lblDef3caption
            // 
            this.lblDef3caption.AutoSize = true;
            this.lblDef3caption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDef3caption.Location = new System.Drawing.Point(3, 243);
            this.lblDef3caption.Name = "lblDef3caption";
            this.lblDef3caption.Size = new System.Drawing.Size(110, 25);
            this.lblDef3caption.TabIndex = 6;
            this.lblDef3caption.Text = "Definition 3";
            // 
            // lblDef3
            // 
            this.lblDef3.BackColor = System.Drawing.Color.White;
            this.lblDef3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDef3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDef3.Location = new System.Drawing.Point(119, 243);
            this.lblDef3.Name = "lblDef3";
            this.lblDef3.Size = new System.Drawing.Size(369, 83);
            this.lblDef3.TabIndex = 7;
            // 
            // lblNumWordscaption
            // 
            this.lblNumWordscaption.AutoSize = true;
            this.lblNumWordscaption.Location = new System.Drawing.Point(500, 0);
            this.lblNumWordscaption.Name = "lblNumWordscaption";
            this.lblNumWordscaption.Size = new System.Drawing.Size(99, 15);
            this.lblNumWordscaption.TabIndex = 1;
            this.lblNumWordscaption.Text = "Num Words Tried";
            // 
            // lblNumWords
            // 
            this.lblNumWords.BackColor = System.Drawing.Color.Azure;
            this.lblNumWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumWords.Location = new System.Drawing.Point(605, 0);
            this.lblNumWords.Name = "lblNumWords";
            this.lblNumWords.Size = new System.Drawing.Size(69, 23);
            this.lblNumWords.TabIndex = 2;
            this.lblNumWords.Text = "0";
            this.lblNumWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScorecaption
            // 
            this.lblScorecaption.AutoSize = true;
            this.lblScorecaption.Location = new System.Drawing.Point(680, 0);
            this.lblScorecaption.Name = "lblScorecaption";
            this.lblScorecaption.Size = new System.Drawing.Size(36, 15);
            this.lblScorecaption.TabIndex = 3;
            this.lblScorecaption.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Azure;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScore.Location = new System.Drawing.Point(722, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(69, 15);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "Definiciando";
            this.tblMain.ResumeLayout(false);
            this.tblControls.ResumeLayout(false);
            this.tblControls.PerformLayout();
            this.tblLayArea.ResumeLayout(false);
            this.tblLayArea.PerformLayout();
            this.tblDefinitions.ResumeLayout(false);
            this.tblDefinitions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblMessage;
        private TableLayoutPanel tblControls;
        private Button btnPickword;
        private Button btnGiveup;
        private RadioButton optDef1;
        private RadioButton optDef2;
        private RadioButton optDef3;
        private Button btnEnter;
        private TableLayoutPanel tblLayArea;
        private TableLayoutPanel tblDefinitions;
        private Label lblWordcaption;
        private Label lblWord;
        private Label lblDef1caption;
        private Label lblDef1;
        private Label lblDef2caption;
        private Label lblDef2;
        private Label lblDef3caption;
        private Label lblDef3;
        private Label lblNumWordscaption;
        private Label lblNumWords;
        private Label lblScorecaption;
        private Label lblScore;
    }
}