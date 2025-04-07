# How to customize the DataGridTableSummaryCellRenderer in .NET MAUI DataGrid (SfDataGrid) ?
In this article, we will show you how to customize the table summary row in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## Xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="sfGrid" 
                        GridLinesVisibility="Both"
                        HeaderGridLinesVisibility="Both"
                        ColumnWidthMode="Auto"
                        AutoGenerateColumnsMode="None"
                        ItemsSource="{Binding Employees}">

    <syncfusion:SfDataGrid.TableSummaryRows>
        <syncfusion:DataGridTableSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                        ShowSummaryInRow="True">
            <syncfusion:DataGridTableSummaryRow.SummaryColumns>
                <syncfusion:DataGridSummaryColumn Name="TotalSalary"
                                                Format="{}{Sum:C0}"
                                                MappingName="Salary"
                                                SummaryType="DoubleAggregate" />
                <syncfusion:DataGridSummaryColumn Name="ProductCount"
                                                Format="{}{Count}"
                                                MappingName="Salary"
                                                SummaryType="CountAggregate" />
            </syncfusion:DataGridTableSummaryRow.SummaryColumns>
        </syncfusion:DataGridTableSummaryRow>
    </syncfusion:SfDataGrid.TableSummaryRows>

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="Name"
                                        HeaderText="Employee Name" />
        <syncfusion:DataGridTextColumn MappingName="Title"
                                        HeaderText="Designation" />
        <syncfusion:DataGridTextColumn MappingName="LoginID"
                                        HeaderText="Login ID" />
        <syncfusion:DataGridTextColumn MappingName="Salary"
                                        HeaderText="Salary" />

    </syncfusion:SfDataGrid.Columns>

</syncfusion:SfDataGrid>
```

## Xaml.cs
The code below demonstrates how to customize the table summary row using custom renderer in SfDataGrid.
```
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
```

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM4ODE5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.GF1uCFxW3FnHxu3CB-K3w9wZhnSqpM0IEJl2kKGmvQo" width=800/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-customize-the-DataGridTableSummaryCellRenderer-in-.NET-MAUI-DataGrid-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to customize the table summary row in SfDataGrid.
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!