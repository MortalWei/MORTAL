using MortalLib.Dev.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace MortalDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle myRectangle = new Rectangle(0, 0, this.Width, this.Height);

            ControlPaint.DrawBorder(e.Graphics, myRectangle,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IsSelected", typeof(bool));
            dt.Columns.Add("Name", typeof(string));

            List<TestModel> _List = new List<TestModel>();
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add();
                dt.Rows[i]["IsSelected"] = false;
                dt.Rows[i]["Name"] = "Name" + i;

                var _Model = new TestModel
                {
                    Id = (i + 1).ToString(),
                    Name = "Name" + (i + 1)
                };
                _List.Add(_Model);
            }

            gridMultiLookUpEdit1.Properties.DataSource = _List;// dt.DefaultView;
        }
    }

    public class TestModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Flags]
    public enum TestEnum
    {
        All = 0x0,
        Newly = 0x1,
        Edit = 0x2,
        Write = 0x3
    }
}
