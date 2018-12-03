using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerhåndtering
{
	public class Binding
	{
		//Den validerer Userinput og sender beskeden videre
		//til de metoder der skal udføre arbejdet
		public static void Switchcase(int userInput, ItemRepository ir)
		{
			string productName;
			int quantity;
			double price;
			
			switch (userInput)
			{
				case 1:
						ir.GetItemList();
				break;
				case 2:
					Console.Write("Write Productname: ");
					string itemName = Console.ReadLine();

					Console.WriteLine(ir.ShowItem(itemName));
				break;

				case 3:
					Console.WriteLine("Write name from product: ");
					productName = Console.ReadLine();

					Console.WriteLine("Write Quantity from product: ");
					quantity = int.Parse(Console.ReadLine());

					Console.WriteLine("Write price from product: ");
					price = double.Parse(Console.ReadLine());
				
					ir.RegisterNewItem(productName, quantity, price);
				break;

				case 4:
					Console.WriteLine("Which Product are you looking for?");
					productName = Console.ReadLine();

					Console.WriteLine("How many Items are in Stock?");
					quantity = int.Parse(Console.ReadLine());

					ir.UpdateQuantity(productName, quantity);
				break;

				case 5:
					Console.WriteLine("Which Product has the wrong price?");
					productName = Console.ReadLine();

					Console.WriteLine("What is the real price?");
					price = double.Parse(Console.ReadLine());

					ir.UpdatePrice(productName, price);
				break;

				case 0:
					//Console.WriteLine("Programmet slukker om et øjeblik");
				break;

				default:
				break;
			}
			
		} 
	}
}
