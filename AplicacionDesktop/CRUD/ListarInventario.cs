using CapaNegocio.NegocioFarmacia;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.MENU;

namespace AplicacionDesktop.CRUD
{
    public partial class ListarInventario : Form
    {
        public ListarInventario()
        {
            InitializeComponent();
            NegocioInventario inventario = new NegocioInventario();
            if (inventario.listarInventarios().Tables[0].Rows.Count>0)
            {
                
                dataGridView1.DataSource = inventario.listarInventarios().Tables[0];
                dataGridView1.ReadOnly = true;
                //cargar solo las filas
                //dataGridView1.Rows.Remove
                dataGridView1.Update();

                //dataGridView1.ColumnHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("No hay medicinas ingresadas");
            }
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            NegocioInventario inventario = new NegocioInventario();
            if (inventario.listarInventarios().Tables[0].Rows.Count > 0)
            {
                //// Creamos el documento con el tamaño de página tradicional
                //Document doc = new Document(PageSize.LETTER);
                //// Indicamos donde vamos a guardar el documento
                //PdfWriter writer = PdfWriter.GetInstance(doc,
                //                            new FileStream(@"C:\Users\nathalia\Documents\GitHub\SolucionFundacionDesktop\prueba.pdf", FileMode.Create));
                try
                {
                    //// Le colocamos el título y el autor
                    //// **Nota: Esto no será visible en el documento
                    //doc.AddTitle("Reporte Inventarios");
                    //doc.AddCreator("Fundacion Apoyo");

                    //// Abrimos el archivo
                    //doc.Open();
                    //// Creamos el tipo de Font que vamos utilizar
                    //iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                    //// Escribimos el encabezamiento en el documento
                    //doc.Add(new Paragraph("Inventario Farmacia Casa Reposo Fundacion Apoyo"));
                    //doc.Add(Chunk.NEWLINE);

                    // Creamos una tabla del tamaño del dataDriew
                    // de nuestros visitante.
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.DefaultCell.Padding = 3;
                    //    pdfTable.WidthPercentage = 30;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;
                    
                    //Header Row
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                         PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                         cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                         pdfTable.AddCell(cell);
                    }
                    //Datarow
                    
                   
                        

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.Cells.ToString().Equals(""))
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }
                          
                      
                        
                            
                       
                    


