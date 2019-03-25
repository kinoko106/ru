using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using guraburuEX.Model.Util;

namespace guraburuEX.Model
{
	class ComicViewerModel
	{
		public int			 Width			{ get; set; }
		public int			 Height			{ get; set; }
		public int			 Episode		{ get; set; }
		public BitmapImage	 Image			{ get; set; }
		public GuraburuImage GuraburuImege	{ get; set; }

		public ComicViewerModel()
		{
			InitWindow();
		}

		public void InitWindow()
		{
			Width		  = AppConfigUtil.GetAppSettingInt("ImageWidth", 630);
			Height		  = AppConfigUtil.GetAppSettingInt("ImageHeight", 1260);
			GuraburuImege = new GuraburuImage(AppConfigUtil.GetAppSettingString("BaseURL"));
			GuraburuImege.Episode = 1;
		}

		public void GetImageSource()
		{
			GuraburuImege.Episode = 1;

			Uri uri = new Uri(GuraburuImege.ImageURL);
			var source = new BitmapImage();
			source.BeginInit();
			source.UriSource = uri;
			source.EndInit();

			Image = source;
		}

		public void GetImageSource(int inEpisodeNum)
		{
			GuraburuImege.Episode = inEpisodeNum;

			Uri uri = new Uri(GuraburuImege.ImageURL);
			var source = new BitmapImage();
			source.BeginInit();
			source.UriSource = uri;
			source.EndInit();

			Image = source;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class GuraburuImage
	{
		string _ImageURL;

		public GuraburuImage(string inURL)
		{
			_ImageURL = inURL;
			Episode = 0;
		}

		public int Episode { get; set; }

		public string ImageURL
		{
			get { return _ImageURL + "_" + Episode.ToString() + ".jpg"; }
			set { _ImageURL = value; }
		}
	}
}
