using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using NotepadCSharp.NotepadForm;
using System.Drawing;
using System.Drawing.Printing;
using NotepadCSharp.Utils;

namespace NotepadCSharp.Menus
{
    public class FileMenu
    {
        RichTextBox _txtEditor;
        nTextEditor _neditFeature;
        Form1 _notepadForm;
        public FileMenu(RichTextBox _txtNotepadeditor, Form1 _NotepadWindow)
        {
            _txtEditor = _txtNotepadeditor;
            _notepadForm = _NotepadWindow;
            _neditFeature = new nTextEditor(_txtNotepadeditor);
        }

        string Filename { get; set; }

        string NotepadEditor
        {
            get { return _txtEditor.Text; }
            set { _txtEditor.Text = value; }
        }

        bool _isdirty;
        bool IsDirty
        {
            get
            {
                if (Filename == null && NotepadEditor == "") { return false; }
                return _isdirty;
            }
            set { _isdirty = value; }
        }

        private string DocumentName
        {
            get
            {
                if (Filename == null) { return "Untitled"; }
                return Path.GetFileName(Filename);
            }
        }
        //Notepad Save Message
        private bool nNotepadMessage()
        {
            if (!IsDirty) { return true; }
            var dialog = new NotepadMessage(DocumentName).ShowDialog();
            switch (dialog)
            {
                case DialogResult.OK:
                    return Save();
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
                default:
                    throw new Exception();
            }
        }

        //Text Changed By Type in Notepad
        public void Notepad_TextChanged()
        {
            if (NotepadEditor.Length > 0)
            {
                _notepadForm.Text = "*" + DocumentName + " MyNotepad";
                IsDirty = true;
            }
            else
            {
                _notepadForm.Text = DocumentName + " MyNotepad";
                IsDirty = false;
            }
        }

        //When Notepad Form Closed
        //Form Closing
        public void Notepad_TextClosing(FormClosingEventArgs e)
        {
            e.Cancel = !nNotepadMessage();
        }
        //When Notepad Closed
        //Form Closing
        public void Notepad_TextClosed()
        {
            MySettings.Default.WindowPosition = _notepadForm.Bounds;
            MySettings.Default.Save();
        }

        //New Files
        public bool NewFile()
        {
            if (!nNotepadMessage()) { return false; }
            Filename = "";
            NotepadEditor = "";
            IsDirty = false;
            return true;
        }

        //Saveobs
        public bool Save()
        {
            if (!IsDirty) { return true; }
            if (Filename == null && DocumentName == "Untitled") { return SaveAs(); }
            File.WriteAllText(Filename, NotepadEditor);
            IsDirty = false;
            _notepadForm.Text = Path.GetFileName(Filename) + " MyNotepad";
            return true;
        }

        //SaveAs
        public bool SaveAs()
        {
            SaveFileDialog _savefile = new SaveFileDialog();
            _savefile.Tag = "Save";
            _savefile.Title = "Save";
            _savefile.Filter = "TextDocuments (*.txt)|*.txt|All Files(*.*)|*.*";
            if (_savefile.ShowDialog() != DialogResult.OK) { return false; }
            File.WriteAllText(_savefile.FileName, NotepadEditor);
            Filename = _savefile.FileName;
            _notepadForm.Text = Path.GetFileName(Filename) + " MyNotepad";
            IsDirty = false;
            return true;
        }

        //OpenFiles
        public bool OpenFile()
        {
            if (!nNotepadMessage()) { return false; }
            OpenFileDialog _openfile = new OpenFileDialog();
            _openfile.Tag = "Open";
            _openfile.Title = "Open";
            _openfile.Filter = "TextDocuments (*.txt)|*.txt|All Files(*.*)|*.*";
            if (_openfile.ShowDialog() != DialogResult.OK) { return false; }
            NotepadEditor = File.ReadAllText(_openfile.FileName);
            Filename = _openfile.FileName;
            _notepadForm.Text = Path.GetFileName(Filename) + " MyNotepad";
            IsDirty = false;
            return true;
        }

