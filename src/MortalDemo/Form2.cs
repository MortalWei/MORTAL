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
using Lenovo.XtraEditors.IEventArgs;

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
            //List<object> _List = new List<object>();
            //_List.Add(new { Id = "1", Name = "张晓辉" });
            //_List.Add(new { Id = "2", Name = "张晓辉" });
            //_List.Add(new { Id = "3", Name = "张晓辉" });
            //_List.Add(new { Id = "4", Name = "张晓辉" });
            //_List.Add(new { Id = "5", Name = "张晓辉" });
            ////lenovoLookUpEdit1.Properties.DataSource = _List;



            //List<object> _List2 = new List<object>();
            //_List2.Add(new { Id = "10201", Name = "张晓辉", InputCode = "ZXH" });
            //_List2.Add(new { Id = "10302", Name = "王英龙", InputCode = "WYL" });
            //_List2.Add(new { Id = "10403", Name = "曹停", InputCode = "CT" });
            //_List2.Add(new { Id = "10504", Name = "李洋", InputCode = "LY" });
            //_List2.Add(new { Id = "11105", Name = "刘峰", InputCode = "LF" });
            //_List2.Add(new { Id = "12106", Name = "周泽生", InputCode = "ZZS" });
            //_List2.Add(new { Id = "13107", Name = "张霁", InputCode = "ZJ" });
            //_List2.Add(new { Id = "23108", Name = "方敏", InputCode = "FM" });
            //_List2.Add(new { Id = "35609", Name = "周平", InputCode = "ZP" });
            //lenovoGridLookUpEdit1.Properties.DataSource = _List2;

            //lenovoGridLookUpEdit1.Properties
            //lenovoTextEdit1.Properties
            //lenovoLookUpEdit1.Properties
            List<object> _List = new List<object>();
            NameHelper _Helper = new NameHelper();
            for (int i = 0; i < 50000; i++)
            {
                var _Id = (i + 1).ToString().PadLeft(10, '0');

                var _Name = _Helper.GetName();
                var _InputCode = NameHelper.GetChineseSpell(_Name);
                _List.Add(new { Id = _Id, Name = _Name, InputCode = _InputCode });
            }
            lenovoGridLookUpEdit1.Properties.DataSource = _List;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lenovoTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

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
