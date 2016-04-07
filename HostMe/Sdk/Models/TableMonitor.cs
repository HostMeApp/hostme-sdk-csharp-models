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
    public partial class TableMonitor :  IEquatable<TableMonitor>
    { 
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Available")]
            Available,
            
            [EnumMember(Value = "Busy")]
            Busy,
            
            [EnumMember(Value = "Assigned")]
            Assigned,
            
            [EnumMember(Value = "Reserved")]
            Reserved
        }

    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TableMonitor" /> class.
        /// Initializes a new instance of the <see cref="TableMonitor" />class.
        /// </summary>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="Status">Status.</param>
        /// <param name="WaitingItemId">WaitingItemId.</param>
        /// <param name="ReservationId">ReservationId.</param>
        /// <param name="RegistrationId">RegistrationId.</param>
        /// <param name="PartySize">PartySize.</param>
        /// <param name="Membership">Membership.</param>
        /// <param name="NextReservationTime">NextReservationTime.</param>
        /// <param name="AssignmentTime">AssignmentTime.</param>
        /// <param name="RegistrationTime">RegistrationTime.</param>
        /// <param name="EstimatedReleaseTime">EstimatedReleaseTime.</param>

        public TableMonitor(string TableNumber = null, StatusEnum? Status = null, int? WaitingItemId = null, string ReservationId = null, int? RegistrationId = null, int? PartySize = null, MembershipInfo Membership = null, DateTimeOffset? NextReservationTime = null, DateTimeOffset? AssignmentTime = null, DateTimeOffset? RegistrationTime = null, DateTimeOffset? EstimatedReleaseTime = null)
        {
            this.TableNumber = TableNumber;
            this.Status = Status;
            this.WaitingItemId = WaitingItemId;
            this.ReservationId = ReservationId;
            this.RegistrationId = RegistrationId;
            this.PartySize = PartySize;
            this.Membership = Membership;
            this.NextReservationTime = NextReservationTime;
            this.AssignmentTime = AssignmentTime;
            this.RegistrationTime = RegistrationTime;
            this.EstimatedReleaseTime = EstimatedReleaseTime;
            
        }
        
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=false)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets WaitingItemId
        /// </summary>
        [DataMember(Name="waitingItemId", EmitDefaultValue=false)]
        public int? WaitingItemId { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationId
        /// </summary>
        [DataMember(Name="reservationId", EmitDefaultValue=false)]
        public string ReservationId { get; set; }
    
        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name="registrationId", EmitDefaultValue=false)]
        public int? RegistrationId { get; set; }
    
        /// <summary>
        /// Gets or Sets PartySize
        /// </summary>
        [DataMember(Name="partySize", EmitDefaultValue=false)]
        public int? PartySize { get; set; }
    
        /// <summary>
        /// Gets or Sets Membership
        /// </summary>
        [DataMember(Name="membership", EmitDefaultValue=false)]
        public MembershipInfo Membership { get; set; }
    
        /// <summary>
        /// Gets or Sets NextReservationTime
        /// </summary>
        [DataMember(Name="nextReservationTime", EmitDefaultValue=false)]
        public DateTimeOffset? NextReservationTime { get; set; }
    
        /// <summary>
        /// Gets or Sets AssignmentTime
        /// </summary>
        [DataMember(Name="assignmentTime", EmitDefaultValue=false)]
        public DateTimeOffset? AssignmentTime { get; set; }
    
        /// <summary>
        /// Gets or Sets RegistrationTime
        /// </summary>
        [DataMember(Name="registrationTime", EmitDefaultValue=false)]
        public DateTimeOffset? RegistrationTime { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedReleaseTime
        /// </summary>
        [DataMember(Name="estimatedReleaseTime", EmitDefaultValue=false)]
        public DateTimeOffset? EstimatedReleaseTime { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableMonitor {\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WaitingItemId: ").Append(WaitingItemId).Append("\n");
            sb.Append("  ReservationId: ").Append(ReservationId).Append("\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  PartySize: ").Append(PartySize).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  NextReservationTime: ").Append(NextReservationTime).Append("\n");
            sb.Append("  AssignmentTime: ").Append(AssignmentTime).Append("\n");
            sb.Append("  RegistrationTime: ").Append(RegistrationTime).Append("\n");
            sb.Append("  EstimatedReleaseTime: ").Append(EstimatedReleaseTime).Append("\n");
            
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
            return this.Equals(obj as TableMonitor);
        }

        /// <summary>
        /// Returns true if TableMonitor instances are equal
        /// </summary>
        /// <param name="other">Instance of TableMonitor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableMonitor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.WaitingItemId == other.WaitingItemId ||
                    this.WaitingItemId != null &&
                    this.WaitingItemId.Equals(other.WaitingItemId)
                ) && 
                (
                    this.ReservationId == other.ReservationId ||
                    this.ReservationId != null &&
                    this.ReservationId.Equals(other.ReservationId)
                ) && 
                (
                    this.RegistrationId == other.RegistrationId ||
                    this.RegistrationId != null &&
                    this.RegistrationId.Equals(other.RegistrationId)
                ) && 
                (
                    this.PartySize == other.PartySize ||
                    this.PartySize != null &&
                    this.PartySize.Equals(other.PartySize)
                ) && 
                (
                    this.Membership == other.Membership ||
                    this.Membership != null &&
                    this.Membership.Equals(other.Membership)
                ) && 
                (
                    this.NextReservationTime == other.NextReservationTime ||
                    this.NextReservationTime != null &&
                    this.NextReservationTime.Equals(other.NextReservationTime)
                ) && 
                (
                    this.AssignmentTime == other.AssignmentTime ||
                    this.AssignmentTime != null &&
                    this.AssignmentTime.Equals(other.AssignmentTime)
                ) && 
                (
                    this.RegistrationTime == other.RegistrationTime ||
                    this.RegistrationTime != null &&
                    this.RegistrationTime.Equals(other.RegistrationTime)
                ) && 
                (
                    this.EstimatedReleaseTime == other.EstimatedReleaseTime ||
                    this.EstimatedReleaseTime != null &&
                    this.EstimatedReleaseTime.Equals(other.EstimatedReleaseTime)
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
                
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.WaitingItemId != null)
                    hash = hash * 59 + this.WaitingItemId.GetHashCode();
                
                if (this.ReservationId != null)
                    hash = hash * 59 + this.ReservationId.GetHashCode();
                
                if (this.RegistrationId != null)
                    hash = hash * 59 + this.RegistrationId.GetHashCode();
                
                if (this.PartySize != null)
                    hash = hash * 59 + this.PartySize.GetHashCode();
                
                if (this.Membership != null)
                    hash = hash * 59 + this.Membership.GetHashCode();
                
                if (this.NextReservationTime != null)
                    hash = hash * 59 + this.NextReservationTime.GetHashCode();
                
                if (this.AssignmentTime != null)
                    hash = hash * 59 + this.AssignmentTime.GetHashCode();
                
                if (this.RegistrationTime != null)
                    hash = hash * 59 + this.RegistrationTime.GetHashCode();
                
                if (this.EstimatedReleaseTime != null)
                    hash = hash * 59 + this.EstimatedReleaseTime.GetHashCode();
                
                return hash;
            }
        }

    }


}
