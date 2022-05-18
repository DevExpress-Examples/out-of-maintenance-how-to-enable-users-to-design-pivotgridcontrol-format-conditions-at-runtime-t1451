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
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.CountriesDBDataSet1 = New countriesDBDataSet()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOfficialName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCurrency = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCapital = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldArea = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPopulation = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldLanguages = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.CountriesTableAdapter1 = New countriesDBDataSetTableAdapters.CountriesTableAdapter()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CountriesDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataMember = "Countries"
            Me.pivotGridControl1.DataSource = Me.CountriesDBDataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCountry, Me.fieldOfficialName, Me.fieldCurrency, Me.fieldCapital, Me.fieldArea, Me.fieldPopulation, Me.fieldLanguages})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(657, 456)
            Me.pivotGridControl1.TabIndex = 0
            '
            'CountriesDBDataSet1
            '
            Me.CountriesDBDataSet1.DataSetName = "countriesDBDataSet"
            Me.CountriesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'fieldCountry
            '
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            DataSourceColumnBinding1.ColumnName = "Country"
            Me.fieldCountry.DataBinding = DataSourceColumnBinding1
            Me.fieldCountry.Name = "fieldCountry"
            '
            'fieldOfficialName
            '
            Me.fieldOfficialName.AreaIndex = 0
            Me.fieldOfficialName.Caption = "Official Name"
            DataSourceColumnBinding2.ColumnName = "OfficialName"
            Me.fieldOfficialName.DataBinding = DataSourceColumnBinding2
            Me.fieldOfficialName.Name = "fieldOfficialName"
            '
            'fieldCurrency
            '
            Me.fieldCurrency.AreaIndex = 1
            Me.fieldCurrency.Caption = "Currency"
            DataSourceColumnBinding3.ColumnName = "Currency"
            Me.fieldCurrency.DataBinding = DataSourceColumnBinding3
            Me.fieldCurrency.Name = "fieldCurrency"
            '
            'fieldCapital
            '
            Me.fieldCapital.AreaIndex = 2
            Me.fieldCapital.Caption = "Capital"
            DataSourceColumnBinding4.ColumnName = "Capital"
            Me.fieldCapital.DataBinding = DataSourceColumnBinding4
            Me.fieldCapital.Name = "fieldCapital"
            '
            'fieldArea
            '
            Me.fieldArea.AreaIndex = 3
            Me.fieldArea.Caption = "Area"
            DataSourceColumnBinding5.ColumnName = "Area"
            Me.fieldArea.DataBinding = DataSourceColumnBinding5
            Me.fieldArea.Name = "fieldArea"
            '
            'fieldPopulation
            '
            Me.fieldPopulation.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPopulation.AreaIndex = 0
            Me.fieldPopulation.Caption = "Population"
            DataSourceColumnBinding6.ColumnName = "Population"
            Me.fieldPopulation.DataBinding = DataSourceColumnBinding6
            Me.fieldPopulation.Name = "fieldPopulation"
            '
            'fieldLanguages
            '
            Me.fieldLanguages.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldLanguages.AreaIndex = 0
            Me.fieldLanguages.Caption = "Languages"
            DataSourceColumnBinding7.ColumnName = "Languages"
            Me.fieldLanguages.DataBinding = DataSourceColumnBinding7
            Me.fieldLanguages.Name = "fieldLanguages"
            '
            'CountriesTableAdapter1
            '
            Me.CountriesTableAdapter1.ClearBeforeFill = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
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
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOfficialName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCurrency As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCapital As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldArea As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPopulation As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldLanguages As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents CountriesDBDataSet1 As countriesDBDataSet
  Friend WithEvents CountriesTableAdapter1 As countriesDBDataSetTableAdapters.CountriesTableAdapter

	End Class
End Namespace

