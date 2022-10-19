using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotepadCSharp.Menus;
using NotepadCSharp.Utils;
using System.Windows.Forms;

namespace NotepadCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _file = new FileMenu(txtRichTextBox, this);
            _edit = new EditMenu(txtRichTextBox);
            _formate = new FormateMenu(txtRichTextBox, fWordWrap);
            _view = new ViewMenu(txtRichTextBox, vStatusBar, lblColumnsAndLine, notepadstatusStrip);
            _ntext = new nTextEditor(txtRichTextBox);
            EventKeys();
        }
        FileMenu _file;
        EditMenu _edit;
        FormateMenu _formate;
        ViewMenu _view;
        nTextEditor _ntext;

        //EventKeys
        private void EventKeys()
        {
            fNew.Click += FileNew;
            fOpen.Click += FileNew;
            fSave.Click += FileSave;
            fSaveAs.Click += FileSaveAs;
            fPageSetup.Click += FilePageSetup;
            fPrint.Click += FilePrint;
            fExit.Click += FileExit;
            //Edit
            eUndo.Click += EditUndo;
            eCut.Click += EditCut;
            eCut.Click += EditCopy;
            ePaste.Click += EditPaste;
            eDelete.Click += EditDelete;
            eFind.Click += EditFind;
            eFindNext.Click += EditFindNext;
            eReplace.Click += EditReplace;
            eGoto.Click += EditGoto;
            eSelectAll.Click += EditSelectAll;
            eDateTime.Click += EditDateTime;
            //Format
            fWordWrap.Click += FormateWordWrap;
            fFont.Click += FormateFont;
            //View
            vStatusBar.Click += ViewStatusBar;
            //Window Settings
            this.Load += Notepad_FormSettings;
            this.FormClosed += Notepad_FormClosed;
            this.FormClosing += Notepad_FormClosing;
            txtRichTextBox.TextChanged += Notepad_RichTextChanged;
            //this.KeyDown += Notepad_Form_KeyDown;
            txtRichTextBox.KeyDown += Notepad_Form_KeyDown;
            
        }

        //File
        #region File
        private void FileNew(object sender,EventArgs e) { _file.NewFile(); }
        private void FileOpen(object sender, EventArgs e) { _file.OpenFile() ; }
        private void FileSave(object sender, EventArgs e) { _file.Save(); }
        private void FileSaveAs(object sender, EventArgs e) { _file.SaveAs(); }
        private void FilePageSetup(object sender, EventArgs e) { _file.PageSetup(); }
        private void FilePrint(object sender, EventArgs e) { _file.PrintPage(); }
        private void FileExit(object sender, EventArgs e) { Close(); }
        #endregion
        //Edit
        #region Edit
        private void EditUndo(object sender, EventArgs e) { _edit.Undo(); }
        private void EditCut(object sender, EventArgs e) { _edit.Cut(); }
        private void EditCopy(object sender, EventArgs e) { _edit.Copy(); }
        private void EditPaste(object sender, EventArgs e) { _edit.Paste(); }
        private void EditDelete(object sender, EventArgs e) { _edit.Delete(); }
        private void EditFind(object sender, EventArgs e) { _edit.Find(); }
        private void EditFindNext(object sender, EventArgs e) { _edit.FindNext(); }
        private void EditReplace(object sender, EventArgs e) { _edit.Replace(); }
        private void EditGoto(object sender, EventArgs e) { _edit.Goto(); }
        private void EditSelectAll(object sender, EventArgs e) { _edit.SelectAll(); }
        private void EditDateTime(object sender, EventArgs e) { _edit.Date_Time(); }
        #endregion
        //Format
        #region Format
        private void FormateWordWrap(object sender, EventArgs e) { _formate.FormateWordWrap(); }
        private void FormateFont(object sender, EventArgs e) { _formate.FormateFont(); }
        #endregion
        //View
        #region View
        private void ViewStatusBar(object sender, EventArgs e) { _view.StatusBarMenu(); }
        #endregion
        //WinForm
        #region WindowForm
        private void Notepad_FormSettings(object sender,EventArgs e) {
            _view.UpdateStatusBar();
            UpdateMenuStatus();
            notepadstatusStrip.Visible = vStatusBar.Checked = MySettings.Default.IsStatusBar;
            _ntext.CurrentFont = MySettings.Default.CurrentFont;
            fWordWrap.Checked = txtRichTextBox.WordWrap = MySettings.Default.IsWordWrap;
            txtRichTextBox.BringToFront();
        }
        private void Notepad_FormClosed(object sender,FormClosedEventArgs e) { _file.Notepad_TextClosed(); }
        private void Notepad_FormClosing(object sender,FormClosingEventArgs e) { _file.Notepad_TextClosing(e); }
        #endregion
        //TextChanged
        #region TextChanged
        private void Notepad_RichTextChanged(object sender,EventArgs e) {
            _file.Notepad_TextChanged();
            _view.UpdateStatusBar();
            UpdateMenuStatus();
        }
        #endregion
        //ShortkutKeys
        #region ShortkutKeys
        private void Notepad_Form_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        _file.NewFile();
                        break;
                    case Keys.O:
                        _file.OpenFile();
                        break;
                    case Keys.S:
                        _file.Save();
                        break;
                    case Keys.P:
                        _file.PrintPage();
                        break;
                    case Keys.Z:
                        _edit.Undo();
                        break;
                    case Keys.X:
                        _edit.Cut();
                        break;
                    case Keys.C:
                        _edit.Copy();
                        break;
                    case Keys.V:
                        _edit.Paste();
                        break;
                    case Keys.F:
                        _edit.Find();
                        break;
                    case Keys.H:
                        _edit.Replace();
                        break;
                    case Keys.G:
                        _edit.Goto();
                        break;
                    case Keys.A:
                        _edit.SelectAll();
                        break;

                }
            }
            if (e.Alt && e.KeyCode == Keys.F4) { Close(); }
            if (e.KeyCode == Keys.Delete) { _edit.Delete(); }
            if (e.KeyCode == Keys.F3) { _edit.FindNext(); }
            if (e.KeyCode == Keys.F5) { _edit.Date_Time(); }
        }


        //TextEdit Deseble
        private void UpdateMenuStatus()
        {
            eUndo.Enabled = eCut.Enabled = eCopy.Enabled = txtRichTextBox.Text.Length > 0;
            eDelete.Enabled = eFind.Enabled = eFindNext.Enabled = eGoto.Enabled = txtRichTextBox.Text.Length > 0;
        }

        #endregion
    }
}
