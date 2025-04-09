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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeFitAdmin
{
    public partial class AddPostForm : Form
    {
        public PostItem newPost;

        private string _todaysDate = DateTime.Now.ToString("dd.MM.yyyy");

        public AddPostForm()
        {
            InitializeComponent();

            labelDateNow.Text = _todaysDate;
            buttonSubmin.Visible = false;

            toolTip1.SetToolTip(titleInfo, "This is the article's title. Click for more information.");
            toolTip1.SetToolTip(descInfo, "This is the description of the article. Click for more information.");
            toolTip1.SetToolTip(urlInfo, "This is the image URL. Click for more details.");
            toolTip1.SetToolTip(dateInfo, "This is the publication date of the article. Click for more details.");

        }

        private async void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                newPost = new PostItem(
                    textBoxTitle.Text,
                    textBoxDesc.Text,
                    textBoxImageUrl.Text,
                    labelDateNow.Text);

                pictureBoxRes.Image = await ImageManager.getImageFromUrl(newPost.ImageUrl);
                labelTitleRes.Text = newPost.Title;
                textBoxDescRes.Text = newPost.Description;
                
                buttonSubmin.Visible = true;
            }
            catch(Exception ex)
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
            Rounder.roundBorders(buttonSubmin, 50);
            Rounder.roundBorders(buttonCheck, 50);
            Rounder.roundBorders(panel1, 50);
            Rounder.roundBorders(panel5, 50);
            Rounder.roundBorders(panel6, 50);
            Rounder.roundBorders(panel7, 50);
            Rounder.roundBorders(panel8, 50);
            Rounder.roundBorders(panel9, 50);
            Rounder.roundBorders(pictureBoxRes, 50);
        }

        private void titleInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This title represents the article's name. The title should be short and descriptive. (Max: 10 characters)");
        }

        private void descInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The description provides a brief explanation of what the article is about. It can be used to attract the user's attention. (Max: 1500 characters)");
        }

        private void urlInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This is the link to an image or other resources that illustrate the article. It may be used for embedding media content.");
        }

        private void dateInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This is the publication date of the article. It’s an important element for determining the relevance of the information. ()");
        }
    }
}
