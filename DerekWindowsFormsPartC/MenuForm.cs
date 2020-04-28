using System;
using System.Windows.Forms;
using WindowsFormsPartC.Unit5;

namespace WindowsFormsPartC
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void runProgram(object sender, EventArgs e)
        {
            if(animationRadioButton.Checked)
            {
                AnimationForm form = new AnimationForm();
                form.Show();
            }
            else if(flyMeRadioButton.Checked)
            {
                FlyMeForm form = new FlyMeForm();
                form.Show();
            }
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
