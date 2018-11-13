using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalDemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var diagJson = System.IO.File.ReadAllText(Application.StartupPath + "\\json\\diags.json");

            /*
             * 反序列化为 Newtonsoft.Json.Linq.JObject
             * 通过 Attribute Name 名称获取值
             */
            var result = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(diagJson);

            /*
             * 状态 0.等待 1.通过 2.失败 3.警告 4.取消 5.无有效操作
             * 诊断接口调用后只可能返回  0 1 2  三种状态的一种
             */
            var status = (int)result["Status"];

            /*
             * 通过 Children() 方法获取 JToken 集合
             */
            var _List = result["Data"].Children();

            var _Str = string.Empty;

            /*
             * 循环 JToken 集合
             */
            foreach (var item in _List)
            {
                _Str += "第一个诊断[" + item["Name"] + "(" + item["Code"] + ")]\r\n";
            }
            MessageBox.Show(_Str);
        }
    }
}
