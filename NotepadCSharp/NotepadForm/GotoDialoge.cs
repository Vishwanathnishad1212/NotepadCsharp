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
    public partial class GotoDialoge : Form
    {
        EditMenu _xEdit;
        public GotoDialoge(EditMenu _yEdit)
        {
            _xEdit = _yEdit;
            InitializeComponent();
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            if (txtLIneNumber.Text == "")
            {
                MessageBox.Show("Enter a Valid Number", "Goto");
            }
            int Indexnumber = Int32.Parse(txtLIneNumber.Text);
            if (Indexnumber == 0)
            {
                MessageBox.Show("Enter a Valid Number", "Goto");
            }
            DialogResult = DialogResult.OK;
            _xEdit.GotoLines(Indexnumber);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GotoDialoge_Load(object sender, EventArgs e)
        {
            txtLIneNumber.SelectAll();
        }

        private void txtLIneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                var Sender = (TextBox)sender;
                MessageBox.Show("Invalid", "Goto");
                e.Handled = true;
                Hide();
            }
        }

        public void Triggered() { txtLIneNumber.Focus(); }
        public new void Show(IWin32Window window = null)
        {
            txtLIneNumber.SelectAll();
            txtLIneNumber.Focus();
            if (window == null) { base.Show(); }
            else { base.Show(window); }
        }
    }
}
