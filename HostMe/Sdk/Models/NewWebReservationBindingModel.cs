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
    public partial class NewWebReservationBindingModel :  IEquatable<NewWebReservationBindingModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewWebReservationBindingModel" /> class.
        /// Initializes a new instance of the <see cref="NewWebReservationBindingModel" />class.
        /// </summary>
        /// <param name="ReservationTime">ReservationTime (required).</param>
        /// <param name="CustomerName">CustomerName (required).</param>
        /// <param name="GroupSize">GroupSize (required).</param>
        /// <param name="PhoneNumber">PhoneNumber (required).</param>
        /// <param name="Areas">Areas.</param>
        /// <param name="Note">Note.</param>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="HighChair">HighChair.</param>
        /// <param name="Stroller">Stroller.</param>

        public NewWebReservationBindingModel(DateTimeOffset? ReservationTime = null, string CustomerName = null, int? GroupSize = null, string PhoneNumber = null, string Areas = null, string Note = null, string TableNumber = null, bool? HighChair = null, bool? Stroller = null)
        {
            // to ensure "ReservationTime" is required (not null)
            if (ReservationTime == null)
            {
                throw new InvalidDataException("ReservationTime is a required property for NewWebReservationBindingModel and cannot be null");
            }
            else
            {
                this.ReservationTime = ReservationTime;
            }
            // to ensure "CustomerName" is required (not null)
            if (CustomerName == null)
            {
                throw new InvalidDataException("CustomerName is a required property for NewWebReservationBindingModel and cannot be null");
            }
            else
            {
                this.CustomerName = CustomerName;
            }
            // to ensure "GroupSize" is required (not null)
            if (GroupSize == null)
            {
                throw new InvalidDataException("GroupSize is a required property for NewWebReservationBindingModel and cannot be null");
            }
            else
            {
                this.GroupSize = GroupSize;
            }
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for NewWebReservationBindingModel and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            this.Areas = Areas;
            this.Note = Note;
            this.TableNumber = TableNumber;
            this.HighChair = HighChair;
            this.Stroller = Stroller;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ReservationTime
        /// </summary>
        [DataMember(Name="reservationTime", EmitDefaultValue=false)]
        public DateTimeOffset? ReservationTime { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupSize
        /// </summary>
        [DataMember(Name="groupSize", EmitDefaultValue=false)]
        public int? GroupSize { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=false)]
        public string Areas { get; set; }
    
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=false)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets HighChair
        /// </summary>
        [DataMember(Name="highChair", EmitDefaultValue=false)]
        public bool? HighChair { get; set; }
    
        /// <summary>
        /// Gets or Sets Stroller
        /// </summary>
        [DataMember(Name="stroller", EmitDefaultValue=false)]
        public bool? Stroller { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewWebReservationBindingModel {\n");
            sb.Append("  ReservationTime: ").Append(ReservationTime).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  HighChair: ").Append(HighChair).Append("\n");
            sb.Append("  Stroller: ").Append(Stroller).Append("\n");
            
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
            return this.Equals(obj as NewWebReservationBindingModel);
        }

        /// <summary>
        /// Returns true if NewWebReservationBindingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of NewWebReservationBindingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewWebReservationBindingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReservationTime == other.ReservationTime ||
                    this.ReservationTime != null &&
                    this.ReservationTime.Equals(other.ReservationTime)
                ) && 
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
                ) && 
                (
                    this.GroupSize == other.GroupSize ||
                    this.GroupSize != null &&
                    this.GroupSize.Equals(other.GroupSize)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.HighChair == other.HighChair ||
                    this.HighChair != null &&
                    this.HighChair.Equals(other.HighChair)
                ) && 
                (
                    this.Stroller == other.Stroller ||
                    this.Stroller != null &&
                    this.Stroller.Equals(other.Stroller)
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
                
                if (this.ReservationTime != null)
                    hash = hash * 59 + this.ReservationTime.GetHashCode();
                
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                
                return hash;
            }
        }

    }


}
