using guraburuEX.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guraburuEX.Model
{
	class EpisodeSelectorModel
	{
		public int Width	{ get; set; }
		public int Height	{ get; set; }

		public EpisodeSelectorModel()
		{
			Height	= 40;
			Width	= AppConfigUtil.GetAppSettingInt("ImageWidth", 630);
		}
	}
}
