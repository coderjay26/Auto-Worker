using Cropper;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Worker.Class
{
        internal class ImageUtility
        {
        public static Image GetEmbeddedImage(string resourceName)
        {
            // Get the current assembly.
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Build the full resource name.
            string fullResourceName = assembly.GetName().Name + "." + resourceName;

            // Load the embedded image.
            using (Stream stream = assembly.GetManifestResourceStream(fullResourceName))
            {
                if (stream != null)
                {
                    return Image.FromStream(stream);
                }
                else
                {
                    // The resource was not found.
                    return null;
                }
            }
        }
        public static Image CropImage(Image sourceImage)
            {
                DialogResult result;

                using (var dialog = new CropImageDialog(sourceImage))
                {
                    result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Get the cropped image from the dialog
                        return dialog.Image;
                    }
                }

                // If the user canceled, or if the dialog result was not OK, return the original image
                return sourceImage;

            }

            public static void PrintImage(Image imageToPrint)
            {

                using (PrintDialog printDialog = new PrintDialog())
                {
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                   
                    // Create and configure the print document
                         PrintDocument printDocument = new PrintDocument();
                        printDocument.PrintPage += (sender, e) =>
                        {
                            e.Graphics.DrawImage(imageToPrint, 0, 0);
                        };
                        printDocument.DefaultPageSettings.PaperSize = printDialog.PrinterSettings.DefaultPageSettings.PaperSize;
                        // Set printer resolution (print quality)
                        printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
                        {
                            X = 2400,
                            Y = 2400
                        };

                        printDialog.Document = printDocument;

                    printDocument.Print();
                    }
                }
            }
        }
}
