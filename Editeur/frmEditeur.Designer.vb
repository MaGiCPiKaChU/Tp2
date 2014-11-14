<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditeur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditeur))
        Me.dlgOuvrir = New System.Windows.Forms.OpenFileDialog()
        Me.prtDocument = New System.Drawing.Printing.PrintDocument()
        Me.dlgImprimer = New System.Windows.Forms.PrintDialog()
        Me.dlgPolice = New System.Windows.Forms.FontDialog()
        Me.dlgEnregistrer = New System.Windows.Forms.SaveFileDialog()
        Me.msBarreMenu = New System.Windows.Forms.MenuStrip()
        Me.miFichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierOuvrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFichierEnregistrer = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierEnregSous = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFichierImprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFichierQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdition = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionRechercher = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionRechercherSuiv = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatRetourAutomatique = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatPolice = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRefaire = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnColler = New System.Windows.Forms.Button()
        Me.BtnCopier = New System.Windows.Forms.Button()
        Me.btnCouper = New System.Windows.Forms.Button()
        Me.btnZoomMax = New System.Windows.Forms.Button()
        Me.BtnZoomMin = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnOuvrir = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnRenvoiLigne = New System.Windows.Forms.Button()
        Me.rtfZoneTexte = New System.Windows.Forms.RichTextBox()
        Me.msBarreMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'msBarreMenu
        '
        Me.msBarreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFichier, Me.miEdition, Me.miFormat})
        Me.msBarreMenu.Location = New System.Drawing.Point(0, 0)
        Me.msBarreMenu.Name = "msBarreMenu"
        Me.msBarreMenu.Size = New System.Drawing.Size(919, 24)
        Me.msBarreMenu.TabIndex = 2
        Me.msBarreMenu.Text = "MenuStrip1"
        '
        'miFichier
        '
        Me.miFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFichierNouveau, Me.miFichierOuvrir, Me.ToolStripMenuItem1, Me.miFichierEnregistrer, Me.miFichierEnregSous, Me.ToolStripMenuItem2, Me.miFichierImprimer, Me.ToolStripMenuItem3, Me.miFichierQuitter})
        Me.miFichier.Name = "miFichier"
        Me.miFichier.Size = New System.Drawing.Size(54, 20)
        Me.miFichier.Text = "&Fichier"
        '
        'miFichierNouveau
        '
        Me.miFichierNouveau.Name = "miFichierNouveau"
        Me.miFichierNouveau.Size = New System.Drawing.Size(166, 22)
        Me.miFichierNouveau.Text = "&Nouveau"
        '
        'miFichierOuvrir
        '
        Me.miFichierOuvrir.Name = "miFichierOuvrir"
        Me.miFichierOuvrir.Size = New System.Drawing.Size(166, 22)
        Me.miFichierOuvrir.Text = "&Ouvrir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
        '
        'miFichierEnregistrer
        '
        Me.miFichierEnregistrer.Name = "miFichierEnregistrer"
        Me.miFichierEnregistrer.Size = New System.Drawing.Size(166, 22)
        Me.miFichierEnregistrer.Text = "&Enregistrer"
        '
        'miFichierEnregSous
        '
        Me.miFichierEnregSous.Name = "miFichierEnregSous"
        Me.miFichierEnregSous.Size = New System.Drawing.Size(166, 22)
        Me.miFichierEnregSous.Text = "En&registrer sous..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 6)
        '
        'miFichierImprimer
        '
        Me.miFichierImprimer.Enabled = False
        Me.miFichierImprimer.Name = "miFichierImprimer"
        Me.miFichierImprimer.Size = New System.Drawing.Size(166, 22)
        Me.miFichierImprimer.Text = "&Imprimer..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(163, 6)
        '
        'miFichierQuitter
        '
        Me.miFichierQuitter.Name = "miFichierQuitter"
        Me.miFichierQuitter.Size = New System.Drawing.Size(166, 22)
        Me.miFichierQuitter.Text = "&Quitter"
        '
        'miEdition
        '
        Me.miEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEditionRechercher, Me.miEditionRechercherSuiv})
        Me.miEdition.Name = "miEdition"
        Me.miEdition.Size = New System.Drawing.Size(56, 20)
        Me.miEdition.Text = "&Edition"
        '
        'miEditionRechercher
        '
        Me.miEditionRechercher.Name = "miEditionRechercher"
        Me.miEditionRechercher.Size = New System.Drawing.Size(186, 22)
        Me.miEditionRechercher.Text = "&Rechercher..."
        '
        'miEditionRechercherSuiv
        '
        Me.miEditionRechercherSuiv.Name = "miEditionRechercherSuiv"
        Me.miEditionRechercherSuiv.Size = New System.Drawing.Size(186, 22)
        Me.miEditionRechercherSuiv.Text = "Rechercher le suivant"
        '
        'miFormat
        '
        Me.miFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFormatRetourAutomatique, Me.miFormatPolice})
        Me.miFormat.Name = "miFormat"
        Me.miFormat.Size = New System.Drawing.Size(57, 20)
        Me.miFormat.Text = "F&ormat"
        '
        'miFormatRetourAutomatique
        '
        Me.miFormatRetourAutomatique.Name = "miFormatRetourAutomatique"
        Me.miFormatRetourAutomatique.Size = New System.Drawing.Size(230, 22)
        Me.miFormatRetourAutomatique.Text = "&Retour automatique à la ligne"
        '
        'miFormatPolice
        '
        Me.miFormatPolice.Name = "miFormatPolice"
        Me.miFormatPolice.Size = New System.Drawing.Size(230, 22)
        Me.miFormatPolice.Text = "&Police..."
        '
        'btnRefaire
        '
        Me.btnRefaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefaire.Image = CType(resources.GetObject("btnRefaire.Image"), System.Drawing.Image)
        Me.btnRefaire.Location = New System.Drawing.Point(457, 35)
        Me.btnRefaire.Name = "btnRefaire"
        Me.btnRefaire.Size = New System.Drawing.Size(31, 26)
        Me.btnRefaire.TabIndex = 28
        Me.btnRefaire.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Image = CType(resources.GetObject("btnAnnuler.Image"), System.Drawing.Image)
        Me.btnAnnuler.Location = New System.Drawing.Point(420, 35)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(31, 26)
        Me.btnAnnuler.TabIndex = 27
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnColler
        '
        Me.btnColler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColler.Image = CType(resources.GetObject("btnColler.Image"), System.Drawing.Image)
        Me.btnColler.Location = New System.Drawing.Point(346, 35)
        Me.btnColler.Name = "btnColler"
        Me.btnColler.Size = New System.Drawing.Size(31, 26)
        Me.btnColler.TabIndex = 26
        Me.btnColler.UseVisualStyleBackColor = True
        '
        'BtnCopier
        '
        Me.BtnCopier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopier.Image = CType(resources.GetObject("BtnCopier.Image"), System.Drawing.Image)
        Me.BtnCopier.Location = New System.Drawing.Point(309, 35)
        Me.BtnCopier.Name = "BtnCopier"
        Me.BtnCopier.Size = New System.Drawing.Size(31, 26)
        Me.BtnCopier.TabIndex = 25
        Me.BtnCopier.UseVisualStyleBackColor = True
        '
        'btnCouper
        '
        Me.btnCouper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCouper.Image = CType(resources.GetObject("btnCouper.Image"), System.Drawing.Image)
        Me.btnCouper.Location = New System.Drawing.Point(272, 35)
        Me.btnCouper.Name = "btnCouper"
        Me.btnCouper.Size = New System.Drawing.Size(31, 26)
        Me.btnCouper.TabIndex = 24
        Me.btnCouper.UseVisualStyleBackColor = True
        '
        'btnZoomMax
        '
        Me.btnZoomMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMax.Image = CType(resources.GetObject("btnZoomMax.Image"), System.Drawing.Image)
        Me.btnZoomMax.Location = New System.Drawing.Point(234, 35)
        Me.btnZoomMax.Name = "btnZoomMax"
        Me.btnZoomMax.Size = New System.Drawing.Size(31, 26)
        Me.btnZoomMax.TabIndex = 23
        Me.btnZoomMax.UseVisualStyleBackColor = True
        '
        'BtnZoomMin
        '
        Me.BtnZoomMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZoomMin.Image = CType(resources.GetObject("BtnZoomMin.Image"), System.Drawing.Image)
        Me.BtnZoomMin.Location = New System.Drawing.Point(197, 35)
        Me.BtnZoomMin.Name = "BtnZoomMin"
        Me.BtnZoomMin.Size = New System.Drawing.Size(31, 26)
        Me.BtnZoomMin.TabIndex = 22
        Me.BtnZoomMin.UseVisualStyleBackColor = True
        '
        'btnRechercher
        '
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Image = CType(resources.GetObject("btnRechercher.Image"), System.Drawing.Image)
        Me.btnRechercher.Location = New System.Drawing.Point(159, 35)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(31, 26)
        Me.btnRechercher.TabIndex = 21
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'btnImprimer
        '
        Me.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimer.Image = CType(resources.GetObject("btnImprimer.Image"), System.Drawing.Image)
        Me.btnImprimer.Location = New System.Drawing.Point(121, 35)
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(31, 26)
        Me.btnImprimer.TabIndex = 20
        Me.btnImprimer.UseVisualStyleBackColor = True
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Image = CType(resources.GetObject("btnEnregistrer.Image"), System.Drawing.Image)
        Me.btnEnregistrer.Location = New System.Drawing.Point(85, 35)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(31, 26)
        Me.btnEnregistrer.TabIndex = 19
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnOuvrir
        '
        Me.btnOuvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOuvrir.Image = CType(resources.GetObject("btnOuvrir.Image"), System.Drawing.Image)
        Me.btnOuvrir.Location = New System.Drawing.Point(48, 35)
        Me.btnOuvrir.Name = "btnOuvrir"
        Me.btnOuvrir.Size = New System.Drawing.Size(31, 26)
        Me.btnOuvrir.TabIndex = 18
        Me.btnOuvrir.UseVisualStyleBackColor = True
        '
        'btnNouveau
        '
        Me.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouveau.Image = CType(resources.GetObject("btnNouveau.Image"), System.Drawing.Image)
        Me.btnNouveau.Location = New System.Drawing.Point(10, 35)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(31, 26)
        Me.btnNouveau.TabIndex = 17
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'btnRenvoiLigne
        '
        Me.btnRenvoiLigne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenvoiLigne.Image = CType(resources.GetObject("btnRenvoiLigne.Image"), System.Drawing.Image)
        Me.btnRenvoiLigne.Location = New System.Drawing.Point(383, 35)
        Me.btnRenvoiLigne.Name = "btnRenvoiLigne"
        Me.btnRenvoiLigne.Size = New System.Drawing.Size(31, 26)
        Me.btnRenvoiLigne.TabIndex = 29
        Me.btnRenvoiLigne.UseVisualStyleBackColor = True
        '
        'rtfZoneTexte
        '
        Me.rtfZoneTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfZoneTexte.Location = New System.Drawing.Point(13, 68)
        Me.rtfZoneTexte.Name = "rtfZoneTexte"
        Me.rtfZoneTexte.Size = New System.Drawing.Size(894, 471)
        Me.rtfZoneTexte.TabIndex = 30
        Me.rtfZoneTexte.Text = ""
        Me.rtfZoneTexte.WordWrap = False
        '
        'frmEditeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 551)
        Me.Controls.Add(Me.rtfZoneTexte)
        Me.Controls.Add(Me.btnRenvoiLigne)
        Me.Controls.Add(Me.btnRefaire)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnColler)
        Me.Controls.Add(Me.BtnCopier)
        Me.Controls.Add(Me.btnCouper)
        Me.Controls.Add(Me.btnZoomMax)
        Me.Controls.Add(Me.BtnZoomMin)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnImprimer)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.btnOuvrir)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.msBarreMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msBarreMenu
        Me.Name = "frmEditeur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Éditeur de texte style Bloc-Notes"
        Me.msBarreMenu.ResumeLayout(False)
        Me.msBarreMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgOuvrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents prtDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents dlgImprimer As System.Windows.Forms.PrintDialog
    Friend WithEvents dlgPolice As System.Windows.Forms.FontDialog
    Friend WithEvents dlgEnregistrer As System.Windows.Forms.SaveFileDialog
    Friend WithEvents msBarreMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents miFichier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierNouveau As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierOuvrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miFichierEnregistrer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierEnregSous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miFichierImprimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miFichierQuitter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionRechercher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionRechercherSuiv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatPolice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatRetourAutomatique As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRefaire As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnColler As System.Windows.Forms.Button
    Friend WithEvents BtnCopier As System.Windows.Forms.Button
    Friend WithEvents btnCouper As System.Windows.Forms.Button
    Friend WithEvents btnZoomMax As System.Windows.Forms.Button
    Friend WithEvents BtnZoomMin As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnOuvrir As System.Windows.Forms.Button
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
    Friend WithEvents btnRenvoiLigne As System.Windows.Forms.Button
    Friend WithEvents rtfZoneTexte As System.Windows.Forms.RichTextBox
End Class
