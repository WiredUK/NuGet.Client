﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetConsole {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGetConsole.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize the PowerShell host. If your PowerShell execution policy setting is set to AllSigned, open the Package Manager Console to initialize the host first..
        /// </summary>
        public static string Console_InitializeHostFails {
            get {
                return ResourceManager.GetString("Console_InitializeHostFails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing script file &apos;{0}&apos;....
        /// </summary>
        public static string ExecutingScript {
            get {
                return ResourceManager.GetString("ExecutingScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: language mode for current session is {0}, it might impact powershell script running..
        /// </summary>
        public static string LanguageModeWarning {
            get {
                return ResourceManager.GetString("LanguageModeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package Manager.
        /// </summary>
        public static string OutputConsolePaneName {
            get {
                return ResourceManager.GetString("OutputConsolePaneName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package Manager Console busy at the moment....
        /// </summary>
        public static string PackageManagerConsoleBusy {
            get {
                return ResourceManager.GetString("PackageManagerConsoleBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package Manager Console Command Executed.
        /// </summary>
        public static string PackageManagerConsoleCommandExecuted {
            get {
                return ResourceManager.GetString("PackageManagerConsoleCommandExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry key &apos;{0}&apos; should be a DWORD..
        /// </summary>
        public static string RegistryKeyShouldBeDWORD {
            get {
                return ResourceManager.GetString("RegistryKeyShouldBeDWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing PowerShell host....
        /// </summary>
        public static string ToolWindowInitializing {
            get {
                return ResourceManager.GetString("ToolWindowInitializing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package Manager Console.
        /// </summary>
        public static string ToolWindowTitle {
            get {
                return ResourceManager.GetString("ToolWindowTitle", resourceCulture);
            }
        }
    }
}
