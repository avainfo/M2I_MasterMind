﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterMind {
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
    internal class Resources1_fr {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources1_fr() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MasterMind.Resources1.fr", typeof(Resources1_fr).Assembly);
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
        ///   Looks up a localized string similar to Rouge Bleu Jaune Orange Vert Violet Rose.
        /// </summary>
        internal static string colors {
            get {
                return ResourceManager.GetString("colors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erreur: .
        /// </summary>
        internal static string error {
            get {
                return ResourceManager.GetString("error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vous avez [1] bon[2].
        /// </summary>
        internal static string good {
            get {
                return ResourceManager.GetString("good", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vous venez de perdre, la bonne réponse était:.
        /// </summary>
        internal static string loose {
            get {
                return ResourceManager.GetString("loose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appuyez sur Entrée pour continuer.
        /// </summary>
        internal static string next {
            get {
                return ResourceManager.GetString("next", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Veuillez sélectionner [1] couleurs (séparer par des espace): .
        /// </summary>
        internal static string selection {
            get {
                return ResourceManager.GetString("selection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vous avez [1] bien placé[2].
        /// </summary>
        internal static string well_placed {
            get {
                return ResourceManager.GetString("well-placed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bravo vous avez gagné !.
        /// </summary>
        internal static string win {
            get {
                return ResourceManager.GetString("win", resourceCulture);
            }
        }
    }
}
