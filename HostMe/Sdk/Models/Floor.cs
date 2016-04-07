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
    public partial class Floor :  IEquatable<Floor>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Floor" /> class.
        /// Initializes a new instance of the <see cref="Floor" />class.
        /// </summary>
        /// <param name="FloorId">FloorId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Map">Map.</param>

        public Floor(string FloorId = null, string Name = null, string Map = null)
        {
            this.FloorId = FloorId;
            this.Name = Name;
            this.Map = Map;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FloorId
        /// </summary>
        [DataMember(Name="floorId", EmitDefaultValue=false)]
        public string FloorId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [DataMember(Name="map", EmitDefaultValue=false)]
        public string Map { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Floor {\n");
            sb.Append("  FloorId: ").Append(FloorId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            
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
            return this.Equals(obj as Floor);
        }

        /// <summary>
        /// Returns true if Floor instances are equal
        /// </summary>
        /// <param name="other">Instance of Floor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Floor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FloorId == other.FloorId ||
                    this.FloorId != null &&
                    this.FloorId.Equals(other.FloorId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Map == other.Map ||
                    this.Map != null &&
                    this.Map.Equals(other.Map)
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
                
                if (this.FloorId != null)
                    hash = hash * 59 + this.FloorId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Map != null)
                    hash = hash * 59 + this.Map.GetHashCode();
                
                return hash;
            }
        }

    }


}
