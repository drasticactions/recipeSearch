﻿using System;
using System.Globalization;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;

namespace Recipes
{
	public class EvenIndexBackgroundConverter : IValueConverter
	{
		static readonly Color EvenColor = Color.FromArgb("#efefef");
		static readonly Color OddColor = Colors.White;

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is int b && (b % 2 == 0))
				return EvenColor;

			return OddColor;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
