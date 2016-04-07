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
    public partial class Table :  IEquatable<Table>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// Initializes a new instance of the <see cref="Table" />class.
        /// </summary>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="TableTopSize">TableTopSize.</param>
        /// <param name="Area">Area.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Reservability">Reservability.</param>
        /// <param name="Waitability">Waitability.</param>

        public Table(string TableNumber = null, int? TableTopSize = null, string Area = null, List<string> Tags = null, TableAvailability Reservability = null, TableAvailability Waitability = null)
        {
            this.TableNumber = TableNumber;
            this.TableTopSize = TableTopSize;
            this.Area = Area;
            this.Tags = Tags;
            this.Reservability = Reservability;
            this.Waitability = Waitability;
            
        }
        
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=false)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets TableTopSize
        /// </summary>
        [DataMember(Name="tableTopSize", EmitDefaultValue=false)]
        public int? TableTopSize { get; set; }
    
        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }
    
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or Sets Reservability
        /// </summary>
        [DataMember(Name="reservability", EmitDefaultValue=false)]
        public TableAvailability Reservability { get; set; }
    
        /// <summary>
        /// Gets or Sets Waitability
        /// </summary>
        [DataMember(Name="waitability", EmitDefaultValue=false)]
        public TableAvailability Waitability { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Table {\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  TableTopSize: ").Append(TableTopSize).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Reservability: ").Append(Reservability).Append("\n");
            sb.Append("  Waitability: ").Append(Waitability).Append("\n");
            
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
            return this.Equals(obj as Table);
        }

        /// <summary>
        /// Returns true if Table instances are equal
        /// </summary>
        /// <param name="other">Instance of Table to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Table other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.TableTopSize == other.TableTopSize ||
                    this.TableTopSize != null &&
                    this.TableTopSize.Equals(other.TableTopSize)
                ) && 
                (
                    this.Area == other.Area ||
                    this.Area != null &&
                    this.Area.Equals(other.Area)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Reservability == other.Reservability ||
                    this.Reservability != null &&
                    this.Reservability.Equals(other.Reservability)
                ) && 
                (
                    this.Waitability == other.Waitability ||
                    this.Waitability != null &&
                    this.Waitability.Equals(other.Waitability)
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
                
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                
                if (this.TableTopSize != null)
                    hash = hash * 59 + this.TableTopSize.GetHashCode();
                
                if (this.Area != null)
                    hash = hash * 59 + this.Area.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.Reservability != null)
                    hash = hash * 59 + this.Reservability.GetHashCode();
                
                if (this.Waitability != null)
                    hash = hash * 59 + this.Waitability.GetHashCode();
                
                return hash;
            }
        }

    }


}
