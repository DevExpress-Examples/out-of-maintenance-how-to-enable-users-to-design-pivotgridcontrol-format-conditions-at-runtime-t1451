namespace FormatCondititonsDesigner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.countriesDBDataSet1 = new FormatCondititonsDesigner.countriesDBDataSet();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOfficialName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCurrency = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCapital = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldArea = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPopulation = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLanguages = new DevExpress.XtraPivotGrid.PivotGridField();
            this.countriesTableAdapter1 = new FormatCondititonsDesigner.countriesDBDataSetTableAdapters.CountriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataMember = "Countries";
            this.pivotGridControl1.DataSource = this.countriesDBDataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldOfficialName,
            this.fieldCurrency,
            this.fieldCapital,
            this.fieldArea,
            this.fieldPopulation,
            this.fieldLanguages});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(657, 456);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // countriesDBDataSet1
            // 
            this.countriesDBDataSet1.DataSetName = "countriesDBDataSet";
            this.countriesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            dataSourceColumnBinding1.ColumnName = "Country";
            this.fieldCountry.DataBinding = dataSourceColumnBinding1;
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldOfficialName
            // 
            this.fieldOfficialName.AreaIndex = 0;
            this.fieldOfficialName.Caption = "Official Name";
            dataSourceColumnBinding2.ColumnName = "OfficialName";
            this.fieldOfficialName.DataBinding = dataSourceColumnBinding2;
            this.fieldOfficialName.Name = "fieldOfficialName";
            // 
            // fieldCurrency
            // 
            this.fieldCurrency.AreaIndex = 1;
            this.fieldCurrency.Caption = "Currency";
            dataSourceColumnBinding3.ColumnName = "Currency";
            this.fieldCurrency.DataBinding = dataSourceColumnBinding3;
            this.fieldCurrency.Name = "fieldCurrency";
            // 
            // fieldCapital
            // 
            this.fieldCapital.AreaIndex = 2;
            this.fieldCapital.Caption = "Capital";
            dataSourceColumnBinding4.ColumnName = "Capital";
            this.fieldCapital.DataBinding = dataSourceColumnBinding4;
            this.fieldCapital.Name = "fieldCapital";
            // 
            // fieldArea
            // 
            this.fieldArea.AreaIndex = 3;
            this.fieldArea.Caption = "Area";
            dataSourceColumnBinding5.ColumnName = "Area";
            this.fieldArea.DataBinding = dataSourceColumnBinding5;
            this.fieldArea.Name = "fieldArea";
            // 
            // fieldPopulation
            // 
            this.fieldPopulation.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPopulation.AreaIndex = 0;
            this.fieldPopulation.Caption = "Population";
            dataSourceColumnBinding6.ColumnName = "Population";
            this.fieldPopulation.DataBinding = dataSourceColumnBinding6;
            this.fieldPopulation.Name = "fieldPopulation";
            // 
            // fieldLanguages
            // 
            this.fieldLanguages.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLanguages.AreaIndex = 0;
            this.fieldLanguages.Caption = "Languages";
            dataSourceColumnBinding7.ColumnName = "Languages";
            this.fieldLanguages.DataBinding = dataSourceColumnBinding7;
            this.fieldLanguages.Name = "fieldLanguages";
            // 
            // countriesTableAdapter1
            // 
            this.countriesTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 456);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "MainForm";
            this.Text = "Example main form";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private countriesDBDataSet countriesDBDataSet1;
        private countriesDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOfficialName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCurrency;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCapital;
        private DevExpress.XtraPivotGrid.PivotGridField fieldArea;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPopulation;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLanguages;

    }
}

