﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aras.AutoComplete.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aras.AutoComplete.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;xs:schema xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; targetNamespace=&quot;http://www.aras.com/AML.xsd&quot; 
        ///xmlns=&quot;http://www.aras.com/AML.xsd&quot; elementFormDefault=&quot;qualified&quot;&gt;
        ///
        ///	&lt;xs:element name=&quot;AML&quot; type=&quot;ItemList&quot;&gt;
        ///		&lt;xs:annotation&gt;&lt;xs:documentation&gt;Root element for an AML query&lt;/xs:documentation&gt;&lt;/xs:annotation&gt;
        ///	&lt;/xs:element&gt;
        ///	
        ///	&lt;xs:element name=&quot;Item&quot;&gt;
        ///		&lt;xs:annotation&gt;&lt;xs:documentation&gt;Item in the Aras database&lt;/xs:documentation&gt;&lt;/xs:annotation&gt;
        ///		&lt;xs:complexType&gt;
        ///			&lt;xs:choice minOccurs=&quot;1&quot; maxO [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AmlSchema {
            get {
                return ResourceManager.GetString("AmlSchema", resourceCulture);
            }
        }
    }
}