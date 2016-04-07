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
    public partial class WeekDayOpenHours :  IEquatable<WeekDayOpenHours>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WeekDayOpenHours" /> class.
        /// Initializes a new instance of the <see cref="WeekDayOpenHours" />class.
        /// </summary>
        /// <param name="Time">Time.</param>
        /// <param name="WeekDay">WeekDay.</param>

        public WeekDayOpenHours(List<HourlyInterval> Time = null, int? WeekDay = null)
        {
            this.Time = Time;
            this.WeekDay = WeekDay;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public List<HourlyInterval> Time { get; set; }
    
        /// <summary>
        /// Gets or Sets WeekDay
        /// </summary>
        [DataMember(Name="weekDay", EmitDefaultValue=false)]
        public int? WeekDay { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeekDayOpenHours {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  WeekDay: ").Append(WeekDay).Append("\n");
            
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
            return this.Equals(obj as WeekDayOpenHours);
        }

        /// <summary>
        /// Returns true if WeekDayOpenHours instances are equal
        /// </summary>
        /// <param name="other">Instance of WeekDayOpenHours to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeekDayOpenHours other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.SequenceEqual(other.Time)
                ) && 
                (
                    this.WeekDay == other.WeekDay ||
                    this.WeekDay != null &&
                    this.WeekDay.Equals(other.WeekDay)
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
                
                if (this.WeekDay != null)
                    hash = hash * 59 + this.WeekDay.GetHashCode();
                
                return hash;
            }
        }

    }


}
