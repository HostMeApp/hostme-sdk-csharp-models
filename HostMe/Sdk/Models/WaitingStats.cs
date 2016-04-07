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
    public partial class WaitingStats :  IEquatable<WaitingStats>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingStats" /> class.
        /// Initializes a new instance of the <see cref="WaitingStats" />class.
        /// </summary>
        /// <param name="WaitByArea">WaitByArea.</param>
        /// <param name="WaitByGroup">WaitByGroup.</param>

        public WaitingStats(List<WaitingStatLine> WaitByArea = null, List<WaitingStatLine> WaitByGroup = null)
        {
            this.WaitByArea = WaitByArea;
            this.WaitByGroup = WaitByGroup;
            
        }
        
    
        /// <summary>
        /// Gets or Sets WaitByArea
        /// </summary>
        [DataMember(Name="waitByArea", EmitDefaultValue=false)]
        public List<WaitingStatLine> WaitByArea { get; set; }
    
        /// <summary>
        /// Gets or Sets WaitByGroup
        /// </summary>
        [DataMember(Name="waitByGroup", EmitDefaultValue=false)]
        public List<WaitingStatLine> WaitByGroup { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingStats {\n");
            sb.Append("  WaitByArea: ").Append(WaitByArea).Append("\n");
            sb.Append("  WaitByGroup: ").Append(WaitByGroup).Append("\n");
            
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
            return this.Equals(obj as WaitingStats);
        }

        /// <summary>
        /// Returns true if WaitingStats instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WaitByArea == other.WaitByArea ||
                    this.WaitByArea != null &&
                    this.WaitByArea.SequenceEqual(other.WaitByArea)
                ) && 
                (
                    this.WaitByGroup == other.WaitByGroup ||
                    this.WaitByGroup != null &&
                    this.WaitByGroup.SequenceEqual(other.WaitByGroup)
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
                
                if (this.WaitByArea != null)
                    hash = hash * 59 + this.WaitByArea.GetHashCode();
                
                if (this.WaitByGroup != null)
                    hash = hash * 59 + this.WaitByGroup.GetHashCode();
                
                return hash;
            }
        }

    }


}
