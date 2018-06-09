using MonoGame.Extended.NuclexGui.Controls;
using MonoGame.Extended.NuclexGui.Controls.Desktop;

namespace MonoGame.Extended.NuclexGui.Visuals.Flat.Renderers
{
    /// <summary>Renders choice controls in a traditional flat style</summary>
    public class FlatDrawControlRenderer : IFlatControlRenderer<GuiDrawControl>
    {


        /// <summary>
        ///     Renders the specified control using the provided graphics interface
        /// </summary>
        /// <param name="control">Control that will be rendered</param>
        /// <param name="graphics">
        ///     Graphics interface that will be used to draw the control
        /// </param>
        public void Render(GuiDrawControl control, IFlatGuiGraphics graphics)
        {
            control.Renderer?.Draw(graphics.SpriteBatch);
        }
    }
}