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
    public partial class SetPushChannelBindingModel :  IEquatable<SetPushChannelBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPushChannelBindingModel" /> class.
        /// Initializes a new instance of the <see cref="SetPushChannelBindingModel" />class.
        /// </summary>
        /// <param name="NotificationUrl">NotificationUrl (required).</param>
        /// <param name="DeviceType">DeviceType (required).</param>
        /// <param name="Longitude">Longitude.</param>
        /// <param name="Lattitude">Lattitude.</param>

        public SetPushChannelBindingModel(string NotificationUrl = null, string DeviceType = null, double? Longitude = null, double? Lattitude = null)
        {
            // to ensure "NotificationUrl" is required (not null)
            if (NotificationUrl == null)
            {
                throw new InvalidDataException("NotificationUrl is a required property for SetPushChannelBindingModel and cannot be null");
            }
            else
            {
                this.NotificationUrl = NotificationUrl;
            }
            // to ensure "DeviceType" is required (not null)
            if (DeviceType == null)
            {
                throw new InvalidDataException("DeviceType is a required property for SetPushChannelBindingModel and cannot be null");
            }
            else
            {
                this.DeviceType = DeviceType;
            }
            this.Longitude = Longitude;
            this.Lattitude = Lattitude;
            
        }
        
    
        /// <summary>
        /// Gets or Sets NotificationUrl
        /// </summary>
        [DataMember(Name="notificationUrl", EmitDefaultValue=false)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="deviceType", EmitDefaultValue=false)]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }
    
        /// <summary>
        /// Gets or Sets Lattitude
        /// </summary>
        [DataMember(Name="lattitude", EmitDefaultValue=false)]
        public double? Lattitude { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPushChannelBindingModel {\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Lattitude: ").Append(Lattitude).Append("\n");
            
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
            return this.Equals(obj as SetPushChannelBindingModel);
        }

        /// <summary>
        /// Returns true if SetPushChannelBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SetPushChannelBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPushChannelBindingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NotificationUrl == other.NotificationUrl ||
                    this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(other.NotificationUrl)
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
                
                if (this.NotificationUrl != null)
                    hash = hash * 59 + this.NotificationUrl.GetHashCode();
                
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                
                if (this.Lattitude != null)
                    hash = hash * 59 + this.Lattitude.GetHashCode();
                
                return hash;
            }
        }

    }


}
