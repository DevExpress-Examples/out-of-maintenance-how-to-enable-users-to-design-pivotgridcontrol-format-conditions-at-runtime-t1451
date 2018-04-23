Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Namespace FormatCondititonsDesigner
	Friend Class ViewFormatDesigner
		' private members
		Private Pivot As PivotGridControl
        Protected field As PivotGridField
		Protected simpleConditionDesigner As SimpleConditionDesigner
		Protected expressionConditionDesigner As ExpressionConditionDesigner

		' constructors

		Public Sub New(ByVal PivotGrid As PivotGridControl)
			Pivot = PivotGrid
			AddHandler Pivot.PopupMenuShowing, AddressOf PivotGridControl_PopupMenuShowing

		End Sub

		Private Sub PivotGridControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
			If e.MenuType = PivotGridMenuType.FieldValue AndAlso e.HitInfo.ValueInfo IsNot Nothing Then
				e.Menu.Items.Add(CreateMenuItem(CreateCaptionForCondition(e.HitInfo.ValueInfo.DataField, True), "Simple"))
				e.Menu.Items.Add(CreateMenuItem(CreateCaptionForCondition(e.HitInfo.ValueInfo.DataField, False), "Expression"))
				field = e.HitInfo.ValueInfo.DataField
			End If
		End Sub

		Private Function CreateMenuItem(ByVal caption As String, ByVal stringForTag As String) As DXMenuCheckItem
			Dim item As New DXMenuCheckItem(caption, False, Nothing, New EventHandler(AddressOf OnMenuItemClick))
			item.Tag = stringForTag
			Return item
		End Function

		' Menu item click handler.
		Private Sub OnMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			If Pivot IsNot Nothing AndAlso field IsNot Nothing Then
				Dim currentTag As String = CStr((TryCast(sender, DXMenuCheckItem)).Tag)
				Select Case currentTag
					Case "Simple"
							ShowSimpleCondititonDesigner()
							Exit Select
					Case "Expression"
							ShowExpressionCondititonDesigner()
							Exit Select
					Case Else
				End Select
			End If
		End Sub

		Private Sub ShowSimpleCondititonDesigner()
			If simpleConditionDesigner Is Nothing Then
				simpleConditionDesigner = New SimpleConditionDesigner()
			End If
			simpleConditionDesigner.SourcePivot = Pivot
			simpleConditionDesigner.SourceField = field
			simpleConditionDesigner.ShowDialog()
		End Sub

		Private Sub ShowExpressionCondititonDesigner()
			If expressionConditionDesigner Is Nothing Then
				expressionConditionDesigner = New ExpressionConditionDesigner()
			End If
			expressionConditionDesigner.SourcePivot = Pivot
			expressionConditionDesigner.SourceField = field
			expressionConditionDesigner.ShowDialog()
		End Sub

		Private Function CreateCaptionForCondition(ByVal field As PivotGridField, ByVal IsSimple As Boolean) As String
			Dim iConditionsCount As Integer = 0
			For Each item As PivotGridStyleFormatCondition In Pivot.FormatConditions
				If item.Field.Name = field.Name Then
					If item.Condition = FormatConditionEnum.Expression AndAlso (Not IsSimple) Then
						iConditionsCount += 1
					End If
					If Not item.Condition = FormatConditionEnum.Expression AndAlso IsSimple Then
						iConditionsCount += 1
					End If
				End If

			Next item
			Return String.Format("{0} conditions editor ({1})",If(IsSimple, "Simple", "Expression"), iConditionsCount)
		End Function        

	End Class
End Namespace
