using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace PDFPDFPDF
{
    class ViewModel
    {
        public ViewModel()
        {
            
        }
        public void Kvittering()
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Courier, 20);
                graphics.DrawString("Hello World", font, PdfBrushes.Black, 50, 50);
                MemoryStream ms = new MemoryStream();
                document.Save(ms);
                Save(ms, "Sample.pdf");


            }
        }

        public async void Save(Stream stream, string filename)
        {
            stream.Position = 0;
            StorageFile stFile;
            if (!(Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons")))
            {
                FileSavePicker savePicker = new FileSavePicker();
                savePicker.DefaultFileExtension = ".pdf";
                savePicker.SuggestedFileName = "Sample";
                savePicker.FileTypeChoices.Add("Adobe PDF Document", new List<string>() { ".pdf" });
                stFile = await savePicker.PickSaveFileAsync();
            }
            else
            {
                StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
                stFile = await local.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            }

            if (stFile != null)
            {
                Windows.Storage.Streams.IRandomAccessStream filestream =
                    await stFile.OpenAsync(FileAccessMode.ReadWrite);
                Stream st = filestream.AsStreamForWrite();
                st.SetLength(0);
                st.Write((stream as MemoryStream).ToArray(), 0, (int)stream.Length);
                st.Flush();
                st.Dispose();
                filestream.Dispose();
                MessageDialog msgdialog = new MessageDialog("Do you want to view the document", "File Created");
                UICommand yesCmd = new UICommand("Yes");
                msgdialog.Commands.Add(yesCmd);
                IUICommand cmd = await msgdialog.ShowAsync();
                if (cmd == yesCmd)
                {
                    bool succes = await Windows.System.Launcher.LaunchFileAsync(stFile);
                }
            }

        }
    }
}
