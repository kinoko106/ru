using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Livet;
using guraburuEX.Model;

namespace guraburuEX.ViewModels
{
	class MainWindowViewModel : ViewModel
	{
		// Model
		MainWindowModel _MainWindowModel;

		// Parameter
		#region Width
		public int Width
		{
			get
			{ return _MainWindowModel.Width; }
			set
			{
				if (_MainWindowModel.Width == value)
					return;
				_MainWindowModel.Width = value;
				RaisePropertyChanged(nameof(Width));
			}
		}
		#endregion

		#region Height
		public int Height
		{
			get
			{ return _MainWindowModel.Height; }
			set
			{
				if (_MainWindowModel.Height == value)
					return;
				_MainWindowModel.Height = value;
				RaisePropertyChanged(nameof(Height));
			}
		}
		#endregion

		// viewmodel
		#region ComicViewerViewModel
		public ComicViewerViewModel _ComicViewerViewModel;

		public ComicViewerViewModel ComicViewerViewModel
		{
			get
			{ return _ComicViewerViewModel; }
			set
			{
				if (_ComicViewerViewModel == value)
					return;
				_ComicViewerViewModel = value;
				RaisePropertyChanged(nameof(ComicViewerViewModel));
			}
		}
		#endregion

		public MainWindowViewModel()
		{
			_MainWindowModel		= new MainWindowModel();
			ComicViewerViewModel	= new ComicViewerViewModel();
		}
	}
}