        //PageSetting
        //Here is PageSettings save
        private PageSettings _PageSettings;
        private PageSettings PageSettings
        {
            get
            {
                if (_PageSettings == null)
                {
                    if (MySettings.Default.PageSettings != null)
                    {
                        _PageSettings = MySettings.Default.PageSettings;
                    }
                    else
                    {
                        var PageSettings = new PageSettings()
                        {
                            Margins = new Margins(75, 75, 100, 100),
                        };

                        _PageSettings = PageSettings;
                    }
                }
                return _PageSettings;
            }
            set
            {
                MySettings.Default.PageSettings = value;
                MySettings.Default.Save();
            }
        }
        //Page Setup
        public void PageSetup()
        {
            PageSetupDialog _dialog = new PageSetupDialog();
            _dialog.PageSettings = PageSettings;
            if (_dialog.ShowDialog() != DialogResult.OK) { return; }
            PageSettings = _dialog.PageSettings;
        }
        //Print page
        //this code is huge code 
        //so i will do copy paste on here
        public void PrintPage()
        {
            var PrintDialog = new PrintDialog();

            if (MySettings.Default.PrinterSettings != null)
            {
                PrintDialog.PrinterSettings = MySettings.Default.PrinterSettings;
            }

            if (PrintDialog.ShowDialog() != DialogResult.OK) { return; }
            MySettings.Default.PrinterSettings = PrintDialog.PrinterSettings;
            MySettings.Default.Save();

            var PrintDocument = new PrintDocument();
            PrintDocument.DefaultPageSettings = PageSettings;
            PrintDocument.PrinterSettings = MySettings.Default.PrinterSettings;
            PrintDocument.DocumentName = DocumentName + " -MyNotepad";

            var RemainingContentToPrint = NotepadEditor;
            var PageIndex = 0;

            PrintDocument.PrintPage += (sender, e) => {
                { // Header
                    var HeaderText = FormatHeaderFooterText(MySettings.Default.Header, PageIndex);
                    var Top = PageSettings.Margins.Top;
                    DrawStringAtPosition(e.Graphics, HeaderText.Left, Top, DrawStringPosition.Left);
                    DrawStringAtPosition(e.Graphics, HeaderText.Center, Top, DrawStringPosition.Center);
                    DrawStringAtPosition(e.Graphics, HeaderText.Right, Top, DrawStringPosition.Right);
                }
                { // Body
                    var CharactersFitted = 0;
                    var LinesFilled = 0;

                    var MarginBounds = new RectangleF(e.MarginBounds.X, e.MarginBounds.Y + /* header */ _neditFeature.CurrentFont.Height, e.MarginBounds.Width, e.MarginBounds.Height - (/* header and footer */ _neditFeature.CurrentFont.Height * 2));

                    e.Graphics.MeasureString(RemainingContentToPrint, _neditFeature.CurrentFont, MarginBounds.Size, StringFormat.GenericTypographic, out CharactersFitted, out LinesFilled);
                    e.Graphics.DrawString(RemainingContentToPrint, _neditFeature.CurrentFont, Brushes.Black, MarginBounds, StringFormat.GenericTypographic);

                    RemainingContentToPrint = RemainingContentToPrint.Substring(CharactersFitted);

                    e.HasMorePages = (RemainingContentToPrint.Length > 0);
                }
                { // Footer
                    var FooterText = FormatHeaderFooterText(MySettings.Default.Footer, PageIndex);
                    var Top = PageSettings.Bounds.Bottom - PageSettings.Margins.Bottom - _neditFeature.CurrentFont.Height;
                    DrawStringAtPosition(e.Graphics, FooterText.Left, Top, DrawStringPosition.Left);
                    DrawStringAtPosition(e.Graphics, FooterText.Center, Top, DrawStringPosition.Center);
                    DrawStringAtPosition(e.Graphics, FooterText.Right, Top, DrawStringPosition.Right);
                }

                PageIndex++;
            };
            PrintDocument.Print();
        }
        private enum DrawStringPosition
        {
            Left,
            Center,
            Right,
        }
        private void DrawStringAtPosition(Graphics pGraphics, string pText, int Top, DrawStringPosition pPosition)
        {
            var HeaderTextSize = new SizeF(pGraphics.MeasureString(pText, _neditFeature.CurrentFont));
            var HeaderTextWidth = HeaderTextSize.Width;
            var PageWidth = PageSettings.Bounds.Right - PageSettings.Bounds.Left;
            float Left;
            if (pPosition == DrawStringPosition.Left)
            {
                Left = PageSettings.Margins.Left;
            }
            else if (pPosition == DrawStringPosition.Center)
            {
                Left = ((PageWidth - HeaderTextWidth) / 2);
            }
            else if (pPosition == DrawStringPosition.Right)
            {
                Left = PageWidth - PageSettings.Margins.Right - HeaderTextWidth;
            }
            else
            {
                throw new Exception();
            }
            pGraphics.DrawString(pText, _neditFeature.CurrentFont, Brushes.Black, Left, Top);
        }

