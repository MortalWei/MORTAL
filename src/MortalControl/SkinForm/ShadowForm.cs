//************************************************************************
//      https://github.com/yuzhengyang
//      author:     yuzhengyang
//      date:       2017.4.27 - 2017.8.25
//      desc:       工具描述
//      Copyright (c) yuzhengyang. All rights reserved.
//************************************************************************
using Mortal.Parts;
using Mortal.Utils.WindowsUtils.APIUtils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortal.Skin.Shadow
{
    internal partial class ShadowForm : NoneForm
    {
        internal int ShadowWidth = 15;
        private ShadowFormSkin Skin;
        public ShadowForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;//设置无边框的窗口样式
            ShowInTaskbar = false;

            //StartPosition = FormStartPosition.CenterScreen;
            //FormBorderStyle = FormBorderStyle.None;
            //ShowInTaskbar = false;
            //Padding = new Padding(3, 3, 3, 3);


        }
        private void IrregularForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Skin = new ShadowFormSkin(this);//创建皮肤层
                ShadowForm_LocationChanged(null, null);
                Skin.BackColor = Color.Red;
                Skin.Show();//显示皮肤层
            }
        }

        private void ShadowForm_LocationChanged(object sender, EventArgs e)
        {
            if (Skin != null)
            {
                Skin.Location = new Point(Left - ShadowWidth, Top - ShadowWidth);
                Skin.DrawShadow();
            }
        }

        private void ShadowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner == null) return;
            if (Owner.IsHandleCreated) Owner.Close();
        }
    }
}
