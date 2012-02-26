using System.Windows;
using System.Windows.Controls;

namespace GadgetVote.Client.Navigation
{
    public static class Navigator
    {
        public static INavigable GetSource(DependencyObject obj)
        {
            return (INavigable)obj.GetValue(SourceProperty);
        }

        public static void SetSource(DependencyObject obj, INavigable value)
        {
            obj.SetValue(SourceProperty, value);
        }

        public static readonly DependencyProperty SourceProperty =
             DependencyProperty.RegisterAttached("Source", typeof(INavigable), typeof(Navigator), new PropertyMetadata(OnSourceChanged));

        private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Page page = (Page)d;

            page.Loaded += PageLoaded;
        }

        private static void PageLoaded(object sender, RoutedEventArgs e)
        {
            Page page = (Page)sender;

            INavigable navSource = GetSource(page);

            if (navSource != null)
            {
                navSource.NavigationService = new NavigationService(page.NavigationService);
            }
        }
    }
}