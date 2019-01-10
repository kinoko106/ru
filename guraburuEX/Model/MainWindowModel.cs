using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guraburuEX.Model
{
	class MainWindowModel
	{
		public int Width	{ get; set; }
		public int Height	{ get; set; }

		public MainWindowModel()
		{
			InitWindow();
		}

		public void InitWindow()
		{
			Width	= 600;
			Height	= 600;
		}
	}
}
