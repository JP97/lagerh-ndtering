using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerhåndtering
{
	public class SmartMenu
	{
		public void ShowMenu()
		{   //variablem bliver deklareret her, da det ellers ikke kan burges i while condition
			int userInput;
			ItemRepository ir = new ItemRepository();
			ir.SetUpItems();
			//ir.Save();
			//Loopet der laver at menuen gentages hele tiden
			do
			{
				//selve menu Teksten
				Console.WriteLine("Hauptmenü");
				Console.WriteLine("");
				Console.WriteLine("press 1 to show all products in the inventory");
				Console.WriteLine("press 2 to search for a specific product");
				Console.WriteLine("press 3 for register new product");
				Console.WriteLine("press 4 for updating quantity");
				Console.WriteLine("press 5 for updating price");
				Console.WriteLine("Press 0 to exit");
				userInput = int.Parse(Console.ReadLine());
				Binding.Switchcase(userInput, ir);


				Console.ReadKey();
				//for at fjerne alt tekst fra Konsollen, hvis menuen bliver vist
				Console.Clear();
			}
			while (userInput != 0);
		}



		public void GetUserInformation()
		{

		}
	}
}
