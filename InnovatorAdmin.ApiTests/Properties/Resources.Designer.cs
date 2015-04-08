﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InnovatorAdmin.ApiTests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InnovatorAdmin.ApiTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SELECT
        ///    c.[id]
        ///  , case when charindex(&apos;/&apos;, c.[CLASSIFICATION]) = 0 then c.[CLASSIFICATION] else left(c.CLASSIFICATION, charindex(&apos;/&apos;, c.[CLASSIFICATION])-1) end classification_01
        ///  , case when charindex(&apos;/&apos;, c.[CLASSIFICATION]) = 0 then c.[CLASSIFICATION]
        ///     when charindex(&apos;/&apos;, c.[CLASSIFICATION], charindex(&apos;/&apos;, c.[CLASSIFICATION])+1) = 0 then c.[CLASSIFICATION]
        ///     else left(c.CLASSIFICATION, charindex(&apos;/&apos;, c.[CLASSIFICATION],charindex(&apos;/&apos;, c.[CLASSIFICATION])+1)-1) end classification_02
        ///  , c [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SampleSql {
            get {
                return ResourceManager.GetString("SampleSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///name: PE_RollupAllPartsInDB
        ///solution: PLM
        ///created: 06-OCT-2006
        ///purpose: Rollup all Parts cost and weight in DB
        ///notes:
        ///*/
        ///
        ///CREATE PROCEDURE PE_RollupAllPartsInDB
        ///AS
        ///BEGIN
        ///  -- 1. Set cost to NULL on Parts with no Part Goal for cost
        ///  UPDATE PART
        ///  SET cost=NULL, cost_basis=NULL
        ///  FROM PART all_parts
        ///    INNER JOIN
        ///      (SELECT p.id id
        ///       FROM PART p LEFT OUTER JOIN PART_GOAL pg ON p.id=pg.source_id
        ///       WHERE (pg.goal IS NULL) OR (pg.goal != &apos;Cost&apos;)) no_cost
        ///    ON all_parts.id=n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SampleSql_PartRollup {
            get {
                return ResourceManager.GetString("SampleSql_PartRollup", resourceCulture);
            }
        }
    }
}