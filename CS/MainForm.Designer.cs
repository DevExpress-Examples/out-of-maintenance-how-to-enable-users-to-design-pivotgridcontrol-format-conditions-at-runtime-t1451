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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.countriesDBDataSet1 = new FormatCondititonsDesigner.countriesDBDataSet();
            this.countriesTableAdapter1 = new FormatCondititonsDesigner.countriesDBDataSetTableAdapters.CountriesTableAdapter();
            this.fieldCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOfficialName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCurrency1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCapital1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldArea1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPopulation1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLanguages1 = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.fieldCountry1,
            this.fieldOfficialName1,
            this.fieldCurrency1,
            this.fieldCapital1,
            this.fieldArea1,
            this.fieldPopulation1,
            this.fieldLanguages1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(657, 456);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // countriesDBDataSet1
            // 
            this.countriesDBDataSet1.DataSetName = "countriesDBDataSet";
            this.countriesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesTableAdapter1
            // 
            this.countriesTableAdapter1.ClearBeforeFill = true;
            // 
            // fieldCountry1
            // 
            this.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry1.AreaIndex = 0;
            this.fieldCountry1.Caption = "Country";
            this.fieldCountry1.FieldName = "Country";
            this.fieldCountry1.Name = "fieldCountry1";
            // 
            // fieldOfficialName1
            // 
            this.fieldOfficialName1.AreaIndex = 0;
            this.fieldOfficialName1.Caption = "Official Name";
            this.fieldOfficialName1.FieldName = "OfficialName";
            this.fieldOfficialName1.Name = "fieldOfficialName1";
            // 
            // fieldCurrency1
            // 
            this.fieldCurrency1.AreaIndex = 1;
            this.fieldCurrency1.Caption = "Currency";
            this.fieldCurrency1.FieldName = "Currency";
            this.fieldCurrency1.Name = "fieldCurrency1";
            // 
            // fieldCapital1
            // 
            this.fieldCapital1.AreaIndex = 2;
            this.fieldCapital1.Caption = "Capital";
            this.fieldCapital1.FieldName = "Capital";
            this.fieldCapital1.Name = "fieldCapital1";
            // 
            // fieldArea1
            // 
            this.fieldArea1.AreaIndex = 3;
            this.fieldArea1.Caption = "Area";
            this.fieldArea1.FieldName = "Area";
            this.fieldArea1.Name = "fieldArea1";
            // 
            // fieldPopulation1
            // 
            this.fieldPopulation1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPopulation1.AreaIndex = 0;
            this.fieldPopulation1.Caption = "Population";
            this.fieldPopulation1.FieldName = "Population";
            this.fieldPopulation1.Name = "fieldPopulation1";
            // 
            // fieldLanguages1
            // 
            this.fieldLanguages1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLanguages1.AreaIndex = 0;
            this.fieldLanguages1.Caption = "Languages";
            this.fieldLanguages1.FieldName = "Languages";
            this.fieldLanguages1.Name = "fieldLanguages1";
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOfficialName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCurrency1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCapital1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldArea1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPopulation1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLanguages1;

    }
}

