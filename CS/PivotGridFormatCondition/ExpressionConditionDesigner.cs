using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Design;
using DevExpress.XtraPivotGrid;

namespace FormatCondititonsDesigner
{
    public partial class ExpressionConditionDesigner : DevExpress.XtraEditors.XtraForm
    {
        protected internal PivotGridControl SourcePivot { get; set; }
        protected internal PivotGridField SourceField { get; set; }


        public ExpressionConditionDesigner()
        {
            InitializeComponent();
        }

        private void ExpressionConditionDesigner_Load(object sender, EventArgs e)
        {
            Text = String.Format("Expression condition for field: [{0}]", SourceField.Name);
            LoadCondititons();
            UpdateEditors();
        }

        void LoadCondititons()
        {
            listBoxControlExpressions.Items.Clear();
            foreach (PivotGridStyleFormatCondition item in SourcePivot.FormatConditions)
            {
                if (item.Field == SourceField && item.Condition == FormatConditionEnum.Expression)
                {
                    AddItemToListBox(item);
                }
            }        
        }

        private void listBoxControlExpressions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ItemCondition selectedItem = listBoxControlExpressions.SelectedItem as ItemCondition;
            if (selectedItem != null)
            {
                using (ExpressionEditorForm form = new ConditionExpressionEditorForm(selectedItem.Condition, null))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        selectedItem.Condition.Condition = FormatConditionEnum.Expression;
                        selectedItem.Condition.Expression = form.Expression;
                    }
                }
            }
            listBoxControlExpressions.Refresh();
        }

        private void listBoxControlExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCondition selectedItem = listBoxControlExpressions.SelectedItem as ItemCondition;
            propertyGridControlAppearance.SelectedObject =  selectedItem == null ? null : selectedItem.Condition.Appearance;
            checkEditApplyToCell.EditValue = selectedItem == null ? false : (bool)selectedItem.Condition.ApplyToCell;
            checkEditApplyToTotal.EditValue = selectedItem == null ? false : (bool)selectedItem.Condition.ApplyToTotalCell;
            checkEditApplyToGrandTotal.EditValue = selectedItem == null ? false : (bool)selectedItem.Condition.ApplyToGrandTotalCell;
            UpdateEditors();
        }

        private void UpdateEditors()
        {
            bool isEnabled = listBoxControlExpressions.Items.Count > 0;
            simpleButtonRemove.Enabled = isEnabled;
            propertyGridControlAppearance.Enabled = isEnabled;
            checkEditApplyToCell.Enabled = isEnabled;
            checkEditApplyToTotal.Enabled = isEnabled;
            checkEditApplyToGrandTotal.Enabled = isEnabled;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (SourcePivot == null) return;
            listBoxControlExpressions.Items.BeginUpdate();
            CreateNewFormatCondition();
            listBoxControlExpressions.Items.EndUpdate();
        }

        private void CreateNewFormatCondition()
        {
            PivotGridStyleFormatCondition item = new PivotGridStyleFormatCondition();
            item.Field = SourceField;
            item.Condition = FormatConditionEnum.None;
            SourcePivot.FormatConditions.Add(item);
            AddItemToListBox(item);
        }

        private void AddItemToListBox(PivotGridStyleFormatCondition item)
        {
            ItemCondition newItemCondition = new ItemCondition(item);
            listBoxControlExpressions.Items.Add(newItemCondition);
            listBoxControlExpressions.SelectedItem = newItemCondition;
        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            if (SourcePivot == null) return;
            RemoveFormatCondition();
        }

        private void RemoveFormatCondition()
        {
            ItemCondition condition = listBoxControlExpressions.SelectedItem as ItemCondition;
            listBoxControlExpressions.Items.Remove(listBoxControlExpressions.SelectedItem);
            SourcePivot.FormatConditions.Remove(condition.Condition);
        }

        private void checkEditApplyToCell_EditValueChanged(object sender, EventArgs e)
        {
            if (listBoxControlExpressions.SelectedItem != null)
            {
                (listBoxControlExpressions.SelectedItem as ItemCondition).Condition.ApplyToCell = (bool)checkEditApplyToCell.EditValue;
            }
        }
    }
}