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
    public partial class RewardConditions :  IEquatable<RewardConditions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardConditions" /> class.
        /// Initializes a new instance of the <see cref="RewardConditions" />class.
        /// </summary>
        /// <param name="AvailableHours">AvailableHours.</param>
        /// <param name="MembershipLevel">MembershipLevel.</param>

        public RewardConditions(List<WeekDayOpenHours> AvailableHours = null, string MembershipLevel = null)
        {
            this.AvailableHours = AvailableHours;
            this.MembershipLevel = MembershipLevel;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AvailableHours
        /// </summary>
        [DataMember(Name="availableHours", EmitDefaultValue=false)]
        public List<WeekDayOpenHours> AvailableHours { get; set; }
    
        /// <summary>
        /// Gets or Sets MembershipLevel
        /// </summary>
        [DataMember(Name="membershipLevel", EmitDefaultValue=false)]
        public string MembershipLevel { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RewardConditions {\n");
            sb.Append("  AvailableHours: ").Append(AvailableHours).Append("\n");
            sb.Append("  MembershipLevel: ").Append(MembershipLevel).Append("\n");
            
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
            return this.Equals(obj as RewardConditions);
        }

        /// <summary>
        /// Returns true if RewardConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of RewardConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RewardConditions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AvailableHours == other.AvailableHours ||
                    this.AvailableHours != null &&
                    this.AvailableHours.SequenceEqual(other.AvailableHours)
                ) && 
                (
                    this.MembershipLevel == other.MembershipLevel ||
                    this.MembershipLevel != null &&
                    this.MembershipLevel.Equals(other.MembershipLevel)
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
                
                if (this.AvailableHours != null)
                    hash = hash * 59 + this.AvailableHours.GetHashCode();
                
                if (this.MembershipLevel != null)
                    hash = hash * 59 + this.MembershipLevel.GetHashCode();
                
                return hash;
            }
        }

    }


}
