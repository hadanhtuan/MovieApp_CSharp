using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganss.Excel;

namespace MovieApp
{
    public partial class FormHome : Form
    {

        private string filePath = Application.StartupPath + @"\assets\movie.xlsx";
        ImageList imgListLarge;

        public FormHome()
        {
            InitializeComponent();
        }

        #region method
        private void ReadData()
        {
            ListMovie.Instance.List = new ExcelMapper(filePath).Fetch<Movie>().ToList();
        }
        void WriteData()
        {
            var execl = new ExcelMapper();
            execl.Save(filePath, ListMovie.Instance.List);
        }

        void LoadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(150, 200) };
            foreach (var movie in ListMovie.Instance.List)
            {
                imgListLarge.Images.Add(new Bitmap(Application.StartupPath + movie.Avt));
            }
        }

        void LoadListView()
        {
            LoadImageList();
            lsv1.LargeImageList = imgListLarge;

            foreach (var movie in ListMovie.Instance.List)
            {
                ListViewItem item = new ListViewItem();
                item.Text = movie.Movie_name;
                item.ImageIndex = movie.Id;
                lsv1.Items.Add(item);
            }

        }
        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            ReadData();
            LoadListView();

        }

        private void lsv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            foreach (ListViewItem item in lsv.SelectedItems)
            {
                FormShow formShow = new FormShow();
                formShow.index = lsv.Items.IndexOf(item);
                this.Hide();
                formShow.Show();
                formShow.ExitShow += FormShow_ExitShow;
            }






        }

        private void FormShow_ExitShow(object sender, EventArgs e)
        {
            (sender as FormShow).isExit = false;
            (sender as FormShow).Close();
            this.Show();
        }

    }
}
