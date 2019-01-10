using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Livet;
using guraburuEX.Model;

namespace guraburuEX.ViewModels
{
	class ComicViewerViewModel : ViewModel
	{
		ComicViewerModel _ComicViewerModel;
		
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
		public int Height
		{
			get
			{ return _ComicViewerModel.Height; }
			set
			{
				if (_ComicViewerModel.Height == value)
					return;
				_ComicViewerModel.Height = value;
				RaisePropertyChanged(nameof(Height));
			}
		}
		#endregion

		#region Text
		public string Text
		{
			get
			{ return _ComicViewerModel.Text; }
			set
			{
				if (_ComicViewerModel.Text == value)
					return;
				_ComicViewerModel.Text = value;
				RaisePropertyChanged(nameof(Text));
			}
		}
		#endregion

		public ComicViewerViewModel()
		{
			_ComicViewerModel = new ComicViewerModel();
		}
	}
}
