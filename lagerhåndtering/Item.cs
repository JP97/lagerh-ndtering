using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerhåndtering
{
	public class Item
	{

		private string name;
		private int quantitiy;
		private double price;

		public string Name { get {return this.name; } set {this.name = value; } }
		public int Quantity { get {return this.quantitiy; } set {this.quantitiy = value; } }
		public double Price { get {return this.price; } set {this.price = value; } }



		// fire constructor, selv en der modtager ingen parameter
		public Item(string name, int quantity, double price)
		{
			Name = name;
			Quantity = quantity;
			Price = price;
		}

		public Item(string name, int quantity) : this (name, quantity, 0.0) { }

		public Item(string name) : this (name, 0, 0.0) { }

		public Item() : this ("Not Given", 0, 0.0){ }



		//Det her er fakes for vores liste
		public void SetUpItems()
		{
			ItemRepository ir = new ItemRepository();
			Item item1 = new Item("Hvid Maling", 10, 100);
			Item item2 = new Item("Grøn Maling", 7, 80);
			Item item3 = new Item("Pink Maling", 53, 132);
			Item item4 = new Item("Blå Maling", 33, 12.89);
			Item item5 = new Item("Violet Maling", 67, 72.50);
			ir.AddItem(item1);
			ir.AddItem(item2);
			ir.AddItem(item3);
			ir.AddItem(item4);
			ir.AddItem(item5);
		}


		//ja override af ToString()
		public override string ToString()
		{
			string alleinformationen = "Navn: " + Name + " " + "Antal: " + Quantity + " " + "Prisen: " + Price;
			return alleinformationen;
		}
	}
}
