using UnityEditor;
using UnityEngine;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Base implementation for <see cref="T:UnityEngine.EditorWindow"/>.
    /// </summary>
    public abstract class BaseEditorWindow : EditorWindow
    {
        /// <summary>
        /// A value indicating whether or not the project was playing in the last update.
        /// This is used to monitor if <see cref="P:OnPlayStarted"/> or <see cref="P:OnPlayStopped"/> should be called.
        /// </summary>
        private bool wasPlaying;

        /// <summary>
        /// The position and size of the window in the last update call.
        /// This is used to monitor if <see cref="P:OnMoved"/> or <see cref="P:OnResized"/> should be called.
        /// </summary>
        private Rect lastPosition;

        /// <summary>
        /// Called by Unity when window is enabled.
        /// </summary>
        protected virtual void OnEnable()
        {
            this.wasPlaying = Application.isPlaying;
            this.lastPosition = this.position;
        }

        /// <summary>
        /// Called by Unity 100 times a second.
        /// </summary>
        protected virtual void Update()
        {
            this.CheckPlayingState();
            this.CheckBoundaries();
        }

        /// <summary>
        /// Called by Unity when you should draw the controls of the window.
        /// </summary>
        protected virtual void OnGUI()
        {
            this.CheckPlayingState();
            this.CheckBoundaries();
        }

        /// <summary>
        /// Calls <see cref="P:OnPlayStarted"/> if playing started and <see cref="P:OnPlayStopped"/> if stopped.
        /// </summary>
        private void CheckPlayingState()
        {
            if (!this.wasPlaying && Application.isPlaying)
            {
                this.wasPlaying = true;
                this.OnPlayStarted();
            }
            else if (this.wasPlaying && !Application.isPlaying)
            {
                this.wasPlaying = false;
                this.OnPlayStopped();
            }
        }

        /// <summary>
        /// Calls <see cref="P:OnMoved"/> if window moved and <see cref="P:OnResized"/> if resized.
        /// </summary>
        private void CheckBoundaries()
        {
            var changed = false;
            if (this.lastPosition.position != this.position.position)
            {
                this.OnMoved();
                changed = true;
            }
            if (this.lastPosition.size != this.position.size)
            {
                this.OnResized();
                changed = true;
            }
            if (changed)
            {
                this.lastPosition = this.position;
            }
        }

        /// <summary>
        /// Called when the projected is started.
        /// </summary>
        protected virtual void OnPlayStarted()
        {
            // do nothing
        }

        /// <summary>
        /// Called when the project is stopped.
        /// </summary>
        protected virtual void OnPlayStopped()
        {
            // do nothing
        }

        /// <summary>
        /// Called when the window have resized.
        /// </summary>
        protected virtual void OnResized()
        {
            // do nothing
        }

        /// <summary>
        /// Called when the window have moved.
        /// </summary>
        protected virtual void OnMoved()
        {
            // do nothing
        }
    }
}
