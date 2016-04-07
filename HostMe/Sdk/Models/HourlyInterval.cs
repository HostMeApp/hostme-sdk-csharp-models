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
    public partial class HourlyInterval :  IEquatable<HourlyInterval>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HourlyInterval" /> class.
        /// Initializes a new instance of the <see cref="HourlyInterval" />class.
        /// </summary>
        /// <param name="Close">Close.</param>
        /// <param name="Open">Open.</param>

        public HourlyInterval(string Close = null, string Open = null)
        {
            this.Close = Close;
            this.Open = Open;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public string Close { get; set; }
    
        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public string Open { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HourlyInterval {\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            
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
            return this.Equals(obj as HourlyInterval);
        }

        /// <summary>
        /// Returns true if HourlyInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of HourlyInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HourlyInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Close == other.Close ||
                    this.Close != null &&
                    this.Close.Equals(other.Close)
                ) && 
                (
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.Equals(other.Open)
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
                
                if (this.Close != null)
                    hash = hash * 59 + this.Close.GetHashCode();
                
                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();
                
                return hash;
            }
        }

    }


}
