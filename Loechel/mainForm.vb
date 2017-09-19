Imports System.ComponentModel

Public Class mainForm

    'Pfad, in dem die Dateien zur Automatisierung liegen
    Public Shared autoPath As String = "Z:\Automatisierung\"



    'Lade den Notiztext aus einer Textdatei
    Private Sub readNotes()
        Try
            noteEditor.Text = System.IO.File.ReadAllText(autoPath + "txt\notes.txt")
        Catch ex As Exception

        End Try
    End Sub

    'Liest Daten für numberpass Feld
    Private Sub readNumberpass()
        numberpass.Rows.Clear()

        For Each ThisLine In My.Computer.FileSystem.ReadAllText(autoPath + "txt\numberpass.txt").Split(Environment.NewLine)

            numberpass.Rows.Add(Split(ThisLine, ControlChars.Tab))

        Next
    End Sub

    'Schreibt Daten von numberpass Feld in Textdatei
    Private Sub writeNumberpass()
        numberpass.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText

        numberpass.SelectAll()

        IO.File.WriteAllText(autoPath + "txt\numberpass.txt", numberpass.GetClipboardContent().GetText.TrimEnd)

        numberpass.ClearSelection()
    End Sub









    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readNotes()

        readNumberpass()
    End Sub

    Private Sub dailyTasks_Click(sender As Object, e As EventArgs) Handles dailyTasks.Click
        Process.Start(autoPath + "bat\start.bat")
    End Sub

    Private Sub zipCatalog1955_Click(sender As Object, e As EventArgs) Handles zipCatalog1955.Click
        Process.Start(autoPath + "WinRar\zipCatalog1955.bat")
    End Sub

    Private Sub zipCatalog2280_Click(sender As Object, e As EventArgs) Handles zipCatalog2280.Click
        Process.Start(autoPath + "WinRar\zipCatalog2280.bat")
    End Sub

    Private Sub uploadCatalog1955_Click(sender As Object, e As EventArgs) Handles uploadCatalog1955.Click
        Process.Start(autoPath + "WinScp\uploadCatalog1955.bat")
    End Sub

    Private Sub uploadCatalog2280_Click(sender As Object, e As EventArgs) Handles uploadCatalog2280.Click
        Process.Start(autoPath + "WinScp\uploadCatalog2280.bat")
    End Sub

    Private Sub downloadPricereport_Click(sender As Object, e As EventArgs) Handles downloadPricereport.Click
        Process.Start(autoPath + "WinScp\downloadPricereport.bat")
    End Sub

    Private Sub startEnventa_Click(sender As Object, e As EventArgs) Handles startEnventa.Click
        Process.Start(autoPath + "eNVenta\eNVenta.jnlp")
    End Sub

    Private Sub startEnventaTest_Click(sender As Object, e As EventArgs) Handles startEnventaTest.Click
        Process.Start(autoPath + "eNVenta\eNVenta -Test.jnlp")
    End Sub

    Private Sub openAmazon_Click(sender As Object, e As EventArgs) Handles openAmazon.Click
        Process.Start("https://sellercentral.amazon.de/gp/homepage.html")
    End Sub

    Private Sub openAmazonCalculator_Click(sender As Object, e As EventArgs) Handles openAmazonCalculator.Click
        Process.Start(autoPath + "Excel\AmazonRechner.xlsx")
    End Sub

    Private Sub openLoechelShop_Click(sender As Object, e As EventArgs) Handles openLoechelShop.Click
        Process.Start("https://www.loechel-industriebedarf.de/admin")
    End Sub

    Private Sub noteEditor_TextChanged(sender As Object, e As EventArgs) Handles noteEditor.TextChanged

    End Sub

    Private Sub saveNotes_Click(sender As Object, e As EventArgs) Handles saveNotes.Click
        My.Computer.FileSystem.WriteAllText(autoPath + "txt\notes.txt", noteEditor.Text, False)
    End Sub

    Private Sub webBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub accessODBC_Click(sender As Object, e As EventArgs) Handles accessODBC.Click, accessODBC.Click
        Process.Start("Z:\Löchel Industriebedarf\Datenmanagement\odbc_test.accdb")
    End Sub

    Private Sub mercateoLieferzeiten_Click(sender As Object, e As EventArgs) Handles mercateoLieferzeiten.Click
        Process.Start("http://tectree24.net/lieferzeit/")
    End Sub

    Private Sub uploadAvailability_Click(sender As Object, e As EventArgs) Handles uploadAvailability.Click
        Process.Start(autoPath + "WinScp\uploadAvailability.bat")
    End Sub

    Private Sub amazonOrders_Click(sender As Object, e As EventArgs) Handles amazonOrders.Click
        Process.Start(autoPath + "Projects\AmazonTranslator\AmazonTranslator\bin\Debug\AmazonTranslatorManual.exe")
    End Sub

    Private Sub addLoechelPics_Click(sender As Object, e As EventArgs) Handles addLoechelPics.Click
        Dim myProcess As New Process
        myProcess.StartInfo.WorkingDirectory = autoPath + "\Projects\CopyArticleImages\CopyArticleImages\bin\Debug\"
        myProcess.StartInfo.FileName = autoPath + "\Projects\CopyArticleImages\CopyArticleImages\bin\Debug\FolderListSearch.exe"
        myProcess.Start()
    End Sub

    Private Sub openPasswordList_Click(sender As Object, e As EventArgs) Handles openPasswordList.Click
        Process.Start("Z:\Löchel Industriebedarf\Liste.xlsx")
    End Sub

    Private Sub numberpass_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles numberpass.CellEndEdit
        writeNumberpass()
    End Sub

    Private Sub openNumberpassTxt_Click(sender As Object, e As EventArgs) Handles openNumberpassTxt.Click
        Process.Start(autoPath + "txt\numberpass.txt")
    End Sub

    Private Sub readNumberpassTxt_Click(sender As Object, e As EventArgs) Handles readNumberpassTxt.Click
        readNumberpass()
    End Sub

    Private Sub startBreak_Click(sender As Object, e As EventArgs) Handles startBreak.Click
        Process.Start("C:\Program Files (x86)\GOG Galaxy\GalaxyClient.exe")
    End Sub

    Private Sub openAmazonScriptPath_Click(sender As Object, e As EventArgs) Handles openAmazonScriptPath.Click
        Process.Start("V:\BMECat\Amazon\Test")
    End Sub

    Private Sub openProjectsFolder_Click(sender As Object, e As EventArgs) Handles openProjectsFolder.Click
        Process.Start(autoPath + "Projects")
    End Sub

    Private Sub openAmazonPriceCalculator_Click(sender As Object, e As EventArgs) Handles openAmazonPriceCalculator.Click
        Process.Start(autoPath + "Projects\AmazonPreise\AmazonPreise\bin\Debug\AmazonPriceCalculator.exe")
    End Sub

    Private Sub openTextSplitter_Click(sender As Object, e As EventArgs) Handles openTextSplitter.Click
        Process.Start(autoPath + "Projects\TextSplitter\TextSplitter\bin\Debug\TextSplitter.exe")
    End Sub
End Class
