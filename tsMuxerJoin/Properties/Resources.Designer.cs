﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tsMuxerJoin.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("tsMuxerJoin.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a folder with .mts files.
        /// </summary>
        internal static string chooseFolderHint {
            get {
                return ResourceManager.GetString("chooseFolderHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select output file name.
        /// </summary>
        internal static string chooseOutputHint {
            get {
                return ResourceManager.GetString("chooseOutputHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi\f0\pard
        ///{\b tsMuxerJoin} — join all .MTS files in directory into single file using tsMuxeR\par
        ///\par
        ///Step 1. Select source directory with several .MTS files\par
        ///Step 2. Select output file name\par
        ///Step 3. Press Mux button and wait until console window closes\par
        ///\par
        ///If instead of console window open file dialog pops up, than tsMuxer was unable to start. Select tsMuxer executable and muxing process should start as expected.\par
        ///}.
        /// </summary>
        internal static string rtfHelp {
            get {
                return ResourceManager.GetString("rtfHelp", resourceCulture);
            }
        }
    }
}
