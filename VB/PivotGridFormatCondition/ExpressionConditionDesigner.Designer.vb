Imports Microsoft.VisualBasic
Imports System
Namespace FormatCondititonsDesigner
	Partial Public Class ExpressionConditionDesigner
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.listBoxControlExpressions = New DevExpress.XtraEditors.ListBoxControl()
			Me.simpleButtonAdd = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButtonRemove = New DevExpress.XtraEditors.SimpleButton()
			Me.propertyGridControlAppearance = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.labelControlAppearance = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditApplyToCell = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditApplyToTotal = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditApplyToGrandTotal = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.listBoxControlExpressions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControlAppearance, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditApplyToCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditApplyToTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditApplyToGrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControlExpressions
			' 
			Me.listBoxControlExpressions.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.listBoxControlExpressions.Location = New System.Drawing.Point(8, 33)
			Me.listBoxControlExpressions.Name = "listBoxControlExpressions"
			Me.listBoxControlExpressions.Size = New System.Drawing.Size(416, 157)
			Me.listBoxControlExpressions.TabIndex = 0
'			Me.listBoxControlExpressions.SelectedIndexChanged += New System.EventHandler(Me.listBoxControlExpressions_SelectedIndexChanged);
'			Me.listBoxControlExpressions.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.listBoxControlExpressions_MouseDoubleClick);
			' 
			' simpleButtonAdd
			' 
			Me.simpleButtonAdd.Location = New System.Drawing.Point(7, 5)
			Me.simpleButtonAdd.Name = "simpleButtonAdd"
			Me.simpleButtonAdd.Size = New System.Drawing.Size(114, 22)
			Me.simpleButtonAdd.TabIndex = 1
			Me.simpleButtonAdd.Text = "Add expression"
'			Me.simpleButtonAdd.Click += New System.EventHandler(Me.simpleButtonAdd_Click);
			' 
			' simpleButtonRemove
			' 
			Me.simpleButtonRemove.Location = New System.Drawing.Point(127, 5)
			Me.simpleButtonRemove.Name = "simpleButtonRemove"
			Me.simpleButtonRemove.Size = New System.Drawing.Size(114, 22)
			Me.simpleButtonRemove.TabIndex = 2
			Me.simpleButtonRemove.Text = "Remove expression"
'			Me.simpleButtonRemove.Click += New System.EventHandler(Me.simpleButtonRemove_Click);
			' 
			' propertyGridControlAppearance
			' 
			Me.propertyGridControlAppearance.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.propertyGridControlAppearance.Location = New System.Drawing.Point(9, 209)
			Me.propertyGridControlAppearance.Name = "propertyGridControlAppearance"
			Me.propertyGridControlAppearance.OptionsView.ShowRootCategories = False
			Me.propertyGridControlAppearance.Size = New System.Drawing.Size(413, 92)
			Me.propertyGridControlAppearance.TabIndex = 3
			' 
			' labelControlAppearance
			' 
			Me.labelControlAppearance.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.labelControlAppearance.Location = New System.Drawing.Point(12, 193)
			Me.labelControlAppearance.Name = "labelControlAppearance"
			Me.labelControlAppearance.Size = New System.Drawing.Size(62, 13)
			Me.labelControlAppearance.TabIndex = 4
			Me.labelControlAppearance.Text = "Appearance:"
			' 
			' checkEditApplyToCell
			' 
			Me.checkEditApplyToCell.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkEditApplyToCell.Location = New System.Drawing.Point(9, 303)
			Me.checkEditApplyToCell.Name = "checkEditApplyToCell"
			Me.checkEditApplyToCell.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.checkEditApplyToCell.Properties.Appearance.Options.UseFont = True
			Me.checkEditApplyToCell.Properties.Caption = "Apply to cell"
			Me.checkEditApplyToCell.Size = New System.Drawing.Size(149, 19)
			Me.checkEditApplyToCell.TabIndex = 5
'			Me.checkEditApplyToCell.EditValueChanged += New System.EventHandler(Me.checkEditApplyToCell_EditValueChanged);
			' 
			' checkEditApplyToTotal
			' 
			Me.checkEditApplyToTotal.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkEditApplyToTotal.Location = New System.Drawing.Point(9, 324)
			Me.checkEditApplyToTotal.Name = "checkEditApplyToTotal"
			Me.checkEditApplyToTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.checkEditApplyToTotal.Properties.Appearance.Options.UseFont = True
			Me.checkEditApplyToTotal.Properties.Caption = "Apply to total"
			Me.checkEditApplyToTotal.Size = New System.Drawing.Size(149, 19)
			Me.checkEditApplyToTotal.TabIndex = 6
			' 
			' checkEditApplyToGrandTotal
			' 
			Me.checkEditApplyToGrandTotal.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkEditApplyToGrandTotal.Location = New System.Drawing.Point(9, 345)
			Me.checkEditApplyToGrandTotal.Name = "checkEditApplyToGrandTotal"
			Me.checkEditApplyToGrandTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.checkEditApplyToGrandTotal.Properties.Appearance.Options.UseFont = True
			Me.checkEditApplyToGrandTotal.Properties.Caption = "Apply to grand total"
			Me.checkEditApplyToGrandTotal.Size = New System.Drawing.Size(149, 19)
			Me.checkEditApplyToGrandTotal.TabIndex = 7
			' 
			' ExpressionConditionDesigner
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(436, 376)
			Me.Controls.Add(Me.checkEditApplyToGrandTotal)
			Me.Controls.Add(Me.checkEditApplyToTotal)
			Me.Controls.Add(Me.checkEditApplyToCell)
			Me.Controls.Add(Me.labelControlAppearance)
			Me.Controls.Add(Me.propertyGridControlAppearance)
			Me.Controls.Add(Me.simpleButtonRemove)
			Me.Controls.Add(Me.simpleButtonAdd)
			Me.Controls.Add(Me.listBoxControlExpressions)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ExpressionConditionDesigner"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "ExpressionConditionDesigner"
'			Me.Load += New System.EventHandler(Me.ExpressionConditionDesigner_Load);
			CType(Me.listBoxControlExpressions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControlAppearance, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditApplyToCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditApplyToTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditApplyToGrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents listBoxControlExpressions As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents simpleButtonAdd As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButtonRemove As DevExpress.XtraEditors.SimpleButton
		Private propertyGridControlAppearance As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private labelControlAppearance As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditApplyToCell As DevExpress.XtraEditors.CheckEdit
		Private checkEditApplyToTotal As DevExpress.XtraEditors.CheckEdit
		Private checkEditApplyToGrandTotal As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace