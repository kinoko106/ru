using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Livet;
using Livet.Commands;

using guraburuEX.Model;
using guraburuEX.Model.Util;


namespace guraburuEX.ViewModels
{
	class EpisodeSelectorViewModel : ViewModel
	{
		// 依存クラス
		EpisodeSelectorModel _EpisodeSelectorModel;

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
				RaisePropertyChanged(nameof(EpisodeText));
			}
		}
		#endregion

		// Commands
		//#region SelectorCommand
		//ListenerCommand<string> _SelectorCommand;
		//public ICommand SelectorCommand
		//{
		//	get
		//	{
		//		if (_SelectorCommand == null)
		//		{
		//			_SelectorCommand = new ListenerCommand<string>(TurnEpisode);
		//		}
		//		return _SelectorCommand;
		//	}
		//}
		//#endregion

		public EpisodeSelectorViewModel()
		{
			_EpisodeSelectorModel = new EpisodeSelectorModel();
		}
	}
}
