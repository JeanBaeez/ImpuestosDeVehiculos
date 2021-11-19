using System.IO;
using System.Threading.Tasks;
using ImpuestosVehiculos.Data;
using Microsoft.JSInterop;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace ImpuestosVehiculos.Services
{
    public class PDFService
    {
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePDF(ResultadosObject resultados)
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add a page to the document
            PdfPage page = document.Pages.Add();

            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;
            PdfPen pen = new PdfPen(PdfBrushes.Black, 5f);
            PointF point1 = new PointF(10, 10);
            PointF point2 = new PointF(10, 100);

            //Set the standard font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            //Draw the text
            graphics
                .DrawString($"Desglose de Resultados  {resultados.ITBIS}",
                font,
                PdfBrushes.Black,
                new Syncfusion.Drawing.PointF(0, 0));
            graphics.DrawLine(pen, point1, point2);

            //Saving the PDF to the MemoryStream
            MemoryStream stream = new MemoryStream();

            document.Save (stream);
            document.Close(true);
            return stream;

            //Download the PDF in the browser.
        }
    }
}
