using System;

using System.Drawing;

using System.Windows.Forms;

namespace GroupesTest
{
    public partial class FormGroupesTest : Form
    {
        public FormGroupesTest()
        {
            InitializeComponent();
        }
        private void FormGroupesTest_Load(object sender, EventArgs e)
        {
            Button btn;
            int i;
            for (i = 1; i <= 5; i++)
            {
                btn = new Button();
                btn.Text = i.ToString();
                btn.Location = new Point(0, i * 25);
                gbxGroupe.Controls.Add(btn);
                btn.Click += ClicSurUnBouton;
            }
        } // Load
        private void ClicSurUnBouton(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)(sender)).Text);
            // On peut écrie également MessageBox.Show(((Control)(sender)).Text);

        } // ClicSurUnBouton
   }

}