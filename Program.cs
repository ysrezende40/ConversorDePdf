using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.Drawing.Imaging;
using System.IO;

namespace ConversorPdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pastaPDF = @"C:\Users\ysaac\OneDrive\Documentos\Pdfs";
            string pastaDestino = @"C:\Users\ysaac\OneDrive\Documentos\ConvertedImages";

            ConvertePDF(pastaPDF, pastaDestino);
            Console.WriteLine("Conversão concluída!");
        }

        private static void ConvertePDF(string pastaPDF, string pastaDestino)
        {
            
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            
            string[] PDFs = Directory.GetFiles(pastaPDF, "*.pdf");

            foreach (string pdfArquivo in PDFs)
            {
                // Carrega o documento PDF
                PdfDocument pdf = new PdfDocument();
                pdf.LoadFromFile(pdfArquivo);

                // Converte cada página do PDF para imagem e salva
                for (int i = 0; i < pdf.Pages.Count; i++)
                {
                    // Converte a página para imagem
                    using (var image = pdf.SaveAsImage(i, PdfImageType.Bitmap, 500, 500))
                    {
                        // Define o caminho completo para o arquivo de saída
                        string caminhoDaImagem = Path.Combine(pastaDestino, $"{Path.GetFileNameWithoutExtension(pdfArquivo)}_page_{i + 1}.jpg");
                                                                                //obter o nome do arquivo sem a extensão
                        

                        image.Save(caminhoDaImagem, ImageFormat.Jpeg);

                        Console.WriteLine($"Imagem salva em: {caminhoDaImagem}");
                    }
                }
            }
        }
    }
}
