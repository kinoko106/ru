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
		EpisodeSelectorModel _EpisodeSelectorModel;

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

		public EpisodeSelectorViewModel()
		{
			_EpisodeSelectorModel = new EpisodeSelectorModel();

			Width = _EpisodeSelectorModel.Width;
			Height = _EpisodeSelectorModel.Height;
		}
	}
}
