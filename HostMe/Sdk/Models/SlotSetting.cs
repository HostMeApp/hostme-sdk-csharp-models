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
    public partial class SlotSetting :  IEquatable<SlotSetting>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SlotSetting" /> class.
        /// Initializes a new instance of the <see cref="SlotSetting" />class.
        /// </summary>
        /// <param name="Interval">Interval.</param>
        /// <param name="MaxCoversPerSlot">MaxCoversPerSlot.</param>

        public SlotSetting(WeekDayOpenHours Interval = null, int? MaxCoversPerSlot = null)
        {
            this.Interval = Interval;
            this.MaxCoversPerSlot = MaxCoversPerSlot;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public WeekDayOpenHours Interval { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxCoversPerSlot
        /// </summary>
        [DataMember(Name="maxCoversPerSlot", EmitDefaultValue=false)]
        public int? MaxCoversPerSlot { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlotSetting {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  MaxCoversPerSlot: ").Append(MaxCoversPerSlot).Append("\n");
            
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
            return this.Equals(obj as SlotSetting);
        }

        /// <summary>
        /// Returns true if SlotSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of SlotSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlotSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.MaxCoversPerSlot == other.MaxCoversPerSlot ||
                    this.MaxCoversPerSlot != null &&
                    this.MaxCoversPerSlot.Equals(other.MaxCoversPerSlot)
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
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.MaxCoversPerSlot != null)
                    hash = hash * 59 + this.MaxCoversPerSlot.GetHashCode();
                
                return hash;
            }
        }

    }


}
