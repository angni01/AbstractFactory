using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	interface ISmartPhone
	{
		string GetModelDetails();
	}
	interface INormalPhone
	{
		string GetModelDetails();
	}

	class NokiaPixel : ISmartPhone
	{
		public string GetModelDetails()
		{
			return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
		}
	}

	class SamsungGalaxy : ISmartPhone
	{
		public string GetModelDetails()
		{
			return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
		}
	}

	class Nokia1600 : INormalPhone
	{
		public string GetModelDetails()
		{
			return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
		}
	}

	class SamsungGuru : INormalPhone
	{
		public string GetModelDetails()
		{
			return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
		}
	}
}
