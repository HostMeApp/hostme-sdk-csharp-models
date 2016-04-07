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
    public partial class RegisterExternalBindingModel :  IEquatable<RegisterExternalBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterExternalBindingModel" /> class.
        /// Initializes a new instance of the <see cref="RegisterExternalBindingModel" />class.
        /// </summary>
        /// <param name="UserName">UserName.</param>
        /// <param name="FullName">FullName (required).</param>
        /// <param name="PhoneNumber">PhoneNumber (required).</param>

        public RegisterExternalBindingModel(string UserName = null, string FullName = null, string PhoneNumber = null)
        {
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for RegisterExternalBindingModel and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for RegisterExternalBindingModel and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            this.UserName = UserName;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterExternalBindingModel {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            
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
            return this.Equals(obj as RegisterExternalBindingModel);
        }

        /// <summary>
        /// Returns true if RegisterExternalBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterExternalBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterExternalBindingModel other)
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
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }


}
