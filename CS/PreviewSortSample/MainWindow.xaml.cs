using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Printing;
// ...

namespace PreviewSortSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        readonly OrderDetailsReport report;

        public MainWindow() {
            InitializeComponent();
            report = new OrderDetailsReport();
            report.SetOrderID(11077);
            XtraReportPreviewModel model = new XtraReportPreviewModel(report);
            model.PreviewClick += model_PreviewClick;
            model.PreviewMouseMove += model_PreviewMouseMove;
            preview.Model = model;
            report.CreateDocument(true);
        }

        void model_PreviewClick(object sender, PreviewClickEventArgs e) {
            if (!string.IsNullOrEmpty(e.ElementTag)) {
                string sortField = e.ElementTag;
                report.Sort(sortField);
            }
        }

        void model_PreviewMouseMove(object sender, PreviewClickEventArgs e) {
            if (!string.IsNullOrEmpty(e.ElementTag) && e.Element != null) {
                e.Element.Cursor = Cursors.Hand;
            }
        }
    }
}
