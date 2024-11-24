namespace MismatchIssueListView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CustomClass customClass = (CustomClass)e.Item;
            ShellNavigationQueryParameters keyValuePairs = new ShellNavigationQueryParameters()
            {
                { "details", customClass }
            };
            await Shell.Current.GoToAsync($"Details", keyValuePairs);
        }
    }

}
