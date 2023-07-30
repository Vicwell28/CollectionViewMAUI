using CollectionViewDemo.Models;
using CollectionViewDemo.ViewModels;
using System.Collections.ObjectModel;

namespace CollectionViewDemo.Views;

public partial class DataView : ContentPage
{

	public DataView()
	{
		InitializeComponent();
		this.BindingContext = new DataViewModel();
	}
}