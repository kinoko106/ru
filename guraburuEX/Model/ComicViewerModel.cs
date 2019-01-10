using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace guraburuEX.Model
{
	class ComicViewerModel
	{
		public string	ComicPath	{ get; set; }
		public int		Width		{ get; set; }
		public int		Height		{ get; set; }
		public string	Text		{ get; set; }

		public ComicViewerModel()
		{
			InitWindow();
		}

		public void InitWindow()
		{
			Width	= 200;
			Height	= 500;
			Text	= "texttttttttttt";
		}
	}
}
