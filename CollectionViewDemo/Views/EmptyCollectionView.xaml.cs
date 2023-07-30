namespace CollectionViewDemo.Views;

public partial class EmptyCollectionView : ContentPage
{
	public EmptyCollectionView()
	{
		InitializeComponent();
	}
	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		var isToggled = e.Value;
		collectionView.EmptyView = isToggled ? Resources["NoResultsView"] :
			 Resources["ConnectivityIssue"];
	}
}