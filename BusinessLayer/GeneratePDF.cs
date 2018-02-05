using DrawsDAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class GeneratePDF
    {
        public static void GenerarPDF(int SorteoID, int ParticipanteID = 0)
        {
            string nombrePdf = null;
            string sorteo = null;
            string nombreParticipante = null;
            int BoletosParticipante = 0;

            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);


            sorteo = GenericServices<Sorteo>.BuscarPorId(SorteoID).NombreSorteo;
            nombrePdf = string.Concat("Completa", sorteo, ".pdf");
            nombrePdf = RemoveWhitespace(nombrePdf);


            if (ParticipanteID != 0)
            {
                    nombreParticipante = GenericServices<Participante>.BuscarPorId(ParticipanteID).ToString();
                    BoletosParticipante = GenericServices<Boleto>.ListarTodos().Count(t => t.ParticipanteId == ParticipanteID && t.SorteoId == SorteoID);
                    nombrePdf = string.Concat(nombreParticipante, ".pdf");
                    nombrePdf = RemoveWhitespace(nombrePdf);
            }

            ////////////////////quitar region si falla
            #region
            // Specify the directory you want to manipulate.
            string path = $@"C:\Sorteos\{sorteo}\pdf\";

            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(path))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("El proceso ha fallado: {0}", e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            // Indicamos donde vamos a guardar el documento   

            //PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($@"D:\Sorteos\{sorteo}\pdf\{nombrePdf}", FileMode.Create));   //Descomentar si se elimina #region
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(string.Concat(path, nombrePdf), FileMode.Create));//Eliminar si se elimina #region
            writer.PageEvent = new CClassPDFPage();

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Participantes Sorteos M&M");
            doc.AddCreator("Edwin Fredy Morales Morales");

            // Abrimos el archivo
            doc.Open();

            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph($"\nLista de participantes del Sorteo \"{sorteo}\""));
            doc.Add(Chunk.NEWLINE);

            if (ParticipanteID != 0)
            {
                // Escribimos el encabezamiento en el documento
                doc.Add(new Paragraph($"Numeros electrónicos del participante  {nombreParticipante} : {BoletosParticipante}"));
                doc.Add(Chunk.NEWLINE);
            }

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable TablaParticipantes = new PdfPTable(3);
            TablaParticipantes.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clParticipante = new PdfPCell(new Phrase("Participante", _standardFont));
            clParticipante.BorderWidth = 0;
            clParticipante.BorderWidthBottom = 0.75f;
            clParticipante.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            PdfPCell clNoParticipante = new PdfPCell(new Phrase("Número electrónico", _standardFont));
            clNoParticipante.BorderWidth = 0;
            clNoParticipante.BorderWidthBottom = 0.75f;
            clNoParticipante.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            PdfPCell clValidador = new PdfPCell(new Phrase("Codigo verificador", _standardFont));
            clValidador.BorderWidth = 0;
            clValidador.BorderWidthBottom = 0.75f;
            clValidador.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            // Añadimos las celdas a la tabla
            TablaParticipantes.AddCell(clParticipante);
            TablaParticipantes.AddCell(clNoParticipante);
            TablaParticipantes.AddCell(clValidador);

            using (var db = new SorteosDB())
            {
                var lista = ParticipanteID == 0 ?

                            (from p in db.Participantes
                             from q in db.Boletos
                             where p.ParticipanteId == q.ParticipanteId && q.SorteoId == SorteoID
                             select new { Id = p.ParticipanteId, NombreCompleto = p.Nombre + " " + p.ApellidoPaterno + " " + p.ApellidoMaterno, Validador = q.CodigoValidacion.ToString(), Boletos = q.BoletoElectronico }) :

                            (from p in db.Participantes
                             from q in db.Boletos
                             where p.ParticipanteId == q.ParticipanteId && p.ParticipanteId == ParticipanteID && q.SorteoId == SorteoID
                             select new { Id = p.ParticipanteId, NombreCompleto = p.Nombre + " " + p.ApellidoPaterno + " " + p.ApellidoMaterno, Validador = q.CodigoValidacion.ToString(), Boletos = q.BoletoElectronico });
                
                foreach (var boleto in lista.OrderBy(p => p.Boletos))
                {
                    nombreParticipante = boleto.NombreCompleto;

                    // Llenamos la tabla con información
                    clParticipante = new PdfPCell(new Phrase(nombreParticipante, _standardFont));
                    clParticipante.BorderWidth = 0;
                    clParticipante.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                    clNoParticipante = new PdfPCell(new Phrase(boleto.Boletos.ToString(), _standardFont));
                    clNoParticipante.BorderWidth = 0;
                    clNoParticipante.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                    string cgoValidador = boleto.Validador.ToString();
                    clValidador = new PdfPCell(new Phrase(cgoValidador, _standardFont));
                    clValidador.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    TablaParticipantes.AddCell(clParticipante);
                    TablaParticipantes.AddCell(clNoParticipante);
                    TablaParticipantes.AddCell(clValidador);
                }
            }

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(TablaParticipantes);

            doc.Close();
            writer.Close();

            MessageBox.Show("Archivo PDF Generado Exitosamente");
        }

        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
