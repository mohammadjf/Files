﻿using System;
using Files.Backend.Models.Coloring;
using Files.Helpers;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

#nullable enable

namespace Files.Uwp.ValueConverters
{
	public sealed class ColorModelToColorConverter : IValueConverter
	{
		public object? Convert(object value, Type targetType, object parameter, string language)
		{
			if (value is SolidBrushColorModel solidBrushModel)
			{
				return new SolidColorBrush(ColorHelpers.FromHex(solidBrushModel.ColorHex));
			}
			else
			{
				return null;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
