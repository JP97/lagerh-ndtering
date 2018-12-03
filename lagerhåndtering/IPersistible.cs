using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerhåndtering
{
	public interface IPersistible
	{
		void Save();
		void Load();
	}
}
