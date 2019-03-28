using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Livet;
using guraburuEX.Model;
using guraburuEX.Model.Util;

namespace guraburuEX.ViewModels
{
	class EpisodeSelectorViewModel : ViewModel
	{
		// 依存クラス
		EpisodeSelectorModel _EpisodeSelectorModel;

		ComicViewerModel _ComicViewerModel;

		// BindingParameters
		#region Width
		private int _Width;
		public int Width
		{
			get
			{ return _Width; }
			set
			{
				if (_Width == value)
					return;
				_Width = value;
				RaisePropertyChanged(nameof(Width));
			}
		}
		#endregion

		#region Height
		private int _Height;
		public int Height
		{
			get
			{ return _Height; }
			set
			{
				if (_Height == value)
					return;
				_Height = value;
				RaisePropertyChanged(nameof(Height));
			}
		}
		#endregion

		#region EpisodeText
		private string _EpisodeText;
		public string EpisodeText
		{
			get
			{ return _EpisodeText; }
			set
			{
				if (_EpisodeText == value)
					return;
				_EpisodeText = value;

				UpdateEpisode(_EpisodeText);

				RaisePropertyChanged(nameof(EpisodeText));
			}
		}
		#endregion

		// Commands

		public EpisodeSelectorViewModel(ComicViewerModel inComicViewerModel)
		{
			_EpisodeSelectorModel = new EpisodeSelectorModel(this, inComicViewerModel);
			EpisodeText = inComicViewerModel.GuraburuImege.Episode.ToString();
		}

		private void UpdateEpisode(string inEpisodeString)
		{
			_EpisodeSelectorModel.UpdateEpisode(inEpisodeString);
		}
	}
}
