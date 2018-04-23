using System;
using DevExpress.XtraReports.UI;
// ...

namespace PreviewSortSample {
    public partial class OrderDetailsReport : XtraReport {
        public OrderDetailsReport() {
            InitializeComponent();
        }

        public void SetOrderID(int orderID) {
            nwindDataSet1.Clear();
            orderDetailsTableAdapter.Fill(nwindDataSet1.OrderDetails, orderID);
            lbOrderID.Text = orderID.ToString();
        }

        public void Sort(string fieldName) {
            // Disable sorting.
            Detail.SortFields.Clear();

            // Create a new sorting criterion.
            GroupField grField = new GroupField { FieldName = fieldName, SortOrder = XRColumnSortOrder.Ascending };

            // Enable sorting.
            Detail.SortFields.Add(grField);

            // Re-create the report document.
            CreateDocument(true);
        }
    }
}
