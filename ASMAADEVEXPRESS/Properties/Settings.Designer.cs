﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASMAADEVEXPRESS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FullName {
            get {
                return ((string)(this["FullName"]));
            }
            set {
                this["FullName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserName {
            get {
                return ((string)(this["UserName"]));
            }
            set {
                this["UserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserDep {
            get {
                return ((string)(this["UserDep"]));
            }
            set {
                this["UserDep"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserRole {
            get {
                return ((string)(this["UserRole"]));
            }
            set {
                this["UserRole"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserID {
            get {
                return ((string)(this["UserID"]));
            }
            set {
                this["UserID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("أسم المؤسسة يمكنك تغييره من الاعدادات")]
        public string CompanyName {
            get {
                return ((string)(this["CompanyName"]));
            }
            set {
                this["CompanyName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("وصف المؤسسة")]
        public string CompanyDes {
            get {
                return ((string)(this["CompanyDes"]));
            }
            set {
                this["CompanyDes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CompanyLogo {
            get {
                return ((string)(this["CompanyLogo"]));
            }
            set {
                this["CompanyLogo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Contract_invoice")]
        public string Database {
            get {
                return ((string)(this["Database"]));
            }
            set {
                this["Database"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SQL")]
        public string Mode {
            get {
                return ((string)(this["Mode"]));
            }
            set {
                this["Mode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ASMAAPC\\SQLEXPRESS")]
        public string Server {
            get {
                return ((string)(this["Server"]));
            }
            set {
                this["Server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-ECKVF6T\\SQLEXPRESS;Initial Catalog=Contract_invoice;Integrate" +
            "d Security=True")]
        public string Contract_invoiceConnectionString {
            get {
                return ((string)(this["Contract_invoiceConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-HIJ5RIA\\SQLEXPRESS;Initial Catalog=Contract_invoice;Integrate" +
            "d Security=True")]
        public string Contract_invoiceConnectionString1 {
            get {
                return ((string)(this["Contract_invoiceConnectionString1"]));
            }
        }
    }
}