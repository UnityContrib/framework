using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using UnityContrib.UnityEngine;
using UnityEditor;
using UnityEngine;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Editor window displaying the timeline.
    /// </summary>
    public class TimelineLogWindow : BaseEditorWindow, IHasCustomMenu
    {
        /// <summary>
        /// The skin to use for the timeline.
        /// </summary>
        private GUISkin skin;

        /// <summary>
        /// The style to use for the source foldout.
        /// </summary>
        private GUIStyle sourceStyle;

        /// <summary>
        /// The style to use for the category label.
        /// </summary>
        private GUIStyle categoryStyle;

        /// <summary>
        /// The style to use for the entry label.
        /// </summary>
        private GUIStyle entryStyle;

        /// <summary>
        /// The style to use for the zoom label.
        /// </summary>
        private GUIStyle zoomStyle;

        /// <summary>
        /// The style to use for the vertical scrollbar.
        /// </summary>
        private GUIStyle verticalScrollbarStyle;

        /// <summary>
        /// The style to use for the horizontal scrollbar.
        /// </summary>
        private GUIStyle horizontalScrollbarStyle;

        /// <summary>
        /// The width of the header column.
        /// </summary>
        private float headerWidth = 150.0f;

        /// <summary>
        /// The height of header rows.
        /// </summary>
        private float rowHeight = 20.0f;

        /// <summary>
        /// The height of entry rows.
        /// </summary>
        private float entryRowHeight = 14.0f;

        /// <summary>
        /// The minimum width of an entry.
        /// </summary>
        private float minEntryWidth = 5.0f;

        /// <summary>
        /// The scale of the timeline.
        /// Used to control zoom.
        /// </summary>
        private float timeScale = 100.0f;

        /// <summary>
        /// The background color of even rows.
        /// </summary>
        private Color bgColor1 = new Color(76.0f / 255.0f, 76.0f / 255.0f, 76.0f / 255.0f);

        /// <summary>
        /// The background color of odd rows.
        /// </summary>
        private Color bgColor2 = new Color(71.0f / 255.0f, 71.0f / 255.0f, 71.0f / 255.0f);

        /// <summary>
        /// The position of the handle for the vertical scrollbar.
        /// </summary>
        private Vector2 verticalScrollPosition;

        /// <summary>
        /// The position of the handle for the horizontal scrollbar.
        /// </summary>
        private Vector2 horizontalScrollPosition;

        /// <summary>
        /// The width of the vertical scrollbar.
        /// </summary>
        private float scrollbarWidth;

        /// <summary>
        /// The height of the horizontal scrollbar.
        /// </summary>
        private float scrollbarHeight;

        /// <summary>
        /// The width of the horizontal scroll view.
        /// </summary>
        private float canvasWidth;

        /// <summary>
        /// The height of the vertical scroll view.
        /// </summary>
        private float canvasHeight;

        /// <summary>
        /// The visible boundaries of the vertical scroll view.
        /// </summary>
        private Rect verticalScrollRect;

        /// <summary>
        /// The total bounaries of the vertical scroll view.
        /// </summary>
        private Rect verticalScrollViewRect;

        /// <summary>
        /// The visible boundaries of the horizontal scroll view.
        /// </summary>
        private Rect horizontalScrollRect;

        /// <summary>
        /// The total boundaries of the horizontal scroll view.
        /// </summary>
        private Rect horizontalScrollViewRect;

        /// <summary>
        /// Displays the timeline editor window.
        /// </summary>
        [MenuItem("Window/Timeline Log")]
        public static void ShowWindow()
        {
            var window = ScriptableObject.CreateInstance<TimelineLogWindow>();
            window.titleContent = new GUIContent("Timeline Log");
            window.Show();
        }

        /// <summary>
        /// Loads skin and caches references to styles.
        /// </summary>
        protected override void OnEnable()
        {
            base.OnEnable();

            this.skin = (GUISkin)(AssetDatabase.LoadAssetAtPath("Assets/UnityContrib/GUISkins/TimelineLogWindow.guiskin", typeof(GUISkin)));
            if (this.skin == null)
            {
                Debug.LogError("TimelineLogWindow.guiskin not found");
                return;
            }

            this.sourceStyle = this.skin.GetStyle("Source");
            this.categoryStyle = this.skin.GetStyle("Category");
            this.entryStyle = this.skin.GetStyle("Entry");
            this.zoomStyle = this.skin.GetStyle("Zoom");
            this.verticalScrollbarStyle = this.skin.verticalScrollbar;
            this.horizontalScrollbarStyle = this.skin.horizontalScrollbar;
        }

        // TODO ???
        //protected override void OnResized()
        //{
        //    base.OnResized();
        //}

        /// <summary>
        /// Repaints the timeline when start playing.
        /// </summary>
        protected override void OnPlayStarted()
        {
            base.OnPlayStarted();
            this.Repaint();
        }

        /// <summary>
        /// Repaints the timeline when end playing.
        /// </summary>
        protected override void OnPlayStopped()
        {
            base.OnPlayStopped();
            this.Repaint();
        }

        /// <summary>
        /// Calculates sizes and boundaries for the timeline.
        /// </summary>
        private void CalculateLayout()
        {
            this.scrollbarWidth = this.verticalScrollbarStyle.fixedWidth;
            this.scrollbarHeight = this.horizontalScrollbarStyle.fixedHeight;
            this.canvasWidth = TimelineLog.MaxTime * this.timeScale;
            this.canvasHeight = (TimelineLog.TotalSources + TimelineLog.TotalCategories) * this.rowHeight;
            this.verticalScrollRect = new Rect(0.0f, 0.0f, this.position.width, this.position.height - this.scrollbarHeight);
            this.verticalScrollViewRect = new Rect(0.0f, 0.0f, this.position.width - this.scrollbarWidth, this.canvasHeight);
            this.horizontalScrollRect = new Rect(this.headerWidth, 0.0f, this.verticalScrollViewRect.width - this.headerWidth, this.verticalScrollViewRect.height);
            this.horizontalScrollViewRect = new Rect(0.0f, 0.0f, this.canvasWidth, this.canvasHeight);
        }

        /// <summary>
        /// Prepares and renders the timeline.
        /// </summary>
        protected override void OnGUI()
        {
            base.OnGUI();
            this.UpdateZoom();
            this.CalculateLayout();
            this.DrawWindow();
        }

        /// <summary>
        /// Adds export feature to timeline menu.
        /// </summary>
        /// <param name="menu">
        /// The menu to add the features to.
        /// </param>
        public void AddItemsToMenu(GenericMenu menu)
        {
            var content = new GUIContent("Export as CSV..");
            menu.AddItem(content, false, this.ExportAsCSV); // "on" parameter means if the menu item is checked
        }

        /// <summary>
        /// Exports the timeline to comma separated values (CSV) plain text file format.
        /// </summary>
        private void ExportAsCSV()
        {
            var result = EditorUtility.SaveFilePanel(
                "Export timeline as CSV",
                Environment.CurrentDirectory,
                DateTime.Now.ToString("yyyyMMdd-HHmmss-") + "timeline.csv",
                "csv"
                );
            if (string.IsNullOrEmpty(result))
            {
                return;
            }

            using (var writer = File.CreateText(result))
            {
                writer.WriteLine("sep=;");
                writer.WriteLine(@"""Start"";""End"";""Color"";""Source"";""Category"";""Message""");
                foreach (string sourceName in TimelineLog.Sources.Keys)
                {
                    var source = TimelineLog.Sources[sourceName] as TimelineLogSource;
                    foreach (string categoryName in source.Categories.Keys)
                    {
                        var entries = source.Categories[categoryName] as LinkedList<TimelineLogEntry>;
                        foreach (var entry in entries)
                        {
                            var line = string.Format(
                                @"{5};{3};""{2}"";""{0}"";""{1}"";""{4}""",
                                sourceName.Replace("\"", "\"\""), // pos 0
                                categoryName.Replace("\"", "\"\""), // pos 1
                                entry.Color, // pos 2
                                entry.End.ToString("0.000000", CultureInfo.InvariantCulture), // pos 3
                                entry.Message.Replace("\"", "\"\""), // pos 4
                                entry.Start.ToString("0.000000", CultureInfo.InvariantCulture) // pos 5
                                );
                            writer.WriteLine(line);
                        }
                    }
                }
            }

            Debug.Log("Timeline log exported: " + result);
        }

        /// <summary>
        /// Converts mouse input to zoom level.
        /// </summary>
        private void UpdateZoom()
        {
            if (Event.current.type == EventType.ScrollWheel)
            {
                this.timeScale += Event.current.delta.y * this.timeScale * 0.04f;
                if (this.timeScale < 0.01f)
                {
                    this.timeScale = 0.01f;
                }
                Event.current.Use();
            }
        }

        /// <summary>
        /// Renders the timeline.
        /// </summary>
        private void DrawWindow()
        {
            GUI.skin = skin;

            GUIEx.ScrollView(this.verticalScrollRect, this.verticalScrollPosition, this.verticalScrollViewRect, GUIStyle.none, GUIStyle.none, () =>
            {
                this.DrawBackground();
                this.DrawNames();
                GUIEx.ScrollView(this.horizontalScrollRect, this.horizontalScrollPosition, this.horizontalScrollViewRect, GUIStyle.none, GUIStyle.none, () =>
                {
                    this.DrawEntries();
                });
            });

            this.DrawScrollbars();
            this.DrawZoomInfo();
        }

        /// <summary>
        /// Renders the background of the timeline.
        /// </summary>
        private void DrawBackground()
        {
            var rect = new Rect(0.0f, 0.0f, this.position.width - this.scrollbarWidth, this.rowHeight);
            foreach (var sourceName in TimelineLog.Sources.Keys.OfType<string>().OrderBy(s => s))
            {
                // nothing to output here, but still increment y-axis
                rect.y += this.rowHeight;

                var source = TimelineLog.Sources[sourceName] as TimelineLogSource;
                if (source.IsFolded)
                {
                    continue;
                }

                for (var index = 0; index < source.Categories.Count; index++)
                {
                    var color = (rect.y % (this.rowHeight * 2.0f)) == 0.0f ? this.bgColor1 : this.bgColor2;
                    EditorGUIEx.DrawRectangle(rect, color);
                    rect.y += this.rowHeight;
                }
            }
            GUI.color = Color.white;
        }

        /// <summary>
        /// Renders the header column.
        /// </summary>
        private void DrawNames()
        {
            var rect = new Rect(0.0f, 0.0f, this.headerWidth, this.rowHeight);
            foreach (var sourceName in TimelineLog.Sources.Keys.OfType<string>().OrderBy(s => s))
            {
                var source = TimelineLog.Sources[sourceName] as TimelineLogSource;

                source.IsFolded = !EditorGUI.Foldout(rect, !source.IsFolded, sourceName, this.sourceStyle);

                rect.y += this.rowHeight;

                if (source.IsFolded)
                {
                    continue;
                }

                foreach (var category in source.Categories.Keys.OfType<string>().OrderBy(s => s))
                {
                    var content = new GUIContent(category, category);
                    GUI.Label(rect, content, this.categoryStyle);
                    rect.y += this.rowHeight;
                }
            }
        }

        /// <summary>
        /// Renders the entries.
        /// </summary>
        private void DrawEntries()
        {
            var rect = new Rect(this.headerWidth, 0.0f, 0.0f, this.entryRowHeight);
            foreach (var sourceName in TimelineLog.Sources.Keys.OfType<string>().OrderBy(s => s))
            {
                var source = TimelineLog.Sources[sourceName] as TimelineLogSource;
                if (source.IsFolded)
                {
                    continue;
                }

                GUI.color = this.bgColor1;
                var columnWidth = 100.0f;
                var width = Mathf.Max(this.canvasWidth, this.position.width);
                var count = width / columnWidth;
                for (var index = 0; index < count; index++)
                {
                    var timeRect = new Rect(index * columnWidth, rect.y, 1.0f, this.rowHeight);
                    EditorGUIEx.DrawRectangle(timeRect, this.bgColor1);
                    timeRect.x += 2.0f;
                    timeRect.width = columnWidth;
                    GUI.Label(timeRect, ((index * columnWidth) / this.timeScale) + "s");
                }
                rect.y += this.rowHeight + (this.rowHeight - this.entryRowHeight) * 0.5f;
                GUI.color = Color.white;

                foreach (var categoryName in source.Categories.Keys.OfType<string>().OrderBy(s => s))
                {
                    var entries = source.Categories[categoryName] as LinkedList<TimelineLogEntry>;
                    foreach (var entry in entries)
                    {
                        var delta = entry.End - entry.Start;
                        var content = new GUIContent(
                            entry.Message,
                            entry.Message + Environment.NewLine +
                            "Start: " + entry.Start + "s" + Environment.NewLine +
                            "End: " + entry.End + "s" + Environment.NewLine +
                            "Delta: " + delta + "s"
                            );
                        rect.x = entry.Start * this.timeScale;
                        rect.width
                            = this.entryStyle.fixedWidth
                                = Mathf.Max(delta * this.timeScale, this.minEntryWidth)
                                ;
                        EditorGUIEx.DrawRectangle(rect, entry.Color);
                        GUI.color = Color.white;
                        GUI.Label(rect, content, this.entryStyle);
                    }

                    rect.y += this.rowHeight;
                }
            }
        }

        /// <summary>
        /// Renders the scrollbars.
        /// </summary>
        private void DrawScrollbars()
        {
            var rect = new Rect(
                this.position.width - this.scrollbarWidth,
                0.0f,
                this.scrollbarWidth,
                this.position.height - this.scrollbarHeight
                );
            var size = rect.height / Mathf.Floor(this.verticalScrollViewRect.height / rect.height);
            this.verticalScrollPosition.y = GUI.VerticalScrollbar(rect, this.verticalScrollPosition.y, size, 0.0f, this.canvasHeight, this.verticalScrollbarStyle);

            rect = new Rect(
                this.headerWidth,
                this.position.height - this.scrollbarHeight,
                this.horizontalScrollRect.width,
                this.scrollbarHeight
                );
            size = rect.width / Mathf.Floor(this.horizontalScrollViewRect.width / rect.width);
            this.horizontalScrollPosition.x = GUI.HorizontalScrollbar(rect, Mathf.Abs(this.horizontalScrollPosition.x), size, 0.0f, this.canvasWidth, this.horizontalScrollbarStyle);
        }

        /// <summary>
        /// Renders the zoom level.
        /// </summary>
        private void DrawZoomInfo()
        {
            var rect = new Rect(0.0f, this.position.height - this.scrollbarHeight, this.headerWidth, this.scrollbarHeight);
            GUI.Label(rect, "Zoom " + (this.timeScale * 100.0f).ToString("#,##0.00") + "%", this.zoomStyle);
        }
    }
}
