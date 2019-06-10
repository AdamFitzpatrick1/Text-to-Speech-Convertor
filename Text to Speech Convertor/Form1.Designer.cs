namespace Text_to_Speech_Convertor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterLabel = new System.Windows.Forms.Label();
            this.synthLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.speakButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rapidSpellDialog1 = new Keyoti.RapidSpell.RapidSpellDialog(this.components);
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text Files(*.txt) |*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(27, 42);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(1002, 449);
            this.inputBox.TabIndex = 1;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(12, 6);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(949, 33);
            this.enterLabel.TabIndex = 1;
            this.enterLabel.Text = "Enter text into the area below, or click the \"Load\" button to load a text file";
            this.enterLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // synthLabel
            // 
            this.synthLabel.AutoSize = true;
            this.synthLabel.Location = new System.Drawing.Point(42, 626);
            this.synthLabel.Name = "synthLabel";
            this.synthLabel.Size = new System.Drawing.Size(97, 13);
            this.synthLabel.TabIndex = 9;
            this.synthLabel.Text = "Synthesiser Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(146, 626);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(24, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Idle";
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.exitpng;
            this.exitButton.Location = new System.Drawing.Point(752, 526);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 107);
            this.exitButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.exitButton, "This button exits the application.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.clearpng;
            this.clearButton.Location = new System.Drawing.Point(621, 527);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 94);
            this.clearButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.clearButton, "This button clear\'s the user\'s text input.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.stoppng;
            this.stopButton.Location = new System.Drawing.Point(490, 541);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(96, 72);
            this.stopButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.stopButton, "This button stops the playback.");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.resumepng_revised;
            this.resumeButton.Location = new System.Drawing.Point(216, 526);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(253, 102);
            this.resumeButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.resumeButton, "This button allows you to resume the playback.");
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.pausepng;
            this.pauseButton.Location = new System.Drawing.Point(118, 526);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 95);
            this.pauseButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pauseButton, "This button pauses the speech.");
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // speakButton
            // 
            this.speakButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.playpng2;
            this.speakButton.Location = new System.Drawing.Point(26, 538);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(70, 71);
            this.speakButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.speakButton, "This button allows you to play the text-to-speech audio.");
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.uploadpng;
            this.loadButton.Location = new System.Drawing.Point(1035, 29);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(180, 178);
            this.loadButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.loadButton, "This button will allow you to upload a text file into the application.");
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // rapidSpellDialog1
            // 
            this.rapidSpellDialog1.AllOperationScope = Keyoti.RapidSpell.OperationScope.AllAssignedTextBoxes;
            this.rapidSpellDialog1.AllowAnyCase = false;
            this.rapidSpellDialog1.AllowMixedCase = false;
            this.rapidSpellDialog1.AlwaysShowDialog = false;
            this.rapidSpellDialog1.BackColor = System.Drawing.Color.Empty;
            this.rapidSpellDialog1.CheckCompoundWords = false;
            this.rapidSpellDialog1.CheckDisabledTextBoxes = false;
            this.rapidSpellDialog1.CheckFromStartOfTextOnMultiples = true;
            this.rapidSpellDialog1.CheckReadOnlyTextBoxes = false;
            this.rapidSpellDialog1.ConsiderationRange = 500;
            this.rapidSpellDialog1.ControlBox = true;
            this.rapidSpellDialog1.DictFilePath = null;
            this.rapidSpellDialog1.FindCapitalizedSuggestions = true;
            this.rapidSpellDialog1.ForeColor = System.Drawing.Color.Empty;
            this.rapidSpellDialog1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.rapidSpellDialog1.GUILanguage = Keyoti.RapidSpell.LanguageType.ENGLISH;
            this.rapidSpellDialog1.Icon = null;
            this.rapidSpellDialog1.IgnoreCapitalizedWords = false;
            this.rapidSpellDialog1.IgnoreIncorrectSentenceCapitalization = false;
            this.rapidSpellDialog1.IgnoreInEnglishLowerCaseI = false;
            this.rapidSpellDialog1.IgnoreURLsAndEmailAddresses = true;
            this.rapidSpellDialog1.IgnoreWordsWithDigits = true;
            this.rapidSpellDialog1.IgnoreXML = false;
            this.rapidSpellDialog1.IncludeUserDictionaryInSuggestions = false;
            this.rapidSpellDialog1.LanguageParser = Keyoti.RapidSpell.LanguageType.ENGLISH;
            this.rapidSpellDialog1.Location = new System.Drawing.Point(300, 200);
            this.rapidSpellDialog1.LookIntoHyphenatedText = true;
            this.rapidSpellDialog1.MdiParent = null;
            this.rapidSpellDialog1.MinimizeBox = true;
            this.rapidSpellDialog1.Modal = false;
            this.rapidSpellDialog1.ModalAutoDispose = true;
            this.rapidSpellDialog1.ModalOwner = null;
            this.rapidSpellDialog1.NumberSuggestionList = false;
            this.rapidSpellDialog1.OptionsEnabled = true;
            this.rapidSpellDialog1.OptionsFileName = "RapidSpell_UserSettings.xml";
            this.rapidSpellDialog1.OptionsStorageLocation = Keyoti.RapidSpell.Options.UserOptions.StorageType.IsolatedStorage;
            this.rapidSpellDialog1.QueryTextBoxMultiline = true;
            this.rapidSpellDialog1.SeparateHyphenWords = false;
            this.rapidSpellDialog1.ShowContextSentence = true;
            this.rapidSpellDialog1.ShowFinishedBoxAtEnd = true;
            this.rapidSpellDialog1.ShowInTaskbar = false;
            this.rapidSpellDialog1.ShowOptionForCheckAsYouType = false;
            this.rapidSpellDialog1.ShowOptionForMultipleUserDictionaries = true;
            this.rapidSpellDialog1.ShowOptionsButton = true;
            this.rapidSpellDialog1.ShowUndoButton = true;
            this.rapidSpellDialog1.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Auto;
            this.rapidSpellDialog1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.rapidSpellDialog1.SuggestionsMethod = Keyoti.RapidSpell.SuggestionsMethodType.HashingSuggestions;
            this.rapidSpellDialog1.SuggestSplitWords = true;
            this.rapidSpellDialog1.TextBoxBaseToCheck = this.inputBox;
            this.rapidSpellDialog1.Texts.AddButtonText = "A&dd";
            this.rapidSpellDialog1.Texts.CancelButtonText = "Canc&el";
            this.rapidSpellDialog1.Texts.ChangeAllButtonText = "Chan&ge All";
            this.rapidSpellDialog1.Texts.ChangeButtonText = "&Change";
            this.rapidSpellDialog1.Texts.CheckCompletePopUpText = "The spelling check is complete.";
            this.rapidSpellDialog1.Texts.CheckCompletePopUpTitle = "Spelling";
            this.rapidSpellDialog1.Texts.CheckingSpellingText = "Checking Document...";
            this.rapidSpellDialog1.Texts.DialogTitleText = "Spelling";
            this.rapidSpellDialog1.Texts.FindingSuggestionsLabelText = "Finding Suggestions...";
            this.rapidSpellDialog1.Texts.FindSuggestionsLabelText = "Find Suggestions?";
            this.rapidSpellDialog1.Texts.FinishedCheckingSelectionPopUpText = "Finished checking selection, would you like to check the rest of the text?";
            this.rapidSpellDialog1.Texts.FinishedCheckingSelectionPopUpTitle = "Finished Checking Selection";
            this.rapidSpellDialog1.Texts.IgnoreAllButtonText = "Ignore &All";
            this.rapidSpellDialog1.Texts.IgnoreButtonText = "&Ignore";
            this.rapidSpellDialog1.Texts.InDictionaryLabelText = "In Dictionary:";
            this.rapidSpellDialog1.Texts.LoadingDictionaryText = "Loading Dictionary...";
            this.rapidSpellDialog1.Texts.NoSuggestionsText = "No Suggestions.";
            this.rapidSpellDialog1.Texts.NotInDictionaryLabelText = "Not In Dictionary:";
            this.rapidSpellDialog1.Texts.OptionsButtonText = "Options...";
            this.rapidSpellDialog1.Texts.OptionsFormAdvancedSettingsText = "Advanced Settings";
            this.rapidSpellDialog1.Texts.OptionsFormAlwaysSuggestCorrectionsText = "Always suggest corrections";
            this.rapidSpellDialog1.Texts.OptionsFormBasicSettingsText = "Basic Settings";
            this.rapidSpellDialog1.Texts.OptionsFormCancelText = "Cancel";
            this.rapidSpellDialog1.Texts.OptionsFormCheckAsYouTypeText = "Check spelling as you type";
            this.rapidSpellDialog1.Texts.OptionsFormIgnoreImproperCaseText = "Ignore improper case (eg. \"australia\", \"tABle\")";
            this.rapidSpellDialog1.Texts.OptionsFormIgnoreInternetAddressesText = "Ignore internet addresses and emails";
            this.rapidSpellDialog1.Texts.OptionsFormIgnoreWordsInUppercaseText = "Ignore words in UPPERCASE";
            this.rapidSpellDialog1.Texts.OptionsFormIgnoreWordsWithNumbersText = "Ignore words with numbers";
            this.rapidSpellDialog1.Texts.OptionsFormOKText = "OK";
            this.rapidSpellDialog1.Texts.OptionsFormRecheckTextText = "Recheck Text";
            this.rapidSpellDialog1.Texts.OptionsFormSuggestFromMainDictionaryOnlyText = "Suggest from main dictionary only";
            this.rapidSpellDialog1.Texts.OptionsFormTitleText = "Spelling";
            this.rapidSpellDialog1.Texts.OptionsFormUserDictionaryEditText = "User Dictionary...";
            this.rapidSpellDialog1.Texts.RemoveDuplicateWordText = "Remove duplicate word";
            this.rapidSpellDialog1.Texts.ResumeButtonText = "&Resume";
            this.rapidSpellDialog1.Texts.SuggestionsLabelText = "Suggestions:";
            this.rapidSpellDialog1.Texts.UndoButtonText = "Undo";
            this.rapidSpellDialog1.Texts.UserDictionaryFormAddText = "Add";
            this.rapidSpellDialog1.Texts.UserDictionaryFormCancelText = "Cancel";
            this.rapidSpellDialog1.Texts.UserDictionaryFormContentsText = "User Dictionary Contents";
            this.rapidSpellDialog1.Texts.UserDictionaryFormDeleteText = "Delete";
            this.rapidSpellDialog1.Texts.UserDictionaryFormDictionaryLabelText = "Dictionary:";
            this.rapidSpellDialog1.Texts.UserDictionaryFormOKText = "OK";
            this.rapidSpellDialog1.Texts.UserDictionaryFormTitleText = "User Dictionary";
            this.rapidSpellDialog1.Texts.UserDictionaryFormWordLabelText = "Word:";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormAddFileText = "Add...";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormCancelText = "Cancel";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormChangeDefaultText = "Change Default";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormDeleteText = "Delete";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormDictionaryLabelText = "Dictionary:";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormEditFileText = "Edit Word List...";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormGroupBoxTitleText = "Dictionary List";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormNewFileText = "New...";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormOKText = "OK";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormRemoveFileText = "Remove";
            this.rapidSpellDialog1.Texts.UserDictionarySelectFormTitleText = "User Dictionary";
            this.rapidSpellDialog1.ThirdPartyTextComponentToCheck = null;
            this.rapidSpellDialog1.TopLevel = true;
            this.rapidSpellDialog1.TopMost = false;
            this.rapidSpellDialog1.UserDictionaryFile = null;
            this.rapidSpellDialog1.V2Parser = true;
            this.rapidSpellDialog1.WarnDuplicates = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1239, 648);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.synthLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.inputBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Text to Speech Convertor © Adam Fitzpatrick 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label synthLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Keyoti.RapidSpell.RapidSpellDialog rapidSpellDialog1;
    }
}

