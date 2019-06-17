using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	interface IMobilePhone
	{ 
		ISmartPhone GetSmartPhone();
		INormalPhone GetNormalPhone();
	}

	class Nokia : IMobilePhone
	{
		public ISmartPhone GetSmartPhone()
		{
			return new NokiaPixel();
		}

		public INormalPhone GetNormalPhone()
		{
			return new Nokia1600();
		}
	}

	class Samsung : IMobilePhone
	{
		public ISmartPhone GetSmartPhone()
		{
			return new SamsungGalaxy();
		}

		public INormalPhone GetNormalPhone()
		{
			return new SamsungGuru();
		}
	}
}
