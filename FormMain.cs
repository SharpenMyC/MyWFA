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
            radioButtonStaff.Checked = false;
            radioButtonHealth.Checked = false;
            radioButtonHumanities.Checked = false;
            radioButtonBusiness.Checked = false;
            radioButtonTechnology.Checked = false;

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
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

            textBoxRegister.AppendText("Date Registered: " + dateTimePickerRegisterDate.Value +"\r\n");
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
            textBoxRegister.AppendText("\r\n");

            //Use the Clear Form Button Event
            buttonClear_Click(sender, e);
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
                            ctn.Font = new Font(DefaultFont, FontStyle.Bold);
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
                            ctn.Font = new Font(DefaultFont, FontStyle.Regular);
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
            groupBoxAssociation.Font = new Font(DefaultFont, FontStyle.Bold);
            toolStripStatusLabelMain.Text = "Enter Person's University Association";
        }

        private void radioButtonStudent_Leave(object sender, EventArgs e)
        {
            groupBoxAssociation.Font = new Font(DefaultFont, FontStyle.Regular);
            toolStripStatusLabelMain.Text = "Ready";
        }

        private void radioButtonHealth_Enter(object sender, EventArgs e)
        {
            groupBoxFaculty.Font = new Font(DefaultFont, FontStyle.Bold);
            toolStripStatusLabelMain.Text = "Enter Person's University Faculty";
        }

        private void radioButtonHealth_Leave(object sender, EventArgs e)
        {
            groupBoxFaculty.Font = new Font(DefaultFont, FontStyle.Regular);
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
            toolStripStatusLabelMain.Text = "Form is activated";
        }
    }
}
