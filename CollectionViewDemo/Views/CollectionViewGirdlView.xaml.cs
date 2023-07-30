using CollectionViewDemo.ViewModels;

namespace CollectionViewDemo.Views;

public partial class CollectionViewGirdlView : ContentPage
{
	public CollectionViewGirdlView()
	{
		InitializeComponent();
		this.BindingContext = new DataViewModel();
	}
}