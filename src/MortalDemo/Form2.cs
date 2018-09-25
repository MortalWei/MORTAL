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
            GridLookUpEdit dd = new GridLookUpEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lenovoTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

        }

        private void treeList1_CustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {

        }

        private void treeList1_CustomNodeCellEditForEditing(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {

        }

        private void treeList1_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {

        }

        private void treeList1_ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        private void treeList1_ShownEditor(object sender, EventArgs e)
        {

        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            //var type = typeof(IGridColumnEventArgs);
            var Assemblies = AppDomain.CurrentDomain.GetAssemblies();
            ////var _Ass = Assemblies[16];
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(s => s.GetTypes());
            //var result = types.Where(p => type.IsAssignableFrom(p));

            var interfaceImplements = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(item => item.GetInterfaces().Contains(typeof(IGridColumnEventArgs)))
                .Select(type => (IGridColumnEventArgs)Activator.CreateInstance(type)).ToList();

            var interfaceImplements2 = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(item => item.GetInterfaces().Contains(typeof(IGridColumnEventArgs)) && item.Namespace == "MortalDemo.HYGrid").ToList();

            //---------------------

            //本文来自 yinyongxian 的CSDN 博客 ，全文地址请点击：https://blog.csdn.net/yinyongxian/article/details/55520007?utm_source=copy 

            //var _MTypes = _Ass.GetTypes();
            //var _MType = _MTypes[10];
            //if (type.IsAssignableFrom(_MType))
            //{

            //}
            //var _MType2 = _MTypes[13];
            //if (type.IsAssignableFrom(_MType2))
            //{

            //}
            //---------------------

            //本文来自 ZhouYaoo 的CSDN 博客 ，全文地址请点击：https://blog.csdn.net/zm_husband/article/details/75106250?utm_source=copy 
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
