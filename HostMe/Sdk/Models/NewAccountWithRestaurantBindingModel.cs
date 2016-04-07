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
    public partial class NewAccountWithRestaurantBindingModel :  IEquatable<NewAccountWithRestaurantBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccountWithRestaurantBindingModel" /> class.
        /// Initializes a new instance of the <see cref="NewAccountWithRestaurantBindingModel" />class.
        /// </summary>
        /// <param name="FullName">FullName (required).</param>
        /// <param name="UserPhone">UserPhone (required).</param>
        /// <param name="UserEmail">UserEmail (required).</param>
        /// <param name="RestaurantName">RestaurantName.</param>
        /// <param name="RestaurantAddress">RestaurantAddress (required).</param>
        /// <param name="RestaurantPhone">RestaurantPhone.</param>

        public NewAccountWithRestaurantBindingModel(string FullName = null, string UserPhone = null, string UserEmail = null, string RestaurantName = null, string RestaurantAddress = null, string RestaurantPhone = null)
        {
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for NewAccountWithRestaurantBindingModel and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
            // to ensure "UserPhone" is required (not null)
            if (UserPhone == null)
            {
                throw new InvalidDataException("UserPhone is a required property for NewAccountWithRestaurantBindingModel and cannot be null");
            }
            else
            {
                this.UserPhone = UserPhone;
            }
            // to ensure "UserEmail" is required (not null)
            if (UserEmail == null)
            {
                throw new InvalidDataException("UserEmail is a required property for NewAccountWithRestaurantBindingModel and cannot be null");
            }
            else
            {
                this.UserEmail = UserEmail;
            }
            // to ensure "RestaurantAddress" is required (not null)
            if (RestaurantAddress == null)
            {
                throw new InvalidDataException("RestaurantAddress is a required property for NewAccountWithRestaurantBindingModel and cannot be null");
            }
            else
            {
                this.RestaurantAddress = RestaurantAddress;
            }
            this.RestaurantName = RestaurantName;
            this.RestaurantPhone = RestaurantPhone;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }
    
        /// <summary>
        /// Gets or Sets UserPhone
        /// </summary>
        [DataMember(Name="userPhone", EmitDefaultValue=false)]
        public string UserPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets UserEmail
        /// </summary>
        [DataMember(Name="userEmail", EmitDefaultValue=false)]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets RestaurantName
        /// </summary>
        [DataMember(Name="restaurantName", EmitDefaultValue=false)]
        public string RestaurantName { get; set; }
    
        /// <summary>
        /// Gets or Sets RestaurantAddress
        /// </summary>
        [DataMember(Name="restaurantAddress", EmitDefaultValue=false)]
        public string RestaurantAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets RestaurantPhone
        /// </summary>
        [DataMember(Name="restaurantPhone", EmitDefaultValue=false)]
        public string RestaurantPhone { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAccountWithRestaurantBindingModel {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  UserPhone: ").Append(UserPhone).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  RestaurantName: ").Append(RestaurantName).Append("\n");
            sb.Append("  RestaurantAddress: ").Append(RestaurantAddress).Append("\n");
            sb.Append("  RestaurantPhone: ").Append(RestaurantPhone).Append("\n");
            
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
            return this.Equals(obj as NewAccountWithRestaurantBindingModel);
        }

        /// <summary>
        /// Returns true if NewAccountWithRestaurantBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of NewAccountWithRestaurantBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAccountWithRestaurantBindingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.UserPhone == other.UserPhone ||
                    this.UserPhone != null &&
                    this.UserPhone.Equals(other.UserPhone)
                ) && 
                (
                    this.UserEmail == other.UserEmail ||
                    this.UserEmail != null &&
                    this.UserEmail.Equals(other.UserEmail)
                ) && 
                (
                    this.RestaurantName == other.RestaurantName ||
                    this.RestaurantName != null &&
                    this.RestaurantName.Equals(other.RestaurantName)
                ) && 
                (
                    this.RestaurantAddress == other.RestaurantAddress ||
                    this.RestaurantAddress != null &&
                    this.RestaurantAddress.Equals(other.RestaurantAddress)
                ) && 
                (
                    this.RestaurantPhone == other.RestaurantPhone ||
                    this.RestaurantPhone != null &&
                    this.RestaurantPhone.Equals(other.RestaurantPhone)
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
                
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                
                if (this.UserPhone != null)
                    hash = hash * 59 + this.UserPhone.GetHashCode();
                
                if (this.UserEmail != null)
                    hash = hash * 59 + this.UserEmail.GetHashCode();
                
                if (this.RestaurantName != null)
                    hash = hash * 59 + this.RestaurantName.GetHashCode();
                
                if (this.RestaurantAddress != null)
                    hash = hash * 59 + this.RestaurantAddress.GetHashCode();
                
                if (this.RestaurantPhone != null)
                    hash = hash * 59 + this.RestaurantPhone.GetHashCode();
                
                return hash;
            }
        }

    }


}
