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
    public partial class Availability :  IEquatable<Availability>
    { 
    
        /// <summary>
        /// Gets or Sets AvailabilityLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityLevelEnum {
            
            [EnumMember(Value = "Available")]
            Available,
            
            [EnumMember(Value = "AvailableForWait")]
            Availableforwait,
            
            [EnumMember(Value = "NotEnoughCovers")]
            Notenoughcovers,
            
            [EnumMember(Value = "Overbooked")]
            Overbooked
        }

    
        /// <summary>
        /// Gets or Sets AvailabilityLevel
        /// </summary>
        [DataMember(Name="availabilityLevel", EmitDefaultValue=false)]
        public AvailabilityLevelEnum? AvailabilityLevel { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Availability" /> class.
        /// Initializes a new instance of the <see cref="Availability" />class.
        /// </summary>
        /// <param name="AcceptReservations">AcceptReservations.</param>
        /// <param name="AvailabilityLevel">AvailabilityLevel.</param>
        /// <param name="InWaitCovers">InWaitCovers.</param>
        /// <param name="MaxCoversForSlot">MaxCoversForSlot.</param>
        /// <param name="Open">Open.</param>
        /// <param name="RecommendedTables">RecommendedTables.</param>
        /// <param name="RequestedTime">RequestedTime.</param>
        /// <param name="ReservedCovers">ReservedCovers.</param>
        /// <param name="Time">Time.</param>

        public Availability(bool? AcceptReservations = null, AvailabilityLevelEnum? AvailabilityLevel = null, int? InWaitCovers = null, int? MaxCoversForSlot = null, bool? Open = null, string RecommendedTables = null, bool? RequestedTime = null, int? ReservedCovers = null, string Time = null)
        {
            this.AcceptReservations = AcceptReservations;
            this.AvailabilityLevel = AvailabilityLevel;
            this.InWaitCovers = InWaitCovers;
            this.MaxCoversForSlot = MaxCoversForSlot;
            this.Open = Open;
            this.RecommendedTables = RecommendedTables;
            this.RequestedTime = RequestedTime;
            this.ReservedCovers = ReservedCovers;
            this.Time = Time;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AcceptReservations
        /// </summary>
        [DataMember(Name="acceptReservations", EmitDefaultValue=false)]
        public bool? AcceptReservations { get; set; }
    
        /// <summary>
        /// Gets or Sets InWaitCovers
        /// </summary>
        [DataMember(Name="inWaitCovers", EmitDefaultValue=false)]
        public int? InWaitCovers { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxCoversForSlot
        /// </summary>
        [DataMember(Name="maxCoversForSlot", EmitDefaultValue=false)]
        public int? MaxCoversForSlot { get; set; }
    
        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public bool? Open { get; set; }
    
        /// <summary>
        /// Gets or Sets RecommendedTables
        /// </summary>
        [DataMember(Name="recommendedTables", EmitDefaultValue=false)]
        public string RecommendedTables { get; set; }
    
        /// <summary>
        /// Gets or Sets RequestedTime
        /// </summary>
        [DataMember(Name="requestedTime", EmitDefaultValue=false)]
        public bool? RequestedTime { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservedCovers
        /// </summary>
        [DataMember(Name="reservedCovers", EmitDefaultValue=false)]
        public int? ReservedCovers { get; set; }
    
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Availability {\n");
            sb.Append("  AcceptReservations: ").Append(AcceptReservations).Append("\n");
            sb.Append("  AvailabilityLevel: ").Append(AvailabilityLevel).Append("\n");
            sb.Append("  InWaitCovers: ").Append(InWaitCovers).Append("\n");
            sb.Append("  MaxCoversForSlot: ").Append(MaxCoversForSlot).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  RecommendedTables: ").Append(RecommendedTables).Append("\n");
            sb.Append("  RequestedTime: ").Append(RequestedTime).Append("\n");
            sb.Append("  ReservedCovers: ").Append(ReservedCovers).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            
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
            return this.Equals(obj as Availability);
        }

        /// <summary>
        /// Returns true if Availability instances are equal
        /// </summary>
        /// <param name="other">Instance of Availability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Availability other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcceptReservations == other.AcceptReservations ||
                    this.AcceptReservations != null &&
                    this.AcceptReservations.Equals(other.AcceptReservations)
                ) && 
                (
                    this.AvailabilityLevel == other.AvailabilityLevel ||
                    this.AvailabilityLevel != null &&
                    this.AvailabilityLevel.Equals(other.AvailabilityLevel)
                ) && 
                (
                    this.InWaitCovers == other.InWaitCovers ||
                    this.InWaitCovers != null &&
                    this.InWaitCovers.Equals(other.InWaitCovers)
                ) && 
                (
                    this.MaxCoversForSlot == other.MaxCoversForSlot ||
                    this.MaxCoversForSlot != null &&
                    this.MaxCoversForSlot.Equals(other.MaxCoversForSlot)
                ) && 
                (
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.Equals(other.Open)
                ) && 
                (
                    this.RecommendedTables == other.RecommendedTables ||
                    this.RecommendedTables != null &&
                    this.RecommendedTables.Equals(other.RecommendedTables)
                ) && 
                (
                    this.RequestedTime == other.RequestedTime ||
                    this.RequestedTime != null &&
                    this.RequestedTime.Equals(other.RequestedTime)
                ) && 
                (
                    this.ReservedCovers == other.ReservedCovers ||
                    this.ReservedCovers != null &&
                    this.ReservedCovers.Equals(other.ReservedCovers)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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
                
                if (this.AcceptReservations != null)
                    hash = hash * 59 + this.AcceptReservations.GetHashCode();
                
                if (this.AvailabilityLevel != null)
                    hash = hash * 59 + this.AvailabilityLevel.GetHashCode();
                
                if (this.InWaitCovers != null)
                    hash = hash * 59 + this.InWaitCovers.GetHashCode();
                
                if (this.MaxCoversForSlot != null)
                    hash = hash * 59 + this.MaxCoversForSlot.GetHashCode();
                
                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();
                
                if (this.RecommendedTables != null)
                    hash = hash * 59 + this.RecommendedTables.GetHashCode();
                
                if (this.RequestedTime != null)
                    hash = hash * 59 + this.RequestedTime.GetHashCode();
                
                if (this.ReservedCovers != null)
                    hash = hash * 59 + this.ReservedCovers.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                return hash;
            }
        }

    }


}
