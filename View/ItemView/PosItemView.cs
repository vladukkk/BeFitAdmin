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
    public partial class PosItemView : UserControl
    {
        public EventHandler ItemClicked;
        public EventHandler ItemDelClick;

        public PosItemView()
        {
            InitializeComponent();
        }

        private void PosItem_Load(object sender, EventArgs e)
        {

        }

        #region properties

        private Image _image;
        private string _title;
        private string _descriprion;
        private string _date;

        [Category("Custom Props")]
        public Image postImage
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Descriprion
        {
            get { return _descriprion; }
            set { _descriprion = value; textBoxDesc.Text = value; }
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set
            { _date = value;labelDate.Text = value; }
        }

        #endregion

        private void textBoxDesc_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemDelClick?.Invoke(this, e);
        }
    }
}
