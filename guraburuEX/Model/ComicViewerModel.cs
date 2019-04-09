using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using guraburuEX.Model.Util;
using guraburuEX.ViewModels;

using Livet;

namespace guraburuEX.Model
{
	class ComicViewerModel : NotificationObject
	{
		public int			 Width			{ get; set; }
		public int			 Height			{ get; set; }
		public GuraburuImage GuraburuImege	{ get; set; } 

		public int Episode
		{
			get { return GuraburuImege.Episode; }
			set
			{
				GuraburuImege.Episode = value;
				RaisePropertyChanged();
			}
		}

		public BitmapImage Image
		{
			get { return GuraburuImege.Image; }
		}

		public ComicViewerModel()
		{
			InitWindow();
		}

		public void InitWindow()
		{
			Width	= AppConfigUtil.GetAppSettingInt("ImageWidth", 630);
			Height	= AppConfigUtil.GetAppSettingInt("ImageHeight", 1260);

			GuraburuImege = new GuraburuImage(AppConfigUtil.GetAppSettingString("BaseURL"), 1);
		}

		public void UpdateEpisode(int inDistans)
		{
			GuraburuImege.Episode += inDistans;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class GuraburuImage
	{
		BitmapImage _ImageSource;
		readonly string _BaseImageURL;
		int _Episode;

		public GuraburuImage(string inBaseURL,int inEpisode)
		{
			_BaseImageURL = inBaseURL;
			Episode = inEpisode;
		}

		public int Episode
		{
			get { return _Episode; }
			set
			{
				if (value > 0)
				{
					_Episode = value;
					UpdateImageSource(_Episode);
				}
			}
		}

		public string ImageURL
		{
			get { return _BaseImageURL + "_" + Episode.ToString() + ".jpg"; }
		}

		public BitmapImage Image { get { return _ImageSource; } }

		private void UpdateImageSource(int inEpisode)
		{
			Uri uri = new Uri(ImageURL);
			var source = new BitmapImage();
			source.BeginInit();
			source.UriSource = uri;
			source.EndInit();

			_ImageSource = source;
		}
	}
}
