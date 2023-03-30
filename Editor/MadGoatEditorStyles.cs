using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MadGoat.CoreUtil.Editor
{
	public static class MadGoatEditorStyles
	{
		private static readonly Dictionary<Color, GUIStyle> headerStyles = new Dictionary<Color, GUIStyle>();
		private static readonly Dictionary<Color, GUIStyle> footerStyles = new Dictionary<Color, GUIStyle>();

		private static GUIStyle contentBoxStyle;
		private static GUIStyle richLabelStyle;

		public static GUIStyle GetHeaderStyle(Color accentColor)
		{
			// Return cached if it exists
			if (headerStyles.ContainsKey(accentColor))
			{
				return headerStyles[accentColor];
			}

			var style = new GUIStyle("ShurikenModuleTitle");
			style.normal.textColor = accentColor;
			style.fontSize = 12;
			style.fontStyle = FontStyle.Bold;
			style.fixedHeight = 30;

			// Cache and return
			headerStyles[accentColor] = style;
			return style;
		}
		public static GUIStyle GetContentBoxStyle()
		{
			// Return cached if any
			if (contentBoxStyle != null)
			{
				return contentBoxStyle;
			}

			var style = new GUIStyle(EditorStyles.helpBox);
			style.padding = new RectOffset(4, 4, 4, 4);
			style.margin = new RectOffset(4, 4, 4, 4);

			// Cache and return
			contentBoxStyle = style;
			return style;
		}

		public static GUIStyle GetFooterStyle(Color accentColor)
		{
			// Return cached if it exists
			if (footerStyles.ContainsKey(accentColor))
			{
				return footerStyles[accentColor];
			}

			var style = new GUIStyle();
			style.fontSize = 12;
			style.richText = true;
			style.normal.textColor = accentColor;

			// Cache and return
			footerStyles[accentColor] = style;
			return style;
		}

		public static GUIStyle GetRichTextStyle()
		{
			// Return cached if any
			if (richLabelStyle != null)
			{
				return richLabelStyle;
			}

			var style = new GUIStyle(EditorStyles.label);
			style.richText = true;

			// Cache and return
			richLabelStyle = style;
			return style;
		}
	}
}