                    //Exporting to PDF
                    string folderPath = "C:\\PDFs\\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
               
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR al intentar crear PDF");
                }
                
            }
            else
            {
                MessageBox.Show("No hay datos para crear documento");
            }
            

            
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario inv =  new MenuAdministrarInventario();
            inv.Show();
            Hide();
        }
        //// Configuramos el título de las columnas de la tabla
        //PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
        //clNombre.BorderWidth = 0;
        //clNombre.BorderWidthBottom = 0.75f;

        //PdfPCell clStock = new PdfPCell(new Phrase("Stock", _standardFont));
        //clStock.BorderWidth = 0;
        //clStock.BorderWidthBottom = 0.75f;

        //PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad Inventario", _standardFont));
        //clPais.BorderWidth = 0;
        //clPais.BorderWidthBottom = 0.75f;

        //// Añadimos las celdas a la tabla
        //tblPrueba.AddCell(clNombre);
        //tblPrueba.AddCell(clApellido);
        //tblPrueba.AddCell(clPais);

        //// Llenamos la tabla con información
        //clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
        //clNombre.BorderWidth = 0;

        //clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
        //clApellido.BorderWidth = 0;

        //clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
        //clPais.BorderWidth = 0;

        //// Añadimos las celdas a la tabla
        //tblPrueba.AddCell(clNombre);
        //tblPrueba.AddCell(clApellido);
        //tblPrueba.AddCell(clPais);
        // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
        //    'variables
        //Dim val As New Double
        //Dim colum As String
        //Dim fecha As String = "0"
        //Dim per As String = "0"

        //'validar que el dataset contenga datos 
        //If dataSet.Tables(0).Rows.Count > 0 Then
        //    'Recorrer el objeto dataset
        //    For Each registro In dataSet.Tables(0).Rows

        //        For i = 0 To dataSet.Tables(0).Columns.Count - 2
        //            'obtener valor de la columna
        //            colum = registro(i)
        //            If IsNumeric(colum) = True Then
        //                val = Format(CDbl(colum), "##.##0,00")
        //                'asignar el valor a la celda correspondiente
        //                If val < 6 And i < 10 Then
        //                    Dim celda As New PdfPCell(New Phrase(Format(CDbl(val), "##,##0.00"), FuenteNotas))
        //                    celda.Padding = 5
        //                    celda.Colspan = 1
        //                    celda.HorizontalAlignment = Element.ALIGN_CENTER
        //                    celda.VerticalAlignment = Element.ALIGN_MIDDLE
        //                    celda.BackgroundColor = iTextSharp.text.Color.RED
        //                    termometroDtb.AddCell(celda)
        //                End If
        //                If val >= 6 And val < 8 Then
        //                    Dim celda As New PdfPCell(New Phrase(Format(CDbl(val), "##,##0.00"), FuenteNotas))
        //                    celda.Padding = 5
        //                    celda.Colspan = 1
        //                    celda.BackgroundColor = iTextSharp.text.Color.WHITE
        //                    celda.HorizontalAlignment = Element.ALIGN_CENTER
        //                    celda.VerticalAlignment = Element.ALIGN_MIDDLE
        //                    termometroDtb.AddCell(celda)
        //                End If
        //                If val >= 8 Then
        //                    Dim celda As New PdfPCell(New Phrase(Format(CDbl(val), "##,##0.00"), FuenteNotas))
        //                    celda.Padding = 5
        //                    celda.Colspan = 1
        //                    celda.BackgroundColor = iTextSharp.text.Color.GREEN
        //                    celda.HorizontalAlignment = Element.ALIGN_CENTER
        //                    celda.VerticalAlignment = Element.ALIGN_MIDDLE
        //                    termometroDtb.AddCell(celda)
        //                End If
        //            Else
        //                Dim celda As New PdfPCell(New Phrase(colum, FuenteNotas))
        //                celda.Padding = 5
        //                celda.Colspan = 1
        //                celda.HorizontalAlignment = Element.ALIGN_CENTER
        //                celda.VerticalAlignment = Element.ALIGN_MIDDLE
        //                celda.BackgroundColor = iTextSharp.text.Color.WHITE
        //                termometroDtb.AddCell(celda)
        //            End If
        //            'obtener periodo
        //            If fecha.Equals("0") Then
        //                fecha = Mid((dataSet.Tables(0).Rows.Item(0).ItemArray(11).ToString()), 1, 6)
        //                per = PeriodoPalabras(fecha)
        //            End If
        //        Next
        //    Next

        //Else

        //    Dim cel_Null As New PdfPCell(New Phrase("ESTE CLIENTE NO POSEE DATOS", fuenteTableNota))
        //    cel_Null.HorizontalAlignment = Element.ALIGN_CENTER
        //    cel_Null.VerticalAlignment = Element.ALIGN_MIDDLE
        //    cel_Null.Colspan = 12
        //    cel_Null.Padding = 5
        //    cel_Null.BackgroundColor = New iTextSharp.text.Color(6, 63, 88)
        //    cel_Null.BackgroundColor = iTextSharp.text.Color.WHITE
        //    termometroDtb.AddCell(cel_Null)
        //    'par_termometro.Add(termometroDtb)
        //End If
        //'evaluar el dato
        //If fecha.Length > 1 Then
        //    parrResumen.Add((New Chunk("Último Termómetro Correspondiente al Mes de " & per, fuenteResumen)))
        //End If

        //' agregar  parrafos 
        //par_termometro.Add(termometroDtb)

        //parNotas.Add(notasDtb)
        //'agregar los parrafos al documento
        //documento.Add(par_RazonS)
        //documento.Add(par_termometro)
        //documento.Add(parrResumen)
        //documento.Add(parNotas)
    }
}
