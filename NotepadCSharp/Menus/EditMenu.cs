using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotepadCSharp.NotepadForm;
using NotepadCSharp.Utils;
namespace NotepadCSharp.Menus
{
    public class EditMenu
    {
        RichTextBox _richtxtbox;
        nTextEditor _ntextEditor;
        public EditMenu(RichTextBox _richtextbox)
        {
            _richtxtbox = _richtextbox;
            _ntextEditor = new nTextEditor(_richtextbox);
        }
        //Undo
        public void Undo() { _richtxtbox.Undo(); }
        //Cut
        public void Cut() { _richtxtbox.Cut(); }
        //Copy
        public void Copy() { _richtxtbox.Copy(); }
        //Paste
        public void Paste() { _richtxtbox.Paste(); }
        //Delete
        public void Delete() {
            if (_ntextEditor.SelectionLength == 0)
            {
                _ntextEditor.SelectionLength = 1;
                _ntextEditor.Content = "";
            }
        }
        //SelectAll
        public void SelectAll() { _richtxtbox.SelectAll(); }
        //DateTime
        public void Date_Time() {
            _richtxtbox.Text = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }
        //Find
        public void Find()
        {
            ShowFindDialog();
        }
        //FindNext
        public void FindNext()
        {
            if (_XFindValue == null) { ShowFindDialog(); }
            else
            {
                sFind(_richtxtbox, _XFindValue, _xchkMatchCase, _xchkMatchWholeCase, _Xupdirection);
            }
        }
        //Replace
        public void Replace()
        {
            ShowReplaceDialog();
        }
        //Goto
        public void Goto()
        {
            ShowGotoDialoge();
        }

        string _XFindValue;
        bool _xchkMatchCase;
        bool _xchkMatchWholeCase;
        bool _Xupdirection;

        //sFind Functions
        public void sFind(RichTextBox _textbox, string _findtxt, bool chkMatchCase,bool chkMatchWholeCase,bool Updirection)
        {

            _XFindValue = _findtxt;
            _xchkMatchCase = chkMatchCase;
            _xchkMatchWholeCase = chkMatchWholeCase;
            _Xupdirection = Updirection;
            RichTextBoxFinds _options = new RichTextBoxFinds();
            if (chkMatchCase) { _options |= RichTextBoxFinds.MatchCase; }
            if (chkMatchWholeCase) { _options |= RichTextBoxFinds.WholeWord; }
            if (Updirection) { _options |= RichTextBoxFinds.Reverse; }

            int Index;
            if (Updirection)
            {
                Index = _textbox.Find(_findtxt, 0, _textbox.SelectionStart, _options);

            }
            else { Index = _textbox.Find(_findtxt, _textbox.SelectionStart + _textbox.SelectionLength, _options); }
            if (Index >= 0)
            {
                _textbox.SelectionStart = Index;
                _textbox.SelectionLength = _findtxt.Length;
            }
            else
            {
                MessageBox.Show("Can't find " + _findtxt);
            }
        }
        //Replace
        public void sReplace(RichTextBox _textbox,string _replaceText)
        {
            _textbox.SelectedText = _replaceText;
        }
        //ReplaceAll
        public void sReplaceAll(RichTextBox _textbox, string _txtFind, string _Textreplace)
        {
            _textbox.Text = _textbox.Text.Replace(_txtFind, _Textreplace);
        }
        //Goto
        public void GotoLines(int LineIndex)
        {
            if (LineIndex > _richtxtbox.Lines.Length)
            {
                MessageBox.Show("Total Line of Number" + _richtxtbox.Lines.Length);
            }
            else
            {
                string[] _lines = _richtxtbox.Lines;
                int len = 0;
                for(int i = 0; i < LineIndex - 1; i++)
                {
                    len += _lines[i].Length + 1;
                }
                _richtxtbox.Focus();
                _richtxtbox.Select(len, 0);
            }
        }

        //Find ShowDialog
        FindDialoge _findDia;
        private void ShowFindDialog()
        {
            if (_richtxtbox.Text.Length == 0) { return; }
            if (_findDia == null) { _findDia = new FindDialoge(_richtxtbox,this); }

            _findDia.Left = _findDia.Left + 56;
            _findDia.Top = _findDia.Top + 100;
            if (!_findDia.Visible) { _findDia.Show(); }
            else { _findDia.Show(); }
            _findDia.Triggered();
        }

        //Replace ShowDialog
        ReplaceDialoge _ReplaceDia;
        private void ShowReplaceDialog()
        {
            if (_richtxtbox.Text.Length == 0) { return; }
            if (_ReplaceDia == null) { _ReplaceDia = new ReplaceDialoge(_richtxtbox,this); }

            _ReplaceDia.Left = _ReplaceDia.Left + 56;
            _ReplaceDia.Top = _ReplaceDia.Top + 100;
            if (!_ReplaceDia.Visible) { _ReplaceDia.Show(); }
            else { _ReplaceDia.Show(); }
            _ReplaceDia.Triggered();
        }
        //Goto
        GotoDialoge _gotoDia;
        private void ShowGotoDialoge()
        {
            if (_richtxtbox.Text.Length == 0) { return; }
            if (_gotoDia == null) { _gotoDia = new GotoDialoge(this); }
            _gotoDia.Left = _gotoDia.Left + 56;
            _gotoDia.Top = _gotoDia.Top + 100;
            if (!_gotoDia.Visible) { _gotoDia.Show(); }
            else { _gotoDia.Show(); }
            _gotoDia.Triggered();
        }
    }
}
