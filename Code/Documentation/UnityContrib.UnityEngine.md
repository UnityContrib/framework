# Documentation for UnityContrib.UnityEngine

## UnityContrib.UnityEngine.ArrayEx

Provides a set of helper methods for working with the [System.Array](https://msdn.microsoft.com/en-us/library/System.Array%28v=vs.90%29.aspx) class.

### Members

#### IsNullOrEmpty(System.Array)

Returns a value indicating if the specified array is null or is empty.

##### array

The array to evaluate.

##### returns

true if the array is null or empty; otherwise false.

#### Swap``1(``0[],System.Int32,System.Int32)

Swaps the elements at indicies i1 and i2 .

##### source

The array containg the elements to swap.

##### i1

The index of one of the elements to swap.

##### i2

The index of the other element to swap.

## UnityContrib.UnityEngine.BaseSelector

Base implementation for selectors. A selector is a component that selects a [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) . The advantage of using this component is that you don't need to write the same find game object code over and over. You can simply attach an instance of a selector to a game object and let that instance find the [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) for you.

### Members

#### selected

The cached reference to the selected [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

#### Selected

Gets the selected [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

#### op_Implicit(UnityContrib.UnityEngine.BaseSelector)~UnityEngine.Transform

Returns the selected [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

##### selector

The selector that selects the [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

#### Select

When implemented, returns the selected [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

##### returns

The selected

#### Reselect

Clears the selected [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) so next time UnityContrib.UnityEngine.BaseSelector.Selected is called the selection algorithm will reevaluate.

## UnityContrib.UnityEngine.BaseSelector`1

Generic base implementation for selectors that selects [UnityEngine.Component](http://docs.unity3d.com/ScriptReference/Component.html) . A selector is a component that selects a [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) . The advantage of using this component is that you don't need to write the same find game object code over and over. You can simply attach an instance of a selector to a game object and let that instance find the [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) for you.

### Members

#### Select

Returns the [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) containing thecomponent.

##### returns



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

#### DrawPath(UnityEngine.NavMeshPath,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Color,System.Single,System.Boolean)

Draws the specified path .

##### path

The path to draw.

##### start

The start of the path.

##### end

The end of the path.

##### color

The color of the path.

##### duration

The amount of seconds the path must be visible for. A duration of zero shows the path for just one frame.

##### depthTest

A value indicating whether or not the path be obscured by objects closer to the camera?

#### DrawSphere(UnityEngine.Vector3,System.Single,UnityEngine.Color,System.Single,System.Boolean)

Draws a sphere at the specified position .

##### position

The position to draw the sphere at.

##### radius

The radius of the sphere.

##### color

The color of the sphere.

##### duration

The amount of seconds the line must be visible for. A duration of zero shows the line for just one frame.

##### depthTest

A value indicating whether or not the line be obscured by objects closer to the camera?

## UnityContrib.UnityEngine.DontDestroyOnLoad

Component that tells the engine not to unload the game object when scene changes.

### Members

#### Awake

Informs the engine not to unload the game object.

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

## UnityContrib.UnityEngine.IEnumerableEx

Provies a set of helper methods for working with the [System.Collections.IEnumerable](https://msdn.microsoft.com/en-us/library/System.Collections.IEnumerable%28v=vs.90%29.aspx) and [System.Collections.Generic.IEnumerable`1](https://msdn.microsoft.com/en-us/library/System.Collections.Generic.IEnumerable`1%28v=vs.90%29.aspx) classes.

### Members

#### IndexOf``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0})

Searches for the specified predicate and returns the index of its first occurrence in the enumerable.

##### source

The enumerable to search.

##### predicate

A function to test each element for a condition.

##### returns

The index of the first occurrence of

#### ForEach``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0})

Performs the specified action on each element of the [System.Collections.Generic.IEnumerable`1](https://msdn.microsoft.com/en-us/library/System.Collections.Generic.IEnumerable`1%28v=vs.90%29.aspx) .

##### source

An [System.Collections.Generic.IEnumerable`1](https://msdn.microsoft.com/en-us/library/System.Collections.Generic.IEnumerable`1%28v=vs.90%29.aspx) to iterate trough.

##### action

The [System.Action`1](https://msdn.microsoft.com/en-us/library/System.Action`1%28v=vs.90%29.aspx) delegate to perform on each element of the [System.Collections.Generic.IEnumerable`1](https://msdn.microsoft.com/en-us/library/System.Collections.Generic.IEnumerable`1%28v=vs.90%29.aspx) .

##### returns

The source for further processing.

## UnityContrib.UnityEngine.IEnumeratorEx

Provides helper methods for working with the [System.Collections.IEnumerator](https://msdn.microsoft.com/en-us/library/System.Collections.IEnumerator%28v=vs.90%29.aspx) class.

### Members

#### Recursive(System.Collections.IEnumerator,System.Int32,System.Int32)

Enumerates the specified enumerator recursively. If the enumerator returns another [System.Collections.IEnumerator](https://msdn.microsoft.com/en-us/library/System.Collections.IEnumerator%28v=vs.90%29.aspx) that will also be enumerated an so forward.

##### enumerator

The [System.Collections.IEnumerator](https://msdn.microsoft.com/en-us/library/System.Collections.IEnumerator%28v=vs.90%29.aspx) to enumerate.

##### maxRecursion

The maximum number of recursion levels before aborting.

##### currentRecursion

The current number of recursion levels.

##### returns

The values of the enumeration(s).

## UnityContrib.UnityEngine.ListEx

Provides a set of helper methods for working with the [System.Collections.Generic.List`1](https://msdn.microsoft.com/en-us/library/System.Collections.Generic.List`1%28v=vs.90%29.aspx) class.

### Members

#### Swap``1(System.Collections.Generic.List{``0},System.Int32,System.Int32)

Swaps the elements at indicies i1 and i2 .

##### source

The list containg the elements to swap.

##### i1

The index of one of the elements to swap.

##### i2

The index of the other element to swap.

## UnityContrib.UnityEngine.MassTreePlacement

Values for placing random trees.

### Members

#### count

The number of trees to place.

#### minWorldY

The lowest point to position a tree.

#### maxWorldY

The highest point to position a tree.

#### minSlope

The minimum allowed slope of the ground to position a tree.

#### maxSlope

The maximum allowed slope of the ground to position a tree.

#### minWidthScale

The minimum value to scale the width of a tree.

#### maxWidthScale

The maximum value to scale the width of a tree.

#### minHeightScale

The minimum value to scale the height of a tree.

#### maxHeightScale

The maximum value to scale the height of a tree.

#### maxTime

The maximum number of seconds for the placement process to take. The process is aborted if it takes any longer.

#### Count

Gets or sets the number of trees to place.

#### MinWorldY

Gets or sets the lowest point to position a tree.

#### MaxWorldY

Gets or sets the highest point to position a tree.

#### MinSlope

Gets or sets the minimum allowed slope of the ground to position a tree.

#### MaxSlope

Gets or sets the maximum allowed slope of the ground to position a tree.

#### MinWidthScale

Gets or sets the minimum value to scale the width of a tree.

#### MaxWidthScale

Gets or sets the maximum value to scale the width of a tree.

#### MinHeightScale

Gets or sets the minimum value to scale the height of a tree.

#### MaxHeightScale

Gets or sets the maximum value to scale the height of a tree.

#### MaxTime

Gets or sets the maximum number of seconds for the placement process to take. The process is aborted if it takes any longer.

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

## UnityContrib.UnityEngine.MultilineWithWordWrapAttribute

Attribute to make a string be edited with a multi-line textfield with word wrap.

### Members

## UnityContrib.UnityEngine.NavMeshAgentEx

Provides a set of helper methods for working with the [UnityEngine.NavMeshAgent](http://docs.unity3d.com/ScriptReference/NavMeshAgent.html) class.

### Members

#### IsNavigating(UnityEngine.NavMeshAgent)

Returns a value indicating whether or not the specified agent is planning or following a path.

##### agent

The agent to query.

##### returns

true if the agent is planning or following a path; otherwise false.

## UnityContrib.UnityEngine.NavMeshPathEx

Provides a set of helper methods for working with the [UnityEngine.NavMeshPath](http://docs.unity3d.com/ScriptReference/NavMeshPath.html) class.

### Members

#### Distance(UnityEngine.NavMeshPath,UnityEngine.Vector3,UnityEngine.Vector3)

Calculates the distance between the specified start and end using the specified path .

##### path

The path who's distance to calculate.

##### start

The start of the path.

##### end

The end of the path.

##### returns

The distance from start to end measured in Unity units.

## UnityContrib.UnityEngine.Note

A note component for game objects.

### Members

#### text

The note.

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

#### Random``1(``0[])

Returns random element from the specified array .

##### array

The array containing the elements.

##### returns

The random element; or default value of

## UnityContrib.UnityEngine.RuntimeTreeColliders

Positions tree colliders near the player.

### Members

#### diagonalLength

The length of the diagonal of the square that defines the area around the player to look for trees. A high number might result in performance issues. A low number might result in trees that can be passed through.

#### maxColliders

The maximum number of colliders to create. A high number might result in performance issues. A low number might result in trees that can be passed through.

#### player

The player the colliders must follow.

#### terrain

A reference to the terrain component.

#### data

A reference to the terrain data.

#### lastChangePosition

The position when the colliders were last changed.

#### colliders

The colliders managed by this component.

#### infos

The tree instance info components attached to the colliders.

#### trees

Quadtree for fast lookup by the player's position.

#### diagonalLengthOver2

Half the length of diagonalLength .

#### DiagonalLength

Gets or sets the length of the diagonal of the square that defines the area around the player to look for trees. A high number might result in performance issues. A low number might result in trees that can be passed through.

#### MaxColliders

Gets or sets the maximum number of colliders to create. A high number might result in performance issues. A low number might result in trees that can be passed through.

#### Player

Gets or sets the player the colliders must follow.

#### Start

Caches quick references and initializes the quadtree.

#### FixedUpdate

Changes the colliders based on which trees the player is near.

#### SetupChildColliders(UnityEngine.CapsuleCollider,UnityEngine.CapsuleCollider)

Creates, updates, enables and disables child colliders.

##### currentCollider

The parent collider.

##### prototypeCollider

The prototype collider containing the child colliders to base the child colliders on.

#### CopyCapsuleColliderProperties(UnityEngine.CapsuleCollider,UnityEngine.CapsuleCollider)

Copies the capsule collider specific properties from one [UnityEngine.CapsuleCollider](http://docs.unity3d.com/ScriptReference/CapsuleCollider.html) to another.

##### from

The [UnityEngine.CapsuleCollider](http://docs.unity3d.com/ScriptReference/CapsuleCollider.html) containing the properties to copy.

##### to

The [UnityEngine.CapsuleCollider](http://docs.unity3d.com/ScriptReference/CapsuleCollider.html) to apply the properties to.

#### AddTree(UnityEngine.TreeInstance)

Adds the specified treeInstance to the collection of trees who's collider to manage.

##### treeInstance

The [UnityEngine.TreeInstance](http://docs.unity3d.com/ScriptReference/TreeInstance.html) to add.

#### RemoveTree(UnityEngine.TreeInstance)

Removes the specified treeInstance from the collection of trees who's collider to manage.

##### treeInstance

The [UnityEngine.TreeInstance](http://docs.unity3d.com/ScriptReference/TreeInstance.html) to remove.

## UnityContrib.UnityEngine.StringEx

Provides a set of helper methods for working with the [System.String](https://msdn.microsoft.com/en-us/library/System.String%28v=vs.90%29.aspx) class.

### Members

#### Contains(System.String,System.String,System.StringComparison)

Returns a value indicating whether a specified substring occurs within this string.

##### text

The string to search in.

##### value

The string to seek.

##### comparisonType

One of the enumeration values that specifies the rules for the search.

##### returns

true if the value parameter occurs within this string, or if value is the empty string (""); otherwise, false.

## UnityContrib.UnityEngine.TagSelector

Selects the game object having a specific tag name.

### Members

#### tagName

The tag name of the game object to select.

#### TagName

Gets or sets the tag name of the game object to select.

#### Select

Returns the selected [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) based on the UnityContrib.UnityEngine.TagSelector.TagName .

##### returns

The selected

## UnityContrib.UnityEngine.TimelineLog

Records an entry for the timeline.

### Members

#### sources

Hashtable of sources. The key is the name of the source. The value is another hashtable containing the categories of the source.

#### source

The source of the entry.

#### category

The category of the entry.

#### message

The message of the entry.

#### start

The time in seconds when the log entry started.

#### Color

Gets or sets the color of the log entry when displayed.

#### Sources

Gets the sources logged.

#### MaxTime

Gets the maximum time in seconds logged.

#### TotalSources

Gets the number of sources logged.

#### TotalCategories

Gets the number of categories logged across sources.

#### #ctor(System.String,System.String,System.String)

Initializes a new instance of the UnityContrib.UnityEngine.TimelineLog class.

##### source

The source of the entry.

##### category

The category of the entry.

##### message

The message of the entry.

#### Dispose

Finalizes the log entry and records it.

#### Clear

Clears the timeline.

## UnityContrib.UnityEngine.TimelineLogEntry

Log entry for the timeline.

### Members

#### Message

Gets the message for the log entry.

#### Start

Gets the time in seconds when the log entry started.

#### End

Gets the time in seconds when the log entry ended.

#### Color

Gets the color of the log entry when displayed.

#### #ctor(System.String,System.Single,System.Single,UnityEngine.Color)

Initializes a new instance of the UnityContrib.UnityEngine.TimelineLogEntry class.

##### message

The textual message for the log entry.

##### start

The time in seconds when the log entry started.

##### end

The time in seconds when the log entry started.

##### color

The color of the log entry when displayed.

## UnityContrib.UnityEngine.TimelineLogSource

Source information for log entries in the timeline.

### Members

#### Categories

Gets the categories of the source.

#### IsFolded

Gets or sets a value indicating if the source is folded as opposed to expanded.

#### #ctor

Initializes a new instance of the UnityContrib.UnityEngine class.

## UnityContrib.UnityEngine.TransformEx

Provides helper methods for working with the [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) class.

### Members

#### DestroyAllChildren(UnityEngine.Transform)

Destroys all the children of the specified parent  [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

##### parent

The parent [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) who's children to destroy.

#### DestroyImmediateAllChildren(UnityEngine.Transform)

Destroys all the children of the specified parent  [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) .

##### parent

The parent [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) who's children to destroy.

#### DecendantsDepthFirst(UnityEngine.Transform)

Returns all the decendant [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) to the specified transform using depth first traversal.

##### transform

The parent [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) to start at.

##### returns

An enumerable of

#### DecendantsBreadthFirst(UnityEngine.Transform)

Returns all the decendant [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) to the specified transform using breadth first traversal.

##### transform

The parent [UnityEngine.Transform](http://docs.unity3d.com/ScriptReference/Transform.html) to start at.

##### returns

An enumerable of

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

## UnityContrib.UnityEngine.TreeInstanceInfo

Provides a reference to the tree that was collided with.

### Members

#### treeInstance

The reference to the tree that was collided with.

#### terrain

The reference to the terrain the tree belongs to.

#### TreePrototype

Gets the prototype of the tree.

#### TreeInstanceIndex

Gets the index of the instance in the [UnityEngine.TerrainData.treeInstances](http://docs.unity3d.com/ScriptReference/TerrainData.treeInstances.html) array.

#### TreeInstance

Gets or sets the reference to the tree that was collided with.

#### Terrain

Gets or sets the reference to the terrain the tree belongs to.

## UnityContrib.UnityEngine.Vector3Ex

Provides a set of helper methods for working with the [UnityEngine.Vector3](http://docs.unity3d.com/ScriptReference/Vector3.html) struct.

### Members

#### Around(UnityEngine.Vector3,System.Single)

Returns a random position around the specified center position . The Y component of the random position will always be the same as the center position.

##### position

The center position to generate a random position around.

##### distance

The distance from the center position to the generated random position.

##### returns

The generated random position.

#### Within(UnityEngine.Vector3,System.Single,System.Single,System.Single)

Returns a random position inside a box.

##### position

The center of the box.

##### x

The width of the box.

##### y

The height of the box.

##### z

The depth of the box.

##### returns

The random position inside the box.

#### CalculateSlopeRad(UnityEngine.Vector3,UnityEngine.Vector3)

Returns the slope of the specified normal in radians.

##### normal

The normal who's slope to calculate.

##### up

The up direction.

##### returns

The slope in radians.

#### CalculateSlopeRad(UnityEngine.Vector3)

Returns the slope of the specified normal in radians.

##### normal

The normal who's slope to calculate.

##### returns

The slope in radians.

#### CalculateSlopeDeg(UnityEngine.Vector3,UnityEngine.Vector3)

Returns the slope of the specified normal in degrees. Based on Y being the up component.

##### normal

The normal who's slope to calculate.

##### up

The up direction.

##### returns

The slope in degrees.

#### CalculateSlopeDeg(UnityEngine.Vector3)

Returns the slope of the specified normal in degrees. Based on Y being the up component.

##### normal

The normal who's slope to calculate.

##### returns

The slope in degrees.

