using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lagerhåndtering
{
	public class ItemRepository : IPersistible
	{
		private List<Item> items = new List<Item>();

		//Denne metode skal finde et specifikt produkt 
		// bruges måske senere
		public Item GetItem(string name)
		{
			foreach(Item i in items)
			{
				if(i.Name == name)
				{
					return i;
				}
			}
			return null;
		}

		//Denne metode finder et specifikt produkt
		//hvis det ikke findes sendes et besked
		public string ShowItem(string name)
		{
			foreach(Item i in items)
			{
				if(i.Name == name)
				{
					return i.ToString();
				}
			}
			return "this product does not exist";
		}


		//Denne metode skal retunere hele antallet af listen i konsolvinduet
		public void GetItemList()
		{
			foreach(Item item in items)
			{
				Console.WriteLine(item);
			}
		}

		//Her oprettes et nyt item, derefter bliver der kaldt til
		// AddItem metoden der gemmer det nye item i listen
		//og giver besked
		public void RegisterNewItem(string name, int quantity, double price)
		{
			Item item = new Item(name, quantity, price);
			AddItem(item);
			Console.WriteLine("Product has been added");
		}

		//Denne metode skal tilføje et item til listen
		public void AddItem(Item item)
		{
			items.Add(item);
		}

		//Denne metode søger det rigtige Item
		//og opdaterer antallet af det
		public void UpdateQuantity(string productName, int quantity)
		{
			foreach(Item i in items)
			{
				if(i.Name == productName)
				{
					i.Quantity = quantity;
					Console.WriteLine("Quantity has been updated");
				}
			}
		}

		//Denne metode søger det rigtige Item
		//og opdaterer prisen af det
		// samme metode som ovenfor
		public void UpdatePrice(string productName, double price)
		{
			foreach (Item i in items)
			{
				if (i.Name == productName)
				{
					i.Price = price;
					Console.WriteLine("Price has been updated");
				}
			}
		}


		//vores setup liste der kun kører engang
		//for at have nogle items at arbejde med
		public void SetUpItems()
		{
				items = new List<Item>
				{
				new Item("Hvid Maling", 10, 100),
				new Item("Grøn Maling", 7, 80),
				new Item("Pink Maling", 53, 132),
				new Item("Blå Maling", 33, 12.89),
				new Item("Violet Maling", 67, 72.50),
				};
		}

		public void Save()
		{
			try
			{
				string filename = "ProductList.txt";
				StreamWriter writer = new StreamWriter(filename);

				foreach (Item i in items)
				{
					writer.WriteLine("MALING;" + i.Name + ";" + "QUANTITY;" + i.Quantity + ";" + "PRICE;" + i.Price + ";");
				}
				writer.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine("UPS der gik noget galt " + e.Message);
			}




			//throw new NotImplementedException();
		}

		public void Load()
		{
			throw new NotImplementedException();
		}
	}
}
