Imports Microsoft.VisualBasic
Imports System
Namespace FormatCondititonsDesigner
	Partial Public Class MainForm
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
        Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.CountriesDBDataSet1 = New countriesDBDataSet()
        Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOfficialName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCurrency1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCapital1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldArea1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPopulation1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLanguages1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CountriesTableAdapter1 = New countriesDBDataSetTableAdapters.CountriesTableAdapter()
        CType(Me.pivotGridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CountriesDBDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pivotGridControl1
        '
        Me.pivotGridControl1.DataMember = "Countries"
        Me.pivotGridControl1.DataSource = Me.CountriesDBDataSet1
        Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCountry1, Me.fieldOfficialName1, Me.fieldCurrency1, Me.fieldCapital1, Me.fieldArea1, Me.fieldPopulation1, Me.fieldLanguages1})
        Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.pivotGridControl1.Name = "pivotGridControl1"
        Me.pivotGridControl1.Size = New System.Drawing.Size(657, 456)
        Me.pivotGridControl1.TabIndex = 0
        '
        'CountriesDBDataSet1
        '
        Me.CountriesDBDataSet1.DataSetName = "countriesDBDataSet"
        Me.CountriesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldCountry1
        '
        Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCountry1.AreaIndex = 0
        Me.fieldCountry1.Caption = "Country"
        Me.fieldCountry1.FieldName = "Country"
        Me.fieldCountry1.Name = "fieldCountry1"
        '
        'fieldOfficialName1
        '
        Me.fieldOfficialName1.AreaIndex = 0
        Me.fieldOfficialName1.Caption = "Official Name"
        Me.fieldOfficialName1.FieldName = "OfficialName"
        Me.fieldOfficialName1.Name = "fieldOfficialName1"
        '
        'fieldCurrency1
        '
        Me.fieldCurrency1.AreaIndex = 1
        Me.fieldCurrency1.Caption = "Currency"
        Me.fieldCurrency1.FieldName = "Currency"
        Me.fieldCurrency1.Name = "fieldCurrency1"
        '
        'fieldCapital1
        '
        Me.fieldCapital1.AreaIndex = 2
        Me.fieldCapital1.Caption = "Capital"
        Me.fieldCapital1.FieldName = "Capital"
        Me.fieldCapital1.Name = "fieldCapital1"
        '
        'fieldArea1
        '
        Me.fieldArea1.AreaIndex = 3
        Me.fieldArea1.Caption = "Area"
        Me.fieldArea1.FieldName = "Area"
        Me.fieldArea1.Name = "fieldArea1"
        '
        'fieldPopulation1
        '
        Me.fieldPopulation1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPopulation1.AreaIndex = 0
        Me.fieldPopulation1.Caption = "Population"
        Me.fieldPopulation1.FieldName = "Population"
        Me.fieldPopulation1.Name = "fieldPopulation1"
        '
        'fieldLanguages1
        '
        Me.fieldLanguages1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldLanguages1.AreaIndex = 0
        Me.fieldLanguages1.Caption = "Languages"
        Me.fieldLanguages1.FieldName = "Languages"
        Me.fieldLanguages1.Name = "fieldLanguages1"
        '
        'CountriesTableAdapter1
        '
        Me.CountriesTableAdapter1.ClearBeforeFill = true
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 456)
        Me.Controls.Add(Me.pivotGridControl1)
        Me.Name = "MainForm"
        Me.Text = "Example main form"
        CType(Me.pivotGridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CountriesDBDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOfficialName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCurrency1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCapital1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldArea1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPopulation1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldLanguages1 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents CountriesDBDataSet1 As countriesDBDataSet
  Friend WithEvents CountriesTableAdapter1 As countriesDBDataSetTableAdapters.CountriesTableAdapter

	End Class
End Namespace

