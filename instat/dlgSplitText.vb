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

Imports instat.Translations
Public Class dlgSplitText
    Public enumSplitMode As String = SplitMode.Prepare
    Public Enum SplitMode
        Prepare
        Climatic
    End Enum

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTextComponentsFixed, clsCurrentNewColumnFunction, clsSquishFunction, clsTextComponentsMaximum, clsStringCollFunction As New RFunction
    Private clsBinaryColumns As New RFunction
    Private clsSplitDummyFunction As New RFunction
    Private clsPatternDummyFunction As New RFunction
    Private dctPatternPairs As New Dictionary(Of String, String)

    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHelpOptions()
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 344

        ucrPnlSplitText.AddRadioButton(rdoTextComponents)
        ucrPnlSplitText.AddRadioButton(rdoBinaryColumns)

        ucrPnlSplitText.AddFunctionNamesCondition(rdoBinaryColumns, "multi.split", True)
        ucrPnlSplitText.AddFunctionNamesCondition(rdoTextComponents, "multi.split", False)

        ucrPnlTextComponents.AddRadioButton(rdoFixedNumberOfComponents)
        ucrPnlTextComponents.AddRadioButton(rdoMaximumNumberOfComponents)

        ucrPnlTextComponents.AddFunctionNamesCondition(rdoMaximumNumberOfComponents, "str_split")
        ucrPnlTextComponents.AddFunctionNamesCondition(rdoFixedNumberOfComponents, "str_split_fixed")

        ucrPnlTextComponents.AddToLinkedControls(ucrNudPieces, {rdoFixedNumberOfComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=2, bNewLinkedChangeParameterValue:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrChkIncludeRegularExpressions, {rdoTextComponents}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrPnlTextComponents, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoFixedNumberOfComponents)
        ucrChkIncludeRegularExpressions.AddToLinkedControls(ucrInputRegexPattern, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPieces.SetLinkedDisplayControl(lblNumberofPiecesToReturn)

        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string", 0))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        dctPatternPairs.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctPatternPairs.Add("Spaces ( )", Chr(34) & " " & Chr(34) & " ") ' Adds an invisible difference
        dctPatternPairs.Add("Period .", Chr(34) & "." & Chr(34))
        dctPatternPairs.Add("Comma ,", Chr(34) & "," & Chr(34))
        dctPatternPairs.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctPatternPairs.Add("Semicolon ;", Chr(34) & ";" & Chr(34))
        dctPatternPairs.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctPatternPairs.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPattern.SetItems(dctPatternPairs)
        ucrInputPattern.bAllowNonConditionValues = True

        ucrNudPieces.SetParameter(New RParameter("n", 2))
        ucrNudPieces.SetMinMax(2, Integer.MaxValue)

        ucrChkIncludeRegularExpressions.SetText("Include Regular Expressions")
        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("checked", 0))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked(True, False)
        ucrChkIncludeRegularExpressions.SetRDefault("FALSE")

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.setLinkedReceiver(ucrReceiverSplitTextColumn)
    End Sub

    Private Sub SetDefaults()
        clsTextComponentsFixed = New RFunction
        clsTextComponentsMaximum = New RFunction
        clsBinaryColumns = New RFunction
        clsStringCollFunction = New RFunction
        clsSplitDummyFunction = New RFunction
        clsPatternDummyFunction = New RFunction
        clsSquishFunction = New RFunction
        clsCurrentNewColumnFunction = New RFunction

        ucrSelectorSplitTextColumn.Reset()
        ucrSaveColumn.Reset()

        ucrInputRegexPattern.SetName("")

        clsSplitDummyFunction.AddParameter("checked", False, iPosition:=0)

        clsPatternDummyFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)

        clsStringCollFunction.SetPackageName("stringr")
        clsStringCollFunction.SetRCommand("coll")
        clsStringCollFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=0)

        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsTextComponentsFixed.SetPackageName("stringr")
        clsTextComponentsFixed.SetRCommand("str_split_fixed")
        clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)

        clsTextComponentsMaximum.SetPackageName("stringr")
        clsTextComponentsMaximum.SetRCommand("str_split")
        clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
        clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)

        clsSquishFunction.SetPackageName("stringr")
        clsSquishFunction.SetRCommand("str_squish")

        clsTextComponentsFixed.SetAssignTo(ucrSaveColumn.GetText(), strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveColumn.GetText())
        clsTextComponentsMaximum.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsBinaryColumns.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveColumn.AddAdditionalRCode(clsTextComponentsMaximum, iAdditionalPairNo:=1)
        ucrSaveColumn.AddAdditionalRCode(clsBinaryColumns, iAdditionalPairNo:=2)

        ucrInputPattern.SetRCode(clsPatternDummyFunction, bReset)
        ucrNudPieces.SetRCode(clsTextComponentsFixed, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsSplitDummyFunction, bReset)
        ucrPnlSplitText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlTextComponents.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveColumn.SetRCode(clsTextComponentsFixed, bReset)
        SetTextSplittingParameters()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSplitTextColumn.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso ((rdoTextComponents.Checked AndAlso ucrNudPieces.GetText <> "" AndAlso ucrSaveColumn.IsComplete()) OrElse rdoBinaryColumns.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
        sdgConstructRegexExpression.ucrReceiverForRegex.Clear()
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumSplitMode
            Case SplitMode.Prepare
                ucrBase.iHelpTopicID = 344
            Case SplitMode.Climatic
                ucrBase.iHelpTopicID = 601
        End Select
    End Sub


    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputRegexPattern.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrPnlSplitText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSplitText.ControlValueChanged
        SetVisibleAddKeyboardButton()
        ChangeParametersValues()
        SetBaseFunction()
    End Sub

    Private Sub ucrPnlTextComponents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextComponents.ControlValueChanged
        ChangeParametersValues()
        SetBaseFunction()
    End Sub

    Private Sub SetVisibleAddKeyboardButton()
        If rdoBinaryColumns.Checked Then
            cmdAddkeyboard.Visible = False
        Else
            cmdAddkeyboard.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
        End If
    End Sub

    Private Sub ChangeParametersValues()
        Dim strPattern As String

        If dctPatternPairs.ContainsKey(ucrInputPattern.GetText) Then
            strPattern = dctPatternPairs(ucrInputPattern.GetText)
        Else
            strPattern = Chr(34) & ucrInputPattern.GetText & Chr(34)
        End If
        clsTextComponentsFixed.RemoveParameterByName("pattern")
        clsTextComponentsMaximum.RemoveParameterByName("pattern")
        clsBinaryColumns.AddParameter("split.char", strPattern, iPosition:=1)
        If ucrChkIncludeRegularExpressions.Checked Then
            clsTextComponentsFixed.AddParameter("pattern", Chr(34) & ucrInputRegexPattern.GetText & Chr(34), iPosition:=1)
            clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & ucrInputRegexPattern.GetText & Chr(34), iPosition:=1)
        Else
            clsStringCollFunction.AddParameter("pattern", strPattern, iPosition:=0)
            clsTextComponentsFixed.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
            clsTextComponentsMaximum.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoBinaryColumns.Checked Then
            cmdAddkeyboard.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
        Else
            If rdoFixedNumberOfComponents.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
            ElseIf rdoMaximumNumberOfComponents.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsMaximum)
            End If
        End If
        SetTextSplittingParameters()
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged, ucrReceiverSplitTextColumn.ControlValueChanged, ucrInputPattern.ControlValueChanged, ucrInputRegexPattern.ControlValueChanged
        clsCurrentNewColumnFunction = ucrReceiverSplitTextColumn.GetVariables()
        clsCurrentNewColumnFunction.SetAssignTo(ucrReceiverSplitTextColumn.GetVariableNames(False))

        ChangeParametersValues()
        SetVisibleAddKeyboardButton()
        SetTextSplittingParameters()
    End Sub

    Private Sub SetTextSplittingParameters()
        clsSquishFunction.RemoveParameterByName("split")
        clsTextComponentsMaximum.RemoveParameterByName("string")
        clsTextComponentsFixed.RemoveParameterByName("string")
        clsBinaryColumns.RemoveParameterByName("string")
        Select Case ucrInputPattern.GetText()
            Case "Spaces ( )"
                clsSquishFunction.AddParameter("split", clsRFunctionParameter:=clsCurrentNewColumnFunction, bIncludeArgumentName:=False, iPosition:=0)
                clsTextComponentsFixed.AddParameter("string", clsRFunctionParameter:=clsSquishFunction, iPosition:=0)
                clsTextComponentsMaximum.AddParameter("string", clsRFunctionParameter:=clsSquishFunction, iPosition:=0)
                clsBinaryColumns.AddParameter("string", clsRFunctionParameter:=clsSquishFunction, iPosition:=0)
            Case Else
                clsTextComponentsFixed.AddParameter("string", clsRFunctionParameter:=clsCurrentNewColumnFunction, iPosition:=0)
                clsTextComponentsMaximum.AddParameter("string", clsRFunctionParameter:=clsCurrentNewColumnFunction, iPosition:=0)
                clsBinaryColumns.AddParameter("string", clsRFunctionParameter:=clsCurrentNewColumnFunction, iPosition:=0)
        End Select
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrPnlSplitText.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class