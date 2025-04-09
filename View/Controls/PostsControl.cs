using BeFitAdmin.tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeFitAdmin
{
    public partial class PostsControl : UserControl
    {
        private string firebaseUrl = "https://trainingapp-7f481-default-rtdb.europe-west1.firebasedatabase.app/";
        private FireBaseService fireBaseService;
        private List<PostItem> posts;

        public PostsControl()
        {
            InitializeComponent();
            fireBaseService = FireBaseService.Instance();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Padding = new Padding(10);
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void PostsControl_Load(object sender, EventArgs e)
        {
            updateLayoutPabel();
        }

        private async void updateLayoutPabel()
        {
            progressBar1.Visible = true;

            posts = await fireBaseService.GetAllPosts();

            flowLayoutPanel1.Controls.Clear();
            List<Control> controlsToAdd = new List<Control>();

            foreach (PostItem post in posts)
            {
                PosItemView posItem = new PosItemView
                {
                    Title = post.Title,
                    Descriprion = post.Description.Length > 100 ? post.Description.Substring(0, 100) + "..." : post.Description,
                    Date = post.CreatedDate,
                    postImage = await ImageManager.getImageFromUrl(post.ImageUrl)
                };
                posItem.ItemClicked += onPostItemClick;
                posItem.ItemDelClick += onPostItemDelClick;
                controlsToAdd.Add(posItem);
            }
            flowLayoutPanel1.Controls.AddRange(controlsToAdd.ToArray());


            progressBar1.Visible = false;
        }

        private void onPostItemClick(object sender, EventArgs e)
        {
            PosItemView clickedItem = sender as PosItemView;
            if (clickedItem != null)
            {
                int index = flowLayoutPanel1.Controls.IndexOf(clickedItem);
                pictureBoxRes.Image = clickedItem.postImage;
                labelTitleRes.Text = clickedItem.Title;
                textBoxDescRes.Text = posts[index].Description;
            }

        }

        private async void onPostItemDelClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure about that?", "Delete Post from DB", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PosItemView posItemView = sender as PosItemView;
                await fireBaseService.deletePost(posItemView.Title);
                updateLayoutPabel();
            }
        }

        private void PostsControl_Paint(object sender, PaintEventArgs e)
        {
            Rounder.roundBorders(buttonAddPost, 50);
            Rounder.roundBorders(panel5, 50);
            Rounder.roundBorders(panel6, 50);
            Rounder.roundBorders(pictureBoxRes, 50);
        }

        private async void buttonAddPost_Click_1(object sender, EventArgs e)
        {
            AddPostForm form = new AddPostForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK && form.newPost != null)
            {
                await fireBaseService.post(form.newPost);
                updateLayoutPabel();
            }
        }
    }
}
