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
    public partial class BusinessHours :  IEquatable<BusinessHours>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHours" /> class.
        /// Initializes a new instance of the <see cref="BusinessHours" />class.
        /// </summary>
        /// <param name="OpeningHours">OpeningHours.</param>
        /// <param name="IsOpenNow">IsOpenNow.</param>

        public BusinessHours(List<WeekDayOpenHours> OpeningHours = null, bool? IsOpenNow = null)
        {
            this.OpeningHours = OpeningHours;
            this.IsOpenNow = IsOpenNow;
            
        }
        
    
        /// <summary>
        /// Gets or Sets OpeningHours
        /// </summary>
        [DataMember(Name="openingHours", EmitDefaultValue=false)]
        public List<WeekDayOpenHours> OpeningHours { get; set; }
    
        /// <summary>
        /// Gets or Sets IsOpenNow
        /// </summary>
        [DataMember(Name="isOpenNow", EmitDefaultValue=false)]
        public bool? IsOpenNow { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessHours {\n");
            sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
            sb.Append("  IsOpenNow: ").Append(IsOpenNow).Append("\n");
            
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
            return this.Equals(obj as BusinessHours);
        }

        /// <summary>
        /// Returns true if BusinessHours instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessHours to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHours other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OpeningHours == other.OpeningHours ||
                    this.OpeningHours != null &&
                    this.OpeningHours.SequenceEqual(other.OpeningHours)
                ) && 
                (
                    this.IsOpenNow == other.IsOpenNow ||
                    this.IsOpenNow != null &&
                    this.IsOpenNow.Equals(other.IsOpenNow)
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
                
                if (this.OpeningHours != null)
                    hash = hash * 59 + this.OpeningHours.GetHashCode();
                
                if (this.IsOpenNow != null)
                    hash = hash * 59 + this.IsOpenNow.GetHashCode();
                
                return hash;
            }
        }

    }


}
