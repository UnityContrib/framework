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

