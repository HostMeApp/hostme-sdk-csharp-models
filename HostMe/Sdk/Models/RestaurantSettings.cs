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
    public partial class RestaurantSettings :  IEquatable<RestaurantSettings>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantSettings" /> class.
        /// Initializes a new instance of the <see cref="RestaurantSettings" />class.
        /// </summary>
        /// <param name="Areas">Areas.</param>
        /// <param name="OpeningHours">OpeningHours.</param>
        /// <param name="TableSizes">TableSizes.</param>

        public RestaurantSettings(List<string> Areas = null, List<WeekDayOpenHours> OpeningHours = null, List<int?> TableSizes = null)
        {
            this.Areas = Areas;
            this.OpeningHours = OpeningHours;
            this.TableSizes = TableSizes;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=false)]
        public List<string> Areas { get; set; }
    
        /// <summary>
        /// Gets or Sets OpeningHours
        /// </summary>
        [DataMember(Name="openingHours", EmitDefaultValue=false)]
        public List<WeekDayOpenHours> OpeningHours { get; set; }
    
        /// <summary>
        /// Gets or Sets TableSizes
        /// </summary>
        [DataMember(Name="tableSizes", EmitDefaultValue=false)]
        public List<int?> TableSizes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantSettings {\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
            sb.Append("  TableSizes: ").Append(TableSizes).Append("\n");
            
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
            return this.Equals(obj as RestaurantSettings);
        }

        /// <summary>
        /// Returns true if RestaurantSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.SequenceEqual(other.Areas)
                ) && 
                (
                    this.OpeningHours == other.OpeningHours ||
                    this.OpeningHours != null &&
                    this.OpeningHours.SequenceEqual(other.OpeningHours)
                ) && 
                (
                    this.TableSizes == other.TableSizes ||
                    this.TableSizes != null &&
                    this.TableSizes.SequenceEqual(other.TableSizes)
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
                
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                
                if (this.OpeningHours != null)
                    hash = hash * 59 + this.OpeningHours.GetHashCode();
                
                if (this.TableSizes != null)
                    hash = hash * 59 + this.TableSizes.GetHashCode();
                
                return hash;
            }
        }

    }


}
