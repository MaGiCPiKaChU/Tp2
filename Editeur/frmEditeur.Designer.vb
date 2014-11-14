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
Me.dlgOuvrir = New System.Windows.Forms.OpenFileDialog()
Me.prtDocument = New System.Drawing.Printing.PrintDocument()
Me.dlgImprimer = New System.Windows.Forms.PrintDialog()
Me.txtTexte = New System.Windows.Forms.TextBox()
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
Me.msBarreMenu.SuspendLayout()
Me.SuspendLayout()
'
'txtTexte
'
Me.txtTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.txtTexte.Location = New System.Drawing.Point(0, 26)
Me.txtTexte.Multiline = True
Me.txtTexte.Name = "txtTexte"
Me.txtTexte.ScrollBars = System.Windows.Forms.ScrollBars.Both
Me.txtTexte.Size = New System.Drawing.Size(501, 230)
Me.txtTexte.TabIndex = 1
Me.txtTexte.WordWrap = False
'
'msBarreMenu
'
Me.msBarreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFichier, Me.miEdition, Me.miFormat})
Me.msBarreMenu.Location = New System.Drawing.Point(0, 0)
Me.msBarreMenu.Name = "msBarreMenu"
Me.msBarreMenu.Size = New System.Drawing.Size(498, 24)
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
'frmEditeur
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(498, 256)
Me.Controls.Add(Me.txtTexte)
Me.Controls.Add(Me.msBarreMenu)
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
    Friend WithEvents txtTexte As System.Windows.Forms.TextBox
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
End Class
