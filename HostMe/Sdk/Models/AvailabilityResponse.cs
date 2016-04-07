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
    public partial class AvailabilityResponse :  IEquatable<AvailabilityResponse>
    { 
    
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitTypeEnum {
            
            [EnumMember(Value = "Cover")]
            Cover,
            
            [EnumMember(Value = "Table")]
            Table,
            
            [EnumMember(Value = "Default")]
            Default
        }

    
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public UnitTypeEnum? UnitType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityResponse" /> class.
        /// Initializes a new instance of the <see cref="AvailabilityResponse" />class.
        /// </summary>
        /// <param name="Availabilities">Availabilities.</param>
        /// <param name="RequestedTime">RequestedTime.</param>
        /// <param name="TotalCovers">TotalCovers.</param>
        /// <param name="TotalReservationCovers">TotalReservationCovers.</param>
        /// <param name="TotalWaitCovers">TotalWaitCovers.</param>
        /// <param name="UnitType">UnitType.</param>

        public AvailabilityResponse(List<Availability> Availabilities = null, DateTimeOffset? RequestedTime = null, int? TotalCovers = null, int? TotalReservationCovers = null, int? TotalWaitCovers = null, UnitTypeEnum? UnitType = null)
        {
            this.Availabilities = Availabilities;
            this.RequestedTime = RequestedTime;
            this.TotalCovers = TotalCovers;
            this.TotalReservationCovers = TotalReservationCovers;
            this.TotalWaitCovers = TotalWaitCovers;
            this.UnitType = UnitType;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Availabilities
        /// </summary>
        [DataMember(Name="availabilities", EmitDefaultValue=false)]
        public List<Availability> Availabilities { get; set; }
    
        /// <summary>
        /// Gets or Sets RequestedTime
        /// </summary>
        [DataMember(Name="requestedTime", EmitDefaultValue=false)]
        public DateTimeOffset? RequestedTime { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalCovers
        /// </summary>
        [DataMember(Name="totalCovers", EmitDefaultValue=false)]
        public int? TotalCovers { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalReservationCovers
        /// </summary>
        [DataMember(Name="totalReservationCovers", EmitDefaultValue=false)]
        public int? TotalReservationCovers { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalWaitCovers
        /// </summary>
        [DataMember(Name="totalWaitCovers", EmitDefaultValue=false)]
        public int? TotalWaitCovers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityResponse {\n");
            sb.Append("  Availabilities: ").Append(Availabilities).Append("\n");
            sb.Append("  RequestedTime: ").Append(RequestedTime).Append("\n");
            sb.Append("  TotalCovers: ").Append(TotalCovers).Append("\n");
            sb.Append("  TotalReservationCovers: ").Append(TotalReservationCovers).Append("\n");
            sb.Append("  TotalWaitCovers: ").Append(TotalWaitCovers).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            
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
            return this.Equals(obj as AvailabilityResponse);
        }

        /// <summary>
        /// Returns true if AvailabilityResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Availabilities == other.Availabilities ||
                    this.Availabilities != null &&
                    this.Availabilities.SequenceEqual(other.Availabilities)
                ) && 
                (
                    this.RequestedTime == other.RequestedTime ||
                    this.RequestedTime != null &&
                    this.RequestedTime.Equals(other.RequestedTime)
                ) && 
                (
                    this.TotalCovers == other.TotalCovers ||
                    this.TotalCovers != null &&
                    this.TotalCovers.Equals(other.TotalCovers)
                ) && 
                (
                    this.TotalReservationCovers == other.TotalReservationCovers ||
                    this.TotalReservationCovers != null &&
                    this.TotalReservationCovers.Equals(other.TotalReservationCovers)
                ) && 
                (
                    this.TotalWaitCovers == other.TotalWaitCovers ||
                    this.TotalWaitCovers != null &&
                    this.TotalWaitCovers.Equals(other.TotalWaitCovers)
                ) && 
                (
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
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
                
                if (this.Availabilities != null)
                    hash = hash * 59 + this.Availabilities.GetHashCode();
                
                if (this.RequestedTime != null)
                    hash = hash * 59 + this.RequestedTime.GetHashCode();
                
                if (this.TotalCovers != null)
                    hash = hash * 59 + this.TotalCovers.GetHashCode();
                
                if (this.TotalReservationCovers != null)
                    hash = hash * 59 + this.TotalReservationCovers.GetHashCode();
                
                if (this.TotalWaitCovers != null)
                    hash = hash * 59 + this.TotalWaitCovers.GetHashCode();
                
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                
                return hash;
            }
        }

    }


}
