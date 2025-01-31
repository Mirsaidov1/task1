using System;

public class Product
{
	public string Name { get; set; }
	public int Price { get; set; }
	public int Quantity { get; set; }


	public void Deconstruct(out string name, out int price, out int quantity)
	{
		name = Name;
		price = Price;
		quantity = Quantity;
	}

	
}
