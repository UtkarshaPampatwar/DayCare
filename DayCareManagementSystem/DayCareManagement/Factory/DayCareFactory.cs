using System;
using System.Collections.Generic;
using System.Text;

namespace DayCareManagement.Factory
{
    class DayCareFactory
    {
		private static DayCareFactory instance = null;
		private DayCareFactory()
		{
		}

		public static DayCareFactory getObj()
		{
			if (instance == null)
			{
				instance = new DayCareFactory();
			}
			return instance;
		}

		public Models.DayCare getDayCareObj()
		{
			Models.DayCare dayCare = new Models.DayCare();
			return dayCare;
		}
	}
}
