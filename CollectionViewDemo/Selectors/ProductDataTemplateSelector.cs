using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewDemo.Models;

namespace CollectionViewDemo.Selectors
{
	public class ProductDataTemplateSelector : DataTemplateSelector
	{
		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			Product Product = item as Product;

			string productTemplate = Product.HasOffer ? "ProductOfferTemplateStyle" : "ProductTemplateStyle";

			Application.Current.Resources.TryGetValue(productTemplate, out var ProductTemplateStyle);

			return ProductTemplateStyle as DataTemplate;
		}
	}
}
