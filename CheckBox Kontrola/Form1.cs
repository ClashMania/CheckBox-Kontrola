using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {

            textBoxNarudzba.Clear();
            textBoxNarudzba.AppendText("Odabrali ste :" + Environment.NewLine);

            if (checkBoxDorucak.Checked)

                textBoxNarudzba.AppendText("dorucak" + Environment.NewLine);

            if (checkBoxRucak.Checked)

                textBoxNarudzba.AppendText("rucak" + Environment.NewLine);

            if (checkBoxVecera.Checked)

                textBoxNarudzba.AppendText("vecera" + Environment.NewLine);
        }

        private void checkBoxSakrij_CheckedChanged(object sender, EventArgs e)
        {
            { 

                if (textBoxNarudzba.Visible == false)

                    textBoxNarudzba.Visible = true;

                else

                    textBoxNarudzba.Visible = false;

            }
        }
    }
}
