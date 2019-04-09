using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Input;

using Livet;
using Livet.Commands;

using guraburuEX.Model;
using Livet.EventListeners;


namespace guraburuEX.ViewModels
{
	class ComicViewerViewModel : ViewModel
	{
		ComicViewerModel _ComicViewerModel;

		// viewmodel
		#region EpisodeSelectorViewModel
		public EpisodeSelectorViewModel _EpisodeSelectorViewModel;

		public EpisodeSelectorViewModel EpisodeSelectorViewModel
		{
			get
			{ return _EpisodeSelectorViewModel; }
			set
			{
				if (_EpisodeSelectorViewModel == value)
					return;
				_EpisodeSelectorViewModel = value;
				RaisePropertyChanged(nameof(EpisodeSelectorViewModel));
			}
		}
		#endregion

		// Parameter
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

		#region Image
		public BitmapImage _Image;
		public BitmapImage Image
		{
			get
			{ return _Image; }
			set
			{
				if (_Image == value)
					return;
				_Image = value;
				RaisePropertyChanged(nameof(Image));
			}
		}
		#endregion

		#region EpisodeText
		private int _EpisodeText;
		public int EpisodeText
		{
			get
			{ return _EpisodeText; }
			set
			{
				if (_EpisodeText == value)
					return;
				_EpisodeText = value;
				RaisePropertyChanged(nameof(EpisodeText));
			}
		}
		#endregion

		#region SelectorCommand
		ViewModelCommand _OnButton;
		public ViewModelCommand OnButton
		{
			get
			{
				if (_OnButton == null)
				{
					_OnButton = new ViewModelCommand(OnButtonMethod);
				}
				return _OnButton;
			}
		}
		#endregion

		public ComicViewerViewModel()
		{
			_ComicViewerModel		  = new ComicViewerModel();
			_EpisodeSelectorViewModel = new EpisodeSelectorViewModel();
		}

		public void OnButtonMethod()
		{
			_ComicViewerModel.UpdateEpisode(1);
			Image = _ComicViewerModel.Image;
			EpisodeText = _ComicViewerModel.Episode;
		}
	}
}
