﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MdbToTextConverter {
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
    internal class ProcessingStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProcessingStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MdbToTextConverter.ProcessingStrings", typeof(ProcessingStrings).Assembly);
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
        ///   Looks up a localized string similar to , .
        /// </summary>
        internal static string CommaSeparator {
            get {
                return ResourceManager.GetString("CommaSeparator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}_Output.txt.
        /// </summary>
        internal static string DataSetTextFileNameFormat {
            get {
                return ResourceManager.GetString("DataSetTextFileNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}_Output.xml.
        /// </summary>
        internal static string DataSetXmlFileNameFormat {
            get {
                return ResourceManager.GetString("DataSetXmlFileNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.txt.
        /// </summary>
        internal static string DataTableTextFileNameFormat {
            get {
                return ResourceManager.GetString("DataTableTextFileNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.xml.
        /// </summary>
        internal static string DataTableXmlFileNameFormat {
            get {
                return ResourceManager.GetString("DataTableXmlFileNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .mdb.
        /// </summary>
        internal static string MdbExtension {
            get {
                return ResourceManager.GetString("MdbExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}.
        /// </summary>
        internal static string OledbConnectionStringFormat {
            get {
                return ResourceManager.GetString("OledbConnectionStringFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM [{0}].
        /// </summary>
        internal static string SqlSelectTableValuesFormat {
            get {
                return ResourceManager.GetString("SqlSelectTableValuesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table Name: {0}.
        /// </summary>
        internal static string TableNameLabelFormat {
            get {
                return ResourceManager.GetString("TableNameLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TABLE_NAME.
        /// </summary>
        internal static string TableNameSchemaValue {
            get {
                return ResourceManager.GetString("TableNameSchemaValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TABLE.
        /// </summary>
        internal static string TableSchemaIdentifier {
            get {
                return ResourceManager.GetString("TableSchemaIdentifier", resourceCulture);
            }
        }
    }
}