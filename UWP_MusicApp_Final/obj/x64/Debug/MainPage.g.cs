﻿#pragma checksum "C:\Users\keyro\Documents\Github\UWP_MusicLibrary\UWP_MusicApp_Final\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3041A3A6FF3AEA64998D96CEE0BB9CA4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_MusicApp_Final
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(global::Windows.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Windows.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Tag(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Tag = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Boolean) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), targetNullValue);
                }
                obj.IsChecked = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj4_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::UWP_MusicApp_Final.Songs dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj4;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj5;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj6;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj7;
            private global::Windows.UI.Xaml.Controls.CheckBox obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4NameDisabled = false;
            private static bool isobj5TagDisabled = false;
            private static bool isobj5ContentDisabled = false;
            private static bool isobj6TagDisabled = false;
            private static bool isobj6ContentDisabled = false;
            private static bool isobj7TagDisabled = false;
            private static bool isobj7ContentDisabled = false;
            private static bool isobj8TagDisabled = false;
            private static bool isobj8IsCheckedDisabled = false;

            private MainPage_obj4_BindingsTracking bindingsTracking;

            public MainPage_obj4_Bindings()
            {
                this.bindingsTracking = new MainPage_obj4_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 63 && columnNumber == 43)
                {
                    isobj4NameDisabled = true;
                }
                else if (lineNumber == 77 && columnNumber == 62)
                {
                    isobj5TagDisabled = true;
                }
                else if (lineNumber == 77 && columnNumber == 83)
                {
                    isobj5ContentDisabled = true;
                }
                else if (lineNumber == 79 && columnNumber == 62)
                {
                    isobj6TagDisabled = true;
                }
                else if (lineNumber == 79 && columnNumber == 83)
                {
                    isobj6ContentDisabled = true;
                }
                else if (lineNumber == 81 && columnNumber == 62)
                {
                    isobj7TagDisabled = true;
                }
                else if (lineNumber == 81 && columnNumber == 95)
                {
                    isobj7ContentDisabled = true;
                }
                else if (lineNumber == 86 && columnNumber == 43)
                {
                    isobj8TagDisabled = true;
                }
                else if (lineNumber == 86 && columnNumber == 105)
                {
                    isobj8IsCheckedDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // MainPage.xaml line 63
                        this.obj4 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 5: // MainPage.xaml line 77
                        this.obj5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 6: // MainPage.xaml line 79
                        this.obj6 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 7: // MainPage.xaml line 81
                        this.obj7 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 8: // MainPage.xaml line 86
                        this.obj8 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_8(this.obj8);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj4.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::UWP_MusicApp_Final.Songs) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::UWP_MusicApp_Final.Songs)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UWP_MusicApp_Final.Songs obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_TitleWithFileExtn(obj.TitleWithFileExtn, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Album(obj.Album, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_TitleWithFileExtn(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 86
                    if (!isobj8TagDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Tag(this.obj8, obj, null);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 63
                    if (!isobj4NameDisabled)
                    {
                        if ((this.obj4.Target as global::Windows.UI.Xaml.Controls.Grid) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name((this.obj4.Target as global::Windows.UI.Xaml.Controls.Grid), obj, null);
                        }
                    }
                    // MainPage.xaml line 81
                    if (!isobj7TagDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Tag(this.obj7, obj, null);
                    }
                    // MainPage.xaml line 81
                    if (!isobj7ContentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj7, obj, null);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 77
                    if (!isobj5TagDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Tag(this.obj5, obj, null);
                    }
                    // MainPage.xaml line 77
                    if (!isobj5ContentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj5, obj, null);
                    }
                }
            }
            private void Update_Album(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 79
                    if (!isobj6TagDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Tag(this.obj6, obj, null);
                    }
                    // MainPage.xaml line 79
                    if (!isobj6ContentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj6, obj, null);
                    }
                }
            }
            private void Update_IsChecked(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 86
                    if (!isobj8IsCheckedDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_8_Tag()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.TitleWithFileExtn = (global::System.String)this.obj8.Tag;
                    }
                }
            }
            private void UpdateTwoWay_8_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.IsChecked = (global::System.Boolean)this.obj8.IsChecked;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj4_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj4_Bindings> weakRefToBindingObj; 

                public MainPage_obj4_BindingsTracking(MainPage_obj4_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj4_Bindings>(obj);
                }

                public MainPage_obj4_Bindings TryGetBindingObject()
                {
                    MainPage_obj4_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

                public void RegisterTwoWayListener_8(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.FrameworkElement.TagProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_Tag();
                        }
                    });
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_IsChecked();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 40
                {
                    this.SongsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5: // MainPage.xaml line 77
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element5).Click += this.HyperlinkButton_ClickAsync;
                }
                break;
            case 6: // MainPage.xaml line 79
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element6 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element6).Click += this.HyperlinkButton_ClickAsync;
                }
                break;
            case 7: // MainPage.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element7 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element7).Click += this.HyperlinkButton_ClickAsync;
                }
                break;
            case 9: // MainPage.xaml line 24
                {
                    this.myMediaPlayerElement = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 10: // MainPage.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Create_Playlist_Button_Click;
                }
                break;
            case 11: // MainPage.xaml line 30
                {
                    this.PlayListCombo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.Go_Button_Click;
                }
                break;
            case 13: // MainPage.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.Delete_MyPlayList_Button_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 4: // MainPage.xaml line 63
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj4_Bindings bindings = new MainPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element4.DataContext);
                    element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element4, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

