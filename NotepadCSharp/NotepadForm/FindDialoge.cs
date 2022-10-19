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
    public partial class FindDialoge : Form
    {
        RichTextBox _editor;
        EditMenu _xEdit;
        public FindDialoge(RichTextBox _richtextbox,EditMenu _yEdit)
        {
            _xEdit = _yEdit;
            _editor = _richtextbox;
            InitializeComponent();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string _findText = txtFindText.Text;
            bool _ChkmatchCase = chkMatchcase.Checked;
            bool _ChkMatchWholeCase = chkMatchWholeWord.Checked;
            bool _RadUpdirection = radDirectionUp.Checked;
            _xEdit.sFind(_editor, _findText, _ChkmatchCase, _ChkMatchWholeCase, _RadUpdirection);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateStatus()
        {
            btnFind.Enabled = txtFindText.Text.Length > 0;
        }

        private void FindDialoge_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void txtFindText_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void FindDialoge_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public new void Show(IWin32Window window = null)
        {
            txtFindText.Focus();
            txtFindText.SelectAll();
            if (window == null) { base.Show(); }
            else { base.Show(window); }
        }
        public void Triggered() { txtFindText.Focus(); }

        private void txtFindText_Enter(object sender, EventArgs e)
        {
            var Sender = (TextBox)sender;
            Sender.SelectAll();
        }
    }
}
