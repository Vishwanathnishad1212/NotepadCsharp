using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace NotepadCSharp.Utils
{
    public class nTextEditor
    {
        RichTextBox _texteditor;
        public nTextEditor(RichTextBox _richtextbox)
        {
            _texteditor = _richtextbox;
        }

        public Font CurrentFont
        {
            get { return MySettings.Default.CurrentFont; }
            set
            {
                _texteditor.Font = MySettings.Default.CurrentFont = value;
                MySettings.Default.Save();
            }
        }
        public string SectionText
        {
            get { return _texteditor.SelectedText; }
            set { _texteditor.SelectedText = value; }
        }
        public int SelectionEnd
        {
            get { return SelectionStart + SelectionLength; }
        }
        public int SelectionStart
        {
            get { return _texteditor.SelectionStart; }
            set
            {
                _texteditor.SelectionStart = value;
                _texteditor.ScrollToCaret();
            }
        }
        public int SelectionLength
        {
            get { return _texteditor.SelectionLength; }
            set { _texteditor.SelectionLength = value; }
        }
        public string Content
        {
            get { return _texteditor.Text; }
            set { _texteditor.Text = value; }
        }
    }
}
