namespace RadioactivityTool
{
    partial class EffectInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EffectInfo));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.ExitButton = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountInputLabel = new System.Windows.Forms.Label();
            this.atomtypeLabel = new System.Windows.Forms.Label();
            this.atomTypeBox = new System.Windows.Forms.ComboBox();
            this.comboboxDose = new System.Windows.Forms.ComboBox();
            this.DosingLabel = new System.Windows.Forms.Label();
            this.InputUpDownBox = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TypeInfoLabel = new System.Windows.Forms.Label();
            this.radiationtypeRadioButton3 = new System.Windows.Forms.RadioButton();
            this.radiationtypeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.radiationtypeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.RunButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EffectBox = new System.Windows.Forms.TextBox();
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            this.ResultListBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.HelpBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.InfoNoteLabel = new System.Windows.Forms.Label();
            this.MainInfoLabel = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.LinkLabel();
            this.UNCLabel = new System.Windows.Forms.LinkLabel();
            this.UNCLogo = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.ExitButton);
            this.menuItem1.Text = "Menu";
            // 
            // ExitButton
            // 
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.RunButton);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 245);
            this.tabPage1.Text = "Input";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HelloLabel);
            this.panel3.Location = new System.Drawing.Point(121, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 125);
            // 
            // HelloLabel
            // 
            this.HelloLabel.Location = new System.Drawing.Point(3, 12);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(109, 102);
            this.HelloLabel.Text = "Welcome!\r\n\r\nTo begin, enter your desired values.\r\nOr, look at Help to learn more." +
                "\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.amountInputLabel);
            this.panel2.Controls.Add(this.atomtypeLabel);
            this.panel2.Controls.Add(this.atomTypeBox);
            this.panel2.Controls.Add(this.comboboxDose);
            this.panel2.Controls.Add(this.DosingLabel);
            this.panel2.Controls.Add(this.InputUpDownBox);
            this.panel2.Location = new System.Drawing.Point(3, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 85);
            // 
            // amountInputLabel
            // 
            this.amountInputLabel.Location = new System.Drawing.Point(3, 59);
            this.amountInputLabel.Name = "amountInputLabel";
            this.amountInputLabel.Size = new System.Drawing.Size(57, 20);
            this.amountInputLabel.Text = "Amount:";
            // 
            // atomtypeLabel
            // 
            this.atomtypeLabel.Location = new System.Drawing.Point(3, 31);
            this.atomtypeLabel.Name = "atomtypeLabel";
            this.atomtypeLabel.Size = new System.Drawing.Size(72, 20);
            this.atomtypeLabel.Text = "Atom Type:";
            // 
            // atomTypeBox
            // 
            this.atomTypeBox.Items.Add("Beta, Gamma and X-rays");
            this.atomTypeBox.Items.Add("Thermal Neutrons");
            this.atomTypeBox.Items.Add("Fast n, a, and protons");
            this.atomTypeBox.Items.Add("Heavy and recoil nuclei");
            this.atomTypeBox.Location = new System.Drawing.Point(75, 31);
            this.atomTypeBox.Name = "atomTypeBox";
            this.atomTypeBox.Size = new System.Drawing.Size(155, 22);
            this.atomTypeBox.TabIndex = 20;
            this.atomTypeBox.SelectedIndexChanged += new System.EventHandler(this.atomTypeBox_SelectedIndexChanged);
            // 
            // comboboxDose
            // 
            this.comboboxDose.Items.Add("Micro");
            this.comboboxDose.Items.Add("Milli");
            this.comboboxDose.Items.Add("Centi");
            this.comboboxDose.Items.Add("Deci");
            this.comboboxDose.Items.Add("Absolute");
            this.comboboxDose.Location = new System.Drawing.Point(75, 3);
            this.comboboxDose.Name = "comboboxDose";
            this.comboboxDose.Size = new System.Drawing.Size(155, 22);
            this.comboboxDose.TabIndex = 11;
            this.comboboxDose.SelectedIndexChanged += new System.EventHandler(this.comboboxDose_SelectedIndexChanged);
            // 
            // DosingLabel
            // 
            this.DosingLabel.Location = new System.Drawing.Point(3, 5);
            this.DosingLabel.Name = "DosingLabel";
            this.DosingLabel.Size = new System.Drawing.Size(56, 20);
            this.DosingLabel.Text = "Dosing:";
            // 
            // InputUpDownBox
            // 
            this.InputUpDownBox.Location = new System.Drawing.Point(75, 57);
            this.InputUpDownBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.InputUpDownBox.Name = "InputUpDownBox";
            this.InputUpDownBox.Size = new System.Drawing.Size(155, 22);
            this.InputUpDownBox.TabIndex = 16;
            this.InputUpDownBox.ValueChanged += new System.EventHandler(this.InputUpDownBox_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TypeInfoLabel);
            this.panel1.Controls.Add(this.radiationtypeRadioButton3);
            this.panel1.Controls.Add(this.radiationtypeRadioButton1);
            this.panel1.Controls.Add(this.radiationtypeRadioButton2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 125);
            // 
            // TypeInfoLabel
            // 
            this.TypeInfoLabel.Location = new System.Drawing.Point(3, 12);
            this.TypeInfoLabel.Name = "TypeInfoLabel";
            this.TypeInfoLabel.Size = new System.Drawing.Size(100, 20);
            this.TypeInfoLabel.Text = "Dosimetry:";
            // 
            // radiationtypeRadioButton3
            // 
            this.radiationtypeRadioButton3.Location = new System.Drawing.Point(4, 66);
            this.radiationtypeRadioButton3.Name = "radiationtypeRadioButton3";
            this.radiationtypeRadioButton3.Size = new System.Drawing.Size(100, 21);
            this.radiationtypeRadioButton3.TabIndex = 15;
            this.radiationtypeRadioButton3.Text = "Roentgen";
            // 
            // radiationtypeRadioButton1
            // 
            this.radiationtypeRadioButton1.Location = new System.Drawing.Point(4, 93);
            this.radiationtypeRadioButton1.Name = "radiationtypeRadioButton1";
            this.radiationtypeRadioButton1.Size = new System.Drawing.Size(100, 21);
            this.radiationtypeRadioButton1.TabIndex = 13;
            this.radiationtypeRadioButton1.Text = "Gray";
            // 
            // radiationtypeRadioButton2
            // 
            this.radiationtypeRadioButton2.Location = new System.Drawing.Point(3, 39);
            this.radiationtypeRadioButton2.Name = "radiationtypeRadioButton2";
            this.radiationtypeRadioButton2.Size = new System.Drawing.Size(100, 21);
            this.radiationtypeRadioButton2.TabIndex = 14;
            this.radiationtypeRadioButton2.Text = "Sievert";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(7, 222);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(226, 20);
            this.RunButton.TabIndex = 19;
            this.RunButton.Text = "Go!";
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.EffectBox);
            this.tabPage2.Controls.Add(this.textBoxCalculation);
            this.tabPage2.Controls.Add(this.ResultListBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 242);
            this.tabPage2.Text = "Output";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.Text = "Closest result in list:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Damage Result:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.Text = "Calculated Result:";
            // 
            // EffectBox
            // 
            this.EffectBox.Location = new System.Drawing.Point(7, 74);
            this.EffectBox.Multiline = true;
            this.EffectBox.Name = "EffectBox";
            this.EffectBox.ReadOnly = true;
            this.EffectBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EffectBox.Size = new System.Drawing.Size(226, 121);
            this.EffectBox.TabIndex = 22;
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Location = new System.Drawing.Point(7, 27);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.ReadOnly = true;
            this.textBoxCalculation.Size = new System.Drawing.Size(230, 21);
            this.textBoxCalculation.TabIndex = 21;
            // 
            // ResultListBox
            // 
            this.ResultListBox.Location = new System.Drawing.Point(7, 221);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.ReadOnly = true;
            this.ResultListBox.Size = new System.Drawing.Size(226, 21);
            this.ResultListBox.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.HelpBox);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(232, 242);
            this.tabPage4.Text = "Help";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.Text = "How to use RadioactivityTool:";
            // 
            // HelpBox
            // 
            this.HelpBox.Location = new System.Drawing.Point(7, 27);
            this.HelpBox.Multiline = true;
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.ReadOnly = true;
            this.HelpBox.Size = new System.Drawing.Size(226, 164);
            this.HelpBox.TabIndex = 22;
            this.HelpBox.Text = resources.GetString("HelpBox.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AboutPanel);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 245);
            this.tabPage3.Text = "About";
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.InfoNoteLabel);
            this.AboutPanel.Controls.Add(this.MainInfoLabel);
            this.AboutPanel.Controls.Add(this.GitHub);
            this.AboutPanel.Controls.Add(this.UNCLabel);
            this.AboutPanel.Controls.Add(this.UNCLogo);
            this.AboutPanel.Location = new System.Drawing.Point(8, 4);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(225, 238);
            // 
            // InfoNoteLabel
            // 
            this.InfoNoteLabel.Location = new System.Drawing.Point(4, 114);
            this.InfoNoteLabel.Name = "InfoNoteLabel";
            this.InfoNoteLabel.Size = new System.Drawing.Size(217, 80);
            this.InfoNoteLabel.Text = "Thank you for using Radioactivity tool!\r\nThis was a school project in 2019, now p" +
                "orted over to Windows Mobile!\r\n\r\nPlease report any issues or similar to:";
            // 
            // MainInfoLabel
            // 
            this.MainInfoLabel.Location = new System.Drawing.Point(4, 4);
            this.MainInfoLabel.Name = "MainInfoLabel";
            this.MainInfoLabel.Size = new System.Drawing.Size(107, 106);
            this.MainInfoLabel.Text = "RadioActivityTool\r\n\r\nBy Quintus Snitjer.\r\nBuilt using VS2008 in 2021.\r\n";
            // 
            // GitHub
            // 
            this.GitHub.Location = new System.Drawing.Point(3, 212);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(218, 20);
            this.GitHub.TabIndex = 4;
            this.GitHub.Text = "https://github.com/dutchcomputerkid";
            // 
            // UNCLabel
            // 
            this.UNCLabel.Location = new System.Drawing.Point(3, 194);
            this.UNCLabel.Name = "UNCLabel";
            this.UNCLabel.Size = new System.Drawing.Size(150, 24);
            this.UNCLabel.TabIndex = 3;
            this.UNCLabel.Text = "https://unitedandco.net";
            // 
            // UNCLogo
            // 
            this.UNCLogo.Image = ((System.Drawing.Image)(resources.GetObject("UNCLogo.Image")));
            this.UNCLogo.Location = new System.Drawing.Point(117, 4);
            this.UNCLogo.Name = "UNCLogo";
            this.UNCLogo.Size = new System.Drawing.Size(105, 107);
            this.UNCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // EffectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "EffectInfo";
            this.Text = "RadioActivity";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.AboutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox atomTypeBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.NumericUpDown InputUpDownBox;
        private System.Windows.Forms.RadioButton radiationtypeRadioButton3;
        private System.Windows.Forms.RadioButton radiationtypeRadioButton2;
        private System.Windows.Forms.RadioButton radiationtypeRadioButton1;
        private System.Windows.Forms.ComboBox comboboxDose;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxCalculation;
        private System.Windows.Forms.TextBox ResultListBox;
        private System.Windows.Forms.TextBox EffectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HelpBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amountInputLabel;
        private System.Windows.Forms.Label atomtypeLabel;
        private System.Windows.Forms.Label DosingLabel;
        private System.Windows.Forms.Label TypeInfoLabel;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.PictureBox UNCLogo;
        private System.Windows.Forms.Label MainInfoLabel;
        private System.Windows.Forms.LinkLabel GitHub;
        private System.Windows.Forms.LinkLabel UNCLabel;
        private System.Windows.Forms.Label InfoNoteLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem ExitButton;

    }
}

