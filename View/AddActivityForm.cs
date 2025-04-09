using BeFitAdmin.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFitAdmin
{
    public partial class AddActivityForm : Form
    {
        public ActivityItem newActivity;

        public AddActivityForm()
        {
            InitializeComponent();
        }

        private async void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int duration = int.Parse(textBoxDuration.Text);
                int sets = int.Parse(textBoxSets.Text);
                int met = int.Parse(textBoxMet.Text);

                newActivity = new ActivityItem(
                    textBoxImageUrl.Text,
                    textBoxName.Text,
                    textBoxDesc.Text,
                    duration,
                    sets,
                    met
                    );

                pictureBoxRes.Image = await ImageManager.getImageFromUrl(newActivity.ImageUrl);
                labelTitleRes.Text = newActivity.Name;
                textBoxDescRes.Text = newActivity.Description;

                buttonSubmin.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSubmin_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelConfigPost_Paint(object sender, PaintEventArgs e)
        {
            Rounder.roundBorders(buttonCheck, 50);
            Rounder.roundBorders(buttonSubmin, 50);
            Rounder.roundBorders(panel5, 50);
            Rounder.roundBorders(panel6, 50);
            Rounder.roundBorders(panel1, 25);
            Rounder.roundBorders(panel7, 25);
            Rounder.roundBorders(panel8, 25);
            Rounder.roundBorders(panel2, 25);
            Rounder.roundBorders(panel4, 25);
            Rounder.roundBorders(panel9, 25);
            Rounder.roundBorders(panel10, 25);
            Rounder.roundBorders(pictureBoxRes, 50);
        }
    }
}
