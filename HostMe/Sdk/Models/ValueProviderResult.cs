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
    public partial class ValueProviderResult :  IEquatable<ValueProviderResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueProviderResult" /> class.
        /// Initializes a new instance of the <see cref="ValueProviderResult" />class.
        /// </summary>
        /// <param name="AttemptedValue">AttemptedValue.</param>
        /// <param name="Culture">Culture.</param>
        /// <param name="RawValue">RawValue.</param>

        public ValueProviderResult(string AttemptedValue = null, string Culture = null, Object RawValue = null)
        {
            this.AttemptedValue = AttemptedValue;
            this.Culture = Culture;
            this.RawValue = RawValue;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AttemptedValue
        /// </summary>
        [DataMember(Name="attemptedValue", EmitDefaultValue=false)]
        public string AttemptedValue { get; set; }
    
        /// <summary>
        /// Gets or Sets Culture
        /// </summary>
        [DataMember(Name="culture", EmitDefaultValue=false)]
        public string Culture { get; set; }
    
        /// <summary>
        /// Gets or Sets RawValue
        /// </summary>
        [DataMember(Name="rawValue", EmitDefaultValue=false)]
        public Object RawValue { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValueProviderResult {\n");
            sb.Append("  AttemptedValue: ").Append(AttemptedValue).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  RawValue: ").Append(RawValue).Append("\n");
            
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
            return this.Equals(obj as ValueProviderResult);
        }

        /// <summary>
        /// Returns true if ValueProviderResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ValueProviderResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueProviderResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AttemptedValue == other.AttemptedValue ||
                    this.AttemptedValue != null &&
                    this.AttemptedValue.Equals(other.AttemptedValue)
                ) && 
                (
                    this.Culture == other.Culture ||
                    this.Culture != null &&
                    this.Culture.Equals(other.Culture)
                ) && 
                (
                    this.RawValue == other.RawValue ||
                    this.RawValue != null &&
                    this.RawValue.Equals(other.RawValue)
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
                
                if (this.AttemptedValue != null)
                    hash = hash * 59 + this.AttemptedValue.GetHashCode();
                
                if (this.Culture != null)
                    hash = hash * 59 + this.Culture.GetHashCode();
                
                if (this.RawValue != null)
                    hash = hash * 59 + this.RawValue.GetHashCode();
                
                return hash;
            }
        }

    }


}
