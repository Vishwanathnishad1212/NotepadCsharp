namespace NotepadCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fFile = new System.Windows.Forms.MenuItem();
            this.fNew = new System.Windows.Forms.MenuItem();
            this.fOpen = new System.Windows.Forms.MenuItem();
            this.fSave = new System.Windows.Forms.MenuItem();
            this.fSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.fPageSetup = new System.Windows.Forms.MenuItem();
            this.fPrint = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.fExit = new System.Windows.Forms.MenuItem();
            this.eEdit = new System.Windows.Forms.MenuItem();
            this.eUndo = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.eCut = new System.Windows.Forms.MenuItem();
            this.eCopy = new System.Windows.Forms.MenuItem();
            this.ePaste = new System.Windows.Forms.MenuItem();
            this.eDelete = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.eFind = new System.Windows.Forms.MenuItem();
            this.eFindNext = new System.Windows.Forms.MenuItem();
            this.eReplace = new System.Windows.Forms.MenuItem();
            this.eGoto = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.eSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.eDateTime = new System.Windows.Forms.MenuItem();
            this.fFormat = new System.Windows.Forms.MenuItem();
            this.fWordWrap = new System.Windows.Forms.MenuItem();
            this.fFont = new System.Windows.Forms.MenuItem();
            this.vView = new System.Windows.Forms.MenuItem();
            this.vStatusBar = new System.Windows.Forms.MenuItem();
            this.hHelp = new System.Windows.Forms.MenuItem();
            this.hAbout = new System.Windows.Forms.MenuItem();
            this.notepadstatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblColumnsAndLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtRichTextBox = new System.Windows.Forms.RichTextBox();
            this.notepadstatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fFile,
            this.eEdit,
            this.fFormat,
            this.vView,
            this.hHelp});
            // 
            // fFile
            // 
            this.fFile.Index = 0;
            this.fFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fNew,
            this.fOpen,
            this.fSave,
            this.fSaveAs,
            this.menuItem13,
            this.fPageSetup,
            this.fPrint,
            this.menuItem14,
            this.fExit});
            this.fFile.Text = "File";
            // 
            // fNew
            // 
            this.fNew.Index = 0;
            this.fNew.Text = "New                  Ctrl+N";
            // 
            // fOpen
            // 
            this.fOpen.Index = 1;
            this.fOpen.Text = "Open                Ctrl+O";
            // 
            // fSave
            // 
            this.fSave.Index = 2;
            this.fSave.Text = "Save                 Ctrl+S";
            // 
            // fSaveAs
            // 
            this.fSaveAs.Index = 3;
            this.fSaveAs.Text = "SaveAs..";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 4;
            this.menuItem13.Text = "-";
            // 
            // fPageSetup
            // 
            this.fPageSetup.Index = 5;
            this.fPageSetup.Text = "Page Setup";
            // 
            // fPrint
            // 
            this.fPrint.Index = 6;
            this.fPrint.Text = "Print....               Ctrl+P";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 7;
            this.menuItem14.Text = "-";
            // 
            // fExit
            // 
            this.fExit.Index = 8;
            this.fExit.Text = "Exit                   Alt+F4";
            // 
            // eEdit
            // 
            this.eEdit.Index = 1;
            this.eEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eUndo,
            this.menuItem26,
            this.eCut,
            this.eCopy,
            this.ePaste,
            this.eDelete,
            this.menuItem27,
            this.eFind,
            this.eFindNext,
            this.eReplace,
            this.eGoto,
            this.menuItem28,
            this.eSelectAll,
            this.menuItem29,
            this.eDateTime});
            this.eEdit.Text = "Edit";
            // 
            // eUndo
            // 
            this.eUndo.Index = 0;
            this.eUndo.Text = "Undo                     Ctrl+Z";
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 1;
            this.menuItem26.Text = "-";
            // 
            // eCut
            // 
            this.eCut.Index = 2;
            this.eCut.Text = "Cut                        Ctrl+X";
            // 
            // eCopy
            // 
            this.eCopy.Index = 3;
            this.eCopy.Text = "Copy                     Ctrl+C";
            // 
            // ePaste
            // 
            this.ePaste.Index = 4;
            this.ePaste.Text = "Paste                     Ctrl+V";
            // 
            // eDelete
            // 
            this.eDelete.Index = 5;
            this.eDelete.Text = "Delete...                Del";
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 6;
            this.menuItem27.Text = "-";
            // 
            // eFind
            // 
            this.eFind.Index = 7;
            this.eFind.Text = "Find                      Ctrl+F";
            // 
            // eFindNext
            // 
            this.eFindNext.Index = 8;
            this.eFindNext.Text = "Find Next...           F3";
            // 
            // eReplace
            // 
            this.eReplace.Index = 9;
            this.eReplace.Text = "Replace                Ctrl+H";
            // 
            // eGoto
            // 
            this.eGoto.Index = 10;
            this.eGoto.Text = "Goto...                  Ctrl+G";
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 11;
            this.menuItem28.Text = "-";
            // 
            // eSelectAll
            // 
            this.eSelectAll.Index = 12;
            this.eSelectAll.Text = "Select All             Ctrl+A";
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 13;
            this.menuItem29.Text = "-";
            // 
            // eDateTime
            // 
            this.eDateTime.Index = 14;
            this.eDateTime.Text = "Date/Time          F5 ";
            // 
            // fFormat
            // 
            this.fFormat.Index = 2;
            this.fFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fWordWrap,
            this.fFont});
            this.fFormat.Text = "Format";
            // 
            // fWordWrap
            // 
            this.fWordWrap.Index = 0;
            this.fWordWrap.Text = "WordWrap...";
            // 
            // fFont
            // 
            this.fFont.Index = 1;
            this.fFont.Text = "Font...";
            // 
            // vView
            // 
            this.vView.Index = 3;
            this.vView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.vStatusBar});
            this.vView.Text = "View";
            // 
            // vStatusBar
            // 
            this.vStatusBar.Index = 0;
            this.vStatusBar.Text = "Status Bar";
            // 
            // hHelp
            // 
            this.hHelp.Index = 4;
            this.hHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.hAbout});
            this.hHelp.Text = "Help";
            // 
            // hAbout
            // 
            this.hAbout.Index = 0;
            this.hAbout.Text = "About...";
            // 
            // notepadstatusStrip
            // 
            this.notepadstatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notepadstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblColumnsAndLine});
            this.notepadstatusStrip.Location = new System.Drawing.Point(0, 425);
            this.notepadstatusStrip.Name = "notepadstatusStrip";
            this.notepadstatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notepadstatusStrip.Size = new System.Drawing.Size(800, 25);
            this.notepadstatusStrip.TabIndex = 0;
            this.notepadstatusStrip.Text = "statusStrip1";
            // 
            // lblColumnsAndLine
            // 
            this.lblColumnsAndLine.Name = "lblColumnsAndLine";
            this.lblColumnsAndLine.Size = new System.Drawing.Size(89, 20);
            this.lblColumnsAndLine.Text = "Ln={},Col={}";
            // 
            // txtRichTextBox
            // 
            this.txtRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRichTextBox.HideSelection = false;
            this.txtRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtRichTextBox.Name = "txtRichTextBox";
            this.txtRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtRichTextBox.Size = new System.Drawing.Size(800, 425);
            this.txtRichTextBox.TabIndex = 1;
            this.txtRichTextBox.Text = "";
            this.txtRichTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRichTextBox);
            this.Controls.Add(this.notepadstatusStrip);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Untitled MyNotepad";
            this.notepadstatusStrip.ResumeLayout(false);
            this.notepadstatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem fFile;
        private System.Windows.Forms.MenuItem fNew;
        private System.Windows.Forms.MenuItem fOpen;
        private System.Windows.Forms.MenuItem fSave;
        private System.Windows.Forms.MenuItem fSaveAs;
        private System.Windows.Forms.MenuItem fPageSetup;
        private System.Windows.Forms.MenuItem fPrint;
        private System.Windows.Forms.MenuItem fExit;
        private System.Windows.Forms.MenuItem eEdit;
        private System.Windows.Forms.MenuItem fFormat;
        private System.Windows.Forms.MenuItem vView;
        private System.Windows.Forms.MenuItem hHelp;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem eUndo;
        private System.Windows.Forms.MenuItem menuItem26;
        private System.Windows.Forms.MenuItem eCut;
        private System.Windows.Forms.MenuItem eCopy;
        private System.Windows.Forms.MenuItem ePaste;
        private System.Windows.Forms.MenuItem eDelete;
        private System.Windows.Forms.MenuItem menuItem27;
        private System.Windows.Forms.MenuItem eFind;
        private System.Windows.Forms.MenuItem eFindNext;
        private System.Windows.Forms.MenuItem eReplace;
        private System.Windows.Forms.MenuItem eGoto;
        private System.Windows.Forms.MenuItem menuItem28;
        private System.Windows.Forms.MenuItem eSelectAll;
        private System.Windows.Forms.MenuItem menuItem29;
        private System.Windows.Forms.MenuItem eDateTime;
        private System.Windows.Forms.MenuItem fWordWrap;
        private System.Windows.Forms.MenuItem fFont;
        private System.Windows.Forms.MenuItem vStatusBar;
        private System.Windows.Forms.MenuItem hAbout;
        private System.Windows.Forms.StatusStrip notepadstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblColumnsAndLine;
        private System.Windows.Forms.RichTextBox txtRichTextBox;
    }
}