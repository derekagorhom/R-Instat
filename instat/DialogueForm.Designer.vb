<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDialogueForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.lblX_Variable = New System.Windows.Forms.Label()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.lblY_Variable = New System.Windows.Forms.Label()
        Me.rdoBar = New instat.ucrRadio()
        Me.rdoBox = New instat.ucrRadio()
        Me.rdoScatter = New instat.ucrRadio()
        Me.grpChartDesign = New System.Windows.Forms.GroupBox()
        Me.ucrChkBox = New instat.ucrCheck()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.ucrNumber = New instat.ucrNud()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputText = New instat.ucrInputTextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 343)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(421, 58)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrame.TabIndex = 1
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(269, 49)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 2
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'lblX_Variable
        '
        Me.lblX_Variable.AutoSize = True
        Me.lblX_Variable.Location = New System.Drawing.Point(271, 26)
        Me.lblX_Variable.Name = "lblX_Variable"
        Me.lblX_Variable.Size = New System.Drawing.Size(58, 13)
        Me.lblX_Variable.TabIndex = 3
        Me.lblX_Variable.Text = "X Variable:"
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Location = New System.Drawing.Point(269, 121)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 4
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'lblY_Variable
        '
        Me.lblY_Variable.AutoSize = True
        Me.lblY_Variable.Location = New System.Drawing.Point(271, 97)
        Me.lblY_Variable.Name = "lblY_Variable"
        Me.lblY_Variable.Size = New System.Drawing.Size(58, 13)
        Me.lblY_Variable.TabIndex = 5
        Me.lblY_Variable.Text = "Y Variable:"
        '
        'rdoBar
        '
        Me.rdoBar.Location = New System.Drawing.Point(269, 174)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(100, 20)
        Me.rdoBar.TabIndex = 9
        '
        'rdoBox
        '
        Me.rdoBox.Location = New System.Drawing.Point(269, 201)
        Me.rdoBox.Name = "rdoBox"
        Me.rdoBox.Size = New System.Drawing.Size(100, 20)
        Me.rdoBox.TabIndex = 10
        '
        'rdoScatter
        '
        Me.rdoScatter.Location = New System.Drawing.Point(269, 229)
        Me.rdoScatter.Name = "rdoScatter"
        Me.rdoScatter.Size = New System.Drawing.Size(100, 20)
        Me.rdoScatter.TabIndex = 11
        '
        'grpChartDesign
        '
        Me.grpChartDesign.Location = New System.Drawing.Point(267, 160)
        Me.grpChartDesign.Name = "grpChartDesign"
        Me.grpChartDesign.Size = New System.Drawing.Size(128, 100)
        Me.grpChartDesign.TabIndex = 12
        Me.grpChartDesign.TabStop = False
        Me.grpChartDesign.Text = "Chart Design"
        '
        'ucrChkBox
        '
        Me.ucrChkBox.Checked = False
        Me.ucrChkBox.Location = New System.Drawing.Point(9, 210)
        Me.ucrChkBox.Name = "ucrChkBox"
        Me.ucrChkBox.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkBox.TabIndex = 13
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(309, 266)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputColour.TabIndex = 14
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(269, 269)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(40, 13)
        Me.lblColour.TabIndex = 15
        Me.lblColour.Text = "Colour:"
        '
        'ucrNumber
        '
        Me.ucrNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNumber.Location = New System.Drawing.Point(329, 293)
        Me.ucrNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumber.Name = "ucrNumber"
        Me.ucrNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNumber.TabIndex = 16
        Me.ucrNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Number:"
        '
        'ucrInputText
        '
        Me.ucrInputText.AddQuotesIfUnrecognised = True
        Me.ucrInputText.IsMultiline = False
        Me.ucrInputText.IsReadOnly = False
        Me.ucrInputText.Location = New System.Drawing.Point(8, 266)
        Me.ucrInputText.Name = "ucrInputText"
        Me.ucrInputText.Size = New System.Drawing.Size(87, 21)
        Me.ucrInputText.TabIndex = 18
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(6, 247)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(58, 13)
        Me.lblText.TabIndex = 19
        Me.lblText.Text = "Input Text:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(9, 304)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(146, 32)
        Me.ucrSaveGraph.TabIndex = 20
        '
        'dlgDialogueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 400)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.ucrInputText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrNumber)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.ucrChkBox)
        Me.Controls.Add(Me.rdoScatter)
        Me.Controls.Add(Me.rdoBox)
        Me.Controls.Add(Me.rdoBar)
        Me.Controls.Add(Me.lblY_Variable)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.lblX_Variable)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpChartDesign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDialogueForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogueForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents rdoScatter As ucrRadio
    Friend WithEvents rdoBox As ucrRadio
    Friend WithEvents rdoBar As ucrRadio
    Friend WithEvents lblY_Variable As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents lblX_Variable As Label
    Friend WithEvents ucrChkBox As ucrCheck
    Friend WithEvents grpChartDesign As GroupBox
    Friend WithEvents lblText As Label
    Friend WithEvents ucrInputText As ucrInputTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrNumber As ucrNud
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents ucrSaveGraph As ucrSaveGraph
End Class
