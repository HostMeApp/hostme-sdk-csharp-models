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
    public partial class PositionMessage :  IEquatable<PositionMessage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionMessage" /> class.
        /// Initializes a new instance of the <see cref="PositionMessage" />class.
        /// </summary>
        /// <param name="MinPos">MinPos (required).</param>
        /// <param name="MaxPos">MaxPos (required).</param>
        /// <param name="MessageTemplate">MessageTemplate.</param>

        public PositionMessage(int? MinPos = null, int? MaxPos = null, string MessageTemplate = null)
        {
            // to ensure "MinPos" is required (not null)
            if (MinPos == null)
            {
                throw new InvalidDataException("MinPos is a required property for PositionMessage and cannot be null");
            }
            else
            {
                this.MinPos = MinPos;
            }
            // to ensure "MaxPos" is required (not null)
            if (MaxPos == null)
            {
                throw new InvalidDataException("MaxPos is a required property for PositionMessage and cannot be null");
            }
            else
            {
                this.MaxPos = MaxPos;
            }
            this.MessageTemplate = MessageTemplate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets MinPos
        /// </summary>
        [DataMember(Name="minPos", EmitDefaultValue=false)]
        public int? MinPos { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxPos
        /// </summary>
        [DataMember(Name="maxPos", EmitDefaultValue=false)]
        public int? MaxPos { get; set; }
    
        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name="messageTemplate", EmitDefaultValue=false)]
        public string MessageTemplate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositionMessage {\n");
            sb.Append("  MinPos: ").Append(MinPos).Append("\n");
            sb.Append("  MaxPos: ").Append(MaxPos).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
            
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
            return this.Equals(obj as PositionMessage);
        }

        /// <summary>
        /// Returns true if PositionMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of PositionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PositionMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinPos == other.MinPos ||
                    this.MinPos != null &&
                    this.MinPos.Equals(other.MinPos)
                ) && 
                (
                    this.MaxPos == other.MaxPos ||
                    this.MaxPos != null &&
                    this.MaxPos.Equals(other.MaxPos)
                ) && 
                (
                    this.MessageTemplate == other.MessageTemplate ||
                    this.MessageTemplate != null &&
                    this.MessageTemplate.Equals(other.MessageTemplate)
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
                
                if (this.MinPos != null)
                    hash = hash * 59 + this.MinPos.GetHashCode();
                
                if (this.MaxPos != null)
                    hash = hash * 59 + this.MaxPos.GetHashCode();
                
                if (this.MessageTemplate != null)
                    hash = hash * 59 + this.MessageTemplate.GetHashCode();
                
                return hash;
            }
        }

    }


}
