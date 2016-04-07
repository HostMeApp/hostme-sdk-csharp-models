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
    public partial class ManageInfoViewModel :  IEquatable<ManageInfoViewModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageInfoViewModel" /> class.
        /// Initializes a new instance of the <see cref="ManageInfoViewModel" />class.
        /// </summary>
        /// <param name="LocalLoginProvider">LocalLoginProvider.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="Logins">Logins.</param>
        /// <param name="ExternalLoginProviders">ExternalLoginProviders.</param>

        public ManageInfoViewModel(string LocalLoginProvider = null, string UserName = null, List<UserLoginInfoViewModel> Logins = null, List<ExternalLoginViewModel> ExternalLoginProviders = null)
        {
            this.LocalLoginProvider = LocalLoginProvider;
            this.UserName = UserName;
            this.Logins = Logins;
            this.ExternalLoginProviders = ExternalLoginProviders;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LocalLoginProvider
        /// </summary>
        [DataMember(Name="localLoginProvider", EmitDefaultValue=false)]
        public string LocalLoginProvider { get; set; }
    
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or Sets Logins
        /// </summary>
        [DataMember(Name="logins", EmitDefaultValue=false)]
        public List<UserLoginInfoViewModel> Logins { get; set; }
    
        /// <summary>
        /// Gets or Sets ExternalLoginProviders
        /// </summary>
        [DataMember(Name="externalLoginProviders", EmitDefaultValue=false)]
        public List<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManageInfoViewModel {\n");
            sb.Append("  LocalLoginProvider: ").Append(LocalLoginProvider).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Logins: ").Append(Logins).Append("\n");
            sb.Append("  ExternalLoginProviders: ").Append(ExternalLoginProviders).Append("\n");
            
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
            return this.Equals(obj as ManageInfoViewModel);
        }

        /// <summary>
        /// Returns true if ManageInfoViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ManageInfoViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManageInfoViewModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LocalLoginProvider == other.LocalLoginProvider ||
                    this.LocalLoginProvider != null &&
                    this.LocalLoginProvider.Equals(other.LocalLoginProvider)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.Logins == other.Logins ||
                    this.Logins != null &&
                    this.Logins.SequenceEqual(other.Logins)
                ) && 
                (
                    this.ExternalLoginProviders == other.ExternalLoginProviders ||
                    this.ExternalLoginProviders != null &&
                    this.ExternalLoginProviders.SequenceEqual(other.ExternalLoginProviders)
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
                
                if (this.LocalLoginProvider != null)
                    hash = hash * 59 + this.LocalLoginProvider.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                
                if (this.Logins != null)
                    hash = hash * 59 + this.Logins.GetHashCode();
                
                if (this.ExternalLoginProviders != null)
                    hash = hash * 59 + this.ExternalLoginProviders.GetHashCode();
                
                return hash;
            }
        }

    }


}
