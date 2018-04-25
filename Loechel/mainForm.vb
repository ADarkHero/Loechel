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

    'Liest Daten für imports Feld
    Private Sub readImports()
        importsDataGrid.Rows.Clear()
        Try
            For Each ThisLine In My.Computer.FileSystem.ReadAllText(autoPath + "txt\imports.txt").Split(Environment.NewLine)

                importsDataGrid.Rows.Add(Split(ThisLine, ControlChars.Tab))

            Next
        Catch ex As Exception

        End Try
    End Sub



    'Schreibt Daten von numberpass Feld in Textdatei
    Private Sub writeNumberpass()
        numberpass.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText

        numberpass.SelectAll()

        Dim writetext As String = numberpass.GetClipboardContent().GetText.TrimEnd

        IO.File.WriteAllText(autoPath + "txt\numberpass.txt", writetext)

        numberpass.ClearSelection()
    End Sub

    'Schreibt Daten von imports Feld in Textdatei
    Private Sub writeImports()
        importsDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText

        importsDataGrid.SelectAll()

        Dim writetext As String = importsDataGrid.GetClipboardContent().GetText.TrimEnd
        writetext = writetext.Substring(0, writetext.Length - 22) 'Deletes last line of the string, else it would save an empty line at the end

        IO.File.WriteAllText(autoPath + "txt\imports.txt", writetext)

        importsDataGrid.ClearSelection()
    End Sub








    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readNotes()

        readNumberpass()

        readImports()
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
        Process.Start(autoPath + "eNVenta\enventa_test.bat")
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
        Process.Start("D:\odbc_test.accdb")
        Process.Start("D:\odbc_test.accdb")
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

    Private Sub numberpass_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles numberpass.CellEnter
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
        Process.Start(autoPath + "exe\CSVSplitter.exe")
        Process.Start(autoPath + "exe\CSVSplitter.exe")
    End Sub

    Private Sub importsDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles importsDataGrid.CellEnter
        writeImports()
    End Sub

    Private Sub addLoechelArticles_Click(sender As Object, e As EventArgs) Handles addLoechelArticles.Click
        Process.Start("D:\LoechelNWShop.odb")
        Process.Start("D:\LoechelNWShop.odb")
    End Sub

    Private Sub openConditionList_Click(sender As Object, e As EventArgs) Handles openConditionList.Click
        Process.Start("Z:\Löchel Industriebedarf\Konditionen LI.xlsx")
        Process.Start("Z:\Löchel Industriebedarf\Konditionen LI.xlsx")
    End Sub

    Private Sub openPictureResizer_Click(sender As Object, e As EventArgs) Handles openPictureResizer.Click
        Process.Start(autoPath + "exe\verkleinerer17b.exe")
    End Sub

    Private Sub openMoreBreak_Click(sender As Object, e As EventArgs) Handles openMoreBreak.Click
        Process.Start("C:\Program Files (x86)\GOG Galaxy\Games\Gwent\GwentUp\GwentUp.exe")
    End Sub

    Private Sub openGYSAHK_Click(sender As Object, e As EventArgs) Handles openGYSAHK.Click
        Process.Start(autoPath + "ahk\gys.ahk")
    End Sub

    Private Sub openKemmlerAHK_Click(sender As Object, e As EventArgs) Handles openKemmlerAHK.Click
        Process.Start(autoPath + "ahk\kemmler.ahk")
    End Sub

    Private Sub openLandefeldAHK_Click(sender As Object, e As EventArgs) Handles openLandefeldAHK.Click
        Process.Start(autoPath + "ahk\landfeld_vm.ahk")
    End Sub

    Private Sub openNordwestAHK_Click(sender As Object, e As EventArgs) Handles openNordwestAHK.Click
        Process.Start(autoPath + "ahk\nordwest.ahk")
    End Sub

    Private Sub startSteamBreak_Click(sender As Object, e As EventArgs) Handles startSteamBreak.Click
        Process.Start("C:\Program Files (x86)\Steam\Steam.exe")
    End Sub

    Private Sub openBreakHS_Click(sender As Object, e As EventArgs) Handles openBreakHS.Click
        Process.Start("C:\Program Files (x86)\Battle.net\Hearthstone\Hearthstone.exe")
    End Sub
End Class
