<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoitesDialogue
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoitesDialogue))
Me.dlgImprimer = New System.Windows.Forms.PrintDialog()
Me.btnapercu = New System.Windows.Forms.Button()
Me.rtfZoneTexte = New System.Windows.Forms.RichTextBox()
Me.prtDocument = New System.Drawing.Printing.PrintDocument()
Me.btnMiseEnPage = New System.Windows.Forms.Button()
Me.dlgApercu = New System.Windows.Forms.PrintPreviewDialog()
Me.btnImprimer = New System.Windows.Forms.Button()
Me.dlgMiseEnPage = New System.Windows.Forms.PageSetupDialog()
Me.dlgOuvrir = New System.Windows.Forms.OpenFileDialog()
Me.btnQuitter = New System.Windows.Forms.Button()
Me.btnCouleur = New System.Windows.Forms.Button()
Me.btnPolice = New System.Windows.Forms.Button()
Me.btnEnrSous = New System.Windows.Forms.Button()
Me.dlgPolice = New System.Windows.Forms.FontDialog()
Me.dlgEnregSous = New System.Windows.Forms.SaveFileDialog()
Me.btnOuvrir = New System.Windows.Forms.Button()
Me.dlgCouleur = New System.Windows.Forms.ColorDialog()
Me.SuspendLayout()
'
'dlgImprimer
'
Me.dlgImprimer.UseEXDialog = True
'
'btnapercu
'
Me.btnapercu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnapercu.Image = CType(resources.GetObject("btnapercu.Image"), System.Drawing.Image)
Me.btnapercu.Location = New System.Drawing.Point(371, 222)
Me.btnapercu.Name = "btnapercu"
Me.btnapercu.Size = New System.Drawing.Size(112, 57)
Me.btnapercu.TabIndex = 19
Me.btnapercu.Text = "&Apercu"
Me.btnapercu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
'
'rtfZoneTexte
'
Me.rtfZoneTexte.Anchor = System.Windows.Forms.AnchorStyles.None
Me.rtfZoneTexte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.rtfZoneTexte.Location = New System.Drawing.Point(19, 14)
Me.rtfZoneTexte.Name = "rtfZoneTexte"
Me.rtfZoneTexte.Size = New System.Drawing.Size(296, 384)
Me.rtfZoneTexte.TabIndex = 18
Me.rtfZoneTexte.Text = "Contenu du contrôle RichTextBox"
'
'prtDocument
'
'
'btnMiseEnPage
'
Me.btnMiseEnPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnMiseEnPage.Image = CType(resources.GetObject("btnMiseEnPage.Image"), System.Drawing.Image)
Me.btnMiseEnPage.Location = New System.Drawing.Point(371, 278)
Me.btnMiseEnPage.Name = "btnMiseEnPage"
Me.btnMiseEnPage.Size = New System.Drawing.Size(112, 57)
Me.btnMiseEnPage.TabIndex = 21
Me.btnMiseEnPage.Text = "&Mise en page"
Me.btnMiseEnPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
'
'dlgApercu
'
Me.dlgApercu.AutoScrollMargin = New System.Drawing.Size(0, 0)
Me.dlgApercu.AutoScrollMinSize = New System.Drawing.Size(0, 0)
Me.dlgApercu.ClientSize = New System.Drawing.Size(400, 300)
Me.dlgApercu.Enabled = True
Me.dlgApercu.Icon = CType(resources.GetObject("dlgApercu.Icon"), System.Drawing.Icon)
Me.dlgApercu.Name = "dlgApercu"
Me.dlgApercu.Visible = False
'
'btnImprimer
'
Me.btnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnImprimer.Image = CType(resources.GetObject("btnImprimer.Image"), System.Drawing.Image)
Me.btnImprimer.Location = New System.Drawing.Point(371, 166)
Me.btnImprimer.Name = "btnImprimer"
Me.btnImprimer.Size = New System.Drawing.Size(112, 57)
Me.btnImprimer.TabIndex = 20
Me.btnImprimer.Text = "&Imprimer"
Me.btnImprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
'
'btnQuitter
'
Me.btnQuitter.BackColor = System.Drawing.SystemColors.Control
Me.btnQuitter.Cursor = System.Windows.Forms.Cursors.Default
Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnQuitter.Image = CType(resources.GetObject("btnQuitter.Image"), System.Drawing.Image)
Me.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.btnQuitter.Location = New System.Drawing.Point(363, 350)
Me.btnQuitter.Name = "btnQuitter"
Me.btnQuitter.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnQuitter.Size = New System.Drawing.Size(128, 57)
Me.btnQuitter.TabIndex = 17
Me.btnQuitter.Text = "&Quitter"
Me.btnQuitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.btnQuitter.UseVisualStyleBackColor = False
'
'btnCouleur
'
Me.btnCouleur.BackColor = System.Drawing.SystemColors.Control
Me.btnCouleur.Cursor = System.Windows.Forms.Cursors.Default
Me.btnCouleur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnCouleur.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnCouleur.Image = CType(resources.GetObject("btnCouleur.Image"), System.Drawing.Image)
Me.btnCouleur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.btnCouleur.Location = New System.Drawing.Point(331, 22)
Me.btnCouleur.Name = "btnCouleur"
Me.btnCouleur.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnCouleur.Size = New System.Drawing.Size(88, 57)
Me.btnCouleur.TabIndex = 13
Me.btnCouleur.Text = "&Couleur"
Me.btnCouleur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.btnCouleur.UseVisualStyleBackColor = False
'
'btnPolice
'
Me.btnPolice.BackColor = System.Drawing.SystemColors.Control
Me.btnPolice.Cursor = System.Windows.Forms.Cursors.Default
Me.btnPolice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnPolice.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnPolice.Image = CType(resources.GetObject("btnPolice.Image"), System.Drawing.Image)
Me.btnPolice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.btnPolice.Location = New System.Drawing.Point(419, 22)
Me.btnPolice.Name = "btnPolice"
Me.btnPolice.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnPolice.Size = New System.Drawing.Size(88, 56)
Me.btnPolice.TabIndex = 14
Me.btnPolice.Text = "&Police"
Me.btnPolice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.btnPolice.UseVisualStyleBackColor = False
'
'btnEnrSous
'
Me.btnEnrSous.BackColor = System.Drawing.SystemColors.Control
Me.btnEnrSous.Cursor = System.Windows.Forms.Cursors.Default
Me.btnEnrSous.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnEnrSous.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnEnrSous.Image = CType(resources.GetObject("btnEnrSous.Image"), System.Drawing.Image)
Me.btnEnrSous.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.btnEnrSous.Location = New System.Drawing.Point(331, 94)
Me.btnEnrSous.Name = "btnEnrSous"
Me.btnEnrSous.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnEnrSous.Size = New System.Drawing.Size(88, 57)
Me.btnEnrSous.TabIndex = 16
Me.btnEnrSous.Text = "Enregistrer &sous"
Me.btnEnrSous.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.btnEnrSous.UseVisualStyleBackColor = False
'
'dlgEnregSous
'
Me.dlgEnregSous.FileName = "doc1"
'
'btnOuvrir
'
Me.btnOuvrir.BackColor = System.Drawing.SystemColors.Control
Me.btnOuvrir.Cursor = System.Windows.Forms.Cursors.Default
Me.btnOuvrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnOuvrir.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnOuvrir.Image = CType(resources.GetObject("btnOuvrir.Image"), System.Drawing.Image)
Me.btnOuvrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.btnOuvrir.Location = New System.Drawing.Point(419, 94)
Me.btnOuvrir.Name = "btnOuvrir"
Me.btnOuvrir.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnOuvrir.Size = New System.Drawing.Size(88, 57)
Me.btnOuvrir.TabIndex = 15
Me.btnOuvrir.Text = "&Ouvrir"
Me.btnOuvrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.btnOuvrir.UseVisualStyleBackColor = False
'
'frmBoitesDialogue
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(526, 420)
Me.Controls.Add(Me.btnapercu)
Me.Controls.Add(Me.rtfZoneTexte)
Me.Controls.Add(Me.btnMiseEnPage)
Me.Controls.Add(Me.btnImprimer)
Me.Controls.Add(Me.btnQuitter)
Me.Controls.Add(Me.btnCouleur)
Me.Controls.Add(Me.btnPolice)
Me.Controls.Add(Me.btnEnrSous)
Me.Controls.Add(Me.btnOuvrir)
Me.MaximizeBox = False
Me.Name = "frmBoitesDialogue"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "Les boîtes de dialogue de Windows"
Me.ResumeLayout(False)

End Sub
    Friend WithEvents dlgImprimer As System.Windows.Forms.PrintDialog
    Friend WithEvents btnapercu As System.Windows.Forms.Button
    Friend WithEvents rtfZoneTexte As System.Windows.Forms.RichTextBox
    Friend WithEvents prtDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnMiseEnPage As System.Windows.Forms.Button
    Friend WithEvents dlgApercu As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents dlgMiseEnPage As System.Windows.Forms.PageSetupDialog
    Friend WithEvents dlgOuvrir As System.Windows.Forms.OpenFileDialog
    Public WithEvents btnQuitter As System.Windows.Forms.Button
    Public WithEvents btnCouleur As System.Windows.Forms.Button
    Public WithEvents btnPolice As System.Windows.Forms.Button
    Public WithEvents btnEnrSous As System.Windows.Forms.Button
    Friend WithEvents dlgPolice As System.Windows.Forms.FontDialog
    Friend WithEvents dlgEnregSous As System.Windows.Forms.SaveFileDialog
    Public WithEvents btnOuvrir As System.Windows.Forms.Button
    Friend WithEvents dlgCouleur As System.Windows.Forms.ColorDialog
End Class
