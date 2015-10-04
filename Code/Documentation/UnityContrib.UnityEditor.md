# Documentation for UnityContrib.UnityEditor

## UnityContrib.UnityEditor.BaseEditorWindow

Base implementation for [UnityEngine.EditorWindow](http://docs.unity3d.com/ScriptReference/EditorWindow.html) .

### Members

#### wasPlaying

A value indicating whether or not the project was playing in the last update. This is used to monitor if OnPlayStarted or OnPlayStopped should be called.

#### lastPosition

The position and size of the window in the last update call. This is used to monitor if OnMoved or OnResized should be called.

#### OnEnable

Called by Unity when window is enabled.

#### Update

Called by Unity 100 times a second.

#### OnGUI

Called by Unity when you should draw the controls of the window.

#### CheckPlayingState

Calls OnPlayStarted if playing started and OnPlayStopped if stopped.

#### CheckBoundaries

Calls OnMoved if window moved and OnResized if resized.

#### OnPlayStarted

Called when the projected is started.

#### OnPlayStopped

Called when the project is stopped.

#### OnResized

Called when the window have resized.

#### OnMoved

Called when the window have moved.

## UnityContrib.UnityEditor.EditorApplicationEx

Provides a set of helper methods for working with the UnityEditor.EditorApplication class.

### Members

#### editorApplicationType

The SystemType of UnityEditor.EditorApplication class.

#### setSceneRepaintDirtyMethod

The [System.Reflection.MethodInfo](https://msdn.microsoft.com/en-us/library/System.Reflection.MethodInfo%28v=vs.90%29.aspx) of the UnityEditor.EditorApplication.SetSceneRepaintDirty method.

#### SetSceneRepaintDirty

Flags repainting of the scene.

## UnityContrib.UnityEditor.EditorGUIEx

Provides helper methods for working with the [UnityEngine.GUI](http://docs.unity3d.com/ScriptReference/GUI.html) and UnityEditor.EditorGUI classes.

### Members

#### DrawRectangle(UnityEngine.Rect,UnityEngine.Color)

Draws a rectangle at the spcified rect with the specified color .

##### rect

The position and size of the rectangle.

##### color

The color of the rectangle.

#### ChangeCheck(System.Action)

Check if any control was changed inside a block of code.

##### content

The callback to invoke between start and end change check.

##### returns

true if changed; otherwise false.

## UnityContrib.UnityEditor.EditorGUIUtilityEx

Provides a set of helper methods for working with GUI in the editor.

### Members

#### editorGuiUtilityType

The SystemType of UnityEditor.EditorGUIUtility class.

#### textContentMethod

The [System.Reflection.MethodInfo](https://msdn.microsoft.com/en-us/library/System.Reflection.MethodInfo%28v=vs.90%29.aspx) of the UnityEditor.EditorGUIUtility.TextContent method.

#### TextContent(System.String)

Returns the GUIContent from the Unity builtin resources with the specified name .

##### name

The name of the builtin resource.

##### returns

The builtin text resource.

## UnityContrib.UnityEditor.MassTreePlacementEditor

Places random trees on a terrain.

### Members

#### terrainDataType

Reference to the [UnityEngine.TerrainData](http://docs.unity3d.com/ScriptReference/TerrainData.html) type for later invocation using reflection.

#### OnInspectorGUI

Draws the "Place" and "Clear" buttons.

#### Clear(UnityEngine.Terrain)

Clears the terrain of all trees.

##### terrain

The terrain who's trees to remove.

#### PlaceRandomTrees(UnityEngine.Terrain,UnityContrib.UnityEngine.MassTreePlacement)

Places random trees on the terrain.

##### terrain

The terrain to place trees on.

##### mtp

The settings for the tree placement.

#### RecalculateTreePositions(UnityEngine.TerrainData)

Invokes [UnityEngine.TerrainData.RecalculateTreePositions](http://docs.unity3d.com/ScriptReference/TerrainData.RecalculateTreePositions.html) using reflection.

##### data

The instance to invoke the method on.

## UnityContrib.UnityEditor.MultilineWithWordWrapPropertyDrawer

Property drawer that supports multi line text and the text is word wrapped.

### Members

#### height

The height of the text area.

#### style

The style to use for the text area.

#### #ctor

Initializes a new instance of the MultilineWithWordWrapPropertyDrawer class.

#### GetPropertyHeight(UnityEditor.SerializedProperty,UnityEngine.GUIContent)

The height of the text area.

##### property

The SerializedProperty to make the custom GUI for.

##### label

The label of this property.

##### returns

The height in pixels.

#### OnGUI(UnityEngine.Rect,UnityEditor.SerializedProperty,UnityEngine.GUIContent)

Draws the editable property.

##### position

Rectangle on the screen to use for the property GUI.

##### property

The SerializedProperty to make the custom GUI for.

##### label

The label of this property.

## UnityContrib.UnityEditor.ShaderUtilEx

Provides a set of helper methods for working with the [UnityEngine.Shader](http://docs.unity3d.com/ScriptReference/Shader.html) class.

### Members

#### shaderUtilType

The SystemType of UnityEditor.ShaderUtil class.

#### hasTangentChannelMethod

The [System.Reflection.MethodInfo](https://msdn.microsoft.com/en-us/library/System.Reflection.MethodInfo%28v=vs.90%29.aspx) of the UnityEditor.ShaderUtil.HasTangentChannel method.

#### HasTangentChannel(UnityEngine.Shader)

Returns a value indicating if the specified shader has a tangent channel.

##### shader

The shader to query.

##### returns

true if the shader has a tangent channel; otherwise false.

## UnityContrib.UnityEditor.TerrainEx

Provides helper methods for working with the [UnityEngine.Terrain](http://docs.unity3d.com/ScriptReference/Terrain.html) class.

### Members

#### terrainType

The SystemType of [UnityEngine.Terrain](http://docs.unity3d.com/ScriptReference/Terrain.html) class.

#### drawTreesAndFoliageField

The [System.Reflection.FieldInfo](https://msdn.microsoft.com/en-us/library/System.Reflection.FieldInfo%28v=vs.90%29.aspx) of the [UnityEngine.Terrain.drawTreesAndFoliage](http://docs.unity3d.com/ScriptReference/Terrain.drawTreesAndFoliage.html) field.

#### DrawTreesAndFoliage(UnityEngine.Terrain)

Returns a value indicating if tree and foliage is drawn on the specified terrain .

##### terrain

The [UnityEngine.Terrain](http://docs.unity3d.com/ScriptReference/Terrain.html) to query.

##### returns

true if trees and foliage is drawn; otherwise false.

#### DrawTreesAndFoliage(UnityEngine.Terrain,System.Boolean)

Assigns a value indicating if tree and foliage is drawn on the specified terrain .

##### terrain

The [UnityEngine.Terrain](http://docs.unity3d.com/ScriptReference/Terrain.html) to change.

##### value

true if trees and foliage is drawn; otherwise false.

## UnityContrib.UnityEditor.TimelineLogWindow

Editor window displaying the timeline.

### Members

#### skin

The skin to use for the timeline.

#### sourceStyle

The style to use for the source foldout.

#### categoryStyle

The style to use for the category label.

#### entryStyle

The style to use for the entry label.

#### zoomStyle

The style to use for the zoom label.

#### verticalScrollbarStyle

The style to use for the vertical scrollbar.

#### horizontalScrollbarStyle

The style to use for the horizontal scrollbar.

#### headerWidth

The width of the header column.

#### rowHeight

The height of header rows.

#### entryRowHeight

The height of entry rows.

#### minEntryWidth

The minimum width of an entry.

#### timeScale

The scale of the timeline. Used to control zoom.

#### bgColor1

The background color of even rows.

#### bgColor2

The background color of odd rows.

#### verticalScrollPosition

The position of the handle for the vertical scrollbar.

#### horizontalScrollPosition

The position of the handle for the horizontal scrollbar.

#### scrollbarWidth

The width of the vertical scrollbar.

#### scrollbarHeight

The height of the horizontal scrollbar.

#### canvasWidth

The width of the horizontal scroll view.

#### canvasHeight

The height of the vertical scroll view.

#### verticalScrollRect

The visible boundaries of the vertical scroll view.

#### verticalScrollViewRect

The total bounaries of the vertical scroll view.

#### horizontalScrollRect

The visible boundaries of the horizontal scroll view.

#### horizontalScrollViewRect

The total boundaries of the horizontal scroll view.

#### ShowWindow

Displays the timeline editor window.

#### OnEnable

Loads skin and caches references to styles.

#### OnPlayStarted

Repaints the timeline when start playing.

#### OnPlayStopped

Repaints the timeline when end playing.

#### CalculateLayout

Calculates sizes and boundaries for the timeline.

#### OnGUI

Prepares and renders the timeline.

#### AddItemsToMenu(UnityEditor.GenericMenu)

Adds export feature to timeline menu.

##### menu

The menu to add the features to.

#### ExportAsCSV

Exports the timeline to comma separated values (CSV) plain text file format.

#### UpdateZoom

Converts mouse input to zoom level.

#### DrawWindow

Renders the timeline.

#### DrawBackground

Renders the background of the timeline.

#### DrawNames

Renders the header column.

#### DrawEntries

Renders the entries.

#### DrawScrollbars

Renders the scrollbars.

#### DrawZoomInfo

Renders the zoom level.

