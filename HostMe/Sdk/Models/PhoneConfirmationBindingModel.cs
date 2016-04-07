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
    public partial class PhoneConfirmationBindingModel :  IEquatable<PhoneConfirmationBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneConfirmationBindingModel" /> class.
        /// Initializes a new instance of the <see cref="PhoneConfirmationBindingModel" />class.
        /// </summary>
        /// <param name="PhoneId">Phone identifier that will be used to send push notifications.</param>
        /// <param name="DeviceType">DeviceType (required).</param>
        /// <param name="Longitude">Longitude of the phone. Coordinates are used to check that phone location and restaurant are close enought..</param>
        /// <param name="Lattitude">Latitude of the phone. Coordinates are used to check that phone location and restaurant are close enought..</param>
        /// <param name="CustomerName">Optional. Only is used. (required).</param>
        /// <param name="NotificationUrl">NotificationUrl (required).</param>

        public PhoneConfirmationBindingModel(string PhoneId = null, string DeviceType = null, double? Longitude = null, double? Lattitude = null, string CustomerName = null, string NotificationUrl = null)
        {
            // to ensure "DeviceType" is required (not null)
            if (DeviceType == null)
            {
                throw new InvalidDataException("DeviceType is a required property for PhoneConfirmationBindingModel and cannot be null");
            }
            else
            {
                this.DeviceType = DeviceType;
            }
            // to ensure "CustomerName" is required (not null)
            if (CustomerName == null)
            {
                throw new InvalidDataException("CustomerName is a required property for PhoneConfirmationBindingModel and cannot be null");
            }
            else
            {
                this.CustomerName = CustomerName;
            }
            // to ensure "NotificationUrl" is required (not null)
            if (NotificationUrl == null)
            {
                throw new InvalidDataException("NotificationUrl is a required property for PhoneConfirmationBindingModel and cannot be null");
            }
            else
            {
                this.NotificationUrl = NotificationUrl;
            }
            this.PhoneId = PhoneId;
            this.Longitude = Longitude;
            this.Lattitude = Lattitude;
            
        }
        
    
        /// <summary>
        /// Phone identifier that will be used to send push notifications
        /// </summary>
        /// <value>Phone identifier that will be used to send push notifications</value>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="deviceType", EmitDefaultValue=false)]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Longitude of the phone. Coordinates are used to check that phone location and restaurant are close enought.
        /// </summary>
        /// <value>Longitude of the phone. Coordinates are used to check that phone location and restaurant are close enought.</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }
    
        /// <summary>
        /// Latitude of the phone. Coordinates are used to check that phone location and restaurant are close enought.
        /// </summary>
        /// <value>Latitude of the phone. Coordinates are used to check that phone location and restaurant are close enought.</value>
        [DataMember(Name="lattitude", EmitDefaultValue=false)]
        public double? Lattitude { get; set; }
    
        /// <summary>
        /// Optional. Only is used.
        /// </summary>
        /// <value>Optional. Only is used.</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Gets or Sets NotificationUrl
        /// </summary>
        [DataMember(Name="notificationUrl", EmitDefaultValue=false)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneConfirmationBindingModel {\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Lattitude: ").Append(Lattitude).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            
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
            return this.Equals(obj as PhoneConfirmationBindingModel);
        }

        /// <summary>
        /// Returns true if PhoneConfirmationBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneConfirmationBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneConfirmationBindingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneId == other.PhoneId ||
                    this.PhoneId != null &&
                    this.PhoneId.Equals(other.PhoneId)
                ) && 
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.Lattitude == other.Lattitude ||
                    this.Lattitude != null &&
                    this.Lattitude.Equals(other.Lattitude)
                ) && 
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
                ) && 
                (
                    this.NotificationUrl == other.NotificationUrl ||
                    this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(other.NotificationUrl)
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
                
                if (this.PhoneId != null)
                    hash = hash * 59 + this.PhoneId.GetHashCode();
                
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                
                if (this.Lattitude != null)
                    hash = hash * 59 + this.Lattitude.GetHashCode();
                
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                
                if (this.NotificationUrl != null)
                    hash = hash * 59 + this.NotificationUrl.GetHashCode();
                
                return hash;
            }
        }

    }


}
