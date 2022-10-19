using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NotepadCSharp.Menus
{
    public class ViewMenu
    {
        RichTextBox _Xrichtextbox;
        MenuItem _xStatusbarmenu;
        ToolStripStatusLabel _XlbllnCol;
        StatusStrip _XstatusBar;
        public ViewMenu(RichTextBox _Yrichtextbox,MenuItem _YStatusbarmenu,ToolStripStatusLabel _YlbllnCol,StatusStrip _Ystatusbar)
        {
            _Xrichtextbox = _Yrichtextbox;
            _xStatusbarmenu = _YStatusbarmenu;
            _XlbllnCol = _YlbllnCol;
            _XstatusBar = _Ystatusbar;
        }


        private bool IsStatusBar
        {
            get { return MySettings.Default.IsStatusBar; }
            set
            {
                _XstatusBar.Visible = _xStatusbarmenu.Checked = MySettings.Default.IsStatusBar = value;
                MySettings.Default.Save();
            }
        }

        public void StatusBarMenu()
        {
            IsStatusBar = !IsStatusBar;
        }

        public void UpdateStatusBar()
        {
            int Position = _Xrichtextbox.SelectionStart;
            int Lines = _Xrichtextbox.GetLineFromCharIndex(Position) + 1;
            int Columns = Position - _Xrichtextbox.GetFirstCharIndexOfCurrentLine() + 1;
            _XlbllnCol.Text = "Ln= " + Lines + ", Col=" + Columns;
        }
    }
}
