using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CClassPDFPage : PdfPageEventHelper
    {

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            Image oImagen = default(Image);
            PdfContentByte cbPie = default(PdfContentByte);
            PdfContentByte cbEncabezado = default(PdfContentByte);

            //-----------------------------------------------------------------------------------------
            // DEFINICIÓN DEL OBJETO PdfContentByte PARA EL ENCABEZADO
            //-----------------------------------------------------------------------------------------
            cbEncabezado = writer.DirectContent;
            var _with1 = cbEncabezado;
            _with1.BeginText();
            _with1.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, Font.NORMAL).BaseFont, 8);
            _with1.SetColorFill(BaseColor.BLACK);
            _with1.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMPUTADORAS Y ACCESORIOS M&M", 290, 760, 0);
            //_with1.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Lista de participantes del sorteo XYZ", 290, 750, 0);            
            _with1.EndText();
            //document.Add(Chunk.NEWLINE);

            //-----------------------------------------------------------------------------------------
            // DEFINICIÓN DEL OBJETO PdfContentByte PARA EL PIE DE PAGINA
            //-----------------------------------------------------------------------------------------
            cbPie = writer.DirectContent;
            cbPie.BeginText();
            cbPie.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, Font.DEFAULTSIZE, Font.NORMAL).BaseFont, 10);
            cbPie.SetColorFill(BaseColor.BLACK);
            cbPie.ShowTextAligned(PdfContentByte.ALIGN_LEFT, $"Última actualización {DateTime.Now}", 35, 25, 0);
            cbPie.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Página: " + writer.PageNumber, 540, 25, 0);
            cbPie.EndText();

            //-----------------------------------------------------------------------------------------
            // LOGOS DEL DOCUMENTO
            //-----------------------------------------------------------------------------------------

            oImagen = Image.GetInstance(Properties.Resources.logotipo, System.Drawing.Imaging.ImageFormat.Png);
            oImagen.SetAbsolutePosition(35, 760);
            oImagen.ScalePercent(30);
            //Ajuste porcentual de la imagen
            document.Add(oImagen);

            ////Se agrega la imagen al documento
            
            oImagen = Image.GetInstance(Properties.Resources.logotipo, System.Drawing.Imaging.ImageFormat.Png);
            oImagen.SetAbsolutePosition(450, 760);
            oImagen.ScalePercent(30);
            document.Add(oImagen);
        }
    }
}
