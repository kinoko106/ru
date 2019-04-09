using guraburuEX.Model.Util;
using guraburuEX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guraburuEX.Model
{
	class EpisodeSelectorModel
	{
		EpisodeSelectorViewModel _Parent;

		public int Width	{ get; set; }
		public int Height	{ get; set; }

		public EpisodeSelectorModel()
		{
			_Parent.Height = 40;
			_Parent.Width = AppConfigUtil.GetAppSettingInt("ImageWidth", 420);
		}
	}
}
