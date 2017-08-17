<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.dailyTasks = New System.Windows.Forms.Button()
        Me.zipCatalog1955 = New System.Windows.Forms.Button()
        Me.zipCatalog2280 = New System.Windows.Forms.Button()
        Me.uploadCatalog1955 = New System.Windows.Forms.Button()
        Me.uploadCatalog2280 = New System.Windows.Forms.Button()
        Me.downloadPricereport = New System.Windows.Forms.Button()
        Me.startEnventa = New System.Windows.Forms.Button()
        Me.startEnventaTest = New System.Windows.Forms.Button()
        Me.openAmazon = New System.Windows.Forms.Button()
        Me.openAmazonCalculator = New System.Windows.Forms.Button()
        Me.openLoechelShop = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.startBreak = New System.Windows.Forms.Button()
        Me.openPasswordList = New System.Windows.Forms.Button()
        Me.addLoechelPics = New System.Windows.Forms.Button()
        Me.amazonOrders = New System.Windows.Forms.Button()
        Me.uploadAvailability = New System.Windows.Forms.Button()
        Me.mercateoLieferzeiten = New System.Windows.Forms.Button()
        Me.accessODBC = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.readNumberpassTxt = New System.Windows.Forms.Button()
        Me.openNumberpassTxt = New System.Windows.Forms.Button()
        Me.numberpass = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noteEditor = New System.Windows.Forms.TextBox()
        Me.saveNotes = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.tabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.numberpass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dailyTasks
        '
        Me.dailyTasks.AutoEllipsis = True
        Me.dailyTasks.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.dailyTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dailyTasks.Cursor = System.Windows.Forms.Cursors.Default
        Me.dailyTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dailyTasks.Location = New System.Drawing.Point(6, 6)
        Me.dailyTasks.Name = "dailyTasks"
        Me.dailyTasks.Size = New System.Drawing.Size(250, 125)
        Me.dailyTasks.TabIndex = 0
        Me.dailyTasks.Text = "Starte tägliche Aufgaben"
        Me.dailyTasks.UseVisualStyleBackColor = False
        '
        'zipCatalog1955
        '
        Me.zipCatalog1955.BackColor = System.Drawing.Color.Silver
        Me.zipCatalog1955.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zipCatalog1955.Location = New System.Drawing.Point(262, 6)
        Me.zipCatalog1955.Name = "zipCatalog1955"
        Me.zipCatalog1955.Size = New System.Drawing.Size(125, 60)
        Me.zipCatalog1955.TabIndex = 1
        Me.zipCatalog1955.Text = "1955 Catalog zippen"
        Me.zipCatalog1955.UseVisualStyleBackColor = False
        '
        'zipCatalog2280
        '
        Me.zipCatalog2280.BackColor = System.Drawing.Color.Silver
        Me.zipCatalog2280.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zipCatalog2280.Location = New System.Drawing.Point(262, 71)
        Me.zipCatalog2280.Name = "zipCatalog2280"
        Me.zipCatalog2280.Size = New System.Drawing.Size(125, 60)
        Me.zipCatalog2280.TabIndex = 2
        Me.zipCatalog2280.Text = "2280 Catalog zippen"
        Me.zipCatalog2280.UseVisualStyleBackColor = False
        '
        'uploadCatalog1955
        '
        Me.uploadCatalog1955.BackColor = System.Drawing.Color.Silver
        Me.uploadCatalog1955.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadCatalog1955.Location = New System.Drawing.Point(393, 6)
        Me.uploadCatalog1955.Name = "uploadCatalog1955"
        Me.uploadCatalog1955.Size = New System.Drawing.Size(125, 60)
        Me.uploadCatalog1955.TabIndex = 3
        Me.uploadCatalog1955.Text = "1955 Catalog hochladen"
        Me.uploadCatalog1955.UseVisualStyleBackColor = False
        '
        'uploadCatalog2280
        '
        Me.uploadCatalog2280.BackColor = System.Drawing.Color.Silver
        Me.uploadCatalog2280.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadCatalog2280.Location = New System.Drawing.Point(393, 72)
        Me.uploadCatalog2280.Name = "uploadCatalog2280"
        Me.uploadCatalog2280.Size = New System.Drawing.Size(125, 60)
        Me.uploadCatalog2280.TabIndex = 4
        Me.uploadCatalog2280.Text = "2280 Catalog hochladen"
        Me.uploadCatalog2280.UseVisualStyleBackColor = False
        '
        'downloadPricereport
        '
        Me.downloadPricereport.BackColor = System.Drawing.Color.Silver
        Me.downloadPricereport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadPricereport.Location = New System.Drawing.Point(524, 38)
        Me.downloadPricereport.Name = "downloadPricereport"
        Me.downloadPricereport.Size = New System.Drawing.Size(125, 60)
        Me.downloadPricereport.TabIndex = 5
        Me.downloadPricereport.Text = "Preisreport herunterladen"
        Me.downloadPricereport.UseVisualStyleBackColor = False
        '
        'startEnventa
        '
        Me.startEnventa.BackColor = System.Drawing.Color.LightBlue
        Me.startEnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startEnventa.Location = New System.Drawing.Point(724, 531)
        Me.startEnventa.Name = "startEnventa"
        Me.startEnventa.Size = New System.Drawing.Size(250, 100)
        Me.startEnventa.TabIndex = 6
        Me.startEnventa.Text = "eNVenta starten"
        Me.startEnventa.UseVisualStyleBackColor = False
        '
        'startEnventaTest
        '
        Me.startEnventaTest.BackColor = System.Drawing.Color.LightBlue
        Me.startEnventaTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startEnventaTest.Location = New System.Drawing.Point(724, 465)
        Me.startEnventaTest.Name = "startEnventaTest"
        Me.startEnventaTest.Size = New System.Drawing.Size(250, 60)
        Me.startEnventaTest.TabIndex = 7
        Me.startEnventaTest.Text = "eNVenta Testsystem"
        Me.startEnventaTest.UseVisualStyleBackColor = False
        '
        'openAmazon
        '
        Me.openAmazon.BackColor = System.Drawing.Color.DarkOrange
        Me.openAmazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openAmazon.Location = New System.Drawing.Point(6, 571)
        Me.openAmazon.Name = "openAmazon"
        Me.openAmazon.Size = New System.Drawing.Size(122, 60)
        Me.openAmazon.TabIndex = 8
        Me.openAmazon.Text = "Amazon Händlerportal"
        Me.openAmazon.UseVisualStyleBackColor = False
        '
        'openAmazonCalculator
        '
        Me.openAmazonCalculator.BackColor = System.Drawing.Color.DarkOrange
        Me.openAmazonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openAmazonCalculator.Location = New System.Drawing.Point(134, 571)
        Me.openAmazonCalculator.Name = "openAmazonCalculator"
        Me.openAmazonCalculator.Size = New System.Drawing.Size(122, 60)
        Me.openAmazonCalculator.TabIndex = 9
        Me.openAmazonCalculator.Text = "Amazon Rechner"
        Me.openAmazonCalculator.UseVisualStyleBackColor = False
        '
        'openLoechelShop
        '
        Me.openLoechelShop.BackColor = System.Drawing.Color.CornflowerBlue
        Me.openLoechelShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openLoechelShop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.openLoechelShop.Location = New System.Drawing.Point(6, 465)
        Me.openLoechelShop.Name = "openLoechelShop"
        Me.openLoechelShop.Size = New System.Drawing.Size(250, 100)
        Me.openLoechelShop.TabIndex = 10
        Me.openLoechelShop.Text = "Löchel Shop öffnen"
        Me.openLoechelShop.UseVisualStyleBackColor = False
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.TabPage1)
        Me.tabControl.Controls.Add(Me.TabPage2)
        Me.tabControl.Location = New System.Drawing.Point(12, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(988, 663)
        Me.tabControl.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.startBreak)
        Me.TabPage1.Controls.Add(Me.openPasswordList)
        Me.TabPage1.Controls.Add(Me.addLoechelPics)
        Me.TabPage1.Controls.Add(Me.amazonOrders)
        Me.TabPage1.Controls.Add(Me.uploadAvailability)
        Me.TabPage1.Controls.Add(Me.mercateoLieferzeiten)
        Me.TabPage1.Controls.Add(Me.accessODBC)
        Me.TabPage1.Controls.Add(Me.dailyTasks)
        Me.TabPage1.Controls.Add(Me.openAmazonCalculator)
        Me.TabPage1.Controls.Add(Me.openLoechelShop)
        Me.TabPage1.Controls.Add(Me.openAmazon)
        Me.TabPage1.Controls.Add(Me.zipCatalog1955)
        Me.TabPage1.Controls.Add(Me.zipCatalog2280)
        Me.TabPage1.Controls.Add(Me.uploadCatalog1955)
        Me.TabPage1.Controls.Add(Me.startEnventa)
        Me.TabPage1.Controls.Add(Me.startEnventaTest)
        Me.TabPage1.Controls.Add(Me.uploadCatalog2280)
        Me.TabPage1.Controls.Add(Me.downloadPricereport)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(980, 637)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'startBreak
        '
        Me.startBreak.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.startBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startBreak.Location = New System.Drawing.Point(388, 531)
        Me.startBreak.Name = "startBreak"
        Me.startBreak.Size = New System.Drawing.Size(330, 34)
        Me.startBreak.TabIndex = 18
        Me.startBreak.Text = "Pause"
        Me.startBreak.UseVisualStyleBackColor = False
        '
        'openPasswordList
        '
        Me.openPasswordList.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.openPasswordList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openPasswordList.Location = New System.Drawing.Point(724, 429)
        Me.openPasswordList.Name = "openPasswordList"
        Me.openPasswordList.Size = New System.Drawing.Size(250, 30)
        Me.openPasswordList.TabIndex = 17
        Me.openPasswordList.Text = "DIE LISTE!"
        Me.openPasswordList.UseVisualStyleBackColor = False
        '
        'addLoechelPics
        '
        Me.addLoechelPics.BackColor = System.Drawing.Color.CornflowerBlue
        Me.addLoechelPics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addLoechelPics.ForeColor = System.Drawing.SystemColors.ControlText
        Me.addLoechelPics.Location = New System.Drawing.Point(262, 465)
        Me.addLoechelPics.Name = "addLoechelPics"
        Me.addLoechelPics.Size = New System.Drawing.Size(120, 100)
        Me.addLoechelPics.TabIndex = 16
        Me.addLoechelPics.Text = "Löchel Shop neue Artikelbilder hinzufügen"
        Me.addLoechelPics.UseVisualStyleBackColor = False
        '
        'amazonOrders
        '
        Me.amazonOrders.BackColor = System.Drawing.Color.DarkOrange
        Me.amazonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.amazonOrders.Location = New System.Drawing.Point(262, 571)
        Me.amazonOrders.Name = "amazonOrders"
        Me.amazonOrders.Size = New System.Drawing.Size(120, 60)
        Me.amazonOrders.TabIndex = 15
        Me.amazonOrders.Text = "Amazon Bestellungen Import Script"
        Me.amazonOrders.UseVisualStyleBackColor = False
        '
        'uploadAvailability
        '
        Me.uploadAvailability.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.uploadAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadAvailability.Location = New System.Drawing.Point(842, 6)
        Me.uploadAvailability.Name = "uploadAvailability"
        Me.uploadAvailability.Size = New System.Drawing.Size(132, 60)
        Me.uploadAvailability.TabIndex = 14
        Me.uploadAvailability.Text = "availability-data-catalog hochladen"
        Me.uploadAvailability.UseVisualStyleBackColor = False
        '
        'mercateoLieferzeiten
        '
        Me.mercateoLieferzeiten.BackColor = System.Drawing.Color.Salmon
        Me.mercateoLieferzeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mercateoLieferzeiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mercateoLieferzeiten.Location = New System.Drawing.Point(6, 429)
        Me.mercateoLieferzeiten.Name = "mercateoLieferzeiten"
        Me.mercateoLieferzeiten.Size = New System.Drawing.Size(376, 30)
        Me.mercateoLieferzeiten.TabIndex = 13
        Me.mercateoLieferzeiten.Text = "Lieferzeiten Mercateo"
        Me.mercateoLieferzeiten.UseVisualStyleBackColor = False
        '
        'accessODBC
        '
        Me.accessODBC.BackColor = System.Drawing.Color.Orchid
        Me.accessODBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accessODBC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.accessODBC.Location = New System.Drawing.Point(388, 571)
        Me.accessODBC.Name = "accessODBC"
        Me.accessODBC.Size = New System.Drawing.Size(330, 60)
        Me.accessODBC.TabIndex = 12
        Me.accessODBC.Text = "Access ODBC"
        Me.accessODBC.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.readNumberpassTxt)
        Me.TabPage2.Controls.Add(Me.openNumberpassTxt)
        Me.TabPage2.Controls.Add(Me.numberpass)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(980, 637)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nummern & Passwörter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'readNumberpassTxt
        '
        Me.readNumberpassTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.readNumberpassTxt.Location = New System.Drawing.Point(568, 591)
        Me.readNumberpassTxt.Name = "readNumberpassTxt"
        Me.readNumberpassTxt.Size = New System.Drawing.Size(200, 40)
        Me.readNumberpassTxt.TabIndex = 15
        Me.readNumberpassTxt.Text = "Aktualisieren"
        Me.readNumberpassTxt.UseVisualStyleBackColor = True
        '
        'openNumberpassTxt
        '
        Me.openNumberpassTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openNumberpassTxt.Location = New System.Drawing.Point(774, 591)
        Me.openNumberpassTxt.Name = "openNumberpassTxt"
        Me.openNumberpassTxt.Size = New System.Drawing.Size(200, 40)
        Me.openNumberpassTxt.TabIndex = 14
        Me.openNumberpassTxt.Text = "Als .txt öffnen"
        Me.openNumberpassTxt.UseVisualStyleBackColor = True
        '
        'numberpass
        '
        Me.numberpass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.numberpass.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.numberpass.Location = New System.Drawing.Point(6, 6)
        Me.numberpass.Name = "numberpass"
        Me.numberpass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.numberpass.Size = New System.Drawing.Size(968, 625)
        Me.numberpass.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 210
        '
        'Column2
        '
        Me.Column2.HeaderText = "Wert"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 210
        '
        'Column3
        '
        Me.Column3.HeaderText = "Zusatzinfo"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 505
        '
        'noteEditor
        '
        Me.noteEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteEditor.Location = New System.Drawing.Point(1006, 186)
        Me.noteEditor.Multiline = True
        Me.noteEditor.Name = "noteEditor"
        Me.noteEditor.Size = New System.Drawing.Size(246, 423)
        Me.noteEditor.TabIndex = 12
        '
        'saveNotes
        '
        Me.saveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveNotes.Location = New System.Drawing.Point(1006, 625)
        Me.saveNotes.Name = "saveNotes"
        Me.saveNotes.Size = New System.Drawing.Size(246, 50)
        Me.saveNotes.TabIndex = 13
        Me.saveNotes.Text = "Notiz Speichern"
        Me.saveNotes.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(1043, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.saveNotes)
        Me.Controls.Add(Me.noteEditor)
        Me.Controls.Add(Me.tabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.Text = "Löchel Industriebedarf"
        Me.tabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.numberpass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dailyTasks As Button
    Friend WithEvents zipCatalog1955 As Button
    Friend WithEvents zipCatalog2280 As Button
    Friend WithEvents uploadCatalog1955 As Button
    Friend WithEvents uploadCatalog2280 As Button
    Friend WithEvents downloadPricereport As Button
    Friend WithEvents startEnventa As Button
    Friend WithEvents startEnventaTest As Button
    Friend WithEvents openAmazon As Button
    Friend WithEvents openAmazonCalculator As Button
    Friend WithEvents openLoechelShop As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents noteEditor As TextBox
    Friend WithEvents saveNotes As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents accessODBC As Button
    Friend WithEvents mercateoLieferzeiten As Button
    Friend WithEvents uploadAvailability As Button
    Friend WithEvents amazonOrders As Button
    Friend WithEvents addLoechelPics As Button
    Friend WithEvents openPasswordList As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents numberpass As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents openNumberpassTxt As Button
    Friend WithEvents readNumberpassTxt As Button
    Friend WithEvents startBreak As Button
End Class
