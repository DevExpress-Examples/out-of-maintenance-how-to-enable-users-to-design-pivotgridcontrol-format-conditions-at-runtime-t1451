namespace FormatCondititonsDesigner
{
    partial class ExpressionConditionDesigner
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
            this.listBoxControlExpressions = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRemove = new DevExpress.XtraEditors.SimpleButton();
            this.propertyGridControlAppearance = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.labelControlAppearance = new DevExpress.XtraEditors.LabelControl();
            this.checkEditApplyToCell = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditApplyToTotal = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditApplyToGrandTotal = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlExpressions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControlAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToCell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToGrandTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControlExpressions
            // 
            this.listBoxControlExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxControlExpressions.Location = new System.Drawing.Point(8, 33);
            this.listBoxControlExpressions.Name = "listBoxControlExpressions";
            this.listBoxControlExpressions.Size = new System.Drawing.Size(416, 157);
            this.listBoxControlExpressions.TabIndex = 0;
            this.listBoxControlExpressions.SelectedIndexChanged += new System.EventHandler(this.listBoxControlExpressions_SelectedIndexChanged);
            this.listBoxControlExpressions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxControlExpressions_MouseDoubleClick);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(7, 5);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(114, 22);
            this.simpleButtonAdd.TabIndex = 1;
            this.simpleButtonAdd.Text = "Add expression";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonRemove
            // 
            this.simpleButtonRemove.Location = new System.Drawing.Point(127, 5);
            this.simpleButtonRemove.Name = "simpleButtonRemove";
            this.simpleButtonRemove.Size = new System.Drawing.Size(114, 22);
            this.simpleButtonRemove.TabIndex = 2;
            this.simpleButtonRemove.Text = "Remove expression";
            this.simpleButtonRemove.Click += new System.EventHandler(this.simpleButtonRemove_Click);
            // 
            // propertyGridControlAppearance
            // 
            this.propertyGridControlAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridControlAppearance.Location = new System.Drawing.Point(9, 209);
            this.propertyGridControlAppearance.Name = "propertyGridControlAppearance";
            this.propertyGridControlAppearance.OptionsView.ShowRootCategories = false;
            this.propertyGridControlAppearance.Size = new System.Drawing.Size(413, 92);
            this.propertyGridControlAppearance.TabIndex = 3;
            // 
            // labelControlAppearance
            // 
            this.labelControlAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControlAppearance.Location = new System.Drawing.Point(12, 193);
            this.labelControlAppearance.Name = "labelControlAppearance";
            this.labelControlAppearance.Size = new System.Drawing.Size(62, 13);
            this.labelControlAppearance.TabIndex = 4;
            this.labelControlAppearance.Text = "Appearance:";
            // 
            // checkEditApplyToCell
            // 
            this.checkEditApplyToCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkEditApplyToCell.Location = new System.Drawing.Point(9, 303);
            this.checkEditApplyToCell.Name = "checkEditApplyToCell";
            this.checkEditApplyToCell.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEditApplyToCell.Properties.Appearance.Options.UseFont = true;
            this.checkEditApplyToCell.Properties.Caption = "Apply to cell";
            this.checkEditApplyToCell.Size = new System.Drawing.Size(149, 19);
            this.checkEditApplyToCell.TabIndex = 5;
            this.checkEditApplyToCell.EditValueChanged += new System.EventHandler(this.checkEditApplyToCell_EditValueChanged);
            // 
            // checkEditApplyToTotal
            // 
            this.checkEditApplyToTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkEditApplyToTotal.Location = new System.Drawing.Point(9, 324);
            this.checkEditApplyToTotal.Name = "checkEditApplyToTotal";
            this.checkEditApplyToTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEditApplyToTotal.Properties.Appearance.Options.UseFont = true;
            this.checkEditApplyToTotal.Properties.Caption = "Apply to total";
            this.checkEditApplyToTotal.Size = new System.Drawing.Size(149, 19);
            this.checkEditApplyToTotal.TabIndex = 6;
            // 
            // checkEditApplyToGrandTotal
            // 
            this.checkEditApplyToGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkEditApplyToGrandTotal.Location = new System.Drawing.Point(9, 345);
            this.checkEditApplyToGrandTotal.Name = "checkEditApplyToGrandTotal";
            this.checkEditApplyToGrandTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEditApplyToGrandTotal.Properties.Appearance.Options.UseFont = true;
            this.checkEditApplyToGrandTotal.Properties.Caption = "Apply to grand total";
            this.checkEditApplyToGrandTotal.Size = new System.Drawing.Size(149, 19);
            this.checkEditApplyToGrandTotal.TabIndex = 7;
            // 
            // ExpressionConditionDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 376);
            this.Controls.Add(this.checkEditApplyToGrandTotal);
            this.Controls.Add(this.checkEditApplyToTotal);
            this.Controls.Add(this.checkEditApplyToCell);
            this.Controls.Add(this.labelControlAppearance);
            this.Controls.Add(this.propertyGridControlAppearance);
            this.Controls.Add(this.simpleButtonRemove);
            this.Controls.Add(this.simpleButtonAdd);
            this.Controls.Add(this.listBoxControlExpressions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpressionConditionDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExpressionConditionDesigner";
            this.Load += new System.EventHandler(this.ExpressionConditionDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlExpressions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControlAppearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToCell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToGrandTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControlExpressions;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemove;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControlAppearance;
        private DevExpress.XtraEditors.LabelControl labelControlAppearance;
        private DevExpress.XtraEditors.CheckEdit checkEditApplyToCell;
        private DevExpress.XtraEditors.CheckEdit checkEditApplyToTotal;
        private DevExpress.XtraEditors.CheckEdit checkEditApplyToGrandTotal;
    }
}