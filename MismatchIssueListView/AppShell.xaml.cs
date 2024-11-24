namespace MismatchIssueListView
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Details", typeof(SecondPage));
        }
    }
}
