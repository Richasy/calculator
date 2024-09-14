// Copyright @ MyScript. All rights reserved.

using Windows.UI.Core;
using MyScriptEditor.UserControls;
using MyScript.IInk;

namespace MyScriptEditor
{
    public class RendererListener : IRendererListener
    {
        private EditorUserControl _ucEditor;

        public RendererListener(EditorUserControl ucEditor)
        {
            _ucEditor = ucEditor;
        }

        public void ViewTransformChanged(Renderer renderer)
        {
            if (_ucEditor.SmartGuideEnabled && _ucEditor.SmartGuide != null)
            {
                var dispatcher = _ucEditor.Dispatcher;
                var task = dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => { _ucEditor.SmartGuide.OnTransformChanged(); });
            }
        }
    }
}
