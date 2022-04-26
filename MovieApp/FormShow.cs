using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class FormShow : Form
    {
        public int index = -1;
        public FormShow()
        {
            InitializeComponent();
        }


        private void Show_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + ListMovie.Instance.List[index].Avt);
            pbxAvt.Image = img;
            pbxAvt.SizeMode = PictureBoxSizeMode.StretchImage;

            lblMovieName.Text = ListMovie.Instance.List[index].Movie_name;
            lblActors.Text = ListMovie.Instance.List[index].Actors;
            lblCategory.Text = ListMovie.Instance.List[index].Category;
            lblDirectors.Text = ListMovie.Instance.List[index].Directors;
            lblTime.Text = ListMovie.Instance.List[index].Time;
            lblViews.Text = ListMovie.Instance.List[index].Views.ToString();
            lblDescription.Text = ListMovie.Instance.List[index].Description;


        }

        public event EventHandler<EventArgs> ExitShow;
        public bool isExit = true;

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitShow(this, new EventArgs());//event cũng giống như tham chiếu đến 1 hàm
        }

        private void Show_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormPlayMovie fpm = new FormPlayMovie();
            fpm.index = this.index;
            this.Hide();
            fpm.Show();
            fpm.ExitPlayMovie += Fpm_ExitPlayMovie;

        }

        private void Fpm_ExitPlayMovie(object sender, EventArgs e)
        {
            (sender as FormPlayMovie).isExit = false;
            (sender as FormPlayMovie).Close();
            this.Show();
        }

        private void ptbStar1_Click(object sender, EventArgs e)
        {
            //ptbStar1.BackgroundImage = Resources.
        }
    }
}
