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
    public partial class TableAvailability :  IEquatable<TableAvailability>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TableAvailability" /> class.
        /// Initializes a new instance of the <see cref="TableAvailability" />class.
        /// </summary>
        /// <param name="MinCoversRequired">MinCoversRequired.</param>
        /// <param name="Reservable">Reservable.</param>
        /// <param name="Hours">Hours.</param>

        public TableAvailability(int? MinCoversRequired = null, bool? Reservable = null, List<WeekDayOpenHours> Hours = null)
        {
            this.MinCoversRequired = MinCoversRequired;
            this.Reservable = Reservable;
            this.Hours = Hours;
            
        }
        
    
        /// <summary>
        /// Gets or Sets MinCoversRequired
        /// </summary>
        [DataMember(Name="minCoversRequired", EmitDefaultValue=false)]
        public int? MinCoversRequired { get; set; }
    
        /// <summary>
        /// Gets or Sets Reservable
        /// </summary>
        [DataMember(Name="reservable", EmitDefaultValue=false)]
        public bool? Reservable { get; set; }
    
        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public List<WeekDayOpenHours> Hours { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableAvailability {\n");
            sb.Append("  MinCoversRequired: ").Append(MinCoversRequired).Append("\n");
            sb.Append("  Reservable: ").Append(Reservable).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            
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
            return this.Equals(obj as TableAvailability);
        }

        /// <summary>
        /// Returns true if TableAvailability instances are equal
        /// </summary>
        /// <param name="other">Instance of TableAvailability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableAvailability other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinCoversRequired == other.MinCoversRequired ||
                    this.MinCoversRequired != null &&
                    this.MinCoversRequired.Equals(other.MinCoversRequired)
                ) && 
                (
                    this.Reservable == other.Reservable ||
                    this.Reservable != null &&
                    this.Reservable.Equals(other.Reservable)
                ) && 
                (
                    this.Hours == other.Hours ||
                    this.Hours != null &&
                    this.Hours.SequenceEqual(other.Hours)
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
                
                if (this.MinCoversRequired != null)
                    hash = hash * 59 + this.MinCoversRequired.GetHashCode();
                
                if (this.Reservable != null)
                    hash = hash * 59 + this.Reservable.GetHashCode();
                
                if (this.Hours != null)
                    hash = hash * 59 + this.Hours.GetHashCode();
                
                return hash;
            }
        }

    }


}
