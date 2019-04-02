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
		ComicViewerModel _ComicViewerModel;

		public int Width	{ get; set; }
		public int Height	{ get; set; }

		public EpisodeSelectorModel(EpisodeSelectorViewModel inParent,ComicViewerModel  inComicViewerModel)
		{
			_Parent			  = inParent;
			_ComicViewerModel = inComicViewerModel;

			_Parent.Height = 40;
			_Parent.Width = AppConfigUtil.GetAppSettingInt("ImageWidth", 420);
		}

		public void UpdateEpisode(string inEpisodeString)
		{
			//int episode = 0;
			//if (int.TryParse(inEpisodeString, out episode))
			//{
			//	_ComicViewerModel.GetImageSource(episode);
			//}
		}

		public string TurnEpisode(string inAdditionNumberText)
		{
			//int episode = 0;
			//if (int.TryParse(inAdditionNumberText, out episode))
			//{
			//	episode = _ComicViewerModel.GetAddedEpisode(episode);
			//}
			//return episode.ToString();

			return string.Empty;
		}
	}
}
