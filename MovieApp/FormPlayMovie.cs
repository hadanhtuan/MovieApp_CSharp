using System;
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
    public partial class FormPlayMovie : Form
    {
        public int index = -1;

        public FormPlayMovie()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> ExitPlayMovie;
        public bool isExit = true;

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitPlayMovie(this, new EventArgs());//event cũng giống như tham chiếu đến 1 hàm
        }

        private void FormPlayMovie_Load(object sender, EventArgs e)
        {
            wmp1.URL = Application.StartupPath + ListMovie.Instance.List[index].Url;
            lblMovieName.Text = ListMovie.Instance.List[index].Movie_name;

        }

        private void FormPlayMovie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
    }
}






