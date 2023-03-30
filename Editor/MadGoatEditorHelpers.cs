using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MadGoat.CoreUtil.Editor
{
	public static class MadGoatEditorHelpers
	{
		public static void DrawTitle(string text, GUIStyle styleTitle)
		{
			EditorGUILayout.Separator();
			GUI.backgroundColor = new Color(.4f, .4f, .4f, 1);
			GUILayout.Label(text, styleTitle);
			GUI.backgroundColor = new Color(1, 1, 1, 1);
		}

		public static void DrawHeader(string text, GUIStyle styleHeader)
		{
			GUI.backgroundColor = new Color(.4f, .4f, .4f, 1);
			GUILayout.Label(text, styleHeader);
			GUI.backgroundColor = new Color(1, 1, 1, 1);
		}

		public static void DrawSocial(GUIStyle styleHeader, GUIStyle styleContentBox)
		{
			DrawHeader("Follow us on", styleHeader);

			styleContentBox.padding = new RectOffset(0, 0, 5, 5);
			EditorGUILayout.BeginVertical(styleContentBox);
			EditorGUILayout.BeginHorizontal();
			if (GUILayout.Button("Discord"))
				Application.OpenURL("https://discord.gg/HVntBs4ghW");
			if (GUILayout.Button("Asset Store"))
				Application.OpenURL("https://assetstore.unity.com/publishers/53387");
			if (GUILayout.Button("Website"))
				Application.OpenURL("http://sunfallgames.com/");
			EditorGUILayout.EndHorizontal();
			EditorGUILayout.EndVertical();
		}

		public static void DrawVersion(string version, string pipeline, GUIStyle styleNormal)
		{
			var oldSize = styleNormal.fontSize;
			var oldStyle = styleNormal.richText;
			styleNormal.fontSize = 10;
			styleNormal.richText = true;
			var versionStr = "<b>Version: " + version + "</b> - Running on <b>" + pipeline + "</b>";
			GUILayout.Label(versionStr, styleNormal);
			styleNormal.fontSize = oldSize;
			styleNormal.richText = oldStyle;
		}

		public static void DrawVersion(string version, GUIStyle styleNormal)
		{
			var oldSize = styleNormal.fontSize;
			var oldStyle = styleNormal.richText;
			styleNormal.fontSize = 10;
			styleNormal.richText = true;
			var versionStr = "<b>Version: " + version + "</b>";
			GUILayout.Label(versionStr, styleNormal);
			styleNormal.fontSize = oldSize;
			styleNormal.richText = oldStyle;
		}
	}
}
