using System;
using System.Collections.Generic;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;

namespace FormatCondititonsDesigner
{
    public partial class SimpleConditionDesigner : DevExpress.XtraEditors.XtraForm
    {
        protected internal PivotGridControl SourcePivot { get; set; }
        protected internal PivotGridField SourceField { get; set; }


        public SimpleConditionDesigner()
        {
            InitializeComponent();
            listBoxConditions.SelectedIndexChanged += new EventHandler(listBoxConditions_SelectedIndexChanged);
        }

        void listBoxConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCondition selectedItem = listBoxConditions.SelectedItem as ItemCondition;
            condititonItemControlMain.Init(selectedItem);
            simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0;
        }

        private void SimpleConditionDesigner_Load(object sender, EventArgs e)
        {
            Text = String.Format("Simple condition for field: [{0}]", SourceField.Name);
            LoadCondititons();
            simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0;
        }

        void LoadCondititons()
        {
            listBoxConditions.Items.Clear();
            condititonItemControlMain.Init(null);
            foreach (PivotGridStyleFormatCondition item in SourcePivot.FormatConditions)
            {
                if (item.Field == SourceField && item.Condition != FormatConditionEnum.Expression)
                {
                    AddItemToListBox(item);
                }
            }
        }

        private void simpleButtonAddCondititon_Click(object sender, EventArgs e)
        {
            if (SourcePivot == null) return;
            listBoxConditions.Items.BeginUpdate();
            CreateNewFormatCondition();
            listBoxConditions.Items.EndUpdate();
        }

        private void CreateNewFormatCondition()
        {
            PivotGridStyleFormatCondition item = new PivotGridStyleFormatCondition();
            item.Field = SourceField;
            SourcePivot.FormatConditions.Add(item);
            AddItemToListBox(item);
        }

        private void condititonItemControlMain_RefreshValues(object sender, EventArgs e)
        {
            listBoxConditions.Refresh();
        }

        private void simpleButtonRemoveCondition_Click(object sender, EventArgs e)
        {
            if (SourcePivot == null) return;
            ItemCondition condition = listBoxConditions.SelectedItem as ItemCondition;
            listBoxConditions.Items.Remove(listBoxConditions.SelectedItem);
            SourcePivot.FormatConditions.Remove(condition.Condition);
        }

        protected void AddItemToListBox(PivotGridStyleFormatCondition newItem)
        {
            ItemCondition newItemCondition = new ItemCondition(newItem);
            listBoxConditions.Items.Add(newItemCondition);
            listBoxConditions.SelectedItem = newItemCondition;        
        }
    }
}