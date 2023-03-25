using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private DataTable dt = new DataTable();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateDataTable();
            FillDataTable(dt);

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.AutoScroll = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Added form = new Added( dt.Rows[i].Field<Image>("Фотография"),
                                        dt.Rows[i].Field<string>("Наименование"), 
                                        dt.Rows[i].Field<string>("Описание"), 
                                        dt.Rows[i].Field<string>("Производитель"),
                                        dt.Rows[i].Field<double>("Цена"));
                form.TopLevel = false;
                form.Dock = DockStyle.Top;
                panel1.Controls.Add(form);
                form.Show();
            }
           
        }

        private void CreateDataTable()
        {
            DataColumn dtColumnPicture = new DataColumn();
            DataColumn dtColumnName = new DataColumn();
            DataColumn dtColumnDesc = new DataColumn();
            DataColumn dtColumnManuf = new DataColumn();
            DataColumn dtColumnPrice = new DataColumn();

            dtColumnPicture.DataType = typeof(Image);
            dtColumnPicture.ColumnName = "Фотография";
            dt.Columns.Add(dtColumnPicture);

            dtColumnName.DataType = typeof(string);
            dtColumnName.ColumnName = "Наименование";
            dt.Columns.Add(dtColumnName);

            dtColumnDesc.DataType = typeof(string);
            dtColumnDesc.ColumnName = "Описание";
            dt.Columns.Add(dtColumnDesc);

            dtColumnManuf.DataType = typeof(string);
            dtColumnManuf.ColumnName = "Производитель";
            dt.Columns.Add(dtColumnManuf);

            dtColumnPrice.DataType = typeof(double);
            dtColumnPrice.ColumnName = "Цена";
            dt.Columns.Add(dtColumnPrice);
        }

        private void FillDataTable(DataTable dt)
        {
            Image productImage;

            dt.Rows.Add(new object[]
            {
                productImage = Resources._1,
                "Товар #1",
                "Описание №1",
                "Производитель №1",
                1000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._2,
                "Товар #2",
                "Описание №2",
                "Производитель №2",
                2000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._3,
                "Товар #3",
                "Описание №3",
                "Производитель №3",
                3000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._4,
                "Товар #4",
                "Описание №4",
                "Производитель №4",
                4000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._5,
                "Товар #5",
                "Описание №5",
                "Производитель №5",
                5000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._6,
                "Товар #6",
                "Описание №6",
                "Производитель №6",
                6000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._7,
                "Товар #7",
                "Описание №7",
                "Производитель №7",
                7000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._8,
                "Товар #8",
                "Описание №8",
                "Производитель №8",
                8000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._9,
                "Товар #9",
                "Описание №9",
                "Производитель №9",
                9000
            });

            dt.Rows.Add(new object[]
            {
                productImage = Resources._10,
                "Товар #10",
                "Описание №10",
                "Производитель №10",
                10000
            });
        }
    }
}
