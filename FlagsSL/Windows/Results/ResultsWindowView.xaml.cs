using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flags
{
    public partial class ResultsWindowView : Page
    {
        private readonly ResultsWindowViewModel _viewModel;

        public ResultsWindowView()
        {
            InitializeComponent();
            _viewModel = DataContext as ResultsWindowViewModel;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var url = e.Uri.ToString();
            var parameters = url.Substring(url.IndexOf("?", StringComparison.Ordinal) + 1);
            _viewModel.ParseSearchParameters(parameters);
        }
    }
}