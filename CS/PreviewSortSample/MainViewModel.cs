using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace PreviewSortSample {
    [POCOViewModel]
    public class MainViewModel {
        public virtual OrderDetailsReport Report { get; protected set; }
        protected MainViewModel() {
            Report = new OrderDetailsReport();
            Report.SetOrderID(11077);
        }

        public void OnPreviewMouseClick(DocumentPreviewMouseEventArgs args) {
            var sortField = args.ElementTag as string;
            if(!string.IsNullOrEmpty(sortField)) {
                Report.Sort(sortField);
            }
        }

        public void OnPreviewMouseMove(DocumentPreviewMouseEventArgs args) {
            var sortField = args.ElementTag as string;
            if(!string.IsNullOrEmpty(sortField)) {
                Mouse.SetCursor(Cursors.Hand);
            }
        }
    }
}
