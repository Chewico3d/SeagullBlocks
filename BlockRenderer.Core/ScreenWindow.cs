using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace BlockRenderer.Core {
    public class ScreenWindow : GameWindow {

        EventHandler FixedUpdate;
        EventHandler FrameUpdate;

        public ScreenWindow(string Title) 
            : base(new GameWindowSettings() { IsMultiThreaded = true, RenderFrequency = 1f / 60f, UpdateFrequency = 0.02f}, new NativeWindowSettings() { Title = Title}) {
        }

        protected override void OnUpdateFrame(FrameEventArgs args) {
            if (FixedUpdate != null)
                FixedUpdate(this, EventArgs.Empty);
        }
        protected override void OnRenderFrame(FrameEventArgs args) {
            if (FrameUpdate != null)
                FrameUpdate(this, EventArgs.Empty);

            SwapBuffers();
        }
        

    }
}
