﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneticSharp.Runner.ConsoleApp.Samples.Resources {
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
    internal class SamplesResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SamplesResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GeneticSharp.Runner.ConsoleApp.Samples.Resources.SamplesResource", typeof(SamplesResource).Assembly);
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
        ///   Looks up a localized string similar to {
        ///    &quot;type&quot;: &quot;success&quot;,
        ///    &quot;value&quot;: [{
        ///        &quot;id&quot;: 347,
        ///        &quot;joke&quot;: &quot;Some people ask for a Kleenex when they sneeze, Chuck Norris asks for a body bag.&quot;,
        ///        &quot;categories&quot;: []
        ///    }, {
        ///        &quot;id&quot;: 555,
        ///        &quot;joke&quot;: &quot;Chuck Norris doesn&apos;t have pubic hairs because hair doesn&apos;t grow on balls of steal.&quot;,
        ///        &quot;categories&quot;: [&quot;explicit&quot;]
        ///    }, {
        ///        &quot;id&quot;: 252,
        ///        &quot;joke&quot;: &quot;Saddam Hussein was not found hiding in a &amp;quot;hole.&amp;quot; Saddam was roundhouse-kicked in the head by C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GhostwriterQuoteJson {
            get {
                return ResourceManager.GetString("GhostwriterQuoteJson", resourceCulture);
            }
        }
    }
}
