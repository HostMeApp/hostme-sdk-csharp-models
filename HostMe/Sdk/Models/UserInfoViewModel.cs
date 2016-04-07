using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace HostMe.Sdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UserInfoViewModel :  IEquatable<UserInfoViewModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoViewModel" /> class.
        /// Initializes a new instance of the <see cref="UserInfoViewModel" />class.
        /// </summary>
        /// <param name="UserName">UserName.</param>
        /// <param name="HasRegistered">HasRegistered.</param>
        /// <param name="LoginProvider">LoginProvider.</param>

        public UserInfoViewModel(string UserName = null, bool? HasRegistered = null, string LoginProvider = null)
        {
            this.UserName = UserName;
            this.HasRegistered = HasRegistered;
            this.LoginProvider = LoginProvider;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or Sets HasRegistered
        /// </summary>
        [DataMember(Name="hasRegistered", EmitDefaultValue=false)]
        public bool? HasRegistered { get; set; }
    
        /// <summary>
        /// Gets or Sets LoginProvider
        /// </summary>
        [DataMember(Name="loginProvider", EmitDefaultValue=false)]
        public string LoginProvider { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfoViewModel {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  HasRegistered: ").Append(HasRegistered).Append("\n");
            sb.Append("  LoginProvider: ").Append(LoginProvider).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserInfoViewModel);
        }

        /// <summary>
        /// Returns true if UserInfoViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInfoViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfoViewModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.HasRegistered == other.HasRegistered ||
                    this.HasRegistered != null &&
                    this.HasRegistered.Equals(other.HasRegistered)
                ) && 
                (
                    this.LoginProvider == other.LoginProvider ||
                    this.LoginProvider != null &&
                    this.LoginProvider.Equals(other.LoginProvider)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                
                if (this.HasRegistered != null)
                    hash = hash * 59 + this.HasRegistered.GetHashCode();
                
                if (this.LoginProvider != null)
                    hash = hash * 59 + this.LoginProvider.GetHashCode();
                
                return hash;
            }
        }

    }


}
