using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotepadCSharp.Utils;
namespace NotepadCSharp.Menus
{
    public class FormateMenu
    {
        RichTextBox _richtexbox;
        MenuItem _wordWrap;
        nTextEditor _nEditor;
        public FormateMenu(RichTextBox _richTextbox, MenuItem _isWordWrap)
        {
            _richtexbox = _richTextbox;
            _wordWrap = _isWordWrap;
            _nEditor = new nTextEditor(_richTextbox);
        }


        private bool WordWrap
        {
            get { return MySettings.Default.IsWordWrap; }
            set
            {
                _wordWrap.Checked = _richtexbox.WordWrap = MySettings.Default.IsWordWrap = value;
                MySettings.Default.Save();
            }
        }
        public void FormateFont()
        {
            FontDialog _fontdia = new FontDialog();
            _fontdia.Font = _nEditor.CurrentFont;
            if (_fontdia.ShowDialog() != DialogResult.OK) { return; }
            _nEditor.CurrentFont = _fontdia.Font;
        }
        public void FormateWordWrap()
        {
            WordWrap = !WordWrap;
        }
    }
}
