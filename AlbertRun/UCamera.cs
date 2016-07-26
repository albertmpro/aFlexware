using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.UI.Xaml.Controls;

namespace Albert.Flex.Runtime
{
	public class UCamera
	{
		private static UCamera _default;
		CaptureElement capturePreview;
		MediaCapture mediaCap;
		ImageEncodingProperties imageProperties = ImageEncodingProperties.CreateJpeg();
		public static UCamera GetDefault()
		{
			if(_default == null)
			{
				_default = new UCamera();
			}
			return _default;
		}

		public async void InitPreview(CaptureElement _capturePReview)
		{
			capturePreview = _capturePReview;
			mediaCap = new MediaCapture();
			
			await  mediaCap.InitializeAsync();
			capturePreview.Source = mediaCap;
			await mediaCap.StartPreviewAsync();
	
			
		}

	}
}
