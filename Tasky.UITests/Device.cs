using System;
using Xamarin.UITest;

namespace Tasky.UITests
{
	public static class Device
	{
		public static void OnPlatform(Action iOS = null, Action Android = null)
		{
            var platform = Setup.Platform;

			if (platform == Platform.iOS)
			{
				iOS.Invoke();
			}
			else if (platform == Platform.Android)
			{
				Android.Invoke();
			}
		}

		public static T OnPlatform<T>(T iOS = default(T), T Android = default(T))
		{
            var platform = Setup.Platform;

			if (platform == Platform.iOS)
			{
				return iOS;
			}
			else if (platform == Platform.Android)
			{
				return Android;
			}

			return default(T);
		}
	}
}
