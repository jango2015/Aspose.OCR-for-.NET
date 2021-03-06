Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class SettingtheOcrEngine
        Public Shared Sub Run()
            ' ExStart:SettingtheOcrEngine
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()
            'Create an instance of OcrEngine class
            Dim ocr As New OcrEngine()

            'Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Set the RemoveNonText to true
            ocr.Config.RemoveNonText = True

            'Perform OCR operation
            If ocr.Process() Then
                'Display results
                Console.WriteLine(ocr.Text)
            End If
            ' ExEnd:SettingtheOcrEngine
        End Sub
    End Class
End Namespace