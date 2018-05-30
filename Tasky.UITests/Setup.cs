using System;
using Xamarin.UITest;

namespace Tasky.UITests
{
	public static class Setup
	{
		public static IApp App { get; private set; }
		public static Platform Platform { get; private set; }

		public static IApp Start(Platform platform)
		{
			Platform = platform;
			IApp app = null;

			switch (platform)
			{
				case Platform.Android:
                    app = ConfigureApp.Android.Debug().EnableLocalScreenshots().ApkFile("/Users/rashmi.padhi/Documents/BitRise Backup/Tasky/TaskyAndroid/bin/Debug/com.xamarin.samples.taskyandroid.apk") .StartApp();
					break;
				case Platform.iOS:
                    app = ConfigureApp.iOS.Debug().EnableLocalScreenshots().AppBundle("/Users/rashmi.padhi/Documents/BitRise Backup/Tasky/TaskyiOS/bin/iPhoneSimulator/Debug/device-builds/iphone6.1-11.1/Tasky.app") .StartApp();
					break;
				default:
					throw new ArgumentException("Unhandled Platform");
			}

			return App = app;
		}
	}
}
