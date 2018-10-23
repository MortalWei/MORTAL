using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoSimpleButton : SimpleButton
    {
        public LenovoSimpleButton()
        {
            LookAndFeel.UseDefaultLookAndFeel = false;
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
        }

        static LenovoSimpleButton()
        {

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
