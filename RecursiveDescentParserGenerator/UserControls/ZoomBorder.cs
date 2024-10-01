using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RecursiveDescentParserGenerator.UserControls
{
    /// <summary>
    /// A custom <see cref="Border"/> control that provides zoom and pan functionality for its child <see cref="UIElement"/>.
    /// </summary>
    public class ZoomBorder : Border
    {
        /// <summary>
        /// The child <see cref="UIElement"/> that is being zoomed and panned within the border.
        /// </summary>
        private UIElement? child;

        /// <summary>
        /// The starting point of the mouse cursor relative to the border when a pan operation begins.
        /// </summary>
        private Point origin;

        /// <summary>
        /// The initial position of the mouse cursor when a pan operation begins.
        /// </summary>
        private Point start;

        /// <summary>
        /// Retrieves the <see cref="TranslateTransform"/> from the <see cref="RenderTransform"/> of the specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="element">The <see cref="UIElement"/> from which to retrieve the <see cref="TranslateTransform"/>.</param>
        /// <returns>The <see cref="TranslateTransform"/> applied to the specified element.</returns>
        /// <exception cref="InvalidCastException">Thrown if the <see cref="RenderTransform"/> of the element is not a <see cref="TransformGroup"/> or does not contain a <see cref="TranslateTransform"/>.</exception>
        private static TranslateTransform GetTranslateTransform(UIElement element)
        {
            return (TranslateTransform)((TransformGroup)element.RenderTransform)
              .Children.First(tr => tr is TranslateTransform);
        }

        /// <summary>
        /// Retrieves the <see cref="ScaleTransform"/> from the <see cref="RenderTransform"/> of the specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="element">The <see cref="UIElement"/> from which to retrieve the <see cref="ScaleTransform"/>.</param>
        /// <returns>The <see cref="ScaleTransform"/> applied to the specified element.</returns>
        /// <exception cref="InvalidCastException">Thrown if the <see cref="RenderTransform"/> of the element is not a <see cref="TransformGroup"/> or does not contain a <see cref="ScaleTransform"/>.</exception>
        private static ScaleTransform GetScaleTransform(UIElement element)
        {
            return (ScaleTransform)((TransformGroup)element.RenderTransform)
              .Children.First(tr => tr is ScaleTransform);
        }

        /// <summary>
        /// Gets or sets the child element of the border.
        /// </summary>
        /// <value>The child <see cref="UIElement"/> of the border.</value>
        public override UIElement Child
        {
            get { return base.Child; }
            set
            {
                if (value != null && value != Child)
                    Initialize(value);
                base.Child = value;
            }
        }

        /// <summary>
        /// Initializes the zoom and pan functionality for the specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="element">The <see cref="UIElement"/> to initialize with zoom and pan functionality.</param>
        public void Initialize(UIElement element)
        {
            child = element;
            if (child != null)
            {
                TransformGroup group = new();
                ScaleTransform st = new();
                group.Children.Add(st);
                TranslateTransform tt = new();
                group.Children.Add(tt);
                child.RenderTransform = group;
                child.RenderTransformOrigin = new Point(0.0, 0.0);
                MouseWheel += Child_MouseWheel;
                MouseLeftButtonDown += Child_MouseLeftButtonDown;
                MouseLeftButtonUp += Child_MouseLeftButtonUp;
                MouseMove += Child_MouseMove;
                PreviewMouseRightButtonDown += new MouseButtonEventHandler(
                  Child_PreviewMouseRightButtonDown);
            }
        }

        /// <summary>
        /// Resets the zoom and pan transformations to their default values.
        /// </summary>
        public void Reset()
        {
            if (child != null)
            {
                // reset zoom
                var st = GetScaleTransform(child);
                st.ScaleX = 1.0;
                st.ScaleY = 1.0;

                // reset pan
                var tt = GetTranslateTransform(child);
                tt.X = 0.0;
                tt.Y = 0.0;
            }
        }

        #region Child Events

        /// <summary>
        /// Handles the mouse wheel events to zoom in or out the child element.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The mouse wheel event data.</param>
        private void Child_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (child != null)
            {
                var st = GetScaleTransform(child);
                var tt = GetTranslateTransform(child);

                double zoom = e.Delta > 0 ? .2 : -.2;
                if (!(e.Delta > 0) && (st.ScaleX < .4 || st.ScaleY < .4))
                    return;

                Point relative = e.GetPosition(child);
                double absoluteX;
                double absoluteY;

                absoluteX = relative.X * st.ScaleX + tt.X;
                absoluteY = relative.Y * st.ScaleY + tt.Y;

                st.ScaleX += zoom;
                st.ScaleY += zoom;

                tt.X = absoluteX - relative.X * st.ScaleX;
                tt.Y = absoluteY - relative.Y * st.ScaleY;
            }
        }

        /// <summary>
        /// Handles the mouse left button down event to initiate panning of the child element.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The mouse button event data.</param>
        private void Child_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (child != null)
            {
                var tt = GetTranslateTransform(child);
                start = e.GetPosition(this);
                origin = new Point(tt.X, tt.Y);
                Cursor = Cursors.Hand;
                child.CaptureMouse();
            }
        }

        /// <summary>
        /// Handles the mouse left button up event to stop panning of the child element.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The mouse button event data.</param>
        private void Child_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (child != null)
            {
                child.ReleaseMouseCapture();
                Cursor = Cursors.Arrow;
            }
        }

        /// <summary>
        /// Handles the preview mouse right button down event to reset zoom and pan transformations.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The mouse button event data.</param>
        void Child_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Handles the mouse move event to pan the child element while the left mouse button is held down.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The mouse event data.</param>
        private void Child_MouseMove(object sender, MouseEventArgs e)
        {
            if (child != null)
            {
                if (child.IsMouseCaptured)
                {
                    var tt = GetTranslateTransform(child);
                    Vector v = start - e.GetPosition(this);
                    tt.X = origin.X - v.X;
                    tt.Y = origin.Y - v.Y;
                }
            }
        }

        #endregion
    }
}
