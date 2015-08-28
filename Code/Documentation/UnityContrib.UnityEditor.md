# Documentation for UnityContrib.UnityEditor

## UnityContrib.UnityEditor.BaseEditorWindow

Base implementation for

### Members

#### wasPlaying

A value indicating whether or not the project was playing in the last update. This is used to monitor if

#### lastPosition

The position and size of the window in the last update call. This is used to monitor if

#### OnEnable

Called by Unity when window is enabled.

#### Update

Called by Unity 100 times a second.

#### OnGUI

Called by Unity when you should draw the controls of the window.

#### CheckPlayingState

Calls

#### CheckBoundaries

Calls

#### OnPlayStarted

Called when the projected is started.

#### OnPlayStopped

Called when the project is stopped.

#### OnResized

Called when the window have resized.

#### OnMoved

Called when the window have moved.

## UnityContrib.UnityEditor.EditorApplicationEx

Provides a set of helper methods for working with the

### Members

#### editorApplicationType

The

#### setSceneRepaintDirtyMethod

The

#### SetSceneRepaintDirty

Flags repainting of the scene.

## UnityContrib.UnityEditor.EditorGUIEx

Provides helper methods for working with the

### Members

#### DrawRectangle(UnityEngine.Rect,UnityEngine.Color)

Draws a rectangle at the spcified

##### rect

The position and size of the rectangle.

##### color

The color of the rectangle.

## UnityContrib.UnityEditor.EditorGUIUtilityEx

Provides a set of helper methods for working with GUI in the editor.

### Members

#### editorGuiUtilityType

The

#### textContentMethod

The

#### TextContent(System.String)

Returns the GUIContent from the Unity builtin resources with the specified

##### name

The name of the builtin resource.

##### returns



The builtin text resource.

## UnityContrib.UnityEditor.ShaderUtilEx

Provides a set of helper methods for working with the

### Members

#### shaderUtilType

The

#### hasTangentChannelMethod

The

#### HasTangentChannel(UnityEngine.Shader)

Returns a value indicating if the specified

##### shader

The shader to query.

##### returns



true if the shader has a tangent channel; otherwise false.

## UnityContrib.UnityEditor.TerrainEx

Provides helper methods for working with the

### Members

#### terrainType

The

#### drawTreesAndFoliageField

The

#### DrawTreesAndFoliage(UnityEngine.Terrain)

Returns a value indicating if tree and foliage is drawn on the specified

##### terrain

The

##### returns



true if trees and foliage is drawn; otherwise false.

#### DrawTreesAndFoliage(UnityEngine.Terrain,System.Boolean)

Assigns a value indicating if tree and foliage is drawn on the specified

##### terrain

The

##### value

true if trees and foliage is drawn; otherwise false.

