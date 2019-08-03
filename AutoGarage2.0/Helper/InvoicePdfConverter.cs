using AutoGarage2._0.Models;
using AutoGarage2._0.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace AutoGarage2._0.Helper
{
   public static class InvoicePdfConverter
    {
        public static void PdfExport(OrderViewModel order)
        {
            Double TotalAmount = 0;
            /// PDF Windows savedialog object and properties
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            sfd.FileName = DateTime.Now.ToString();

            /// If statement to save the file by pressing OK.
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                /// Using filestream to save the data in memory
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {

                    /// Creating the Document and the PDF writer object
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    /// Open the document and adding detail information
                    pdfDoc.Open();
                    pdfDoc.AddAuthor("Template");
                    pdfDoc.AddCreator("G");
                    pdfDoc.AddKeywords("Invoice");
                    pdfDoc.AddSubject("Created invoice PDF generator");
                    BaseFont f_cb = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    BaseFont f_cn = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                    /// Contentwriter Class for customizing elements
                    PdfContentByte cb = writer.DirectContent;

                    ///  Header ///
                    ///  
                    ///
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 22);
                    cb.SetTextMatrix(100, 100); // Left, Top  
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "FACTUUR", 300, 820, 0);
                    cb.EndText();
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 12);
                    cb.SetTextMatrix(100, 100); // Left, Top  
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template Company", 120, 740, 0);
                    cb.EndText();
                    //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("auto-logo_73313-24.jpg");
                    //img.SetAbsolutePosition(50, 750);
                    //img.ScaleAbsolute(25, 25);
                    //img.ScalePercent(25);
                    //cb.AddImage(img);
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 12);
                    cb.SetTextMatrix(100, 100); // Left, Top  
                    cb.SetColorFill(BaseColor.GRAY);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Adres:", 370, 790, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template", 470, 790, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template", 470, 778, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Telefoon:", 370, 760, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template", 470, 760, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Fax:", 370, 742, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template3", 470, 742, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Rek.nr.:", 370, 726, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template", 470, 726, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "KvK nr.:", 370, 708, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template", 470, 708, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "BTW nr.", 370, 690, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Template", 470, 690, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "In- en verkoop personenauto's en bedrifswagens", 125, 720, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Verkoop nieuwe en gebruikte onderdelen:", 125, 702, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Machines en heftrucks:", 125, 686, 0);
                    cb.EndText();
                    cb.SetLineWidth(0f);
                    cb.MoveTo(1, 670);
                    cb.LineTo(600, 670);
                    cb.Stroke();
                    cb.SetLineWidth(0f);
                    cb.MoveTo(1, 738);
                    cb.LineTo(242, 738);
                    cb.Stroke();

                    /// Body
                    /// 
                    ///
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 12);
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.SetTextMatrix(100, 100);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Factuur nummer:", 100, 650, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, order.InvoiceNumber.ToString(), 400, 650, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Rekening voor:", 100, 610, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, order.CustomerName, 400, 610, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Faktuurdatum:", 100, 570, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, order.OrderTime.ToString(), 400, 570, 0);
                    // Looping the Orderservices and writing to PDF with x coordinate values
                    var Y = 460;
                    foreach (var service in order.OrderServices)
                    {
                        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, service.Description, 60, Y, 0);
                        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, service.Cost.ToString() + " €", 450, Y, 0);
                        TotalAmount = TotalAmount + service.Cost;
                        Y = Y - 20;
                    }
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Omscrijving:", 100, 490, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Bedrag:", 450, 490, 0);
                    cb.EndText();
                    cb.SetLineWidth(0f);
                    cb.MoveTo(70, 500);
                    cb.LineTo(485, 500);
                    cb.Stroke();
                    cb.SetLineWidth(0f);
                    cb.MoveTo(70, 485);
                    cb.LineTo(485, 485);
                    cb.Stroke();
                    cb.SetLineWidth(0f);
                    cb.MoveTo(70, 205);
                    cb.LineTo(485, 205);
                    cb.Stroke();
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 12);
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.SetTextMatrix(100, 100);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Totaal bedrag:", 350, 190, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, TotalAmount.ToString() + " €", 450, 190, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "BTW 21%:", 350, 170, 0);
                    var btw = TotalAmount * 0.21;
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, btw + " €", 450, 170, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Totaal te betalen:", 350, 150, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, btw + TotalAmount + " €", 450, 150, 0);
                    cb.EndText();
                    cb.SetLineWidth(0f);
                    cb.MoveTo(70, 140);
                    cb.LineTo(485, 140);
                    cb.Stroke();

                    /// Footer
                    /// 
                    ///
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 12);
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.SetTextMatrix(100, 100);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                            "Wij vragen u het totaal bedrag binnen 14 dagen over to maken op het bovengenoemde rekening nummer", 25, 50, 0);
                    cb.EndText();

                    ///  Closing Document and memory stream
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
