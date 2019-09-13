using System.Windows;

namespace Books.Views
{
    public partial class ModifyWindowsView : Window
    {
        public ModifyWindowsView(Models.Books books)
        {
            InitializeComponent();
            Books = books;
            DataContext = books;
        }

        public Models.Books Books { get; set; }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}