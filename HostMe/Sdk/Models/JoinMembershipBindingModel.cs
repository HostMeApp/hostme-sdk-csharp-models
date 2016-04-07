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
    public partial class JoinMembershipBindingModel :  IEquatable<JoinMembershipBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinMembershipBindingModel" /> class.
        /// Initializes a new instance of the <see cref="JoinMembershipBindingModel" />class.
        /// </summary>
        /// <param name="RestaurantId">RestaurantId.</param>

        public JoinMembershipBindingModel(int? RestaurantId = null)
        {
            this.RestaurantId = RestaurantId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=false)]
        public int? RestaurantId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinMembershipBindingModel {\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
            
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
            return this.Equals(obj as JoinMembershipBindingModel);
        }

        /// <summary>
        /// Returns true if JoinMembershipBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of JoinMembershipBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinMembershipBindingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
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
                
                return hash;
            }
        }

    }


}
