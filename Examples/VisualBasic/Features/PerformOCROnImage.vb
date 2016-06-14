Imports Microsoft.VisualBasic
Imports System
Imports System.IO

Imports Aspose.OCR

Namespace Aspose.OCR.Examples.VisualBasic.Features
    Public Class PerformOCROnImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Source file: the file on which OCR will be performed.
            Dim imageFile As String = dataDir & "Sampleocr.bmp"

            Console.WriteLine("Performing OCR on " & imageFile & "....")

            ' Initialize OcrEngine.
            Dim ocr As New OcrEngine()
            ' Set the image.
            ocr.Image = ImageStream.FromFile(imageFile)

            Try
                ' Process the whole image
                If ocr.Process() Then
                    ' Get the complete recognized text found from the image
                    Console.WriteLine("Text recognized: " & ocr.Text.ToString())
                    File.WriteAllText(dataDir & "Output.txt", ocr.Text.ToString())
                End If
            Catch ex As Exception
                Console.WriteLine("Exception: " & ex.ToString())
            End Try
        End Sub
    End Class
End Namespace