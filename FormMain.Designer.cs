
namespace MySecondWindowsFormsApp
{
    partial class FormMain
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
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxSmartPhone = new System.Windows.Forms.ComboBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.labelRegisterDate = new System.Windows.Forms.Label();
            this.checkBoxGender = new System.Windows.Forms.CheckBox();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.listBoxLanguage = new System.Windows.Forms.ListBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSmartPhone = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainRadioGroups = new System.Windows.Forms.Panel();
            this.groupBoxFaculty = new System.Windows.Forms.GroupBox();
            this.radioButtonTechnology = new System.Windows.Forms.RadioButton();
            this.radioButtonBusiness = new System.Windows.Forms.RadioButton();
            this.radioButtonHumanities = new System.Windows.Forms.RadioButton();
            this.radioButtonHealth = new System.Windows.Forms.RadioButton();
            this.groupBoxAssociation = new System.Windows.Forms.GroupBox();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxRegister = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panelMainRadioGroups.SuspendLayout();
            this.groupBoxFaculty.SuspendLayout();
            this.groupBoxAssociation.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Tag = "Name";
            this.labelName.Text = "Name";
            // 
            // comboBoxSmartPhone
            // 
            this.comboBoxSmartPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSmartPhone.FormattingEnabled = true;
            this.comboBoxSmartPhone.Items.AddRange(new object[] {
            "Android",
            "iPhone",
            "Ubuntuphone",
            "BlackBerry"});
            this.comboBoxSmartPhone.Location = new System.Drawing.Point(86, 169);
            this.comboBoxSmartPhone.Name = "comboBoxSmartPhone";
            this.comboBoxSmartPhone.Size = new System.Drawing.Size(201, 21);
            this.comboBoxSmartPhone.TabIndex = 6;
            this.toolTipMain.SetToolTip(this.comboBoxSmartPhone, "Smartphone OS");
            this.comboBoxSmartPhone.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.comboBoxSmartPhone.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.comboBoxSmartPhone.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.comboBoxSmartPhone.MouseLeave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(16, 71);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(58, 13);
            this.labelTelephone.TabIndex = 2;
            this.labelTelephone.Tag = "Telephone";
            this.labelTelephone.Text = "Telephone";
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(86, 68);
            this.maskedTextBoxTelephone.Mask = "00 00 00 00";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxTelephone.TabIndex = 2;
            this.maskedTextBoxTelephone.Tag = "Telephone";
            this.toolTipMain.SetToolTip(this.maskedTextBoxTelephone, "Person\'s Telephone Number");
            this.maskedTextBoxTelephone.Click += new System.EventHandler(this.maskedTextBoxTelephone_Click);
            this.maskedTextBoxTelephone.Enter += new System.EventHandler(this.maskedTextBoxTelephone_Enter);
            this.maskedTextBoxTelephone.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.maskedTextBoxTelephone.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.maskedTextBoxTelephone.MouseLeave += new System.EventHandler(this.textBoxName_MouseLeave);
            // 
            // labelRegisterDate
            // 
            this.labelRegisterDate.AutoSize = true;
            this.labelRegisterDate.Location = new System.Drawing.Point(16, 123);
            this.labelRegisterDate.Name = "labelRegisterDate";
            this.labelRegisterDate.Size = new System.Drawing.Size(30, 13);
            this.labelRegisterDate.TabIndex = 4;
            this.labelRegisterDate.Text = "Date";
            // 
            // checkBoxGender
            // 
            this.checkBoxGender.AutoSize = true;
            this.checkBoxGender.Location = new System.Drawing.Point(87, 94);
            this.checkBoxGender.Name = "checkBoxGender";
            this.checkBoxGender.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGender.TabIndex = 3;
            this.checkBoxGender.Text = "Gender";
            this.toolTipMain.SetToolTip(this.checkBoxGender, "Check my Gender\r\n");
            this.checkBoxGender.UseVisualStyleBackColor = true;
            this.checkBoxGender.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.checkBoxGender.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.checkBoxGender.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.checkBoxGender.MouseLeave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(86, 117);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerRegisterDate.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.dateTimePickerRegisterDate, "Set the registration date");
            this.dateTimePickerRegisterDate.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.dateTimePickerRegisterDate.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.dateTimePickerRegisterDate.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.dateTimePickerRegisterDate.MouseLeave += new System.EventHandler(this.textBoxName_MouseLeave);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(15, 292);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 7;
            this.labelLanguage.Text = "Language";
            // 
            // listBoxLanguage
            // 
            this.listBoxLanguage.FormattingEnabled = true;
            this.listBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "Finnish",
            "German",
            "Norwegian"});
            this.listBoxLanguage.Location = new System.Drawing.Point(87, 290);
            this.listBoxLanguage.Name = "listBoxLanguage";
            this.listBoxLanguage.Size = new System.Drawing.Size(200, 82);
            this.listBoxLanguage.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.listBoxLanguage, "Select Persons\'s Main Language");
            this.listBoxLanguage.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.listBoxLanguage.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.listBoxLanguage.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.listBoxLanguage.MouseLeave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(86, 143);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownAge.TabIndex = 5;
            this.toolTipMain.SetToolTip(this.numericUpDownAge, "Person\'s age");
            this.numericUpDownAge.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.numericUpDownAge.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(16, 145);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age";
            this.labelAge.UseWaitCursor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(86, 196);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(201, 88);
            this.textBoxDescription.TabIndex = 7;
            this.toolTipMain.SetToolTip(this.textBoxDescription, "Description of Academic position");
            this.textBoxDescription.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxDescription.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.textBoxDescription.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.textBoxDescription.MouseLeave += new System.EventHandler(this.textBoxName_MouseLeave);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Tag = "Name";
            this.toolTipMain.SetToolTip(this.textBoxName, "Person\'s Firstname Lastname");
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.textBoxName.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            this.textBoxName.MouseLeave += new System.EventHandler(this.textBoxName_MouseLeave);
            // 
            // labelSmartPhone
            // 
            this.labelSmartPhone.AutoSize = true;
            this.labelSmartPhone.Location = new System.Drawing.Point(16, 172);
            this.labelSmartPhone.Name = "labelSmartPhone";
            this.labelSmartPhone.Size = new System.Drawing.Size(64, 13);
            this.labelSmartPhone.TabIndex = 12;
            this.labelSmartPhone.Text = "Smartphone";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(16, 199);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 408);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(785, 22);
            this.statusStripMain.TabIndex = 16;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabelMain.Text = "toolStripStatusLabelMain";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(785, 24);
            this.menuStripMain.TabIndex = 17;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "&Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelMainRadioGroups
            // 
            this.panelMainRadioGroups.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMainRadioGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainRadioGroups.Controls.Add(this.groupBoxFaculty);
            this.panelMainRadioGroups.Controls.Add(this.groupBoxAssociation);
            this.panelMainRadioGroups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMainRadioGroups.Location = new System.Drawing.Point(305, 41);
            this.panelMainRadioGroups.Name = "panelMainRadioGroups";
            this.panelMainRadioGroups.Size = new System.Drawing.Size(235, 331);
            this.panelMainRadioGroups.TabIndex = 9;
            // 
            // groupBoxFaculty
            // 
            this.groupBoxFaculty.Controls.Add(this.radioButtonTechnology);
            this.groupBoxFaculty.Controls.Add(this.radioButtonBusiness);
            this.groupBoxFaculty.Controls.Add(this.radioButtonHumanities);
            this.groupBoxFaculty.Controls.Add(this.radioButtonHealth);
            this.groupBoxFaculty.Location = new System.Drawing.Point(17, 107);
            this.groupBoxFaculty.Name = "groupBoxFaculty";
            this.groupBoxFaculty.Size = new System.Drawing.Size(199, 135);
            this.groupBoxFaculty.TabIndex = 12;
            this.groupBoxFaculty.TabStop = false;
            this.groupBoxFaculty.Text = "Faculty";
            // 
            // radioButtonTechnology
            // 
            this.radioButtonTechnology.AutoSize = true;
            this.radioButtonTechnology.Location = new System.Drawing.Point(67, 99);
            this.radioButtonTechnology.Name = "radioButtonTechnology";
            this.radioButtonTechnology.Size = new System.Drawing.Size(81, 17);
            this.radioButtonTechnology.TabIndex = 16;
            this.radioButtonTechnology.TabStop = true;
            this.radioButtonTechnology.Text = "Technology";
            this.radioButtonTechnology.UseVisualStyleBackColor = true;
            this.radioButtonTechnology.Enter += new System.EventHandler(this.radioButtonHealth_Enter);
            this.radioButtonTechnology.Leave += new System.EventHandler(this.radioButtonHealth_Leave);
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.AutoSize = true;
            this.radioButtonBusiness.Location = new System.Drawing.Point(67, 76);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(67, 17);
            this.radioButtonBusiness.TabIndex = 15;
            this.radioButtonBusiness.TabStop = true;
            this.radioButtonBusiness.Text = "Business";
            this.radioButtonBusiness.UseVisualStyleBackColor = true;
            this.radioButtonBusiness.Enter += new System.EventHandler(this.radioButtonHealth_Enter);
            this.radioButtonBusiness.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // radioButtonHumanities
            // 
            this.radioButtonHumanities.AutoSize = true;
            this.radioButtonHumanities.Location = new System.Drawing.Point(67, 53);
            this.radioButtonHumanities.Name = "radioButtonHumanities";
            this.radioButtonHumanities.Size = new System.Drawing.Size(77, 17);
            this.radioButtonHumanities.TabIndex = 14;
            this.radioButtonHumanities.TabStop = true;
            this.radioButtonHumanities.Text = "Humanities";
            this.radioButtonHumanities.UseVisualStyleBackColor = true;
            this.radioButtonHumanities.Enter += new System.EventHandler(this.radioButtonHealth_Enter);
            this.radioButtonHumanities.Leave += new System.EventHandler(this.radioButtonHealth_Leave);
            // 
            // radioButtonHealth
            // 
            this.radioButtonHealth.AutoSize = true;
            this.radioButtonHealth.Location = new System.Drawing.Point(67, 30);
            this.radioButtonHealth.Name = "radioButtonHealth";
            this.radioButtonHealth.Size = new System.Drawing.Size(56, 17);
            this.radioButtonHealth.TabIndex = 13;
            this.radioButtonHealth.TabStop = true;
            this.radioButtonHealth.Text = "Health";
            this.toolTipMain.SetToolTip(this.radioButtonHealth, "Select Person\'s Faculty");
            this.radioButtonHealth.UseVisualStyleBackColor = true;
            this.radioButtonHealth.Enter += new System.EventHandler(this.radioButtonHealth_Enter);
            this.radioButtonHealth.Leave += new System.EventHandler(this.radioButtonHealth_Leave);
            // 
            // groupBoxAssociation
            // 
            this.groupBoxAssociation.Controls.Add(this.radioButtonStaff);
            this.groupBoxAssociation.Controls.Add(this.radioButtonStudent);
            this.groupBoxAssociation.Location = new System.Drawing.Point(17, 15);
            this.groupBoxAssociation.Name = "groupBoxAssociation";
            this.groupBoxAssociation.Size = new System.Drawing.Size(200, 80);
            this.groupBoxAssociation.TabIndex = 9;
            this.groupBoxAssociation.TabStop = false;
            this.groupBoxAssociation.Text = "University";
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Location = new System.Drawing.Point(68, 46);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(47, 17);
            this.radioButtonStaff.TabIndex = 11;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            this.radioButtonStaff.Enter += new System.EventHandler(this.radioButtonStudent_Enter);
            this.radioButtonStaff.Leave += new System.EventHandler(this.radioButtonStudent_Leave);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Checked = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(68, 23);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(62, 17);
            this.radioButtonStudent.TabIndex = 10;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.toolTipMain.SetToolTip(this.radioButtonStudent, "Select Person\'s University Affiliation");
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.Enter += new System.EventHandler(this.radioButtonStudent_Enter);
            this.radioButtonStudent.Leave += new System.EventHandler(this.radioButtonStudent_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(465, 378);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 17;
            this.buttonRegister.Text = "&Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            this.buttonRegister.Enter += new System.EventHandler(this.buttonRegister_Enter);
            this.buttonRegister.Leave += new System.EventHandler(this.buttonRegister_Leave);
            this.buttonRegister.MouseHover += new System.EventHandler(this.buttonRegister_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(384, 378);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.Enter += new System.EventHandler(this.buttonClear_Enter);
            this.buttonClear.Leave += new System.EventHandler(this.buttonClear_Leave);
            this.buttonClear.MouseHover += new System.EventHandler(this.buttonClear_MouseHover);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(698, 378);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "E&xit";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // toolTipMain
            // 
            this.toolTipMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTipMain.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolTipMain.StripAmpersands = true;
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxRegister.Location = new System.Drawing.Point(562, 41);
            this.textBoxRegister.Multiline = true;
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.ReadOnly = true;
            this.textBoxRegister.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRegister.Size = new System.Drawing.Size(211, 331);
            this.textBoxRegister.TabIndex = 20;
            this.textBoxRegister.TabStop = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(16, 95);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 21;
            this.labelGender.Tag = "Gender";
            this.labelGender.Text = "Gender";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxRegister);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.panelMainRadioGroups);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSmartPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.listBoxLanguage);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.dateTimePickerRegisterDate);
            this.Controls.Add(this.checkBoxGender);
            this.Controls.Add(this.labelRegisterDate);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.comboBoxSmartPhone);
            this.Controls.Add(this.labelName);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWFA";
            this.toolTipMain.SetToolTip(this, "heisann");
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelMainRadioGroups.ResumeLayout(false);
            this.groupBoxFaculty.ResumeLayout(false);
            this.groupBoxFaculty.PerformLayout();
            this.groupBoxAssociation.ResumeLayout(false);
            this.groupBoxAssociation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxSmartPhone;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private System.Windows.Forms.Label labelRegisterDate;
        private System.Windows.Forms.CheckBox checkBoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDate;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ListBox listBoxLanguage;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSmartPhone;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelMainRadioGroups;
        private System.Windows.Forms.GroupBox groupBoxAssociation;
        private System.Windows.Forms.RadioButton radioButtonStaff;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.GroupBox groupBoxFaculty;
        private System.Windows.Forms.RadioButton radioButtonTechnology;
        private System.Windows.Forms.RadioButton radioButtonBusiness;
        private System.Windows.Forms.RadioButton radioButtonHumanities;
        private System.Windows.Forms.RadioButton radioButtonHealth;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.TextBox textBoxRegister;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

