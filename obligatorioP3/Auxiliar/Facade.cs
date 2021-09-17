using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliar
{
	public class Facade
	{
		public static Facade _instance =null;

		private FabricaRepositorios _fabricaRepositorios;

		public static Facade Instance { 
			get {
				if (_instance == null)
				{
					_instance = new Facade();
				}

				return _instance;
			}
		}

		public Facade()
		{
			_fabricaRepositorios = new FabricaRepositorios();
		}

	}
}
