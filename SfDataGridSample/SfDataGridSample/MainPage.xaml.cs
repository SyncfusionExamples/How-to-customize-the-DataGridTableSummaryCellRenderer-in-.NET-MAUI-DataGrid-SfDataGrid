using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sfGrid.CellRenderers.Remove("TableSummary");
            sfGrid.CellRenderers.Add("TableSummary", new TableSummaryCellRenderer());
        }
    }
    public class TableSummaryCellRenderer : DataGridTableSummaryCellRenderer
    {
        protected override void OnSetCellStyle(DataColumnBase dataColumn)
        {
            base.OnSetCellStyle(dataColumn);

            if (dataColumn.ColumnElement != null && dataColumn.ColumnElement.Content is SfDataGridLabel label)
            {
                dataColumn.ColumnElement.Background = Colors.SkyBlue;

                label.HorizontalTextAlignment = TextAlignment.Start;
                label.FontSize = 16;
                label.FontAttributes = FontAttributes.Bold;
                label.TextColor = Colors.White;
            }
        }
    }
}