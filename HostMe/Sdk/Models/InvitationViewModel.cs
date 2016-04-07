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
    public partial class InvitationViewModel :  IEquatable<InvitationViewModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationViewModel" /> class.
        /// Initializes a new instance of the <see cref="InvitationViewModel" />class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="Role">Role.</param>
        /// <param name="IsRedeemed">IsRedeemed.</param>
        /// <param name="Code">Code.</param>
        /// <param name="FullName">FullName.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>

        public InvitationViewModel(string Email = null, string Role = null, bool? IsRedeemed = null, string Code = null, string FullName = null, string PhoneNumber = null)
        {
            this.Email = Email;
            this.Role = Role;
            this.IsRedeemed = IsRedeemed;
            this.Code = Code;
            this.FullName = FullName;
            this.PhoneNumber = PhoneNumber;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or Sets IsRedeemed
        /// </summary>
        [DataMember(Name="isRedeemed", EmitDefaultValue=false)]
        public bool? IsRedeemed { get; set; }
    
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
    
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
            sb.Append("class InvitationViewModel {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  IsRedeemed: ").Append(IsRedeemed).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(obj as InvitationViewModel);
        }

        /// <summary>
        /// Returns true if InvitationViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of InvitationViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationViewModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.IsRedeemed == other.IsRedeemed ||
                    this.IsRedeemed != null &&
                    this.IsRedeemed.Equals(other.IsRedeemed)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                
                if (this.IsRedeemed != null)
                    hash = hash * 59 + this.IsRedeemed.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }


}
