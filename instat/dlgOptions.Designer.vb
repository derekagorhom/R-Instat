﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Languages")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comments")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Output Window")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Commands")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Data View")
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdLanguage = New System.Windows.Forms.Button()
        Me.spltControls = New System.Windows.Forms.SplitContainer()
        Me.cmdFactoryReset = New System.Windows.Forms.Button()
        Me.trOptions = New System.Windows.Forms.TreeView()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpLanguages = New System.Windows.Forms.TabPage()
        Me.lversion = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.ucrInputLanguage = New instat.ucrInputComboBox()
        Me.tbpComments = New System.Windows.Forms.TabPage()
        Me.pnComments = New System.Windows.Forms.Panel()
        Me.ucrInputComment = New instat.ucrInputTextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbpImport = New System.Windows.Forms.TabPage()
        Me.lblPreviewRows = New System.Windows.Forms.Label()
        Me.ucrNudPreviewRows = New instat.ucrNud()
        Me.pnImportData = New System.Windows.Forms.Panel()
        Me.tbpOutputWindow = New System.Windows.Forms.TabPage()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrNudMaxOutputsHeight = New instat.ucrNud()
        Me.ucrChkMaxOutputsHeight = New instat.ucrCheck()
        Me.ucrChkShowRCommandsinOutputWindow = New instat.ucrCheck()
        Me.ucrChkIncludeCommentsbyDefault = New instat.ucrCheck()
        Me.grpROptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkShowSignifStars = New instat.ucrCheck()
        Me.ucrNudDigits = New instat.ucrNud()
        Me.lblNoDigits = New System.Windows.Forms.Label()
        Me.pnFormatOptions = New System.Windows.Forms.Panel()
        Me.rtbCommentPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbOutputPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbCommandPreview = New System.Windows.Forms.RichTextBox()
        Me.cmdCommandFormat = New System.Windows.Forms.Button()
        Me.lblCommentFormat = New System.Windows.Forms.Label()
        Me.cmdOutputFormat = New System.Windows.Forms.Button()
        Me.lblOutputFormat = New System.Windows.Forms.Label()
        Me.cmdCommentFormat = New System.Windows.Forms.Button()
        Me.lblCommandFormat = New System.Windows.Forms.Label()
        Me.tbpEditor = New System.Windows.Forms.TabPage()
        Me.pnFormatEditor = New System.Windows.Forms.Panel()
        Me.cmdEditorFont = New System.Windows.Forms.Button()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.tbpCommands = New System.Windows.Forms.TabPage()
        Me.lblWaitSeconds = New System.Windows.Forms.Label()
        Me.ucrChkShowWaitDialog = New instat.ucrCheck()
        Me.ucrNudWaitSeconds = New instat.ucrNud()
        Me.ucrChkIncludeDefaultParams = New instat.ucrCheck()
        Me.tbpDataView = New System.Windows.Forms.TabPage()
        Me.ucrChkTurnOffUndo = New instat.ucrCheck()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ucrNudRowUndoLimit = New instat.ucrNud()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrNudColUndoLimit = New instat.ucrNud()
        Me.lblEvery = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.ucrChkAutoSave = New instat.ucrCheck()
        Me.ucrChkShowDataonGrid = New instat.ucrCheck()
        Me.ucrNudAutoSaveMinutes = New instat.ucrNud()
        Me.ucrNudMaxCols = New instat.ucrNud()
        Me.lblMaxCols = New System.Windows.Forms.Label()
        Me.ucrNudMaxRows = New instat.ucrNud()
        Me.lblMaxRows = New System.Windows.Forms.Label()
        Me.tbpWorkingDirectory = New System.Windows.Forms.TabPage()
        Me.cmdWorkingDirectory = New System.Windows.Forms.Button()
        Me.lblWorkingDirectory = New System.Windows.Forms.Label()
        Me.ucrWorkingDirectory = New instat.ucrInputTextBox()
        Me.tbpGraphDisplay = New System.Windows.Forms.TabPage()
        Me.rdoDisplayinSeparateWindows = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayinRViewer = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayinOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphDisplay = New instat.UcrPanel()
        Me.tbpTailoredMenus = New System.Windows.Forms.TabPage()
        Me.ucrChkViewTricotMenu = New instat.ucrCheck()
        Me.ucrChkViewStructuredMenu = New instat.ucrCheck()
        Me.ucrChkViewOptionsByContextMenu = New instat.ucrCheck()
        Me.ucrChkViewProcurementMenu = New instat.ucrCheck()
        Me.ucrChkViewClimaticMenu = New instat.ucrCheck()
        Me.tbpClimsoft = New System.Windows.Forms.TabPage()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.ucrInputUserName = New instat.ucrInputTextBox()
        Me.ucrInputPort = New instat.ucrInputTextBox()
        Me.ucrInputHost = New instat.ucrInputTextBox()
        Me.ucrInputDatabaseName = New instat.ucrInputTextBox()
        Me.tbpWebsite = New System.Windows.Forms.TabPage()
        Me.ucrChkReminder = New instat.ucrCheck()
        Me.ucrChkViewTricotXpMenu = New instat.ucrCheck()
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltControls.Panel1.SuspendLayout()
        Me.spltControls.Panel2.SuspendLayout()
        Me.spltControls.SuspendLayout()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguages.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.pnComments.SuspendLayout()
        Me.tbpImport.SuspendLayout()
        Me.tbpOutputWindow.SuspendLayout()
        Me.grpROptions.SuspendLayout()
        Me.pnFormatOptions.SuspendLayout()
        Me.tbpEditor.SuspendLayout()
        Me.pnFormatEditor.SuspendLayout()
        Me.tbpCommands.SuspendLayout()
        Me.tbpDataView.SuspendLayout()
        Me.tbpWorkingDirectory.SuspendLayout()
        Me.tbpGraphDisplay.SuspendLayout()
        Me.tbpTailoredMenus.SuspendLayout()
        Me.tbpClimsoft.SuspendLayout()
        Me.tbpWebsite.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(384, 324)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 10
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(465, 324)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 12
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(303, 324)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(222, 324)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdLanguage
        '
        Me.cmdLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLanguage.Location = New System.Drawing.Point(545, 324)
        Me.cmdLanguage.Name = "cmdLanguage"
        Me.cmdLanguage.Size = New System.Drawing.Size(37, 23)
        Me.cmdLanguage.TabIndex = 13
        Me.cmdLanguage.Tag = ""
        Me.cmdLanguage.Text = "Lang"
        Me.cmdLanguage.UseVisualStyleBackColor = True
        '
        'spltControls
        '
        Me.spltControls.Location = New System.Drawing.Point(5, 1)
        Me.spltControls.Name = "spltControls"
        '
        'spltControls.Panel1
        '
        Me.spltControls.Panel1.Controls.Add(Me.cmdFactoryReset)
        Me.spltControls.Panel1.Controls.Add(Me.trOptions)
        '
        'spltControls.Panel2
        '
        Me.spltControls.Panel2.Controls.Add(Me.tbcOptions)
        Me.spltControls.Size = New System.Drawing.Size(760, 317)
        Me.spltControls.SplitterDistance = 184
        Me.spltControls.TabIndex = 8
        '
        'cmdFactoryReset
        '
        Me.cmdFactoryReset.Location = New System.Drawing.Point(13, 287)
        Me.cmdFactoryReset.Name = "cmdFactoryReset"
        Me.cmdFactoryReset.Size = New System.Drawing.Size(100, 23)
        Me.cmdFactoryReset.TabIndex = 13
        Me.cmdFactoryReset.Tag = "Help"
        Me.cmdFactoryReset.Text = "Factory Reset"
        Me.cmdFactoryReset.UseVisualStyleBackColor = True
        '
        'trOptions
        '
        Me.trOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trOptions.Location = New System.Drawing.Point(0, 0)
        Me.trOptions.Name = "trOptions"
        TreeNode13.Name = "ndLanguages"
        TreeNode13.Tag = "1"
        TreeNode13.Text = "Languages"
        TreeNode13.ToolTipText = "Choose different languages"
        TreeNode14.Name = "ndComments"
        TreeNode14.Tag = "2"
        TreeNode14.Text = "Comments"
        TreeNode14.ToolTipText = "Comments for the dialogs"
        TreeNode15.Name = "ndImport"
        TreeNode15.Tag = "3"
        TreeNode15.Text = "Import"
        TreeNode15.ToolTipText = "Import Data Settings"
        TreeNode16.Name = "ndOutputWindow"
        TreeNode16.Tag = "4"
        TreeNode16.Text = "Output Window"
        TreeNode16.ToolTipText = "Output Window Formatting Options"
        TreeNode17.Name = "ndCommands"
        TreeNode17.Tag = "8"
        TreeNode17.Text = "Commands"
        TreeNode17.ToolTipText = "Commands Options"
        TreeNode18.Name = "ndDataView"
        TreeNode18.Text = "Data View"
        Me.trOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Me.trOptions.Size = New System.Drawing.Size(184, 317)
        Me.trOptions.TabIndex = 0
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguages)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpImport)
        Me.tbcOptions.Controls.Add(Me.tbpOutputWindow)
        Me.tbcOptions.Controls.Add(Me.tbpEditor)
        Me.tbcOptions.Controls.Add(Me.tbpCommands)
        Me.tbcOptions.Controls.Add(Me.tbpDataView)
        Me.tbcOptions.Controls.Add(Me.tbpWorkingDirectory)
        Me.tbcOptions.Controls.Add(Me.tbpGraphDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpTailoredMenus)
        Me.tbcOptions.Controls.Add(Me.tbpClimsoft)
        Me.tbcOptions.Controls.Add(Me.tbpWebsite)
        Me.tbcOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(572, 317)
        Me.tbcOptions.TabIndex = 0
        '
        'tbpLanguages
        '
        Me.tbpLanguages.Controls.Add(Me.lversion)
        Me.tbpLanguages.Controls.Add(Me.lblLanguage)
        Me.tbpLanguages.Controls.Add(Me.ucrInputLanguage)
        Me.tbpLanguages.Location = New System.Drawing.Point(4, 22)
        Me.tbpLanguages.Name = "tbpLanguages"
        Me.tbpLanguages.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpLanguages.Size = New System.Drawing.Size(564, 291)
        Me.tbpLanguages.TabIndex = 0
        Me.tbpLanguages.Tag = "Languages"
        Me.tbpLanguages.Text = "Languages"
        Me.tbpLanguages.UseVisualStyleBackColor = True
        '
        'lversion
        '
        Me.lversion.Location = New System.Drawing.Point(306, 267)
        Me.lversion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lversion.Name = "lversion"
        Me.lversion.Size = New System.Drawing.Size(254, 18)
        Me.lversion.TabIndex = 4
        Me.lversion.Text = "v. "
        Me.lversion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(9, 18)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(61, 13)
        Me.lblLanguage.TabIndex = 3
        Me.lblLanguage.Text = "Language :"
        '
        'ucrInputLanguage
        '
        Me.ucrInputLanguage.AddQuotesIfUnrecognised = True
        Me.ucrInputLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLanguage.GetSetSelectedIndex = -1
        Me.ucrInputLanguage.IsReadOnly = False
        Me.ucrInputLanguage.Location = New System.Drawing.Point(75, 15)
        Me.ucrInputLanguage.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputLanguage.Name = "ucrInputLanguage"
        Me.ucrInputLanguage.Size = New System.Drawing.Size(110, 21)
        Me.ucrInputLanguage.TabIndex = 2
        '
        'tbpComments
        '
        Me.tbpComments.Controls.Add(Me.pnComments)
        Me.tbpComments.Location = New System.Drawing.Point(4, 22)
        Me.tbpComments.Name = "tbpComments"
        Me.tbpComments.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpComments.Size = New System.Drawing.Size(564, 291)
        Me.tbpComments.TabIndex = 1
        Me.tbpComments.Tag = "Comments"
        Me.tbpComments.Text = "Comments"
        Me.tbpComments.UseVisualStyleBackColor = True
        '
        'pnComments
        '
        Me.pnComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnComments.Controls.Add(Me.ucrInputComment)
        Me.pnComments.Controls.Add(Me.lblComment)
        Me.pnComments.Location = New System.Drawing.Point(10, 10)
        Me.pnComments.Name = "pnComments"
        Me.pnComments.Size = New System.Drawing.Size(391, 29)
        Me.pnComments.TabIndex = 2
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.AutoSize = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        Me.ucrInputComment.Location = New System.Drawing.Point(96, 5)
        Me.ucrInputComment.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(292, 21)
        Me.ucrInputComment.TabIndex = 1
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(2, 9)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(54, 13)
        Me.lblComment.TabIndex = 0
        Me.lblComment.Tag = "Comment:"
        Me.lblComment.Text = "Comment:"
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.lblPreviewRows)
        Me.tbpImport.Controls.Add(Me.ucrNudPreviewRows)
        Me.tbpImport.Controls.Add(Me.pnImportData)
        Me.tbpImport.Location = New System.Drawing.Point(4, 22)
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.Size = New System.Drawing.Size(564, 291)
        Me.tbpImport.TabIndex = 3
        Me.tbpImport.Text = "Import"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'lblPreviewRows
        '
        Me.lblPreviewRows.AutoSize = True
        Me.lblPreviewRows.Location = New System.Drawing.Point(3, 9)
        Me.lblPreviewRows.Name = "lblPreviewRows"
        Me.lblPreviewRows.Size = New System.Drawing.Size(130, 13)
        Me.lblPreviewRows.TabIndex = 0
        Me.lblPreviewRows.Text = "Number of Preview Rows:"
        '
        'ucrNudPreviewRows
        '
        Me.ucrNudPreviewRows.AutoSize = True
        Me.ucrNudPreviewRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewRows.Location = New System.Drawing.Point(270, 5)
        Me.ucrNudPreviewRows.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudPreviewRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Name = "ucrNudPreviewRows"
        Me.ucrNudPreviewRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewRows.TabIndex = 3
        Me.ucrNudPreviewRows.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'pnImportData
        '
        Me.pnImportData.AutoSize = True
        Me.pnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnImportData.Location = New System.Drawing.Point(10, 10)
        Me.pnImportData.Name = "pnImportData"
        Me.pnImportData.Size = New System.Drawing.Size(0, 0)
        Me.pnImportData.TabIndex = 2
        '
        'tbpOutputWindow
        '
        Me.tbpOutputWindow.Controls.Add(Me.lblWidth)
        Me.tbpOutputWindow.Controls.Add(Me.ucrNudWidth)
        Me.tbpOutputWindow.Controls.Add(Me.ucrNudMaxOutputsHeight)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkMaxOutputsHeight)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkShowRCommandsinOutputWindow)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkIncludeCommentsbyDefault)
        Me.tbpOutputWindow.Controls.Add(Me.grpROptions)
        Me.tbpOutputWindow.Controls.Add(Me.pnFormatOptions)
        Me.tbpOutputWindow.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutputWindow.Name = "tbpOutputWindow"
        Me.tbpOutputWindow.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpOutputWindow.Size = New System.Drawing.Size(564, 291)
        Me.tbpOutputWindow.TabIndex = 2
        Me.tbpOutputWindow.Text = "Output Window"
        Me.tbpOutputWindow.UseVisualStyleBackColor = True
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(362, 187)
        Me.lblWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(87, 13)
        Me.lblWidth.TabIndex = 31
        Me.lblWidth.Text = "Width to Display:"
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.AutoSize = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(506, 185)
        Me.ucrNudWidth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 30
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxOutputsHeight
        '
        Me.ucrNudMaxOutputsHeight.AutoSize = True
        Me.ucrNudMaxOutputsHeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxOutputsHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxOutputsHeight.Location = New System.Drawing.Point(506, 135)
        Me.ucrNudMaxOutputsHeight.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudMaxOutputsHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxOutputsHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxOutputsHeight.Name = "ucrNudMaxOutputsHeight"
        Me.ucrNudMaxOutputsHeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxOutputsHeight.TabIndex = 29
        Me.ucrNudMaxOutputsHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxOutputsHeight
        '
        Me.ucrChkMaxOutputsHeight.AutoSize = True
        Me.ucrChkMaxOutputsHeight.Checked = False
        Me.ucrChkMaxOutputsHeight.Location = New System.Drawing.Point(300, 135)
        Me.ucrChkMaxOutputsHeight.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkMaxOutputsHeight.Name = "ucrChkMaxOutputsHeight"
        Me.ucrChkMaxOutputsHeight.Size = New System.Drawing.Size(196, 34)
        Me.ucrChkMaxOutputsHeight.TabIndex = 28
        '
        'ucrChkShowRCommandsinOutputWindow
        '
        Me.ucrChkShowRCommandsinOutputWindow.AutoSize = True
        Me.ucrChkShowRCommandsinOutputWindow.Checked = False
        Me.ucrChkShowRCommandsinOutputWindow.Location = New System.Drawing.Point(10, 160)
        Me.ucrChkShowRCommandsinOutputWindow.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkShowRCommandsinOutputWindow.Name = "ucrChkShowRCommandsinOutputWindow"
        Me.ucrChkShowRCommandsinOutputWindow.Size = New System.Drawing.Size(271, 34)
        Me.ucrChkShowRCommandsinOutputWindow.TabIndex = 27
        '
        'ucrChkIncludeCommentsbyDefault
        '
        Me.ucrChkIncludeCommentsbyDefault.AutoSize = True
        Me.ucrChkIncludeCommentsbyDefault.Checked = False
        Me.ucrChkIncludeCommentsbyDefault.Location = New System.Drawing.Point(10, 135)
        Me.ucrChkIncludeCommentsbyDefault.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkIncludeCommentsbyDefault.Name = "ucrChkIncludeCommentsbyDefault"
        Me.ucrChkIncludeCommentsbyDefault.Size = New System.Drawing.Size(271, 34)
        Me.ucrChkIncludeCommentsbyDefault.TabIndex = 26
        '
        'grpROptions
        '
        Me.grpROptions.Controls.Add(Me.ucrChkShowSignifStars)
        Me.grpROptions.Controls.Add(Me.ucrNudDigits)
        Me.grpROptions.Controls.Add(Me.lblNoDigits)
        Me.grpROptions.Location = New System.Drawing.Point(10, 192)
        Me.grpROptions.Name = "grpROptions"
        Me.grpROptions.Size = New System.Drawing.Size(271, 93)
        Me.grpROptions.TabIndex = 25
        Me.grpROptions.TabStop = False
        Me.grpROptions.Text = "R Options"
        '
        'ucrChkShowSignifStars
        '
        Me.ucrChkShowSignifStars.AutoSize = True
        Me.ucrChkShowSignifStars.Checked = False
        Me.ucrChkShowSignifStars.Location = New System.Drawing.Point(7, 49)
        Me.ucrChkShowSignifStars.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkShowSignifStars.Name = "ucrChkShowSignifStars"
        Me.ucrChkShowSignifStars.Size = New System.Drawing.Size(255, 34)
        Me.ucrChkShowSignifStars.TabIndex = 28
        '
        'ucrNudDigits
        '
        Me.ucrNudDigits.AutoSize = True
        Me.ucrNudDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDigits.Location = New System.Drawing.Point(177, 23)
        Me.ucrNudDigits.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Name = "ucrNudDigits"
        Me.ucrNudDigits.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDigits.TabIndex = 27
        Me.ucrNudDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNoDigits
        '
        Me.lblNoDigits.AutoSize = True
        Me.lblNoDigits.Location = New System.Drawing.Point(6, 23)
        Me.lblNoDigits.Name = "lblNoDigits"
        Me.lblNoDigits.Size = New System.Drawing.Size(137, 13)
        Me.lblNoDigits.TabIndex = 1
        Me.lblNoDigits.Text = "Number of Digits to Display:"
        '
        'pnFormatOptions
        '
        Me.pnFormatOptions.AutoSize = True
        Me.pnFormatOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatOptions.Controls.Add(Me.rtbCommentPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbOutputPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbCommandPreview)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommandFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommandFormat)
        Me.pnFormatOptions.Location = New System.Drawing.Point(10, 10)
        Me.pnFormatOptions.Name = "pnFormatOptions"
        Me.pnFormatOptions.Size = New System.Drawing.Size(391, 118)
        Me.pnFormatOptions.TabIndex = 21
        '
        'rtbCommentPreview
        '
        Me.rtbCommentPreview.Location = New System.Drawing.Point(124, 89)
        Me.rtbCommentPreview.Name = "rtbCommentPreview"
        Me.rtbCommentPreview.ReadOnly = True
        Me.rtbCommentPreview.Size = New System.Drawing.Size(147, 26)
        Me.rtbCommentPreview.TabIndex = 22
        Me.rtbCommentPreview.Text = ""
        '
        'rtbOutputPreview
        '
        Me.rtbOutputPreview.Location = New System.Drawing.Point(124, 49)
        Me.rtbOutputPreview.Name = "rtbOutputPreview"
        Me.rtbOutputPreview.ReadOnly = True
        Me.rtbOutputPreview.Size = New System.Drawing.Size(147, 26)
        Me.rtbOutputPreview.TabIndex = 21
        Me.rtbOutputPreview.Text = ""
        '
        'rtbCommandPreview
        '
        Me.rtbCommandPreview.Location = New System.Drawing.Point(124, 9)
        Me.rtbCommandPreview.Name = "rtbCommandPreview"
        Me.rtbCommandPreview.ReadOnly = True
        Me.rtbCommandPreview.Size = New System.Drawing.Size(147, 26)
        Me.rtbCommandPreview.TabIndex = 20
        Me.rtbCommandPreview.Text = ""
        '
        'cmdCommandFormat
        '
        Me.cmdCommandFormat.Location = New System.Drawing.Point(288, 9)
        Me.cmdCommandFormat.Name = "cmdCommandFormat"
        Me.cmdCommandFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommandFormat.TabIndex = 10
        Me.cmdCommandFormat.Text = "Change..."
        Me.cmdCommandFormat.UseVisualStyleBackColor = True
        '
        'lblCommentFormat
        '
        Me.lblCommentFormat.AutoSize = True
        Me.lblCommentFormat.Location = New System.Drawing.Point(4, 94)
        Me.lblCommentFormat.Name = "lblCommentFormat"
        Me.lblCommentFormat.Size = New System.Drawing.Size(89, 13)
        Me.lblCommentFormat.TabIndex = 19
        Me.lblCommentFormat.Text = "Comment Format:"
        '
        'cmdOutputFormat
        '
        Me.cmdOutputFormat.Location = New System.Drawing.Point(288, 49)
        Me.cmdOutputFormat.Name = "cmdOutputFormat"
        Me.cmdOutputFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutputFormat.TabIndex = 16
        Me.cmdOutputFormat.Text = "Change..."
        Me.cmdOutputFormat.UseVisualStyleBackColor = True
        '
        'lblOutputFormat
        '
        Me.lblOutputFormat.AutoSize = True
        Me.lblOutputFormat.Location = New System.Drawing.Point(4, 54)
        Me.lblOutputFormat.Name = "lblOutputFormat"
        Me.lblOutputFormat.Size = New System.Drawing.Size(77, 13)
        Me.lblOutputFormat.TabIndex = 18
        Me.lblOutputFormat.Text = "Output Format:"
        '
        'cmdCommentFormat
        '
        Me.cmdCommentFormat.Location = New System.Drawing.Point(288, 89)
        Me.cmdCommentFormat.Name = "cmdCommentFormat"
        Me.cmdCommentFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommentFormat.TabIndex = 16
        Me.cmdCommentFormat.Text = "Change..."
        Me.cmdCommentFormat.UseVisualStyleBackColor = True
        '
        'lblCommandFormat
        '
        Me.lblCommandFormat.AutoSize = True
        Me.lblCommandFormat.Location = New System.Drawing.Point(4, 14)
        Me.lblCommandFormat.Name = "lblCommandFormat"
        Me.lblCommandFormat.Size = New System.Drawing.Size(92, 13)
        Me.lblCommandFormat.TabIndex = 17
        Me.lblCommandFormat.Text = "Command Format:"
        '
        'tbpEditor
        '
        Me.tbpEditor.Controls.Add(Me.pnFormatEditor)
        Me.tbpEditor.Location = New System.Drawing.Point(4, 22)
        Me.tbpEditor.Name = "tbpEditor"
        Me.tbpEditor.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpEditor.Size = New System.Drawing.Size(564, 291)
        Me.tbpEditor.TabIndex = 10
        Me.tbpEditor.Text = "Editor Window"
        Me.tbpEditor.ToolTipText = "Data View"
        Me.tbpEditor.UseVisualStyleBackColor = True
        '
        'pnFormatEditor
        '
        Me.pnFormatEditor.AutoSize = True
        Me.pnFormatEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatEditor.Controls.Add(Me.cmdEditorFont)
        Me.pnFormatEditor.Controls.Add(Me.lblFont)
        Me.pnFormatEditor.Location = New System.Drawing.Point(10, 10)
        Me.pnFormatEditor.Name = "pnFormatEditor"
        Me.pnFormatEditor.Size = New System.Drawing.Size(212, 28)
        Me.pnFormatEditor.TabIndex = 22
        '
        'cmdEditorFont
        '
        Me.cmdEditorFont.Location = New System.Drawing.Point(109, 2)
        Me.cmdEditorFont.Name = "cmdEditorFont"
        Me.cmdEditorFont.Size = New System.Drawing.Size(100, 23)
        Me.cmdEditorFont.TabIndex = 10
        Me.cmdEditorFont.Text = "Change..."
        Me.cmdEditorFont.UseVisualStyleBackColor = True
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(4, 7)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(66, 13)
        Me.lblFont.TabIndex = 17
        Me.lblFont.Text = "Format Font:"
        '
        'tbpCommands
        '
        Me.tbpCommands.Controls.Add(Me.lblWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkShowWaitDialog)
        Me.tbpCommands.Controls.Add(Me.ucrNudWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkIncludeDefaultParams)
        Me.tbpCommands.Location = New System.Drawing.Point(4, 22)
        Me.tbpCommands.Name = "tbpCommands"
        Me.tbpCommands.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpCommands.Size = New System.Drawing.Size(564, 291)
        Me.tbpCommands.TabIndex = 4
        Me.tbpCommands.Tag = "Commands"
        Me.tbpCommands.Text = "Commands"
        Me.tbpCommands.UseVisualStyleBackColor = True
        '
        'lblWaitSeconds
        '
        Me.lblWaitSeconds.AutoSize = True
        Me.lblWaitSeconds.Location = New System.Drawing.Point(403, 46)
        Me.lblWaitSeconds.Name = "lblWaitSeconds"
        Me.lblWaitSeconds.Size = New System.Drawing.Size(47, 13)
        Me.lblWaitSeconds.TabIndex = 8
        Me.lblWaitSeconds.Text = "seconds"
        '
        'ucrChkShowWaitDialog
        '
        Me.ucrChkShowWaitDialog.AutoSize = True
        Me.ucrChkShowWaitDialog.Checked = False
        Me.ucrChkShowWaitDialog.Location = New System.Drawing.Point(6, 47)
        Me.ucrChkShowWaitDialog.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkShowWaitDialog.Name = "ucrChkShowWaitDialog"
        Me.ucrChkShowWaitDialog.Size = New System.Drawing.Size(337, 34)
        Me.ucrChkShowWaitDialog.TabIndex = 6
        '
        'ucrNudWaitSeconds
        '
        Me.ucrNudWaitSeconds.AutoSize = True
        Me.ucrNudWaitSeconds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaitSeconds.Location = New System.Drawing.Point(349, 45)
        Me.ucrNudWaitSeconds.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudWaitSeconds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaitSeconds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Name = "ucrNudWaitSeconds"
        Me.ucrNudWaitSeconds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWaitSeconds.TabIndex = 5
        Me.ucrNudWaitSeconds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeDefaultParams
        '
        Me.ucrChkIncludeDefaultParams.AutoSize = True
        Me.ucrChkIncludeDefaultParams.Checked = False
        Me.ucrChkIncludeDefaultParams.Location = New System.Drawing.Point(6, 20)
        Me.ucrChkIncludeDefaultParams.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkIncludeDefaultParams.Name = "ucrChkIncludeDefaultParams"
        Me.ucrChkIncludeDefaultParams.Size = New System.Drawing.Size(398, 34)
        Me.ucrChkIncludeDefaultParams.TabIndex = 3
        '
        'tbpDataView
        '
        Me.tbpDataView.Controls.Add(Me.ucrChkTurnOffUndo)
        Me.tbpDataView.Controls.Add(Me.Label4)
        Me.tbpDataView.Controls.Add(Me.Label3)
        Me.tbpDataView.Controls.Add(Me.ucrNudRowUndoLimit)
        Me.tbpDataView.Controls.Add(Me.Label2)
        Me.tbpDataView.Controls.Add(Me.Label1)
        Me.tbpDataView.Controls.Add(Me.ucrNudColUndoLimit)
        Me.tbpDataView.Controls.Add(Me.lblEvery)
        Me.tbpDataView.Controls.Add(Me.lblMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrChkAutoSave)
        Me.tbpDataView.Controls.Add(Me.ucrChkShowDataonGrid)
        Me.tbpDataView.Controls.Add(Me.ucrNudAutoSaveMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxCols)
        Me.tbpDataView.Controls.Add(Me.lblMaxCols)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxRows)
        Me.tbpDataView.Controls.Add(Me.lblMaxRows)
        Me.tbpDataView.Location = New System.Drawing.Point(4, 22)
        Me.tbpDataView.Name = "tbpDataView"
        Me.tbpDataView.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpDataView.Size = New System.Drawing.Size(564, 291)
        Me.tbpDataView.TabIndex = 9
        Me.tbpDataView.Text = "Data View"
        Me.tbpDataView.UseVisualStyleBackColor = True
        '
        'ucrChkTurnOffUndo
        '
        Me.ucrChkTurnOffUndo.AutoSize = True
        Me.ucrChkTurnOffUndo.Checked = False
        Me.ucrChkTurnOffUndo.Location = New System.Drawing.Point(13, 233)
        Me.ucrChkTurnOffUndo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkTurnOffUndo.Name = "ucrChkTurnOffUndo"
        Me.ucrChkTurnOffUndo.Size = New System.Drawing.Size(217, 34)
        Me.ucrChkTurnOffUndo.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(360, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "(Any changes from the default only apply to the current session of R-Instat.)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "rows."
        '
        'ucrNudRowUndoLimit
        '
        Me.ucrNudRowUndoLimit.AutoSize = True
        Me.ucrNudRowUndoLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowUndoLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRowUndoLimit.Location = New System.Drawing.Point(353, 173)
        Me.ucrNudRowUndoLimit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudRowUndoLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRowUndoLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowUndoLimit.Name = "ucrNudRowUndoLimit"
        Me.ucrNudRowUndoLimit.Size = New System.Drawing.Size(71, 20)
        Me.ucrNudRowUndoLimit.TabIndex = 9
        Me.ucrNudRowUndoLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "columns or"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Switch off spreadsheet-syle undo when a dataframe has more than"
        '
        'ucrNudColUndoLimit
        '
        Me.ucrNudColUndoLimit.AutoSize = True
        Me.ucrNudColUndoLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColUndoLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColUndoLimit.Location = New System.Drawing.Point(353, 151)
        Me.ucrNudColUndoLimit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudColUndoLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColUndoLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColUndoLimit.Name = "ucrNudColUndoLimit"
        Me.ucrNudColUndoLimit.Size = New System.Drawing.Size(71, 20)
        Me.ucrNudColUndoLimit.TabIndex = 6
        Me.ucrNudColUndoLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblEvery
        '
        Me.lblEvery.AutoSize = True
        Me.lblEvery.Location = New System.Drawing.Point(220, 115)
        Me.lblEvery.Name = "lblEvery"
        Me.lblEvery.Size = New System.Drawing.Size(33, 13)
        Me.lblEvery.TabIndex = 4
        Me.lblEvery.Text = "every"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(340, 115)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(43, 13)
        Me.lblMinutes.TabIndex = 4
        Me.lblMinutes.Text = "minutes"
        '
        'ucrChkAutoSave
        '
        Me.ucrChkAutoSave.AutoSize = True
        Me.ucrChkAutoSave.Checked = False
        Me.ucrChkAutoSave.Location = New System.Drawing.Point(13, 114)
        Me.ucrChkAutoSave.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkAutoSave.Name = "ucrChkAutoSave"
        Me.ucrChkAutoSave.Size = New System.Drawing.Size(217, 34)
        Me.ucrChkAutoSave.TabIndex = 3
        '
        'ucrChkShowDataonGrid
        '
        Me.ucrChkShowDataonGrid.AutoSize = True
        Me.ucrChkShowDataonGrid.Checked = False
        Me.ucrChkShowDataonGrid.Location = New System.Drawing.Point(13, 78)
        Me.ucrChkShowDataonGrid.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkShowDataonGrid.Name = "ucrChkShowDataonGrid"
        Me.ucrChkShowDataonGrid.Size = New System.Drawing.Size(393, 34)
        Me.ucrChkShowDataonGrid.TabIndex = 3
        '
        'ucrNudAutoSaveMinutes
        '
        Me.ucrNudAutoSaveMinutes.AutoSize = True
        Me.ucrNudAutoSaveMinutes.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Location = New System.Drawing.Point(268, 112)
        Me.ucrNudAutoSaveMinutes.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudAutoSaveMinutes.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Name = "ucrNudAutoSaveMinutes"
        Me.ucrNudAutoSaveMinutes.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAutoSaveMinutes.TabIndex = 2
        Me.ucrNudAutoSaveMinutes.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxCols
        '
        Me.ucrNudMaxCols.AutoSize = True
        Me.ucrNudMaxCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxCols.Location = New System.Drawing.Point(268, 41)
        Me.ucrNudMaxCols.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudMaxCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Name = "ucrNudMaxCols"
        Me.ucrNudMaxCols.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxCols.TabIndex = 2
        Me.ucrNudMaxCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxCols
        '
        Me.lblMaxCols.AutoSize = True
        Me.lblMaxCols.Location = New System.Drawing.Point(10, 44)
        Me.lblMaxCols.Name = "lblMaxCols"
        Me.lblMaxCols.Size = New System.Drawing.Size(198, 13)
        Me.lblMaxCols.TabIndex = 1
        Me.lblMaxCols.Text = "Maximum Number of Columns to Display:"
        '
        'ucrNudMaxRows
        '
        Me.ucrNudMaxRows.AutoSize = True
        Me.ucrNudMaxRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxRows.Location = New System.Drawing.Point(268, 15)
        Me.ucrNudMaxRows.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudMaxRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Name = "ucrNudMaxRows"
        Me.ucrNudMaxRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxRows.TabIndex = 2
        Me.ucrNudMaxRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxRows
        '
        Me.lblMaxRows.AutoSize = True
        Me.lblMaxRows.Location = New System.Drawing.Point(10, 18)
        Me.lblMaxRows.Name = "lblMaxRows"
        Me.lblMaxRows.Size = New System.Drawing.Size(185, 13)
        Me.lblMaxRows.TabIndex = 1
        Me.lblMaxRows.Text = "Maximum Number of Rows to Display:"
        '
        'tbpWorkingDirectory
        '
        Me.tbpWorkingDirectory.Controls.Add(Me.cmdWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.lblWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.ucrWorkingDirectory)
        Me.tbpWorkingDirectory.Location = New System.Drawing.Point(4, 22)
        Me.tbpWorkingDirectory.Name = "tbpWorkingDirectory"
        Me.tbpWorkingDirectory.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpWorkingDirectory.Size = New System.Drawing.Size(564, 291)
        Me.tbpWorkingDirectory.TabIndex = 11
        Me.tbpWorkingDirectory.Text = "Working Directory"
        Me.tbpWorkingDirectory.UseVisualStyleBackColor = True
        '
        'cmdWorkingDirectory
        '
        Me.cmdWorkingDirectory.Location = New System.Drawing.Point(399, 16)
        Me.cmdWorkingDirectory.Name = "cmdWorkingDirectory"
        Me.cmdWorkingDirectory.Size = New System.Drawing.Size(24, 21)
        Me.cmdWorkingDirectory.TabIndex = 2
        Me.cmdWorkingDirectory.Text = "..."
        Me.cmdWorkingDirectory.UseVisualStyleBackColor = True
        '
        'lblWorkingDirectory
        '
        Me.lblWorkingDirectory.AutoSize = True
        Me.lblWorkingDirectory.Location = New System.Drawing.Point(13, 20)
        Me.lblWorkingDirectory.Name = "lblWorkingDirectory"
        Me.lblWorkingDirectory.Size = New System.Drawing.Size(95, 13)
        Me.lblWorkingDirectory.TabIndex = 0
        Me.lblWorkingDirectory.Text = "Working Directory:"
        '
        'ucrWorkingDirectory
        '
        Me.ucrWorkingDirectory.AddQuotesIfUnrecognised = True
        Me.ucrWorkingDirectory.AutoSize = True
        Me.ucrWorkingDirectory.IsMultiline = False
        Me.ucrWorkingDirectory.IsReadOnly = False
        Me.ucrWorkingDirectory.Location = New System.Drawing.Point(138, 17)
        Me.ucrWorkingDirectory.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrWorkingDirectory.Name = "ucrWorkingDirectory"
        Me.ucrWorkingDirectory.Size = New System.Drawing.Size(255, 21)
        Me.ucrWorkingDirectory.TabIndex = 1
        '
        'tbpGraphDisplay
        '
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinSeparateWindows)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinRViewer)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinOutputWindow)
        Me.tbpGraphDisplay.Controls.Add(Me.ucrPnlGraphDisplay)
        Me.tbpGraphDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraphDisplay.Name = "tbpGraphDisplay"
        Me.tbpGraphDisplay.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpGraphDisplay.Size = New System.Drawing.Size(564, 291)
        Me.tbpGraphDisplay.TabIndex = 12
        Me.tbpGraphDisplay.Text = "Graph Display"
        Me.tbpGraphDisplay.UseVisualStyleBackColor = True
        '
        'rdoDisplayinSeparateWindows
        '
        Me.rdoDisplayinSeparateWindows.AutoSize = True
        Me.rdoDisplayinSeparateWindows.Checked = True
        Me.rdoDisplayinSeparateWindows.Location = New System.Drawing.Point(6, 52)
        Me.rdoDisplayinSeparateWindows.Name = "rdoDisplayinSeparateWindows"
        Me.rdoDisplayinSeparateWindows.Size = New System.Drawing.Size(163, 17)
        Me.rdoDisplayinSeparateWindows.TabIndex = 1
        Me.rdoDisplayinSeparateWindows.TabStop = True
        Me.rdoDisplayinSeparateWindows.Text = "Display in Separate Windows"
        Me.rdoDisplayinSeparateWindows.UseVisualStyleBackColor = True
        '
        'rdoDisplayinRViewer
        '
        Me.rdoDisplayinRViewer.AutoSize = True
        Me.rdoDisplayinRViewer.Location = New System.Drawing.Point(6, 29)
        Me.rdoDisplayinRViewer.Name = "rdoDisplayinRViewer"
        Me.rdoDisplayinRViewer.Size = New System.Drawing.Size(116, 17)
        Me.rdoDisplayinRViewer.TabIndex = 1
        Me.rdoDisplayinRViewer.Text = "Display in R Viewer"
        Me.rdoDisplayinRViewer.UseVisualStyleBackColor = True
        '
        'rdoDisplayinOutputWindow
        '
        Me.rdoDisplayinOutputWindow.AutoSize = True
        Me.rdoDisplayinOutputWindow.Location = New System.Drawing.Point(6, 6)
        Me.rdoDisplayinOutputWindow.Name = "rdoDisplayinOutputWindow"
        Me.rdoDisplayinOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDisplayinOutputWindow.TabIndex = 1
        Me.rdoDisplayinOutputWindow.Text = "Display in Output Window"
        Me.rdoDisplayinOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphDisplay
        '
        Me.ucrPnlGraphDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGraphDisplay.Location = New System.Drawing.Point(0, 3)
        Me.ucrPnlGraphDisplay.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrPnlGraphDisplay.Name = "ucrPnlGraphDisplay"
        Me.ucrPnlGraphDisplay.Size = New System.Drawing.Size(365, 66)
        Me.ucrPnlGraphDisplay.TabIndex = 3
        '
        'tbpTailoredMenus
        '
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewTricotXpMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewTricotMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewStructuredMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewOptionsByContextMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewProcurementMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewClimaticMenu)
        Me.tbpTailoredMenus.Location = New System.Drawing.Point(4, 22)
        Me.tbpTailoredMenus.Name = "tbpTailoredMenus"
        Me.tbpTailoredMenus.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpTailoredMenus.Size = New System.Drawing.Size(564, 291)
        Me.tbpTailoredMenus.TabIndex = 13
        Me.tbpTailoredMenus.Text = "Tailored Menus"
        Me.tbpTailoredMenus.UseVisualStyleBackColor = True
        '
        'ucrChkViewTricotMenu
        '
        Me.ucrChkViewTricotMenu.AutoSize = True
        Me.ucrChkViewTricotMenu.Checked = False
        Me.ucrChkViewTricotMenu.Location = New System.Drawing.Point(7, 92)
        Me.ucrChkViewTricotMenu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkViewTricotMenu.Name = "ucrChkViewTricotMenu"
        Me.ucrChkViewTricotMenu.Size = New System.Drawing.Size(413, 34)
        Me.ucrChkViewTricotMenu.TabIndex = 3
        '
        'ucrChkViewStructuredMenu
        '
        Me.ucrChkViewStructuredMenu.AutoSize = True
        Me.ucrChkViewStructuredMenu.Checked = False
        Me.ucrChkViewStructuredMenu.Location = New System.Drawing.Point(7, 12)
        Me.ucrChkViewStructuredMenu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkViewStructuredMenu.Name = "ucrChkViewStructuredMenu"
        Me.ucrChkViewStructuredMenu.Size = New System.Drawing.Size(378, 34)
        Me.ucrChkViewStructuredMenu.TabIndex = 2
        '
        'ucrChkViewOptionsByContextMenu
        '
        Me.ucrChkViewOptionsByContextMenu.AutoSize = True
        Me.ucrChkViewOptionsByContextMenu.Checked = False
        Me.ucrChkViewOptionsByContextMenu.Location = New System.Drawing.Point(7, 172)
        Me.ucrChkViewOptionsByContextMenu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkViewOptionsByContextMenu.Name = "ucrChkViewOptionsByContextMenu"
        Me.ucrChkViewOptionsByContextMenu.Size = New System.Drawing.Size(413, 34)
        Me.ucrChkViewOptionsByContextMenu.TabIndex = 1
        '
        'ucrChkViewProcurementMenu
        '
        Me.ucrChkViewProcurementMenu.AutoSize = True
        Me.ucrChkViewProcurementMenu.Checked = False
        Me.ucrChkViewProcurementMenu.Location = New System.Drawing.Point(7, 212)
        Me.ucrChkViewProcurementMenu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkViewProcurementMenu.Name = "ucrChkViewProcurementMenu"
        Me.ucrChkViewProcurementMenu.Size = New System.Drawing.Size(413, 34)
        Me.ucrChkViewProcurementMenu.TabIndex = 0
        '
        'ucrChkViewClimaticMenu
        '
        Me.ucrChkViewClimaticMenu.AutoSize = True
        Me.ucrChkViewClimaticMenu.Checked = False
        Me.ucrChkViewClimaticMenu.Location = New System.Drawing.Point(7, 52)
        Me.ucrChkViewClimaticMenu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkViewClimaticMenu.Name = "ucrChkViewClimaticMenu"
        Me.ucrChkViewClimaticMenu.Size = New System.Drawing.Size(407, 34)
        Me.ucrChkViewClimaticMenu.TabIndex = 0
        '
        'tbpClimsoft
        '
        Me.tbpClimsoft.Controls.Add(Me.lblUserName)
        Me.tbpClimsoft.Controls.Add(Me.lblPort)
        Me.tbpClimsoft.Controls.Add(Me.lblHost)
        Me.tbpClimsoft.Controls.Add(Me.lblDatabaseName)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputUserName)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputPort)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputHost)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputDatabaseName)
        Me.tbpClimsoft.Location = New System.Drawing.Point(4, 22)
        Me.tbpClimsoft.Name = "tbpClimsoft"
        Me.tbpClimsoft.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpClimsoft.Size = New System.Drawing.Size(564, 291)
        Me.tbpClimsoft.TabIndex = 14
        Me.tbpClimsoft.Text = "Climsoft"
        Me.tbpClimsoft.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(6, 103)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.Text = "Username:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(6, 76)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 18
        Me.lblPort.Text = "Port:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(6, 49)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(32, 13)
        Me.lblHost.TabIndex = 17
        Me.lblHost.Text = "Host:"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(6, 21)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(87, 13)
        Me.lblDatabaseName.TabIndex = 16
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'ucrInputUserName
        '
        Me.ucrInputUserName.AddQuotesIfUnrecognised = True
        Me.ucrInputUserName.AutoSize = True
        Me.ucrInputUserName.IsMultiline = False
        Me.ucrInputUserName.IsReadOnly = False
        Me.ucrInputUserName.Location = New System.Drawing.Point(168, 96)
        Me.ucrInputUserName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputUserName.Name = "ucrInputUserName"
        Me.ucrInputUserName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputUserName.TabIndex = 15
        '
        'ucrInputPort
        '
        Me.ucrInputPort.AddQuotesIfUnrecognised = True
        Me.ucrInputPort.AutoSize = True
        Me.ucrInputPort.IsMultiline = False
        Me.ucrInputPort.IsReadOnly = False
        Me.ucrInputPort.Location = New System.Drawing.Point(168, 69)
        Me.ucrInputPort.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputPort.Name = "ucrInputPort"
        Me.ucrInputPort.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPort.TabIndex = 14
        '
        'ucrInputHost
        '
        Me.ucrInputHost.AddQuotesIfUnrecognised = True
        Me.ucrInputHost.AutoSize = True
        Me.ucrInputHost.IsMultiline = False
        Me.ucrInputHost.IsReadOnly = False
        Me.ucrInputHost.Location = New System.Drawing.Point(168, 43)
        Me.ucrInputHost.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputHost.Name = "ucrInputHost"
        Me.ucrInputHost.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHost.TabIndex = 13
        '
        'ucrInputDatabaseName
        '
        Me.ucrInputDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabaseName.AutoSize = True
        Me.ucrInputDatabaseName.IsMultiline = False
        Me.ucrInputDatabaseName.IsReadOnly = False
        Me.ucrInputDatabaseName.Location = New System.Drawing.Point(168, 17)
        Me.ucrInputDatabaseName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputDatabaseName.Name = "ucrInputDatabaseName"
        Me.ucrInputDatabaseName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDatabaseName.TabIndex = 12
        '
        'tbpWebsite
        '
        Me.tbpWebsite.Controls.Add(Me.ucrChkReminder)
        Me.tbpWebsite.Location = New System.Drawing.Point(4, 22)
        Me.tbpWebsite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpWebsite.Name = "tbpWebsite"
        Me.tbpWebsite.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpWebsite.Size = New System.Drawing.Size(564, 291)
        Me.tbpWebsite.TabIndex = 15
        Me.tbpWebsite.Text = "Website"
        Me.tbpWebsite.UseVisualStyleBackColor = True
        '
        'ucrChkReminder
        '
        Me.ucrChkReminder.AutoSize = True
        Me.ucrChkReminder.Checked = False
        Me.ucrChkReminder.Location = New System.Drawing.Point(7, 22)
        Me.ucrChkReminder.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkReminder.Name = "ucrChkReminder"
        Me.ucrChkReminder.Size = New System.Drawing.Size(413, 34)
        Me.ucrChkReminder.TabIndex = 2
        '
        'ucrChkViewTricotXpMenu
        '
        Me.ucrChkViewTricotXpMenu.AutoSize = True
        Me.ucrChkViewTricotXpMenu.Checked = False
        Me.ucrChkViewTricotXpMenu.Location = New System.Drawing.Point(7, 132)
        Me.ucrChkViewTricotXpMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkViewTricotXpMenu.Name = "ucrChkViewTricotXpMenu"
        Me.ucrChkViewTricotXpMenu.Size = New System.Drawing.Size(413, 34)
        Me.ucrChkViewTricotXpMenu.TabIndex = 4
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(770, 353)
        Me.Controls.Add(Me.cmdLanguage)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.spltControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.spltControls.Panel1.ResumeLayout(False)
        Me.spltControls.Panel2.ResumeLayout(False)
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltControls.ResumeLayout(False)
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpLanguages.ResumeLayout(False)
        Me.tbpLanguages.PerformLayout()
        Me.tbpComments.ResumeLayout(False)
        Me.pnComments.ResumeLayout(False)
        Me.pnComments.PerformLayout()
        Me.tbpImport.ResumeLayout(False)
        Me.tbpImport.PerformLayout()
        Me.tbpOutputWindow.ResumeLayout(False)
        Me.tbpOutputWindow.PerformLayout()
        Me.grpROptions.ResumeLayout(False)
        Me.grpROptions.PerformLayout()
        Me.pnFormatOptions.ResumeLayout(False)
        Me.pnFormatOptions.PerformLayout()
        Me.tbpEditor.ResumeLayout(False)
        Me.tbpEditor.PerformLayout()
        Me.pnFormatEditor.ResumeLayout(False)
        Me.pnFormatEditor.PerformLayout()
        Me.tbpCommands.ResumeLayout(False)
        Me.tbpCommands.PerformLayout()
        Me.tbpDataView.ResumeLayout(False)
        Me.tbpDataView.PerformLayout()
        Me.tbpWorkingDirectory.ResumeLayout(False)
        Me.tbpWorkingDirectory.PerformLayout()
        Me.tbpGraphDisplay.ResumeLayout(False)
        Me.tbpGraphDisplay.PerformLayout()
        Me.tbpTailoredMenus.ResumeLayout(False)
        Me.tbpTailoredMenus.PerformLayout()
        Me.tbpClimsoft.ResumeLayout(False)
        Me.tbpClimsoft.PerformLayout()
        Me.tbpWebsite.ResumeLayout(False)
        Me.tbpWebsite.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdApply As Button
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpLanguages As TabPage
    Friend WithEvents tbpComments As TabPage
    Friend WithEvents pnComments As Panel
    Friend WithEvents lblComment As Label
    Friend WithEvents tbpImport As TabPage
    Friend WithEvents pnImportData As Panel
    Friend WithEvents lblPreviewRows As Label
    Friend WithEvents tbpOutputWindow As TabPage
    Friend WithEvents pnFormatOptions As Panel
    Friend WithEvents rtbCommentPreview As RichTextBox
    Friend WithEvents rtbOutputPreview As RichTextBox
    Friend WithEvents rtbCommandPreview As RichTextBox
    Friend WithEvents cmdCommandFormat As Button
    Friend WithEvents lblCommentFormat As Label
    Friend WithEvents cmdOutputFormat As Button
    Friend WithEvents lblOutputFormat As Label
    Friend WithEvents cmdCommentFormat As Button
    Friend WithEvents lblCommandFormat As Label
    Friend WithEvents tbpEditor As TabPage
    Friend WithEvents pnFormatEditor As Panel
    Friend WithEvents cmdEditorFont As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents tbpCommands As TabPage
    Friend WithEvents tbpDataView As TabPage
    Friend WithEvents lblMaxRows As Label
    Friend WithEvents tbpWorkingDirectory As TabPage
    Friend WithEvents cmdWorkingDirectory As Button
    Friend WithEvents ucrWorkingDirectory As ucrInputTextBox
    Friend WithEvents lblWorkingDirectory As Label
    Friend WithEvents trOptions As TreeView
    Friend WithEvents spltControls As SplitContainer
    Friend WithEvents tbpGraphDisplay As TabPage
    Friend WithEvents rdoDisplayinSeparateWindows As RadioButton
    Friend WithEvents rdoDisplayinRViewer As RadioButton
    Friend WithEvents rdoDisplayinOutputWindow As RadioButton
    Friend WithEvents grpROptions As GroupBox
    Friend WithEvents lblNoDigits As Label
    Friend WithEvents cmdFactoryReset As Button
    Friend WithEvents ucrNudPreviewRows As ucrNud
    Friend WithEvents ucrNudDigits As ucrNud
    Friend WithEvents ucrChkIncludeCommentsbyDefault As ucrCheck
    Friend WithEvents ucrChkShowRCommandsinOutputWindow As ucrCheck
    Friend WithEvents ucrChkShowSignifStars As ucrCheck
    Friend WithEvents ucrChkIncludeDefaultParams As ucrCheck
    Friend WithEvents ucrNudMaxRows As ucrNud
    Friend WithEvents ucrPnlGraphDisplay As UcrPanel
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents ucrNudMaxCols As ucrNud
    Friend WithEvents lblMaxCols As Label
    Friend WithEvents ucrChkShowDataonGrid As ucrCheck
    Friend WithEvents ucrChkAutoSave As ucrCheck
    Friend WithEvents ucrNudAutoSaveMinutes As ucrNud
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblEvery As Label
    Friend WithEvents lblWaitSeconds As Label
    Friend WithEvents ucrChkShowWaitDialog As ucrCheck
    Friend WithEvents ucrNudWaitSeconds As ucrNud
    Friend WithEvents tbpTailoredMenus As TabPage
    Friend WithEvents ucrChkViewProcurementMenu As ucrCheck
    Friend WithEvents ucrChkViewClimaticMenu As ucrCheck
    Friend WithEvents ucrChkViewOptionsByContextMenu As ucrCheck
    Friend WithEvents tbpClimsoft As TabPage
    Friend WithEvents ucrInputUserName As ucrInputTextBox
    Friend WithEvents ucrInputPort As ucrInputTextBox
    Friend WithEvents ucrInputHost As ucrInputTextBox
    Friend WithEvents ucrInputDatabaseName As ucrInputTextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents ucrChkViewStructuredMenu As ucrCheck
    Friend WithEvents lblLanguage As Label
    Friend WithEvents ucrInputLanguage As ucrInputComboBox
    Friend WithEvents cmdLanguage As Button
    Friend WithEvents ucrChkMaxOutputsHeight As ucrCheck
    Friend WithEvents ucrNudMaxOutputsHeight As ucrNud
    Friend WithEvents lversion As Label
    Friend WithEvents tbpWebsite As TabPage
    Friend WithEvents ucrChkReminder As ucrCheck
    Friend WithEvents ucrNudColUndoLimit As ucrNud
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ucrNudRowUndoLimit As ucrNud
    Friend WithEvents Label4 As Label
    Friend WithEvents ucrChkTurnOffUndo As ucrCheck
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrChkViewTricotMenu As ucrCheck
    Friend WithEvents ucrChkViewTricotXpMenu As ucrCheck
End Class
