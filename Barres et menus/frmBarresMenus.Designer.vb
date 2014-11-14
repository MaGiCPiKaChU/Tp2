<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarresMenus
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
Me.components = New System.ComponentModel.Container
Me.miCopier = New System.Windows.Forms.ToolStripMenuItem
Me.miColler = New System.Windows.Forms.ToolStripMenuItem
Me.miStyle = New System.Windows.Forms.ToolStripMenuItem
Me.miGras = New System.Windows.Forms.ToolStripMenuItem
Me.miItalique = New System.Windows.Forms.ToolStripMenuItem
Me.miRefaire = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
Me.miCouper = New System.Windows.Forms.ToolStripMenuItem
Me.ssTaille = New System.Windows.Forms.ToolStripStatusLabel
Me.ssDate = New System.Windows.Forms.ToolStripStatusLabel
Me.ssBarreEtat = New System.Windows.Forms.StatusStrip
Me.cmCopier = New System.Windows.Forms.ToolStripMenuItem
Me.cmColler = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
Me.rtfTexte = New System.Windows.Forms.RichTextBox
Me.cmMenuContextuel = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.cmCouper = New System.Windows.Forms.ToolStripMenuItem
Me.cmGras = New System.Windows.Forms.ToolStripMenuItem
Me.cmItalique = New System.Windows.Forms.ToolStripMenuItem
Me.msBarreMenu = New System.Windows.Forms.MenuStrip
Me.miEdition = New System.Windows.Forms.ToolStripMenuItem
Me.miAnnuler = New System.Windows.Forms.ToolStripMenuItem
Me.tsBarreOutils = New System.Windows.Forms.ToolStrip
Me.tsbCouper = New System.Windows.Forms.ToolStripButton
Me.tsbCopier = New System.Windows.Forms.ToolStripButton
Me.tsbColler = New System.Windows.Forms.ToolStripButton
Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
Me.tsbGras = New System.Windows.Forms.ToolStripButton
Me.tsbItalique = New System.Windows.Forms.ToolStripButton
Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
Me.ssBarreEtat.SuspendLayout()
Me.cmMenuContextuel.SuspendLayout()
Me.msBarreMenu.SuspendLayout()
Me.tsBarreOutils.SuspendLayout()
Me.SuspendLayout()
'
'miCopier
'
Me.miCopier.Name = "miCopier"
Me.miCopier.Size = New System.Drawing.Size(133, 22)
Me.miCopier.Text = "Co&pier"
'
'miColler
'
Me.miColler.Name = "miColler"
Me.miColler.Size = New System.Drawing.Size(133, 22)
Me.miColler.Text = "C&oller"
'
'miStyle
'
Me.miStyle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miGras, Me.miItalique})
Me.miStyle.Name = "miStyle"
Me.miStyle.Size = New System.Drawing.Size(48, 20)
Me.miStyle.Text = "&Style"
'
'miGras
'
Me.miGras.Name = "miGras"
Me.miGras.Size = New System.Drawing.Size(131, 22)
Me.miGras.Text = "&Gras"
'
'miItalique
'
Me.miItalique.Name = "miItalique"
Me.miItalique.Size = New System.Drawing.Size(131, 22)
Me.miItalique.Text = "&Italique"
'
'miRefaire
'
Me.miRefaire.Name = "miRefaire"
Me.miRefaire.Size = New System.Drawing.Size(133, 22)
Me.miRefaire.Text = "&Refaire"
'
'ToolStripMenuItem1
'
Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 6)
'
'miCouper
'
Me.miCouper.Name = "miCouper"
Me.miCouper.Size = New System.Drawing.Size(133, 22)
Me.miCouper.Text = "&Couper"
'
'ssTaille
'
Me.ssTaille.AutoSize = False
Me.ssTaille.Name = "ssTaille"
Me.ssTaille.Size = New System.Drawing.Size(250, 17)
Me.ssTaille.Text = "Taille : 0 octet"
'
'ssDate
'
Me.ssDate.Name = "ssDate"
Me.ssDate.Size = New System.Drawing.Size(103, 17)
Me.ssDate.Text = "Date du système"
'
'ssBarreEtat
'
Me.ssBarreEtat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssTaille, Me.ssDate})
Me.ssBarreEtat.Location = New System.Drawing.Point(0, 248)
Me.ssBarreEtat.Name = "ssBarreEtat"
Me.ssBarreEtat.Size = New System.Drawing.Size(422, 22)
Me.ssBarreEtat.TabIndex = 7
Me.ssBarreEtat.Text = "StatusStrip1"
'
'cmCopier
'
Me.cmCopier.Name = "cmCopier"
Me.cmCopier.Size = New System.Drawing.Size(131, 22)
Me.cmCopier.Text = "Copier"
'
'cmColler
'
Me.cmColler.Name = "cmColler"
Me.cmColler.Size = New System.Drawing.Size(131, 22)
Me.cmColler.Text = "Coller"
'
'ToolStripMenuItem2
'
Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
Me.ToolStripMenuItem2.Size = New System.Drawing.Size(128, 6)
'
'rtfTexte
'
Me.rtfTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.rtfTexte.ContextMenuStrip = Me.cmMenuContextuel
Me.rtfTexte.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.rtfTexte.Location = New System.Drawing.Point(-1, 45)
Me.rtfTexte.Name = "rtfTexte"
Me.rtfTexte.Size = New System.Drawing.Size(424, 203)
Me.rtfTexte.TabIndex = 5
Me.rtfTexte.Text = ""
'
'cmMenuContextuel
'
Me.cmMenuContextuel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmCouper, Me.cmCopier, Me.cmColler, Me.ToolStripMenuItem2, Me.cmGras, Me.cmItalique})
Me.cmMenuContextuel.Name = "cmMenuContextuel"
Me.cmMenuContextuel.Size = New System.Drawing.Size(132, 120)
'
'cmCouper
'
Me.cmCouper.Name = "cmCouper"
Me.cmCouper.Size = New System.Drawing.Size(131, 22)
Me.cmCouper.Text = "Couper"
'
'cmGras
'
Me.cmGras.Name = "cmGras"
Me.cmGras.Size = New System.Drawing.Size(131, 22)
Me.cmGras.Text = "Gras"
'
'cmItalique
'
Me.cmItalique.Name = "cmItalique"
Me.cmItalique.Size = New System.Drawing.Size(131, 22)
Me.cmItalique.Text = "Italique"
'
'msBarreMenu
'
Me.msBarreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEdition, Me.miStyle})
Me.msBarreMenu.Location = New System.Drawing.Point(0, 0)
Me.msBarreMenu.Name = "msBarreMenu"
Me.msBarreMenu.Size = New System.Drawing.Size(422, 24)
Me.msBarreMenu.TabIndex = 6
Me.msBarreMenu.Text = "MenuStrip1"
'
'miEdition
'
Me.miEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAnnuler, Me.miRefaire, Me.ToolStripMenuItem1, Me.miCouper, Me.miCopier, Me.miColler})
Me.miEdition.Name = "miEdition"
Me.miEdition.Size = New System.Drawing.Size(58, 20)
Me.miEdition.Text = "&Edition"
'
'miAnnuler
'
Me.miAnnuler.Name = "miAnnuler"
Me.miAnnuler.Size = New System.Drawing.Size(133, 22)
Me.miAnnuler.Text = "&Annuler"
'
'tsBarreOutils
'
Me.tsBarreOutils.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCouper, Me.tsbCopier, Me.tsbColler, Me.ToolStripSeparator1, Me.tsbGras, Me.tsbItalique, Me.ToolStripSeparator2})
Me.tsBarreOutils.Location = New System.Drawing.Point(0, 24)
Me.tsBarreOutils.Name = "tsBarreOutils"
Me.tsBarreOutils.Size = New System.Drawing.Size(422, 25)
Me.tsBarreOutils.TabIndex = 8
Me.tsBarreOutils.Text = "ToolStrip1"
'
'tsbCouper
'
Me.tsbCouper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.tsbCouper.Image = Global.Automne2007.My.Resources.Resources.CutHS
Me.tsbCouper.ImageTransparentColor = System.Drawing.Color.Magenta
Me.tsbCouper.Name = "tsbCouper"
Me.tsbCouper.Size = New System.Drawing.Size(23, 22)
Me.tsbCouper.Text = "ToolStripButton1"
Me.tsbCouper.ToolTipText = "Couper"
'
'tsbCopier
'
Me.tsbCopier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.tsbCopier.Image = Global.Automne2007.My.Resources.Resources.CopyHS
Me.tsbCopier.ImageTransparentColor = System.Drawing.Color.Magenta
Me.tsbCopier.Name = "tsbCopier"
Me.tsbCopier.Size = New System.Drawing.Size(23, 22)
Me.tsbCopier.Text = "ToolStripButton2"
Me.tsbCopier.ToolTipText = "Copier"
'
'tsbColler
'
Me.tsbColler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.tsbColler.Image = Global.Automne2007.My.Resources.Resources.PasteHS
Me.tsbColler.ImageTransparentColor = System.Drawing.Color.Magenta
Me.tsbColler.Name = "tsbColler"
Me.tsbColler.Size = New System.Drawing.Size(23, 22)
Me.tsbColler.Text = "ToolStripButton3"
Me.tsbColler.ToolTipText = "Coller"
'
'ToolStripSeparator1
'
Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
'
'tsbGras
'
Me.tsbGras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.tsbGras.Image = Global.Automne2007.My.Resources.Resources.boldhs
Me.tsbGras.ImageTransparentColor = System.Drawing.Color.Magenta
Me.tsbGras.Name = "tsbGras"
Me.tsbGras.Size = New System.Drawing.Size(23, 22)
Me.tsbGras.Text = "Gras"
'
'tsbItalique
'
Me.tsbItalique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.tsbItalique.Image = Global.Automne2007.My.Resources.Resources.ItalicHS
Me.tsbItalique.ImageTransparentColor = System.Drawing.Color.Magenta
Me.tsbItalique.Name = "tsbItalique"
Me.tsbItalique.Size = New System.Drawing.Size(23, 22)
Me.tsbItalique.Text = "ToolStripButton1"
Me.tsbItalique.ToolTipText = "Italique"
'
'ToolStripSeparator2
'
Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
'
'frmBarresMenus
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(422, 270)
Me.Controls.Add(Me.tsBarreOutils)
Me.Controls.Add(Me.ssBarreEtat)
Me.Controls.Add(Me.rtfTexte)
Me.Controls.Add(Me.msBarreMenu)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
Me.MainMenuStrip = Me.msBarreMenu
Me.Name = "frmBarresMenus"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "Barre d'outils et barre d'état"
Me.ssBarreEtat.ResumeLayout(False)
Me.ssBarreEtat.PerformLayout()
Me.cmMenuContextuel.ResumeLayout(False)
Me.msBarreMenu.ResumeLayout(False)
Me.msBarreMenu.PerformLayout()
Me.tsBarreOutils.ResumeLayout(False)
Me.tsBarreOutils.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents miCopier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miColler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miStyle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miGras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miItalique As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miRefaire As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miCouper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssTaille As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssBarreEtat As System.Windows.Forms.StatusStrip
    Friend WithEvents cmCopier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmColler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents rtfTexte As System.Windows.Forms.RichTextBox
    Friend WithEvents cmMenuContextuel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmCouper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmGras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmItalique As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msBarreMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents miEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAnnuler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBarreOutils As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCouper As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCopier As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbColler As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGras As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbItalique As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
