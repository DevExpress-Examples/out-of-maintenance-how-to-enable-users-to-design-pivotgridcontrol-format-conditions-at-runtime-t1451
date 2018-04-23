using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;

namespace FormatCondititonsDesigner
{
    class ViewFormatDesigner
    {
        // private members
        protected PivotGridField field;
        protected SimpleConditionDesigner simpleConditionDesigner;
        protected ExpressionConditionDesigner expressionConditionDesigner;

        // constructors

        public ViewFormatDesigner(PivotGridControl pivotGridControl)
        {
            PivotGridControl = pivotGridControl;
            PivotGridControl.PopupMenuShowing += PivotGridControl_PopupMenuShowing;

        }

        void PivotGridControl_PopupMenuShowing(object sender, DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == PivotGridMenuType.FieldValue && e.HitInfo.ValueInfo != null)
            {
                e.Menu.Items.Add(CreateMenuItem(CreateCaptionForCondition(e.HitInfo.ValueInfo.DataField, true), "Simple"));
                e.Menu.Items.Add(CreateMenuItem(CreateCaptionForCondition(e.HitInfo.ValueInfo.DataField, false), "Expression"));
                field = e.HitInfo.ValueInfo.DataField;
            }
        }

        DXMenuCheckItem CreateMenuItem(string caption, string stringForTag)
        {
            DXMenuCheckItem item = new DXMenuCheckItem(caption, false, null, new EventHandler(OnMenuItemClick));
            item.Tag = stringForTag;
            return item;
        }

        // Menu item click handler.
        void OnMenuItemClick(object sender, EventArgs e)
        {
            if (PivotGridControl != null && field != null)
            {
                string currentTag = (string)(sender as DXMenuCheckItem).Tag;
                switch (currentTag)
                {
                    case "Simple":
                        {
                            ShowSimpleCondititonDesigner();
                            break;
                        }
                    case "Expression":
                        {
                            ShowExpressionCondititonDesigner();
                            break;
                        }
                    default:
                        break;
                }                
            }
        }

        void ShowSimpleCondititonDesigner()
        {
            if (simpleConditionDesigner == null)
            {
                simpleConditionDesigner = new SimpleConditionDesigner();
            }
            simpleConditionDesigner.SourcePivot = PivotGridControl;
            simpleConditionDesigner.SourceField = field;
            simpleConditionDesigner.ShowDialog();
        }

        void ShowExpressionCondititonDesigner()
        {
            if (expressionConditionDesigner == null)
            {
                expressionConditionDesigner = new ExpressionConditionDesigner();
            }
            expressionConditionDesigner.SourcePivot = PivotGridControl;
            expressionConditionDesigner.SourceField = field;
            expressionConditionDesigner.ShowDialog();        
        }

        string CreateCaptionForCondition(PivotGridField field, bool IsSimple)
        {
            int iConditionsCount = 0;
            foreach (PivotGridStyleFormatCondition item in PivotGridControl.FormatConditions)
            {
                if (item.Field == field)
                {
                    if (item.Condition == FormatConditionEnum.Expression && !IsSimple) iConditionsCount++;
                    if (item.Condition != FormatConditionEnum.Expression && IsSimple) iConditionsCount++;
                }
                
            }
            return String.Format("{0} conditions editor ({1})", IsSimple ? "Simple" : "Expression", iConditionsCount);
        }
        public PivotGridControl PivotGridControl { get; private set; }
    }
}
