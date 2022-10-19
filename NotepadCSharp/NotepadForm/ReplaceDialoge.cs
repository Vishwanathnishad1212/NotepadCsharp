using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotepadCSharp.Menus;

namespace NotepadCSharp.NotepadForm
{
    public partial class ReplaceDialoge : Form
    {
        RichTextBox _richtext;
        EditMenu _xEdit;
        public ReplaceDialoge(RichTextBox _richtextBox,EditMenu _yEdit)
        {
            _xEdit = _yEdit;
            _richtext = _richtextBox;
            InitializeComponent();
        }

        string _findText;
        bool _chkMatchCase;
        bool _chkMatchWholeCase;
        bool _UpDirection;

        private void btnFind_Click(object sender, EventArgs e)
        {
            _findText = txtFindText.Text;
            _chkMatchCase = chkMatchcase.Checked;
            _chkMatchWholeCase = chkMatchWholeWord.Checked;
            _UpDirection = radDirectionUp.Checked;
            _xEdit.sFind(_richtext, _findText, _chkMatchCase, _chkMatchWholeCase, _UpDirection);  
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            _xEdit.sReplace(_richtext, txtReplace.Text);
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            _xEdit.sReplaceAll(_richtext, txtFindText.Text, txtReplace.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ReplaceDialoge_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void ReplaceDialoge_Load(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void txtFindText_TextChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void UpdateStats()
        {
            btnFind.Enabled = btnReplace.Enabled = btnReplaceAll.Enabled = txtFindText.Text.Length > 0;
        }

        public void Triggered() { txtFindText.Focus(); }

        public new void Show(IWin32Window window = null)
        {
            txtFindText.Focus();
            txtFindText.SelectAll();
            if (window == null) { base.Show(); }
            else { base.Show(window); }
        }

        private void txtFindText_Enter(object sender, EventArgs e)
        {
            var Sender = (TextBox)sender;
            Sender.SelectAll();
        }

        private void txtReplace_Enter(object sender, EventArgs e)
        {
            var Sender = (TextBox)sender;
            Sender.SelectAll();
        }
    }
}
