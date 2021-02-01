using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MySecondWindowsFormsApp
{
    public partial class FormMain : Form
    {
        Font fontBold = new Font(DefaultFont, FontStyle.Bold);
        Font fontRegular = new Font(DefaultFont, FontStyle.Regular);
        DateTime startTime;
        DateTime summaryTime;

        int noRecords = 0;
        int noStudentRecords=0;
        float SumAllGradeAverages;  
        float totalGradeAverage;

        int secondsActive;

        public FormMain()
        {
            InitializeComponent();
        }  


        private void buttonRegister_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Press to Register Person";
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                this.Width = this.Width + 20;
                this.Height += 15;
            }
            if (e.KeyChar == '-')
            {
                this.Width -= 20;
                this.Height -= 15;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolTipMain.SetToolTip(this.buttonRegister, "Register new Person");
            //  toolTipMain.SetToolTip(this.checkBoxGender, "Check the Gender if applicable");

            comboBoxSmartPhone.SelectedIndex = 0;
            listBoxLanguage.SelectedIndex = 0;

            startTime = DateTime.Now;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxSmartPhone.SelectedIndex = 0;
            maskedTextBoxTelephone.Text = "";
            checkBoxGender.Checked = false;
            dateTimePickerRegisterDate.Value = System.DateTime.Now;
            listBoxLanguage.SelectedIndex = 0;
            numericUpDownAge.Value = 0;
            textBoxDescription.Clear();
            textBoxName.Text = "";
            toolStripStatusLabelMain.Text = "Ready";
            radioButtonStudent.Checked = true;
            radioButtonStaff.Checked = false;
            radioButtonHealth.Checked = false;
            radioButtonHumanities.Checked = false;
            radioButtonBusiness.Checked = false;
            radioButtonTechnology.Checked = false;
            textBoxGradeMath.Text = "";
            textBoxGradePhysics.Text = "";
            textBoxGradeChemistry.Text = "";


        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if ((textBoxGradeMath.TextLength < 1 || textBoxGradePhysics.TextLength < 1 || textBoxGradeChemistry.TextLength < 1) && radioButtonStudent.Checked)
            {
                MessageBox.Show("Missing Grades");
                textBoxGradeMath.Focus();
            }
            else 
            {
                noRecords += 1;
                textBoxRegister.AppendText("[Record]" + noRecords+ "\r\n");// Add a record number
                textBoxRegister.AppendText("Name: " + textBoxName.Text + "\r\n");
                textBoxRegister.AppendText("Telephone: " + maskedTextBoxTelephone.Text + "\r\n");

                if (checkBoxGender.Checked)
                {
                    textBoxRegister.AppendText("Gender: Gender" + "\r\n");
                }
                else
                {
                    textBoxRegister.AppendText("Gender: No gender" + "\r\n");
                }

                textBoxRegister.AppendText("Date Registered: " + dateTimePickerRegisterDate.Value + "\r\n");
                textBoxRegister.AppendText("Age: " + numericUpDownAge.Value + "\r\n");
                textBoxRegister.AppendText("Smartphone OS: " + comboBoxSmartPhone.Text + "\r\n");
                if (textBoxRegister.Lines.Length > 0)
                {
                    textBoxRegister.AppendText("Description: \r\n");
                    for (int i = 0; i < textBoxDescription.Lines.Length; i++)
                    {
                        textBoxRegister.AppendText(textBoxDescription.Lines[i] + "\r\n");
                    }
                }
                textBoxRegister.AppendText("Language: " + listBoxLanguage.Items[listBoxLanguage.SelectedIndex].ToString() + "\r\n");
                if (radioButtonStaff.Checked)
                {
                    textBoxRegister.AppendText("Member of University Staff" + "\r\n");
                }
                else
                {
                    textBoxRegister.AppendText("Member of the University Student body" + "\r\n");
                }


                textBoxRegister.AppendText("Faculty of ");
                if (radioButtonHealth.Checked)
                {
                    textBoxRegister.AppendText("Health" + "\r\n");
                }
                else if (radioButtonHumanities.Checked)
                {
                    textBoxRegister.AppendText("Humanities" + "\r\n");
                }
                else if (radioButtonBusiness.Checked)
                {
                    textBoxRegister.AppendText("Business" + "\r\n");
                }
                else if (radioButtonTechnology.Checked)
                {
                    textBoxRegister.AppendText("Technology" + "\r\n");
                }
                else
                {
                    textBoxRegister.AppendText("\r\n");
                }

                //Grades
                if (radioButtonStudent.Checked)
                {
                    noStudentRecords++;
                    int MathGrade = 0;
                    int PhysicsGrade = 0;
                    int ChemistryGrade = 0;
                    float GradeAverage=0.0f;

                    
                    MathGrade = Convert.ToInt32(textBoxGradeMath.Text);//int.Parse();
                    PhysicsGrade = int.Parse(textBoxGradePhysics.Text);
                    ChemistryGrade = int.Parse(textBoxGradeChemistry.Text);

                    GradeAverage = ((float)MathGrade + PhysicsGrade + ChemistryGrade) / 3;
                    SumAllGradeAverages += GradeAverage;
                
                    textBoxRegister.AppendText("Grades:" + "\r\n");
                    textBoxRegister.AppendText("Math: " + textBoxGradeMath.Text + "\r\n");
                    textBoxRegister.AppendText("Physics: " + textBoxGradePhysics.Text + "\r\n");
                    textBoxRegister.AppendText("Chemistry: " + textBoxGradeChemistry.Text + "\r\n");
                    textBoxRegister.AppendText("Grade Average:" + GradeAverage.ToString("0.00") + "\r\n");
                    textBoxRegister.AppendText("\r\n");
                }

                textBoxRegister.AppendText("\r\n");

                //Use the Clear Form Button Event
                buttonClear_Click(sender, e);
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            Control anyComponent = sender as Control;
                                 
            if (anyComponent != null)
            {
                //int anyComponentNameLength = anyComponent.Name.Length;
                string anyComponentType = anyComponent.GetType().ToString().Substring(21); //System.Windows.Forms.TextBox  => TextBox

                //Remove Type from Name
                string anyComponentName = anyComponent.Name.Substring(anyComponentType.Length, (anyComponent.Name.Length - anyComponentType.Length)); 
                //Label name to find
                string LabelNameSearch = "label" + anyComponentName;

                foreach (Control ctn in this.Controls)
                {
                    if (ctn is Label)
                    {
                        if (ctn.Name == LabelNameSearch)
                        {
                            ctn.Font = fontBold;
                        }
                    }
                }
                toolStripStatusLabelMain.Text = "Enter Person's " + anyComponentName;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            Control anyComponent = sender as Control;

            if (anyComponent != null)
            {
                //int anyComponentNameLength = anyComponent.Name.Length;
                string anyComponentType = anyComponent.GetType().ToString().Substring(21); //System.Windows.Forms.TextBox  => TextBox

                //Remove Type from Name
                string anyComponentName = anyComponent.Name.Substring(anyComponentType.Length, (anyComponent.Name.Length - anyComponentType.Length));
                //Label name to find
                string LabelNameSearch = "label" + anyComponentName;

                foreach (Control ctn in this.Controls)
                {
                    if (ctn is Label)
                    {
                        if (ctn.Name == LabelNameSearch)
                        {
                            ctn.Font = fontRegular;
                        }
                    }
                }
                toolStripStatusLabelMain.Text = "Ready";
            }
        }

        private void textBoxName_MouseEnter(object sender, EventArgs e)
        {
            Control anyComponent = sender as Control;
            if (anyComponent != null)
            {
                anyComponent.Cursor = Cursors.Hand;
            }            
        }

        private void textBoxName_MouseLeave(object sender, EventArgs e)
        {
            Control anyComponent = sender as Control;
            if (anyComponent != null)
            {
                anyComponent.Cursor = Cursors.Default;
            }
        }

        private void radioButtonStudent_Enter(object sender, EventArgs e)
        {
            groupBoxAssociation.Font = fontBold;
            toolStripStatusLabelMain.Text = "Enter Person's University Association";
        }

        private void radioButtonStudent_Leave(object sender, EventArgs e)
        {
            groupBoxAssociation.Font = fontRegular;
            toolStripStatusLabelMain.Text = "Ready";
        }

        private void radioButtonHealth_Enter(object sender, EventArgs e)
        {
            groupBoxFaculty.Font = fontBold;
            toolStripStatusLabelMain.Text = "Enter Person's University Faculty";
        }

        private void radioButtonHealth_Leave(object sender, EventArgs e)
        {
            groupBoxFaculty.Font = fontRegular;
            toolStripStatusLabelMain.Text = "Ready";
        }

        private void buttonRegister_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Register Person";
        }

        private void buttonRegister_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Ready";
        }

        private void buttonClear_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Clear non registered information";
        }

        private void buttonClear_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Ready";
        }

        private void FormMain_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Ready";
        }

        private void buttonClear_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Clear form";
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Exit application";
        }

        private void maskedTextBoxTelephone_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxTelephone.Text.Length>0)
            {
                this.maskedTextBoxTelephone.Select(maskedTextBoxTelephone.Text.Length, 0);
            }
            else
            {
                this.maskedTextBoxTelephone.Select(0, 0);
            }
            

        }

        private void maskedTextBoxTelephone_Click(object sender, EventArgs e)
        {
           this.maskedTextBoxTelephone.Select(0, 0);
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            timerFormActive.Enabled = true;
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            summaryTime = DateTime.Now;
            System.TimeSpan sessionTime = summaryTime.Subtract(startTime);
            textBoxSummary.AppendText("Summary: \r\n");
            textBoxSummary.AppendText("Session time: " + sessionTime + "\r\n");

            textBoxSummary.AppendText("Registered so far: " + noRecords.ToString()+"\r\n");
 
            //Activity
            //textBoxSummary.AppendText("Seconds Active: " +secondsActive.ToString() + "\r\n");

            //Grade Average of registered
            float TotalGradeAverage = SumAllGradeAverages / noStudentRecords;
            textBoxSummary.AppendText("Grade Average All Registered: " + TotalGradeAverage.ToString("0.00") + "\r\n");
            textBoxSummary.AppendText("\r\n");



            /*
            byte century = 20; //0x00010100
            byte maxByte = 255; //0x11111111

            century = (byte)(century + maxByte);
            uint Test = 2147564343;
            uint Test2 = 3134564343;
            
            Test = Test + Test2;
            string centuryStr = "century = " + century.ToString();

            textBoxSummary.AppendText(centuryStr + "\r\n");
            ushort years = 2000;
            textBoxSummary.AppendText("years = " + Test + "\r\n");
            decimal decimalPI = 3.14159265358979238m;
            textBoxSummary.AppendText("pi = " + decimalPI + "\r\n");
            bool isEmpty = true;
            textBoxSummary.AppendText("isEmtpty = " + isEmpty + "\r\n");
            char ch = 'a';
            textBoxSummary.AppendText("My Character is " + ch + "\r\n");
            string firstName = "John";
            textBoxSummary.AppendText("My first name is " + firstName + "\r\n");
            
            uint a = 0b11000000000000000000000000000000;
            int b = 0;
            uint c;

            c = (a << 2) ;
            
            int input = int.Parse(textBoxInput.Text);
            string byFive;
            string bySeven;

            //Ex2
            byFive = (input % 5 == 0 ? "is divisible by 5" : "is not divisible by 5");
            bySeven = (input % 7 == 0 ? "is divisible by 7" : "is not divisible by 7");
            textBoxSummary.AppendText("input is " + byFive +" and "+ bySeven + "\r\n");

            // Ex1 textBoxSummary.AppendText("input is " + (input%2 == 0?"even" : "odd") + "\r\n");


            //3

            if (textBoxInput.Text.Length > 3)
            {
                textBoxSummary.AppendText("3rd digit is " +(textBoxInput.Text[(textBoxInput.Text.Length - 3)] =='7'?"":"not ")  + "seven \r\n");
            }
            


            //textBoxSummary.AppendText("c=" + + "\r\n");

            //Ex4
            int bitMask = 0b00000000000000000000000000000100;

            textBoxSummary.AppendText("3rd bit of input is " + ((input&bitMask)>>2) +"\r\n");


            

            //Test single point precision versus double
            
            float floatTest = 0.1f;
            double doubleTest = floatTest;

            textBoxSummary.AppendText("Singel: 1 divided by 3 = " + floatTest + "\r\n"); //Convert.ToSingle(1.0f/3.0f)
            textBoxSummary.AppendText("Double: 1 divided by 3 = " + doubleTest + "\r\n");//Convert.ToDouble(1.0 / 3.0)
            textBoxSummary.AppendText("Decimal: 1 divided by 3 = " + Convert.ToDecimal(1.0m / 3.0m) + "\r\n");
            
            int a = 5;
            int b = 4;
            textBoxSummary.AppendText("a+b= " + (a+b) + "\r\n");
            textBoxSummary.AppendText("a+b= " + (a + (b++)) + "\r\n");
            textBoxSummary.AppendText("a+b= " + (a +(++b)) + "\r\n");
                     

            //long a = 218237918739871293;
            //int b = (int)a;
            //string str = "hello";
            //char str3 = str[3];
            //textBoxSummary.AppendText("str[3]= " + str3 + "\r\n");
            
            int controllerMode = 0;
            controllerMode = int.Parse(textBoxInput.Text);

            switch (controllerMode)
            {
                case 0:
                    textBoxSummary.AppendText("Controller in Manual Mode \r\n");
                    break;
                case 1:
                    textBoxSummary.AppendText("Controller in Auto Mode \r\n");
                    break;
                case 2:
                case 3:    
                    textBoxSummary.AppendText("Controller in Tuning Mode \r\n");
                    break;
                default:
                    textBoxSummary.AppendText("No Controller Mode selected \r\n");
                    break;
            }


            


            switch ((int)numericUpDownAge.Value)
            {
                case int n when n < 16 :
                    textBoxSummary.AppendText("Child");
                    break;
                case int n when n >= 18 && n < 70:
                    textBoxSummary.AppendText("Adult");
                    break;
                case int n when n >= 70:
                    textBoxSummary.AppendText("Retiree");
                    break;
                default:
                    break;
            }

            */

        }

        private void timerFormActive_Tick(object sender, EventArgs e)
        {
            secondsActive += 1;
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            timerFormActive.Enabled = false;
        }

        private void radioButtonStaff_CheckedChanged(object sender, EventArgs e)
        {
            /* if (radioButtonStaff.Checked)
             {
                 groupBoxGrades.Visible = false;
             }
             else
             {
                 groupBoxGrades.Visible = true;
             }
            */
            groupBoxGrades.Visible = !radioButtonStaff.Checked;


        }


        private void textBoxMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] grades = { '1', '2', '3', '4', '5', '6' };

            TextBox anyTextBox = sender as TextBox;

            if (anyTextBox != null)
            {
                if (anyTextBox.TextLength == 0)
                {
                    if (grades.Contains(e.KeyChar) != true)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBoxSmartPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSmartPhone.SelectedIndex)
            {
                case 0:
                    pictureBoxOSLogo.Image = Properties.Resources.androidLogo;
                    break;
                case 1:
                    pictureBoxOSLogo.Image = Properties.Resources.iosLogo;
                    break;
                case 2:
                    pictureBoxOSLogo.Image = Properties.Resources.ubuntuLogo;
                    break;
                case 3:
                    pictureBoxOSLogo.Image = Properties.Resources.blackberryLogo;
                    break;
                default:
                    pictureBoxOSLogo.Image = Properties.Resources.whatOS;
                    
                    break;

                /*Android
                iPhone
                Ubuntuphone
                BlackBerry*/
            
            
            }

        }

        private void textBoxPhysics_KeyPress(object sender, KeyPressEventArgs e)
        {
        switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                    break;
                default:
                    e.Handled = true;
                    break;
            }

            

        }

        private void buttonSummary_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Generate a summary of the total records and grade average.";
        }

        private void FormMain_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Ready";
        }

    

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '\b':
                    break;
                default:
                    break;
            }
        }
    }
}
