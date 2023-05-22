' R- Instat
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

Imports instat
Imports instat.Translations
Public Class dlgHistogram
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsHistAesFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private bResetHistLayerSubdialog As Boolean = True
    Private clsPercentage As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    'Private clsRgeomBarFunction As New RFunction
    Private clsGeomTextFunction As New RFunction
    Private clsRgeomHistFunction As New RFunction
    'Private clsForecatsReverse As New RFunction
    'Private clsForecatsInfreq As New RFunction
    Private clsForecatsInfreqValue As New RFunction
    Private clsForecatsReverseValue As New RFunction
    'Private clsReorderFunction As New RFunction
    Private clsReorderFunctionValue As New RFunction
    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strGeomParameterNames() As String = {strFirstParameterName}

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If

        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
        'DialogueSize()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctStats As New Dictionary(Of String, String)
        Dim dctPositionPairs As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 435

        ucrPnlOptions.AddRadioButton(rdoHistogram)
        ucrPnlOptions.AddRadioButton(rdoDensity_ridges)
        ucrPnlOptions.AddRadioButton(rdoFrequencyPolygon)

        ucrPnlOptions.AddFunctionNamesCondition(rdoHistogram, {"geom_histogram", "geom_dotplot"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoDensity_ridges, {"geom_density", "geom_density_ridges"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequencyPolygon, "geom_freqpoly")

        ucrHistogramSelector.SetParameter(New RParameter("data", 0))
        ucrHistogramSelector.SetParameterIsrfunction()

        ucrFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        'can put in colour for density and polygon but fill for Histogram
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrInputStats.SetParameter(New RParameter("y", 0))
        dctStats.Add("Counts", "stat(count)")
        dctStats.Add("Fractions", "stat(count/sum(count))")
        dctStats.Add("Scaled Fractions", "stat(count/max(count))")
        ucrInputStats.SetDropDownStyleAsNonEditable()
        ucrInputStats.SetItems(dctStats)
        ucrInputStats.SetLinkedDisplayControl(lblStats)
        ucrInputStats.AddToLinkedControls(ucrChkPercentages, {"Fractions"}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputAddReorder.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputAddReorder.SetDropDownStyleAsNonEditable()
        ucrInputAddReorder.SetLinkedDisplayControl(lblReorder)

        'ucrInputReorderX.SetItems({strAscending, strDescending, strReverse, strNone})
        'ucrInputReorderX.SetDropDownStyleAsNonEditable()

        ucrInputBarChartPositions.SetLinkedDisplayControl(lblPosition)

        ucrInputBarChartPositions.SetParameter(New RParameter("position", 0))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        ucrInputBarChartPositions.SetItems(dctPositionPairs)
        ucrInputBarChartPositions.SetDropDownStyleAsNonEditable()
        ucrInputBarChartPositions.SetRDefault(Chr(34) & "stack" & Chr(34))

        ucrChkPercentages.SetText("percentages")
        ucrChkPercentages.AddParameterPresentCondition(True, "scale")
        ucrChkPercentages.AddParameterPresentCondition(False, "scale", False)

        ucrChkDisplayAsDotPlot.SetText("Display as Dotplot")
        ucrChkDisplayAsDotPlot.AddFunctionNamesCondition(True, "geom_dotplot")
        ucrChkDisplayAsDotPlot.AddFunctionNamesCondition(False, "geom_dotplot", False)

        ucrChkRidges.SetText("Density Ridges")
        ucrChkRidges.AddFunctionNamesCondition(True, "geom_density_ridges")
        ucrChkRidges.AddFunctionNamesCondition(False, "geom_density_ridges", False)

        ucrVariablesAsFactorforHist.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorforHist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforHist.Selector = ucrHistogramSelector
        ucrVariablesAsFactorforHist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforHist.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforHist.bWithQuotes = False
        ucrVariablesAsFactorforHist.SetParameterIsString()

        ucrPnlOptions.AddToLinkedControls({ucrChkDisplayAsDotPlot}, {rdoHistogram}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkRidges}, {rdoDensity_ridges}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRidges.AddToLinkedControls(ucrInputStats, {"FALSE"}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveHist.SetPrefix("histogram")
        ucrSaveHist.SetDataFrameSelector(ucrHistogramSelector.ucrAvailableDataFrames)
        ucrSaveHist.SetIsComboBox()
        ucrSaveHist.SetCheckBoxText("Save Graph")
        ucrSaveHist.SetSaveTypeAsGraph()
        ucrSaveHist.SetAssignToIfUncheckedValue("last_graph")
        'DialogueSize()
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsHistAesFunction = New RFunction
        clsPercentage = New RFunction
        'clsRgeomBarFunction = New RFunction
        clsRgeomHistFunction = New RFunction
        clsGeomTextFunction = New RFunction
        'clsForecatsReverse = New RFunction
        'clsForecatsInfreq = New RFunction
        clsForecatsInfreqValue = New RFunction
        clsForecatsReverseValue = New RFunction
        'clsReorderFunction = New RFunction
        clsReorderFunctionValue = New RFunction
        ucrHistogramSelector.Reset()
        ucrHistogramSelector.SetGgplotFunction(clsBaseOperator)
        ucrSaveHist.Reset()
        ucrVariablesAsFactorforHist.SetMeAsReceiver()
        bResetSubdialog = True
        bResetHistLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsRgeomHistFunction, iPosition:=2)
        'clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsHistAesFunction.SetPackageName("ggplot2")
        clsHistAesFunction.SetRCommand("aes")
        clsHistAesFunction.AddParameter("y", "stat(count)", iPosition:=0)

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_histogram")
        clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)

        clsPercentage.SetPackageName("scales")
        clsPercentage.SetRCommand("percent_format")

        'clsForecatsReverse.SetPackageName("forcats")
        'clsForecatsReverse.SetRCommand("fct_rev")

        clsForecatsInfreqValue.SetPackageName("forcats")
        clsForecatsInfreqValue.SetRCommand("fct_infreq")

        'clsForecatsInfreq.SetPackageName("forcats")
        'clsForecatsInfreq.SetRCommand("fct_infreq")

        clsReorderFunctionValue.SetRCommand("reorder")
        'clsReorderFunction.SetRCommand("reorder")

        'ucrInputReorderX.SetText(strNone)
        'ucrInputReorderX.bUpdateRCodeFromControl = True


        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        ucrInputAddReorder.SetText(strNone)

        clsRgeomHistFunction.SetPackageName("ggplot2")
        clsRgeomHistFunction.SetRCommand("geom_histogram")
        clsRgeomHistFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=0)
        'clsRgeomHistFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)

        'clsGeomTextFunction.SetPackageName("ggplot2")
        'clsGeomTextFunction.SetRCommand("geom_text")
        ''clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
        'clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        'clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        'clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)


        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveHist.SetRCode(clsBaseOperator, bReset)
        ucrHistogramSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkPercentages.SetRCode(clsYScalecontinuousFunction, bReset)
        ucrChkDisplayAsDotPlot.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkRidges.SetRCode(clsRgeomPlotFunction, bReset)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorforHist.SetRCode(clsRaesFunction, bReset)
        ucrInputBarChartPositions.SetRCode(clsRgeomHistFunction, bReset)
        ucrFactorReceiver.AddAdditionalCodeParameterPair(clsReorderFunctionValue, New RParameter("x", 0), iAdditionalPairNo:=2)
        If bReset Then
            ucrInputStats.SetRCode(clsHistAesFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        'Tests when ok can be enabled
        If ucrVariablesAsFactorforHist.IsEmpty OrElse Not ucrSaveHist.IsComplete OrElse (ucrChkRidges.Checked AndAlso (ucrFactorReceiver.IsEmpty OrElse ucrFactorReceiver.Enabled = False)) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetDialogOptions()
        clsHistAesFunction.RemoveParameterByName("x")
        clsHistAesFunction.RemoveParameterByName("y")
        clsHistAesFunction.AddParameter("y", "stat(count)", iPosition:=0)
        clsRgeomPlotFunction.SetPackageName("ggplot2")
        If rdoHistogram.Checked Then
            If ucrChkDisplayAsDotPlot.Checked Then
                clsRgeomPlotFunction.SetRCommand("geom_dotplot")
            Else
                clsRgeomPlotFunction.SetRCommand("geom_histogram")
            End If
            ucrInputBarChartPositions.Visible = Not ucrFactorReceiver.IsEmpty()
            ucrFactorReceiver.ChangeParameterName("fill")
            If ucrVariablesAsFactorforHist.bSingleVariable Then
                ucrInputAddReorder.Visible = Not ucrFactorReceiver.IsEmpty()
                If Not ucrInputAddReorder.Visible Then
                    ucrInputAddReorder.SetText(strNone)
                End If
            End If
            If Not ucrSaveHist.bUserTyped Then ucrSaveHist.SetPrefix("histogram")
            End If
            If rdoDensity_ridges.Checked Then
            If ucrChkRidges.Checked Then
                ucrFactorReceiver.ChangeParameterName("y")
                clsHistAesFunction.RemoveParameterByName("y")
                clsHistAesFunction.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorforHist.GetVariables(), iPosition:=1)
                clsHistAesFunction.AddParameter("y", clsRFunctionParameter:=ucrFactorReceiver.GetVariables(), iPosition:=2)
                clsRgeomPlotFunction.SetPackageName("ggridges")
                clsRgeomPlotFunction.SetRCommand("geom_density_ridges")
                If Not ucrSaveHist.bUserTyped Then
                    ucrSaveHist.SetPrefix("density_ridges")
                End If
            Else
                ucrFactorReceiver.ChangeParameterName("colour")
                clsRgeomPlotFunction.SetRCommand("geom_density")
                If Not ucrSaveHist.bUserTyped Then
                    ucrSaveHist.SetPrefix("density")
                End If
            End If
        ElseIf rdoFrequencyPolygon.Checked Then
            ucrFactorReceiver.ChangeParameterName("colour")
            clsRgeomPlotFunction.SetRCommand("geom_freqpoly")
            If Not ucrSaveHist.bUserTyped Then
                ucrSaveHist.SetPrefix("frequency_polygon")
            End If
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrPnlOptions_Control() Handles ucrPnlOptions.ControlValueChanged, ucrChkDisplayAsDotPlot.ControlValueChanged, ucrChkRidges.ControlValueChanged, ucrFactorReceiver.ControlValueChanged, ucrVariablesAsFactorforHist.ControlValueChanged
        toolStripMenuItemHistogramOptions.Enabled = rdoHistogram.Checked AndAlso Not ucrChkDisplayAsDotPlot.Checked
        toolStripMenuItemDotOptions.Enabled = rdoHistogram.Checked AndAlso ucrChkDisplayAsDotPlot.Checked
        toolStripMenuItemDensityOptions.Enabled = rdoDensity_ridges.Checked AndAlso Not ucrChkRidges.Checked
        toolStripMenuItemDensityRidgesOptions.Enabled = rdoDensity_ridges.Checked AndAlso ucrChkRidges.Checked
        toolStripMenuItemFrequencyPolygonOptions.Enabled = rdoFrequencyPolygon.Checked
        SetDialogOptions()
        'DialogueSize()
    End Sub

    Private Sub Adding_Percentages(ucrChangedControl As ucrCore) Handles ucrInputStats.ControlValueChanged, ucrChkPercentages.ControlValueChanged
        If ucrInputStats.GetText() = "Fractions" AndAlso ucrChkPercentages.Checked Then
            clsYScalecontinuousFunction.AddParameter("labels", clsRFunctionParameter:=clsPercentage)
            clsBaseOperator.AddParameter("scale", clsRFunctionParameter:=clsYScalecontinuousFunction)
        Else
            clsBaseOperator.RemoveParameterByName("scale")
        End If
    End Sub

    'TODO remove vbCr not compatible with other code
    Private Sub rdoHistogram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoHistogram.KeyPress
        If e.KeyChar = vbCr Then
            rdoHistogram.Checked = True
        End If
    End Sub

    Private Sub rdoDensity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoDensity_ridges.KeyPress
        If e.KeyChar = vbCr Then
            rdoDensity_ridges.Checked = True
        End If
    End Sub

    Private Sub rdoFrequencyPolygon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoFrequencyPolygon.KeyPress
        If e.KeyChar = vbCr Then
            rdoFrequencyPolygon.Checked = True
        End If
    End Sub

    Private Sub ucrVariablesAsFactorforHist_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorforHist.ControlValueChanged
        If Not ucrVariablesAsFactorforHist.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=0)
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction,
                         clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrHistogramSelector,
                         clsNewGlobalAesFunction:=clsRaesFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                         clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemHistogramOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemHistogramOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorforHist.bSingleVariable) Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf (clsParam.strArgumentName = "fill" AndAlso rdoHistogram.Checked) OrElse (clsParam.strArgumentName = "colour" AndAlso (rdoFrequencyPolygon.Checked OrElse (rdoDensity_ridges.Checked AndAlso Not ucrChkRidges.Checked))) OrElse (clsParam.strArgumentName = "y" AndAlso (rdoDensity_ridges.Checked AndAlso ucrChkRidges.Checked)) Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        'this is here because of the subdialog 
        clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)
        TestOkEnabled()
    End Sub

    Private Sub toolStripMenuItemDensityOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDensityOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub toolStripMenuItemDensityRidgesOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDensityRidgesOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub toolStripMenuItemFrequencyPolygonOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemFrequencyPolygonOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()

    End Sub
    Private Sub UpdateParameter()
        'Dim strChangedTextFreq As String = ucrInputReorderX.GetText()
        Dim strChangedTextValue As String = ucrInputAddReorder.GetText()
        'Dim strChangeTextReorder As String = ucrInputReorderValue.GetText()
        If rdoHistogram.Checked Then
            'clsForecatsInfreq.AddParameter("f", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=0)
            clsForecatsInfreqValue.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
            'Select Case strChangedTextFreq
            '    Case strAscending
            '        clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
            '        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
            '    Case strDescending
            '        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
            '    Case strReverse
            '        clsForecatsReverse.AddParameter("f", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            '        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
            'End Select
            Select Case strChangedTextValue
                Case strAscending
                    clsForecatsReverseValue.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=1)
                Case strDescending
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=1)
                Case strReverse
                    clsForecatsReverseValue.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=1)
            End Select

        Else
            'Select Case strChangeTextReorder
            '    Case strAscending
            '        clsReorderFunction.AddParameter("X", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            '        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
            '    Case strDescending
            '        clsReorderFunction.AddParameter("X", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            '        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
            '    Case strReverse
            '        clsForecatsReverse.AddParameter("f", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            '        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
            'End Select
            Select Case strChangedTextValue
                Case strAscending
                    clsReorderFunctionValue.AddParameter("X", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=1)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                Case strDescending
                    clsReorderFunctionValue.AddParameter("X", "-" & ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=1)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                Case strReverse
                    clsForecatsReverseValue.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
            End Select
        End If
    End Sub

    Private Sub ChangeParameterName()
        clsHistAesFunction.RemoveParameterByName("x")
        clsHistAesFunction.RemoveParameterByName("y")
        If rdoHistogram.Checked Then
            clsHistAesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
            clsHistAesFunction.AddParameter("y", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=1)
            clsHistAesFunction.AddParameter("fill", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=2)
            clsRgeomHistFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            If ucrVariablesAsFactorforHist.IsEmpty Then
                clsHistAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
            End If
            If ucrFactorReceiver.IsEmpty Then
                clsHistAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
            End If
        End If
        UpdateParameter()
    End Sub
    Private Sub SetGeomTextOptions()
        If ucrInputBarChartPositions.GetText = "Dodge" Then
            clsGeomTextFunction.AddParameter("position", "position_dodge(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Fill" Then
            clsGeomTextFunction.AddParameter("position", "position_fill(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Jitter" Then
            clsGeomTextFunction.AddParameter("position", "position_jitter(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack in reverse" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.5, reverse = TRUE)", iPosition:=2)
        Else
            clsGeomTextFunction.AddParameter("position", "position_identity()", iPosition:=2)
        End If
    End Sub

    Private Sub ucrInputBarChartPositions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBarChartPositions.ControlValueChanged
        SetGeomTextOptions()
    End Sub
    Private Sub toolStripMenuItemDotOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    'Private Sub DialogueSize()
    '    If rdoHistogram.Checked Then
    '        Me.Size = New Size(464, 409)
    '        Me.ucrSaveHist.Location = New Point(10, 284)
    '        Me.ucrBase.Location = New Point(10, 314)
    '    ElseIf rdoDensity_ridges.Checked Then
    '        Me.Size = New Size(464, 433)
    '        Me.ucrSaveHist.Location = New Point(10, 311)
    '        Me.ucrBase.Location = New Point(10, 334)
    '    Else
    '        Me.Size = New Size(464, 401)
    '        Me.ucrSaveHist.Location = New Point(10, 275)
    '        Me.ucrBase.Location = New Point(10, 305)
    '    End If
    'End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforHist.ControlContentsChanged, ucrSaveHist.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged, ucrChkRidges.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class