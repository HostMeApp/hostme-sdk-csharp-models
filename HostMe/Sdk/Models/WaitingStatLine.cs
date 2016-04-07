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
    public partial class WaitingStatLine :  IEquatable<WaitingStatLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingStatLine" /> class.
        /// Initializes a new instance of the <see cref="WaitingStatLine" />class.
        /// </summary>
        /// <param name="Area">Area.</param>
        /// <param name="AvgCallTime">AvgCallTime.</param>
        /// <param name="AvgSeatTime">AvgSeatTime.</param>
        /// <param name="TopSize">TopSize.</param>

        public WaitingStatLine(string Area = null, double? AvgCallTime = null, double? AvgSeatTime = null, int? TopSize = null)
        {
            this.Area = Area;
            this.AvgCallTime = AvgCallTime;
            this.AvgSeatTime = AvgSeatTime;
            this.TopSize = TopSize;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }
    
        /// <summary>
        /// Gets or Sets AvgCallTime
        /// </summary>
        [DataMember(Name="avgCallTime", EmitDefaultValue=false)]
        public double? AvgCallTime { get; set; }
    
        /// <summary>
        /// Gets or Sets AvgSeatTime
        /// </summary>
        [DataMember(Name="avgSeatTime", EmitDefaultValue=false)]
        public double? AvgSeatTime { get; set; }
    
        /// <summary>
        /// Gets or Sets TopSize
        /// </summary>
        [DataMember(Name="topSize", EmitDefaultValue=false)]
        public int? TopSize { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingStatLine {\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  AvgCallTime: ").Append(AvgCallTime).Append("\n");
            sb.Append("  AvgSeatTime: ").Append(AvgSeatTime).Append("\n");
            sb.Append("  TopSize: ").Append(TopSize).Append("\n");
            
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
            return this.Equals(obj as WaitingStatLine);
        }

        /// <summary>
        /// Returns true if WaitingStatLine instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingStatLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingStatLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Area == other.Area ||
                    this.Area != null &&
                    this.Area.Equals(other.Area)
                ) && 
                (
                    this.AvgCallTime == other.AvgCallTime ||
                    this.AvgCallTime != null &&
                    this.AvgCallTime.Equals(other.AvgCallTime)
                ) && 
                (
                    this.AvgSeatTime == other.AvgSeatTime ||
                    this.AvgSeatTime != null &&
                    this.AvgSeatTime.Equals(other.AvgSeatTime)
                ) && 
                (
                    this.TopSize == other.TopSize ||
                    this.TopSize != null &&
                    this.TopSize.Equals(other.TopSize)
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
                
                if (this.Area != null)
                    hash = hash * 59 + this.Area.GetHashCode();
                
                if (this.AvgCallTime != null)
                    hash = hash * 59 + this.AvgCallTime.GetHashCode();
                
                if (this.AvgSeatTime != null)
                    hash = hash * 59 + this.AvgSeatTime.GetHashCode();
                
                if (this.TopSize != null)
                    hash = hash * 59 + this.TopSize.GetHashCode();
                
                return hash;
            }
        }

    }


}
