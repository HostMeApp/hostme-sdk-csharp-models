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
    public partial class UserIdentityInfo :  IEquatable<UserIdentityInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentityInfo" /> class.
        /// Initializes a new instance of the <see cref="UserIdentityInfo" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="IdentityProvider">IdentityProvider.</param>
        /// <param name="NameIdentifier">NameIdentifier.</param>

        public UserIdentityInfo(int? Id = null, string IdentityProvider = null, string NameIdentifier = null)
        {
            this.Id = Id;
            this.IdentityProvider = IdentityProvider;
            this.NameIdentifier = NameIdentifier;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdentityProvider
        /// </summary>
        [DataMember(Name="identityProvider", EmitDefaultValue=false)]
        public string IdentityProvider { get; set; }
    
        /// <summary>
        /// Gets or Sets NameIdentifier
        /// </summary>
        [DataMember(Name="nameIdentifier", EmitDefaultValue=false)]
        public string NameIdentifier { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserIdentityInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("  NameIdentifier: ").Append(NameIdentifier).Append("\n");
            
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
            return this.Equals(obj as UserIdentityInfo);
        }

        /// <summary>
        /// Returns true if UserIdentityInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserIdentityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentityInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdentityProvider == other.IdentityProvider ||
                    this.IdentityProvider != null &&
                    this.IdentityProvider.Equals(other.IdentityProvider)
                ) && 
                (
                    this.NameIdentifier == other.NameIdentifier ||
                    this.NameIdentifier != null &&
                    this.NameIdentifier.Equals(other.NameIdentifier)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdentityProvider != null)
                    hash = hash * 59 + this.IdentityProvider.GetHashCode();
                
                if (this.NameIdentifier != null)
                    hash = hash * 59 + this.NameIdentifier.GetHashCode();
                
                return hash;
            }
        }

    }


}
