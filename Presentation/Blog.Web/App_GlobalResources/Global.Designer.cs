//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Global {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Global() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Global", global::System.Reflection.Assembly.Load("App_GlobalResources"));
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
        ///   Looks up a localized string similar to Hello world!.
        /// </summary>
        internal static string Home_Title {
            get {
                return ResourceManager.GetString("Home_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        internal static string Name {
            get {
                return ResourceManager.GetString("Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing has found.
        /// </summary>
        internal static string No_Data {
            get {
                return ResourceManager.GetString("No_Data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Pages.
        /// </summary>
        internal static string PagesCount {
            get {
                return ResourceManager.GetString("PagesCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The content on this site represents my own personal opinions and thoughts at the time of posting..
        /// </summary>
        internal static string PersonalOpinionNotice {
            get {
                return ResourceManager.GetString("PersonalOpinionNotice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Articleed by {0} on {1}.
        /// </summary>
        internal static string Posted_Date {
            get {
                return ResourceManager.GetString("Posted_Date", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Article a comment.
        /// </summary>
        internal static string Post_Comment {
            get {
                return ResourceManager.GetString("Post_Comment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} comments.
        /// </summary>
        internal static string Post_Comments {
            get {
                return ResourceManager.GetString("Post_Comments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search.
        /// </summary>
        internal static string Search_Label {
            get {
                return ResourceManager.GetString("Search_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tags.
        /// </summary>
        internal static string Tags_Label {
            get {
                return ResourceManager.GetString("Tags_Label", resourceCulture);
            }
        }
    }
}
