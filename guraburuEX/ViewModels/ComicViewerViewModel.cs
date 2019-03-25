using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Livet;
using guraburuEX.Model;
using System.Windows.Media.Imaging;

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
		public int Width
		{
			get
			{ return _ComicViewerModel.Width; }
			set
			{
				if (_ComicViewerModel.Width == value)
					return;
				_ComicViewerModel.Width = value;
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

		#region ComicHeight
		private int _ComicHeight;
		public int ComicHeight
		{
			get
			{ return _ComicHeight; }
			set
			{
				if (_ComicHeight == value)
					return;
				_ComicHeight = value;
				RaisePropertyChanged(nameof(ComicHeight));
			}
		}
		#endregion

		#region SelectorHeight
		private int _SelectorHeight;
		public int SelectorHeight
		{
			get
			{ return _SelectorHeight; }
			set
			{
				if (_SelectorHeight == value)
					return;
				_SelectorHeight = value;
				RaisePropertyChanged(nameof(SelectorHeight));
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

		public ComicViewerViewModel()
		{
			_EpisodeSelectorViewModel = new EpisodeSelectorViewModel();

			_ComicViewerModel = new ComicViewerModel();
			_ComicViewerModel.GetImageSource();

			Height			= _EpisodeSelectorViewModel.Height + _ComicViewerModel.Height;
			Width			= _ComicViewerModel.Width;
			Image			= _ComicViewerModel.Image;
			ComicHeight		= _ComicViewerModel.Height;
			SelectorHeight	= _EpisodeSelectorViewModel.Height;
		}
	}
}
