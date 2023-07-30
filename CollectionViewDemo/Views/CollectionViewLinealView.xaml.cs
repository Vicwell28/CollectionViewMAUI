using CollectionViewDemo.ViewModels;
namespace CollectionViewDemo.Views;

public partial class CollectionViewLinealView : ContentPage
{
	public CollectionViewLinealView()
	{
		InitializeComponent();
		this.BindingContext = new DataViewModel(); 
	}

	private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var element = e.CurrentSelection;
	}
}