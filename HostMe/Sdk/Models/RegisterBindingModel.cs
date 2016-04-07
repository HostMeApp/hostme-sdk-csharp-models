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
    public partial class RegisterBindingModel :  IEquatable<RegisterBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterBindingModel" /> class.
        /// Initializes a new instance of the <see cref="RegisterBindingModel" />class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="FullName">FullName (required).</param>
        /// <param name="PhoneNumber">PhoneNumber (required).</param>
        /// <param name="Password">Password (required).</param>
        /// <param name="ConfirmPassword">ConfirmPassword.</param>
        /// <param name="ConfirmationUrl">ConfirmationUrl.</param>
        /// <param name="InvitationCode">InvitationCode.</param>

        public RegisterBindingModel(string Email = null, string FullName = null, string PhoneNumber = null, string Password = null, string ConfirmPassword = null, string ConfirmationUrl = null, string InvitationCode = null)
        {
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for RegisterBindingModel and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for RegisterBindingModel and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for RegisterBindingModel and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.Email = Email;
            this.ConfirmPassword = ConfirmPassword;
            this.ConfirmationUrl = ConfirmationUrl;
            this.InvitationCode = InvitationCode;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
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
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or Sets ConfirmPassword
        /// </summary>
        [DataMember(Name="confirmPassword", EmitDefaultValue=false)]
        public string ConfirmPassword { get; set; }
    
        /// <summary>
        /// Gets or Sets ConfirmationUrl
        /// </summary>
        [DataMember(Name="confirmationUrl", EmitDefaultValue=false)]
        public string ConfirmationUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets InvitationCode
        /// </summary>
        [DataMember(Name="invitationCode", EmitDefaultValue=false)]
        public string InvitationCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterBindingModel {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ConfirmPassword: ").Append(ConfirmPassword).Append("\n");
            sb.Append("  ConfirmationUrl: ").Append(ConfirmationUrl).Append("\n");
            sb.Append("  InvitationCode: ").Append(InvitationCode).Append("\n");
            
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
            return this.Equals(obj as RegisterBindingModel);
        }

        /// <summary>
        /// Returns true if RegisterBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterBindingModel other)
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
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.ConfirmPassword == other.ConfirmPassword ||
                    this.ConfirmPassword != null &&
                    this.ConfirmPassword.Equals(other.ConfirmPassword)
                ) && 
                (
                    this.ConfirmationUrl == other.ConfirmationUrl ||
                    this.ConfirmationUrl != null &&
                    this.ConfirmationUrl.Equals(other.ConfirmationUrl)
                ) && 
                (
                    this.InvitationCode == other.InvitationCode ||
                    this.InvitationCode != null &&
                    this.InvitationCode.Equals(other.InvitationCode)
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
                
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.ConfirmPassword != null)
                    hash = hash * 59 + this.ConfirmPassword.GetHashCode();
                
                if (this.ConfirmationUrl != null)
                    hash = hash * 59 + this.ConfirmationUrl.GetHashCode();
                
                if (this.InvitationCode != null)
                    hash = hash * 59 + this.InvitationCode.GetHashCode();
                
                return hash;
            }
        }

    }


}
