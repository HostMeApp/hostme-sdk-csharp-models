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
    public partial class WaitingsStatDimensions :  IEquatable<WaitingsStatDimensions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingsStatDimensions" /> class.
        /// Initializes a new instance of the <see cref="WaitingsStatDimensions" />class.
        /// </summary>
        /// <param name="Time">Time.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="TopSize">TopSize.</param>
        /// <param name="LinePosition">LinePosition.</param>
        /// <param name="Status">Status.</param>

        public WaitingsStatDimensions(TimeDimension Time = null, int? GroupSize = null, int? TopSize = null, int? LinePosition = null, string Status = null)
        {
            this.Time = Time;
            this.GroupSize = GroupSize;
            this.TopSize = TopSize;
            this.LinePosition = LinePosition;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public TimeDimension Time { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=false)]
        public int? GroupSize { get; set; }
    
        /// <summary>
        /// Gets or Sets TopSize
        /// </summary>
        [DataMember(Name="topSize", EmitDefaultValue=false)]
        public int? TopSize { get; set; }
    
        /// <summary>
        /// Gets or Sets LinePosition
        /// </summary>
        [DataMember(Name="linePosition", EmitDefaultValue=false)]
        public int? LinePosition { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingsStatDimensions {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  TopSize: ").Append(TopSize).Append("\n");
            sb.Append("  LinePosition: ").Append(LinePosition).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as WaitingsStatDimensions);
        }

        /// <summary>
        /// Returns true if WaitingsStatDimensions instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingsStatDimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingsStatDimensions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.TopSize == other.TopSize ||
                    this.TopSize != null &&
                    this.TopSize.Equals(other.TopSize)
                ) && 
                (
                    this.LinePosition == other.LinePosition ||
                    this.LinePosition != null &&
                    this.LinePosition.Equals(other.LinePosition)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                
                if (this.TopSize != null)
                    hash = hash * 59 + this.TopSize.GetHashCode();
                
                if (this.LinePosition != null)
                    hash = hash * 59 + this.LinePosition.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }


}