        private class HeaderOrFooterInfo
        {
            public string Left = "";
            public string Center = "";
            public string Right = "";
        }

        private HeaderOrFooterInfo FormatHeaderFooterText(string pText, int PageIndex)
        {
            var HeaderOrFooterInfo = GetHeaderOrFooterInfo(pText);
            HeaderOrFooterInfo.Left = FormatSingleHeaderFooterText(HeaderOrFooterInfo.Left, PageIndex);
            HeaderOrFooterInfo.Center = FormatSingleHeaderFooterText(HeaderOrFooterInfo.Center, PageIndex);
            HeaderOrFooterInfo.Right = FormatSingleHeaderFooterText(HeaderOrFooterInfo.Right, PageIndex);
            return HeaderOrFooterInfo;
        }

        private string FormatSingleHeaderFooterText(string pText, int PageIndex)
        {
            return pText
                        .Replace("&f", DocumentName)
                        .Replace("&p", (PageIndex + 1).ToString())
                        .Replace("&d", DateTime.Now.ToLongDateString())
                        .Replace("&t", DateTime.Now.ToLongTimeString())
                        ;
        }

        private static HeaderOrFooterInfo GetHeaderOrFooterInfo(string pText)
        {
            const string CONST_Left = "Left";
            const string CONST_Center = "Center";
            const string CONST_Right = "Right";
            var LeftIndexes = nDocumentIndex.GetIndexes(pText, "&l", false);
            var CenterIndexes = nDocumentIndex.GetIndexes(pText, "&c", false);
            var RightIndexes = nDocumentIndex.GetIndexes(pText, "&r", false);
            var SideInfos =
                LeftIndexes.Select(o => new { Side = CONST_Left, Index = o })
                .Union(CenterIndexes.Select(o => new { Side = CONST_Center, Index = o }))
                .Union(RightIndexes.Select(o => new { Side = CONST_Right, Index = o }))
                .OrderBy(o => o.Index)
                .ToList();
            var HeaderOrFooterInfo = new HeaderOrFooterInfo();
            if (SideInfos.Count == 0)
            {
                HeaderOrFooterInfo.Center = pText;
                return HeaderOrFooterInfo;
            }
            for (int i = 0; i < SideInfos.Count; i++)
            {
                var SideInfo = SideInfos[i];
                var IsFirstSideInfo = (i == 0);
                var IsLastSideInfo = (i == (SideInfos.Count - 1));
                if (IsFirstSideInfo)
                {
                    if (SideInfo.Index != 0)
                    {
                        HeaderOrFooterInfo.Center = pText.Substring(0, SideInfo.Index - 1);
                    }
                }
                var StartIndex = SideInfo.Index + 2;
                var EndIndex = 0;
                if (IsLastSideInfo)
                {
                    EndIndex = pText.Length - 1;
                }
                else
                {
                    var NextSideInfo = SideInfos[i + 1];
                    EndIndex = NextSideInfo.Index - 1;
                }
                var Length = EndIndex - StartIndex + 1;
                var Text = pText.Substring(StartIndex, Length);
                switch (SideInfo.Side)
                {
                    case CONST_Left:
                        HeaderOrFooterInfo.Left += Text;
                        break;
                    case CONST_Center:
                        HeaderOrFooterInfo.Center += Text;
                        break;
                    case CONST_Right:
                        HeaderOrFooterInfo.Right += Text;
                        break;
                    default:
                        throw new Exception();
                }
            }
            return HeaderOrFooterInfo;
        }
    }
}

//File Menu Is Complete
//In the Next Video I will show you Edit Menu