using UnityContrib.UnityEngine;
using UnityEditor;
using UnityEngine;
using cls = UnityContrib.UnityEditor.MultilineWithWordWrapPropertyDrawer;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Property drawer that supports multi line text and the text is word wrapped.
    /// </summary>
    [CustomPropertyDrawer(typeof(MultilineWithWordWrapAttribute))]
    public class MultilineWithWordWrapPropertyDrawer : PropertyDrawer
    {
        /// <summary>
        /// The height of the text area.
        /// </summary>
        private const float height = 200.0f;

        /// <summary>
        /// The style to use for the text area.
        /// </summary>
        private GUIStyle style;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MultilineWithWordWrapPropertyDrawer"/> class.
        /// </summary>
        public MultilineWithWordWrapPropertyDrawer()
        {
            this.style = new GUIStyle(EditorStyles.textField);
            this.style.wordWrap = true;
            this.style.fixedHeight = cls.height;
        }

        /// <summary>
        /// The height of the text area.
        /// </summary>
        /// <param name="property">
        /// The SerializedProperty to make the custom GUI for.
        /// </param>
        /// <param name="label">
        /// The label of this property.
        /// </param>
        /// <returns>
        /// The height in pixels. 
        /// </returns>
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return cls.height;
        }

        /// <summary>
        /// Draws the editable property.
        /// </summary>
        /// <param name="position">
        /// Rectangle on the screen to use for the property GUI.
        /// </param>
        /// <param name="property">
        /// The SerializedProperty to make the custom GUI for.
        /// </param>
        /// <param name="label">
        /// The label of this property.
        /// </param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.height = cls.height;
            using (new EditorGUI.PropertyScope(position, label, property))
            {
                var input = string.Empty;
                var hasChange = EditorGUIEx.ChangeCheck(() =>
                {
                    input = EditorGUI.TextArea(position, property.stringValue, this.style);
                });
                if (hasChange)
                {
                    property.stringValue = input;
                }
            }
        }
    }
}
