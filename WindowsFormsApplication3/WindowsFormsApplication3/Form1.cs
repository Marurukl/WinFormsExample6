using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class FormForGetInfo : Form
    {
        public FormForGetInfo()
        {
            InitializeComponent();
        }

        private void FormForGetInfo_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            int dayInMonth = 31; int monthInYear = 31;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((Int32.Parse(textBoxDay.Text) > dayInMonth) || (Int32.Parse(textBoxMonth.Text) > monthInYear))
                {
                    MessageBox.Show("Неправильно была введена дата рождения!");
                    textBoxDay.Clear();
                }
                else {
                    StreamWriter fw = new StreamWriter(saveFile.FileName, true);
                    fw.WriteLine("{0} : {1}", labelName.Text, textBoxName.Text);
                    fw.WriteLine("{0} : {1}", labelSurName.Text, textBoxSurName.Text);
                    fw.WriteLine("{0} : {1}", labelPatronymic.Text, textBoxPatronymic.Text);              
                    fw.WriteLine("{0} : {1} , {2} , {3}", labelBirthDay.Text, textBoxDay.Text, textBoxMonth.Text, textBoxYear.Text);
                    if (radioButtonMale.Checked)
                    {
                        fw.WriteLine("{0} : {1}" , labelSex.Text , radioButtonMale.Text);
                    }
                    else if (radioButtonFemale.Checked)
                    {
                        fw.WriteLine("{0} : {1}", labelSex.Text, radioButtonFemale.Text);
                    }
                    fw.WriteLine("{0} : {1}", labelMaritalStatus.Text, textBoxMaritalStatus.Text);
                    fw.WriteLine("{0} : {1}", labelAdditionalInfo.Text, textBoxAdditionalInfo.Text);
                    fw.Close();
                }
            }
        }

        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;

        }
    }
}
