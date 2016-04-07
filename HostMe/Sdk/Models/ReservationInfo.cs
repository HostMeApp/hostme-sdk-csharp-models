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
    public partial class ReservationInfo :  IEquatable<ReservationInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationInfo" /> class.
        /// Initializes a new instance of the <see cref="ReservationInfo" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ReservationTime">ReservationTime.</param>

        public ReservationInfo(string Id = null, DateTimeOffset? ReservationTime = null)
        {
            this.Id = Id;
            this.ReservationTime = ReservationTime;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationTime
        /// </summary>
        [DataMember(Name="reservationTime", EmitDefaultValue=false)]
        public DateTimeOffset? ReservationTime { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservationInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            
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
            return this.Equals(obj as ReservationInfo);
        }

        /// <summary>
        /// Returns true if ReservationInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservationInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ReservationTime == other.ReservationTime ||
                    this.ReservationTime != null &&
                    this.ReservationTime.Equals(other.ReservationTime)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                
                return hash;
            }
        }

    }


}
