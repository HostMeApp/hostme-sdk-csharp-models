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
    public partial class MembershipInfo :  IEquatable<MembershipInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipInfo" /> class.
        /// Initializes a new instance of the <see cref="MembershipInfo" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MembershipLevel">MembershipLevel.</param>
        /// <param name="Points">Points.</param>

        public MembershipInfo(int? Id = null, string MembershipLevel = null, long? Points = null)
        {
            this.Id = Id;
            this.MembershipLevel = MembershipLevel;
            this.Points = Points;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets MembershipLevel
        /// </summary>
        [DataMember(Name="membershipLevel", EmitDefaultValue=false)]
        public string MembershipLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public long? Points { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MembershipLevel: ").Append(MembershipLevel).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            
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
            return this.Equals(obj as MembershipInfo);
        }

        /// <summary>
        /// Returns true if MembershipInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MembershipInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipInfo other)
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
                    this.MembershipLevel == other.MembershipLevel ||
                    this.MembershipLevel != null &&
                    this.MembershipLevel.Equals(other.MembershipLevel)
                ) && 
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
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
                
                if (this.MembershipLevel != null)
                    hash = hash * 59 + this.MembershipLevel.GetHashCode();
                
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                
                return hash;
            }
        }

    }


}
