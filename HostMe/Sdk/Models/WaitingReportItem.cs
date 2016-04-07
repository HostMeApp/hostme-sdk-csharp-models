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
    public partial class WaitingReportItem :  IEquatable<WaitingReportItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingReportItem" /> class.
        /// Initializes a new instance of the <see cref="WaitingReportItem" />class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="Created">Created.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="StartPosition">StartPosition.</param>
        /// <param name="TimeToCall">TimeToCall.</param>
        /// <param name="TimeToSeat">TimeToSeat.</param>
        /// <param name="TimeToCancel">TimeToCancel.</param>

        public WaitingReportItem(string Status = null, DateTimeOffset? Created = null, int? GroupSize = null, int? StartPosition = null, int? TimeToCall = null, int? TimeToSeat = null, int? TimeToCancel = null)
        {
            this.Status = Status;
            this.Created = Created;
            this.GroupSize = GroupSize;
            this.StartPosition = StartPosition;
            this.TimeToCall = TimeToCall;
            this.TimeToSeat = TimeToSeat;
            this.TimeToCancel = TimeToCancel;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTimeOffset? Created { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=false)]
        public int? GroupSize { get; set; }
    
        /// <summary>
        /// Gets or Sets StartPosition
        /// </summary>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public int? StartPosition { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeToCall
        /// </summary>
        [DataMember(Name="timeToCall", EmitDefaultValue=false)]
        public int? TimeToCall { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeToSeat
        /// </summary>
        [DataMember(Name="timeToSeat", EmitDefaultValue=false)]
        public int? TimeToSeat { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeToCancel
        /// </summary>
        [DataMember(Name="timeToCancel", EmitDefaultValue=false)]
        public int? TimeToCancel { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingReportItem {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  TimeToCall: ").Append(TimeToCall).Append("\n");
            sb.Append("  TimeToSeat: ").Append(TimeToSeat).Append("\n");
            sb.Append("  TimeToCancel: ").Append(TimeToCancel).Append("\n");
            
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
            return this.Equals(obj as WaitingReportItem);
        }

        /// <summary>
        /// Returns true if WaitingReportItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingReportItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.TimeToCall == other.TimeToCall ||
                    this.TimeToCall != null &&
                    this.TimeToCall.Equals(other.TimeToCall)
                ) && 
                (
                    this.TimeToSeat == other.TimeToSeat ||
                    this.TimeToSeat != null &&
                    this.TimeToSeat.Equals(other.TimeToSeat)
                ) && 
                (
                    this.TimeToCancel == other.TimeToCancel ||
                    this.TimeToCancel != null &&
                    this.TimeToCancel.Equals(other.TimeToCancel)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                
                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();
                
                if (this.TimeToCall != null)
                    hash = hash * 59 + this.TimeToCall.GetHashCode();
                
                if (this.TimeToSeat != null)
                    hash = hash * 59 + this.TimeToSeat.GetHashCode();
                
                if (this.TimeToCancel != null)
                    hash = hash * 59 + this.TimeToCancel.GetHashCode();
                
                return hash;
            }
        }

    }


}
