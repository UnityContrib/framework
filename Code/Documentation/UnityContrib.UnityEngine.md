# Documentation for UnityContrib.UnityEngine

## UnityContrib.UnityEngine.BehaviourEx

Provides a set of helper methods for working with the [UnityEngine.Behaviour](http://docs.unity3d.com/ScriptReference/Behaviour.html) class.

### Members

#### DisableIfNull``1(``0,UnityEngine.Behaviour,System.String)

Disables the behaviour if the specified value is null.

##### value

The value to null test.

##### behaviour

The behaviour to disable.

##### variableName

The name of the value variable used in the warning message.

## UnityContrib.UnityEngine.Color32Ex

Provides a set of helper methods for working with the [UnityEngine.Color32](http://docs.unity3d.com/ScriptReference/Color32.html) struct.

### Members

#### Equals(UnityEngine.Color32,UnityEngine.Color32)

Returns a value indicating whether or not the specified [UnityEngine.Color32](http://docs.unity3d.com/ScriptReference/Color32.html) are equal.

##### value

The left side [UnityEngine.Color32](http://docs.unity3d.com/ScriptReference/Color32.html) of the comparison.

##### other

The right side [UnityEngine.Color32](http://docs.unity3d.com/ScriptReference/Color32.html) of the comparison.

##### returns

true if equal; otherwise false.

## UnityContrib.UnityEngine.DebugEx

Provides a set of helper methods for debugging.

### Members

#### DrawCross3D(UnityEngine.Vector3,System.Single,UnityEngine.Color,System.Single,System.Boolean)

Draws 3 lines intersecting each other at the specified position .

##### position

The position where the 3 lines intersect.

##### size

The length of each line.

##### color

The color of the lines.

##### duration

The amount of seconds the line must be visible for. A duration of zero shows the line for just one frame.

##### depthTest

A value indicating whether or not the line be obscured by objects closer to the camera?

## UnityContrib.UnityEngine.GUIEx

Provides helper methods for working with the [UnityEngine.GUI](http://docs.unity3d.com/ScriptReference/GUI.html) class.

### Members

#### ScrollView(UnityEngine.Rect,UnityEngine.Vector2,UnityEngine.Rect,UnityEngine.GUIStyle,UnityEngine.GUIStyle,System.Action)

Begin a scrolling view inside your GUI. ScrollViews let you make a smaller area on-screen look 'into' a much larger area, using scrollbars placed on the sides of the ScrollView.

##### rect

Rectangle on the screen to use for the ScrollView.

##### scrollPosition

The pixel distance that the view is scrolled in the X and Y directions.

##### viewRect

The rectangle used inside the scrollview.

##### horizontalScrollbar

GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.

##### verticalScrollbar

GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.

##### action

The callback that renders the controls.

##### returns

The modified scrollPosition. Feed this back into the variable you pass in.

## UnityContrib.UnityEngine.GUILayoutEx

Provides helper methods for working with the [UnityEngine.GUILayout](http://docs.unity3d.com/ScriptReference/GUILayout.html) class.

Provides helper methods for working with the [UnityEngine.GUILayout](http://docs.unity3d.com/ScriptReference/GUILayout.html) class.

### Members

#### Horizontal(System.Action,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed horizontically below each other.

##### action

The callback that renders the controls.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Horizontal(System.Action,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed horizontically below each other.

##### action

The callback that renders the controls.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Horizontal(System.Action,UnityEngine.GUIContent,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed horizontically below each other.

##### action

The callback that renders the controls.

##### content

The text, image, and tooltip for this group.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Horizontal(System.Action,System.String,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed horizontically below each other.

##### action

The callback that renders the controls.

##### text

The text to display on group.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Horizontal(System.Action,UnityEngine.Texture2D,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed horizontically below each other.

##### action

The callback that renders the controls.

##### image

The texture to display on group.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Vertical(System.Action,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed vertically below each other.

##### action

The callback that renders the controls.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Vertical(System.Action,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed vertically below each other.

##### action

The callback that renders the controls.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Vertical(System.Action,UnityEngine.GUIContent,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed vertically below each other.

##### action

The callback that renders the controls.

##### content

The text, image, and tooltip for this group.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Vertical(System.Action,System.String,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed vertically below each other.

##### action

The callback that renders the controls.

##### text

The text to display on group.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

#### Vertical(System.Action,UnityEngine.Texture2D,UnityEngine.GUIStyle,UnityEngine.GUILayoutOption[])

All controls rendered inside this method will be placed vertically below each other.

##### action

The callback that renders the controls.

##### image

The texture to display on group.

##### style

The style to use for background image and padding values. If left out, the background is transparent.

##### options

An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.

## UnityContrib.UnityEngine.Measure

Provides methods for doing measurements of code execution.

### Members

#### Time(System.Action)

Measures the time the specified action takes to execute.

##### action

The action to measure.

#### DebugLogTime(System.String,System.Action)

Measures the time the specified action takes to execute.

##### caption

The caption of the measurement.

##### action

The action to measure.

## UnityContrib.UnityEngine.NavMeshAgentEx

Provides a set of helper methods for working with the [UnityEngine.NavMeshAgent](http://docs.unity3d.com/ScriptReference/NavMeshAgent.html) class.

### Members

#### IsNavigating(UnityEngine.NavMeshAgent)

Returns a value indicating whether or not the specified agent is planning or following a path.

##### agent

The agent to query.

##### returns

true if the agent is planning or following a path; otherwise false.

## UnityContrib.UnityEngine.Quadtree`1

A region quadtree implementation used for fast lookup in a two dimensional world.

### Members

#### nodeCapacity

The maximum number of nodes per tree.

#### nodes

The nodes inside this region.

#### children

The child trees inside this region.

#### boundaries

The boundaries of this region.

#### Count

Gets the number of values inside this tree.

#### #ctor(UnityEngine.Rect,System.Int32)

Initializes a new instance of the Quadtree`1 class.

##### boundaries

The boundaries of the region.

##### nodeCapacity

The maximum number of nodes per tree. If the amount of nodes exceeds the tree will be subdivided into 4 sub trees. A value of 32 seems fine in terms of insert and remove speed. A value greater than 32 improves insert speed but slows down remove speed.

#### Insert(System.Single,System.Single,`0)

Inserts a value into the region.

##### x

The X component of the value's position.

##### y

The y component of the value's position.

##### value

The value to insert.

##### returns

true if the value was inserted into the region; false if the value's position was outside the region.

#### Insert(UnityEngine.Vector2,`0)

Inserts a value into the region.

##### position

The position of the value.

##### value

The value to insert.

##### returns

true if the value was inserted into the region; false if the value's position was outside the region.

#### Insert(UnityContrib.UnityEngine.Quadtree{`0}.QuadtreeNode)

Inserts a node into the region.

##### node

The node to insert.

##### returns

true if the node was inserted into the region; false if the position of the node was outside the region.

#### Find(UnityEngine.Rect)

Returns the values that are within the specified range .

##### range

A rectangle representing the region to query.

##### returns

Any value found inside the specified

#### Remove(System.Single,System.Single,`0)

Removes a value from the region.

##### x

The X component of the value's position.

##### z

The Z component of the value's position.

##### value

The value to remove.

##### returns

true if the value was removed from the region; false if the value's position was outside the region.

#### Remove(UnityEngine.Vector2,`0)

Removes a value from the region.

##### position

The position of the value.

##### value

The value to remove.

##### returns

true if the value was removed from the region; false if the value's position was outside the region.

#### Subdivide

Splits the region into 4 new subregions and moves the existing values into the new subregions.

#### Combine

Joins the contents of the children into this region and remove the child regions.

## UnityContrib.UnityEngine.Quadtree`1.QuadtreeNode

A single node inside a quadtree used for keeping values and their position.

### Members

#### Position

Gets the position of the value.

#### Value

Gets the value.

#### #ctor(UnityEngine.Vector2,`0)

Initializes a new instance of the QuadtreeNode class.

##### position

The position of the value.

##### value

The value.

## UnityContrib.UnityEngine.RandomEx

Provides a set of helper methods for working with random values.

### Members

#### Vector3XZ

Returns a random point inside a circle with a radius of 1. The Y component is always 0.0.

##### returns

The random vector.

#### Vector3XZ(System.Single)

Returns a random point inside a circle. The Y component is always 0.0.

##### distance

This distance from the center of the circle to the point.

##### returns

The random vector.

## UnityContrib.UnityEngine.TransformEx

Provides helper methods for working with the [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) class.

### Members

#### DestroyAllChildren(UnityEngine.Transform)

Destroys all the children of the specified parent  [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

##### parent

The parent [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) who's children to destroy.

## UnityContrib.UnityEngine.TreeInstanceEx

Provides a set of helper methods for working with the [UnityEngine.TreeInstance](http://docs.unity3d.com/ScriptReference/TreeInstance.html) class.

### Members

#### Same(UnityEngine.TreeInstance,UnityEngine.TreeInstance)

Compares two instances of [UnityEngine.TreeInstance](http://docs.unity3d.com/ScriptReference/TreeInstance.html) .

##### instance1

One of the [UnityEngine.TreeInstance](http://docs.unity3d.com/ScriptReference/TreeInstance.html) .

##### instance2

The other [UnityEngine.TreeInstance](http://docs.unity3d.com/ScriptReference/TreeInstance.html) .

##### returns

true if the state of both instances are the same; otherwise false.

