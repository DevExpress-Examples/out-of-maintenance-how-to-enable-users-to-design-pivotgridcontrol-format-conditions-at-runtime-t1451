Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Namespace FormatCondititonsDesigner
	Partial Public Class SimpleConditionDesigner
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
			AddHandler listBoxConditions.SelectedIndexChanged, AddressOf listBoxConditions_SelectedIndexChanged
		End Sub

		Private Sub listBoxConditions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedItem As ItemCondition = TryCast(listBoxConditions.SelectedItem, ItemCondition)
			condititonItemControlMain.Init(selectedItem)
			simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0
		End Sub

		Private Sub SimpleConditionDesigner_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Text = String.Format("Simple condition for field: [{0}]", SourceField.Name)
			LoadCondititons()
			simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0
		End Sub

		Private Sub LoadCondititons()
			listBoxConditions.Items.Clear()
			condititonItemControlMain.Init(Nothing)
			For Each item As PivotGridStyleFormatCondition In SourcePivot.FormatConditions
				If item.Field.Name = SourceField.Name AndAlso Not item.Condition = FormatConditionEnum.Expression Then
					AddItemToListBox(item)
				End If
			Next item
		End Sub

		Private Sub simpleButtonAddCondititon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonAddCondititon.Click
			If SourcePivot Is Nothing Then
				Return
			End If
			listBoxConditions.Items.BeginUpdate()
			CreateNewFormatCondition()
			listBoxConditions.Items.EndUpdate()
		End Sub

		Private Sub CreateNewFormatCondition()
			Dim item As New PivotGridStyleFormatCondition()
			item.Field = SourceField
			SourcePivot.FormatConditions.Add(item)
			AddItemToListBox(item)
		End Sub

		Private Sub condititonItemControlMain_RefreshValues(ByVal sender As Object, ByVal e As EventArgs) Handles condititonItemControlMain.RefreshValues
			listBoxConditions.Refresh()
		End Sub

		Private Sub simpleButtonRemoveCondition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRemoveCondition.Click
			If SourcePivot Is Nothing Then
				Return
			End If
			Dim condition As ItemCondition = TryCast(listBoxConditions.SelectedItem, ItemCondition)
			listBoxConditions.Items.Remove(listBoxConditions.SelectedItem)
			SourcePivot.FormatConditions.Remove(condition.Condition)
		End Sub

		Protected Sub AddItemToListBox(ByVal newItem As PivotGridStyleFormatCondition)
			Dim newItemCondition As New ItemCondition(newItem)
			listBoxConditions.Items.Add(newItemCondition)
			listBoxConditions.SelectedItem = newItemCondition
		End Sub
	End Class
End Namespace