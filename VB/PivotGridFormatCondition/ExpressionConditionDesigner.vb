Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Design
Imports DevExpress.XtraPivotGrid

Namespace FormatCondititonsDesigner
	Partial Public Class ExpressionConditionDesigner
		Inherits DevExpress.XtraEditors.XtraForm
		Private privateSourcePivot As PivotGridControl
		Protected Friend Property SourcePivot() As PivotGridControl
			Get
				Return privateSourcePivot
			End Get
			Set(ByVal value As PivotGridControl)
				privateSourcePivot = value
			End Set
		End Property
		Private privateSourceField As PivotGridField
		Protected Friend Property SourceField() As PivotGridField
			Get
				Return privateSourceField
			End Get
			Set(ByVal value As PivotGridField)
				privateSourceField = value
			End Set
		End Property


		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ExpressionConditionDesigner_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Text = String.Format("Expression condition for field: [{0}]", SourceField.Name)
			LoadCondititons()
			UpdateEditors()
		End Sub

		Private Sub LoadCondititons()
			listBoxControlExpressions.Items.Clear()
			For Each item As PivotGridStyleFormatCondition In SourcePivot.FormatConditions
                If item.Field.Name = SourceField.Name AndAlso item.Condition = FormatConditionEnum.Expression Then
					AddItemToListBox(item)
				End If
			Next item
		End Sub

		Private Sub listBoxControlExpressions_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControlExpressions.MouseDoubleClick
			Dim selectedItem As ItemCondition = TryCast(listBoxControlExpressions.SelectedItem, ItemCondition)
			If selectedItem IsNot Nothing Then
				Using form As ExpressionEditorForm = New ConditionExpressionEditorForm(selectedItem.Condition, Nothing)
					form.StartPosition = FormStartPosition.CenterParent
					If form.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
						selectedItem.Condition.Condition = FormatConditionEnum.Expression
						selectedItem.Condition.Expression = form.Expression
					End If
				End Using
			End If
			listBoxControlExpressions.Refresh()
		End Sub

		Private Sub listBoxControlExpressions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControlExpressions.SelectedIndexChanged
			Dim selectedItem As ItemCondition = TryCast(listBoxControlExpressions.SelectedItem, ItemCondition)
			propertyGridControlAppearance.SelectedObject = If(selectedItem Is Nothing, Nothing, selectedItem.Condition.Appearance)
			checkEditApplyToCell.EditValue = If(selectedItem Is Nothing, False, CBool(selectedItem.Condition.ApplyToCell))
			checkEditApplyToTotal.EditValue = If(selectedItem Is Nothing, False, CBool(selectedItem.Condition.ApplyToTotalCell))
			checkEditApplyToGrandTotal.EditValue = If(selectedItem Is Nothing, False, CBool(selectedItem.Condition.ApplyToGrandTotalCell))
			UpdateEditors()
		End Sub

		Private Sub UpdateEditors()
			Dim isEnabled As Boolean = listBoxControlExpressions.Items.Count > 0
			simpleButtonRemove.Enabled = isEnabled
			propertyGridControlAppearance.Enabled = isEnabled
			checkEditApplyToCell.Enabled = isEnabled
			checkEditApplyToTotal.Enabled = isEnabled
			checkEditApplyToGrandTotal.Enabled = isEnabled
		End Sub

		Private Sub simpleButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonAdd.Click
			If SourcePivot Is Nothing Then
				Return
			End If
			listBoxControlExpressions.Items.BeginUpdate()
			CreateNewFormatCondition()
			listBoxControlExpressions.Items.EndUpdate()
		End Sub

		Private Sub CreateNewFormatCondition()
			Dim item As New PivotGridStyleFormatCondition()
			item.Field = SourceField
			item.Condition = FormatConditionEnum.None
			SourcePivot.FormatConditions.Add(item)
			AddItemToListBox(item)
		End Sub

		Private Sub AddItemToListBox(ByVal item As PivotGridStyleFormatCondition)
			Dim newItemCondition As New ItemCondition(item)
			listBoxControlExpressions.Items.Add(newItemCondition)
			listBoxControlExpressions.SelectedItem = newItemCondition
		End Sub

		Private Sub simpleButtonRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRemove.Click
			If SourcePivot Is Nothing Then
				Return
			End If
			RemoveFormatCondition()
		End Sub

		Private Sub RemoveFormatCondition()
			Dim condition As ItemCondition = TryCast(listBoxControlExpressions.SelectedItem, ItemCondition)
			listBoxControlExpressions.Items.Remove(listBoxControlExpressions.SelectedItem)
			SourcePivot.FormatConditions.Remove(condition.Condition)
		End Sub

		Private Sub checkEditApplyToCell_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditApplyToCell.EditValueChanged
			If listBoxControlExpressions.SelectedItem IsNot Nothing Then
				TryCast(listBoxControlExpressions.SelectedItem, ItemCondition).Condition.ApplyToCell = CBool(checkEditApplyToCell.EditValue)
			End If
		End Sub
	End Class
End Namespace