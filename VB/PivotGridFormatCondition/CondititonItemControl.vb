Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid

Namespace FormatCondititonsDesigner
	Partial Public Class CondititonItemControl
		Inherits UserControl
		Private basEditValue1 As BaseEdit
		Private basEditValue2 As BaseEdit
		Private currentColumnType As Type = Nothing
		Private currentFormatCondition As PivotGridStyleFormatCondition

		Public Event RefreshValues As EventHandler

		Public Sub New()
			InitializeComponent()
			InitConditions()
			AddHandler comboBoxEditCondititon.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
			AddHandler checkEditApplyToCell.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
			AddHandler checkEditApplyToTotal.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
			AddHandler checkEditApplyToGrandTotal.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
		End Sub

		Public Sub Init(ByVal item As ItemCondition)
			If item IsNot Nothing Then
				currentFormatCondition = item.Condition
				CreateValues(item.Condition.Field.DataType)
			Else
				currentFormatCondition = Nothing
			End If
			RefreshEditorsValues(item)
			UpdateEditors(item)
		End Sub

		Private Sub UpdateEditors(ByVal item As ItemCondition)
			comboBoxEditCondititon.Enabled = CBool(item IsNot Nothing)
			propertyGridControlAppearance.Enabled = CBool(item IsNot Nothing)
			If basEditValue1 IsNot Nothing Then
				basEditValue1.Visible = CBool(item IsNot Nothing)
			End If
			If basEditValue1 IsNot Nothing Then
				basEditValue2.Visible = CBool(item IsNot Nothing)
			End If
			checkEditApplyToCell.Enabled = CBool(item IsNot Nothing)
		End Sub

		Private Sub CreateValues(ByVal type As Type)
			If type IsNot currentColumnType Then
				currentColumnType = type
				DisposeEditors()
				If type.Equals(GetType(Boolean)) Then
					CreateEditorsAsCheckEdit()
				ElseIf type.IsValueType Then
					CreateEditorsAsSpinEdit(type)
				Else
					basEditValue1 = New TextEdit()
					basEditValue2 = New TextEdit()
				End If
				AddEditors()
				CalculateEditorsSizeLocation(type)
			End If
		End Sub

		Private Sub CurrentEditor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If currentFormatCondition IsNot Nothing Then
				Dim currentEditor As BaseEdit = TryCast(sender, BaseEdit)
				Select Case currentEditor.Name
					Case "basEditValue1"
						currentFormatCondition.Value1 = currentEditor.EditValue
					Case "basEditValue2"
						currentFormatCondition.Value2 = currentEditor.EditValue
					Case "checkEditApplyToCell"
						currentFormatCondition.ApplyToCell = CBool(currentEditor.EditValue)
					Case "checkEditApplyToTotal"
						currentFormatCondition.ApplyToTotalCell = CBool(currentEditor.EditValue)
					Case "checkEditApplyToGrandTotal"
						currentFormatCondition.ApplyToGrandTotalCell = CBool(currentEditor.EditValue)
					Case "comboBoxEditCondititon"
						currentFormatCondition.Condition = CType(currentEditor.EditValue, FormatConditionEnum)
				End Select
				RaiseEvent RefreshValues(Me, New EventArgs())
			End If
		End Sub

		Private Sub RefreshEditorsValues(ByVal item As ItemCondition)
			comboBoxEditCondititon.EditValue = If(item Is Nothing, FormatConditionEnum.Equal, item.Condition.Condition)
			If basEditValue1 IsNot Nothing AndAlso basEditValue2 IsNot Nothing Then
				basEditValue1.EditValue = If(item Is Nothing, 0, item.Condition.Value1)
				basEditValue2.EditValue = If(item Is Nothing, 0, item.Condition.Value2)
			End If
			checkEditApplyToCell.EditValue = If(item Is Nothing, False, item.Condition.ApplyToCell)
			checkEditApplyToTotal.EditValue = If(item Is Nothing, False, item.Condition.ApplyToTotalCell)
			checkEditApplyToGrandTotal.EditValue = If(item Is Nothing, False, item.Condition.ApplyToGrandTotalCell)
			propertyGridControlAppearance.SelectedObject = If(item Is Nothing, Nothing, item.Condition.Appearance)
		End Sub

		Private Sub InitConditions()
			Dim values As Array = System.Enum.GetValues(GetType(FormatConditionEnum))
			For Each item In values
				If CType(item, FormatConditionEnum) <> FormatConditionEnum.Expression Then
					comboBoxEditCondititon.Properties.Items.Add(item)
				End If
			Next item
		End Sub

		Private Sub DisposeEditors()
			If basEditValue1 IsNot Nothing AndAlso basEditValue2 IsNot Nothing Then
				RemoveHandler basEditValue1.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
				RemoveHandler basEditValue2.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
				Me.Controls.Remove(basEditValue1)
				Me.Controls.Remove(basEditValue2)
			End If
		End Sub

		Private Sub AddEditors()
			basEditValue1.Name = "basEditValue1"
			basEditValue2.Name = "basEditValue2"
			Me.Controls.Add(basEditValue1)
			Me.Controls.Add(basEditValue2)
			AddHandler basEditValue1.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
			AddHandler basEditValue2.EditValueChanged, AddressOf CurrentEditor_EditValueChanged
		End Sub

		Private Sub CreateEditorsAsCheckEdit()
			basEditValue1 = New CheckEdit()
			basEditValue2 = New CheckEdit()
			basEditValue1.Text = "Value1"
			basEditValue2.Text = "Value2"
			labelControlValue2.Visible = False
			labelControlValue1.Visible = labelControlValue2.Visible
		End Sub

		Private Sub CreateEditorsAsSpinEdit(ByVal type As Type)
			basEditValue1 = New SpinEdit()
			basEditValue2 = New SpinEdit()
			If "System.Int16System.Int32System.Int64System.Byte".IndexOf(type.ToString()) > -1 Then
				TryCast(basEditValue1, SpinEdit).Properties.IsFloatValue = False
				TryCast(basEditValue2, SpinEdit).Properties.IsFloatValue = False
			End If
		End Sub

		Private Sub CalculateEditorsSizeLocation(ByVal type As Type)
			basEditValue2.Size = New Size(comboBoxEditCondititon.Width, comboBoxEditCondititon.Height)
			basEditValue1.Size = basEditValue2.Size
			If type.Equals(GetType(Boolean)) Then
				basEditValue1.Location = labelControlValue1.Location
				basEditValue2.Location = labelControlValue2.Location
			Else
				basEditValue1.Location = New Point(comboBoxEditCondititon.Location.X, labelControlValue1.Location.Y)
				basEditValue2.Location = New Point(comboBoxEditCondititon.Location.X, labelControlValue2.Location.Y)
			End If
		End Sub
	End Class
End Namespace
