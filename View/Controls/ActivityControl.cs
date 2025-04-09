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
    public partial class ActivityControl : UserControl
    {
        List<ActivityItem> activities = new List<ActivityItem>();
        FireBaseService fireBaseService;
        public ActivityControl()
        {
            InitializeComponent();

            fireBaseService = FireBaseService.Instance();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Padding = new Padding(10);
            progressBar1.Style = ProgressBarStyle.Marquee;
            panel1.Visible = false;
        }

        private async void buttonAddPost_Click(object sender, EventArgs e)
        {
            //await fireBaseService.PostActivity(new ActivityItem("https://i.pinimg.com/originals/47/0d/49/470d497f82d1fb2d608fc40a22c2383b.gif", "Side-to-Side Squat Walks", "Start in a squat position and step side-to-side while maintaining the squat. This exercise strengthens the glutes, thighs, and hips while improving balance and stability",30,4,4.5));
            //await fireBaseService.PostActivity(new ActivityItem("https://i.pinimg.com/originals/12/b8/75/12b875db67e1c1767cd9d54f4fe2388b.gif", "Bodyweight Squats", "Stand with feet shoulder-width apart and lower your body into a squat position, keeping your back straight and knees aligned with your toes. This exercise targets the glutes, quadriceps, and hamstrings while improving overall lower-body strength and mobilit", 30, 4, 3.5));
            //await fireBaseService.PostActivity(new ActivityItem("https://i.pinimg.com/originals/6e/02/d5/6e02d57881838d36a318082c122c6adf.gif", "Chair-Assisted Lunges", "Use a chair for balance and perform lunges. This targets the quadriceps, glutes, and hamstrings, while the chair helps maintain proper form.", 30, 3, 4.0));
            //await fireBaseService.PostActivity(new ActivityItem("https://i.pinimg.com/originals/f3/76/04/f37604be4cde7047817ee17429aca263.gif", "Leg Raises", "Start in a squat position and step side-to-side while maintaining the squat. This exercise strengthens the glutes, thighs, and hips while improving balance and stability",30, 5, 3.0));
            //await fireBaseService.PostActivity(new ActivityItem("https://images-ext-1.discordapp.net/external/Gee5DMntXgIm1nuiM5XVwzxm29np1SUVsAiko0PliHY/https/i.gifer.com/7BhQ.gif", "Leg Raises", "Start in a squat position and step side-to-side while maintaining the squat. This exercise strengthens the glutes, thighs, and hips while improving balance and stability", 30, 5, 3.0));
            AddActivityForm form = new AddActivityForm();

            var result = form.ShowDialog();

            if (result == DialogResult.OK && form.newActivity != null)
            {
                await fireBaseService.PostActivity(form.newActivity);
                updateLayoutPabel();
            }

        }

        private async void onPostItemClick(object sender, EventArgs e)
        {
            ActivityItemView clickedItem = sender as ActivityItemView;
            if (clickedItem != null)
            {
                labelTitleRes.Text = clickedItem.ActivityItem.Name;
                textBoxDescRes.Text = clickedItem.ActivityItem.Description;
                labelDuration.Text = clickedItem.ActivityItem.Duration.ToString() + "s";
                labelSets.Text = clickedItem.ActivityItem.Sets.ToString();
                panel1.Visible = true;
                try
                {
                    var image = await ImageManager.getImageFromUrl(clickedItem.ActivityItem.ImageUrl);
                    if (image != null)
                        pictureBoxRes.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private async void onPostDelClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure about that?", "Delete Post from DB", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ActivityItemView posItemView = sender as ActivityItemView;
                    await fireBaseService.DeleteActivity(posItemView.ActivityItem.Name);
                    updateLayoutPabel();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            pictureBoxRes.Invalidate();
        }

        private void ActivityControl_Load(object sender, EventArgs e)
        {
            updateLayoutPabel();
        }
        
        private async void updateLayoutPabel()
        {
            progressBar1.Visible = true;

            activities = await fireBaseService.GetAllActivities();

            flowLayoutPanel1.Controls.Clear();
            List<Control> controlsToAdd = new List<Control>();

            foreach (ActivityItem activity in activities)
            {
                ActivityItemView activityItemView = new ActivityItemView(activity);
                activityItemView.ItemClicked += onPostItemClick;
                activityItemView.ItemDelClick += onPostDelClick;
                controlsToAdd.Add(activityItemView);
            }
            flowLayoutPanel1.Controls.AddRange(controlsToAdd.ToArray());

            progressBar1.Visible = false;
        }

        private void ActivityControl_Paint(object sender, PaintEventArgs e)
        {
            Rounder.roundBorders(buttonAddPost, 50);
            Rounder.roundBorders(panel5, 50);
            Rounder.roundBorders(panel6, 50);
            Rounder.roundBorders(panel1, 25);
            Rounder.roundBorders(pictureBoxRes, 50);
        }
    }
}
