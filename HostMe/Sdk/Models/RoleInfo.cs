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
    public partial class RoleInfo :  IEquatable<RoleInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleInfo" /> class.
        /// Initializes a new instance of the <see cref="RoleInfo" />class.
        /// </summary>
        /// <param name="RestaurantId">RestaurantId.</param>
        /// <param name="RestaurantName">RestaurantName.</param>
        /// <param name="Name">Name.</param>

        public RoleInfo(int? RestaurantId = null, string RestaurantName = null, string Name = null)
        {
            this.RestaurantId = RestaurantId;
            this.RestaurantName = RestaurantName;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=false)]
        public int? RestaurantId { get; set; }
    
        /// <summary>
        /// Gets or Sets RestaurantName
        /// </summary>
        [DataMember(Name="restaurantName", EmitDefaultValue=false)]
        public string RestaurantName { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleInfo {\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
            sb.Append("  RestaurantName: ").Append(RestaurantName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as RoleInfo);
        }

        /// <summary>
        /// Returns true if RoleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RoleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
                ) && 
                (
                    this.RestaurantName == other.RestaurantName ||
                    this.RestaurantName != null &&
                    this.RestaurantName.Equals(other.RestaurantName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                
                if (this.RestaurantName != null)
                    hash = hash * 59 + this.RestaurantName.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }


}
