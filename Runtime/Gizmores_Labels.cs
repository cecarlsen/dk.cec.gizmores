/*
	Copyright © Carl Emil Carlsen 2024
	http://cec.dk
*/

using UnityEngine;

public static partial class Gizmores
{
	static GUIStyle labelStyle;


	/// <summary>
	/// Draw a label in the scene using UnityEditor.Handles.
	/// </summary>
	public static void DrawLabel( Vector4 position, string text, GUIStyle style = null )
	{
#if UNITY_EDITOR
		GUIStyle usedStyle;
		if( style != null ) {
			usedStyle = style;
		} else {
			if( labelStyle == null ) labelStyle = new GUIStyle();
			labelStyle.normal.textColor = Gizmos.color;
			usedStyle = labelStyle;
		}

		UnityEditor.Handles.Label( position, text, usedStyle );
#endif
	}
}