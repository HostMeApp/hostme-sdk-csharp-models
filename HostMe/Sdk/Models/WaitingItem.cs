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
    public partial class WaitingItem :  IEquatable<WaitingItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingItem" /> class.
        /// Initializes a new instance of the <see cref="WaitingItem" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Closed">Closed.</param>
        /// <param name="PhoneId">PhoneId.</param>
        /// <param name="ConfirmationCode">ConfirmationCode.</param>
        /// <param name="CustomerName">CustomerName.</param>
        /// <param name="GroupSize">GroupSize.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="RegistrationMethod">RegistrationMethod.</param>
        /// <param name="DeviceType">DeviceType.</param>
        /// <param name="NotificationUrl">NotificationUrl.</param>
        /// <param name="Areas">Areas.</param>
        /// <param name="ExpectedTime">ExpectedTime.</param>
        /// <param name="Position">Position.</param>
        /// <param name="Note">Note.</param>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="StatusTime">StatusTime.</param>
        /// <param name="RestaurantId">RestaurantId.</param>
        /// <param name="HighChair">HighChair.</param>
        /// <param name="Stroller">Stroller.</param>
        /// <param name="OnHoldMode">OnHoldMode.</param>
        /// <param name="OnHoldTime">OnHoldTime.</param>
        /// <param name="OnHoldEndTime">OnHoldEndTime.</param>
        /// <param name="Messages">Messages.</param>
        /// <param name="Membership">Membership.</param>
        /// <param name="Reservation">Reservation.</param>
        /// <param name="EstimatedTurnOverTime">EstimatedTurnOverTime.</param>
        /// <param name="UnreadMessageCount">UnreadMessageCount.</param>

        public WaitingItem(int? Id = null, string Status = null, DateTimeOffset? Created = null, DateTimeOffset? Closed = null, string PhoneId = null, int? ConfirmationCode = null, string CustomerName = null, int? GroupSize = null, string Phone = null, string RegistrationMethod = null, string DeviceType = null, string NotificationUrl = null, string Areas = null, DateTimeOffset? ExpectedTime = null, int? Position = null, string Note = null, string TableNumber = null, DateTimeOffset? StatusTime = null, int? RestaurantId = null, bool? HighChair = null, bool? Stroller = null, string OnHoldMode = null, DateTimeOffset? OnHoldTime = null, DateTimeOffset? OnHoldEndTime = null, List<Message> Messages = null, MembershipInfo Membership = null, ReservationInfo Reservation = null, double? EstimatedTurnOverTime = null, int? UnreadMessageCount = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.Created = Created;
            this.Closed = Closed;
            this.PhoneId = PhoneId;
            this.ConfirmationCode = ConfirmationCode;
            this.CustomerName = CustomerName;
            this.GroupSize = GroupSize;
            this.Phone = Phone;
            this.RegistrationMethod = RegistrationMethod;
            this.DeviceType = DeviceType;
            this.NotificationUrl = NotificationUrl;
            this.Areas = Areas;
            this.ExpectedTime = ExpectedTime;
            this.Position = Position;
            this.Note = Note;
            this.TableNumber = TableNumber;
            this.StatusTime = StatusTime;
            this.RestaurantId = RestaurantId;
            this.HighChair = HighChair;
            this.Stroller = Stroller;
            this.OnHoldMode = OnHoldMode;
            this.OnHoldTime = OnHoldTime;
            this.OnHoldEndTime = OnHoldEndTime;
            this.Messages = Messages;
            this.Membership = Membership;
            this.Reservation = Reservation;
            this.EstimatedTurnOverTime = EstimatedTurnOverTime;
            this.UnreadMessageCount = UnreadMessageCount;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTimeOffset? Created { get; set; }
    
        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=false)]
        public DateTimeOffset? Closed { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneId
        /// </summary>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }
    
        /// <summary>
        /// Gets or Sets ConfirmationCode
        /// </summary>
        [DataMember(Name="confirmationCode", EmitDefaultValue=false)]
        public int? ConfirmationCode { get; set; }
    
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
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets RegistrationMethod
        /// </summary>
        [DataMember(Name="registrationMethod", EmitDefaultValue=false)]
        public string RegistrationMethod { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="deviceType", EmitDefaultValue=false)]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Gets or Sets NotificationUrl
        /// </summary>
        [DataMember(Name="notificationUrl", EmitDefaultValue=false)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=false)]
        public string Areas { get; set; }
    
        /// <summary>
        /// Gets or Sets ExpectedTime
        /// </summary>
        [DataMember(Name="expectedTime", EmitDefaultValue=false)]
        public DateTimeOffset? ExpectedTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }
    
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
        /// Gets or Sets StatusTime
        /// </summary>
        [DataMember(Name="statusTime", EmitDefaultValue=false)]
        public DateTimeOffset? StatusTime { get; set; }
    
        /// <summary>
        /// Gets or Sets RestaurantId
        /// </summary>
        [DataMember(Name="restaurantId", EmitDefaultValue=false)]
        public int? RestaurantId { get; set; }
    
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
        /// Gets or Sets OnHoldMode
        /// </summary>
        [DataMember(Name="onHoldMode", EmitDefaultValue=false)]
        public string OnHoldMode { get; set; }
    
        /// <summary>
        /// Gets or Sets OnHoldTime
        /// </summary>
        [DataMember(Name="onHoldTime", EmitDefaultValue=false)]
        public DateTimeOffset? OnHoldTime { get; set; }
    
        /// <summary>
        /// Gets or Sets OnHoldEndTime
        /// </summary>
        [DataMember(Name="onHoldEndTime", EmitDefaultValue=false)]
        public DateTimeOffset? OnHoldEndTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<Message> Messages { get; set; }
    
        /// <summary>
        /// Gets or Sets Membership
        /// </summary>
        [DataMember(Name="membership", EmitDefaultValue=false)]
        public MembershipInfo Membership { get; set; }
    
        /// <summary>
        /// Gets or Sets Reservation
        /// </summary>
        [DataMember(Name="reservation", EmitDefaultValue=false)]
        public ReservationInfo Reservation { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedTurnOverTime
        /// </summary>
        [DataMember(Name="estimatedTurnOverTime", EmitDefaultValue=false)]
        public double? EstimatedTurnOverTime { get; set; }
    
        /// <summary>
        /// Gets or Sets UnreadMessageCount
        /// </summary>
        [DataMember(Name="unreadMessageCount", EmitDefaultValue=false)]
        public int? UnreadMessageCount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  ConfirmationCode: ").Append(ConfirmationCode).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  GroupSize: ").Append(GroupSize).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  RegistrationMethod: ").Append(RegistrationMethod).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  ExpectedTime: ").Append(ExpectedTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  StatusTime: ").Append(StatusTime).Append("\n");
            sb.Append("  RestaurantId: ").Append(RestaurantId).Append("\n");
            sb.Append("  HighChair: ").Append(HighChair).Append("\n");
            sb.Append("  Stroller: ").Append(Stroller).Append("\n");
            sb.Append("  OnHoldMode: ").Append(OnHoldMode).Append("\n");
            sb.Append("  OnHoldTime: ").Append(OnHoldTime).Append("\n");
            sb.Append("  OnHoldEndTime: ").Append(OnHoldEndTime).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  Reservation: ").Append(Reservation).Append("\n");
            sb.Append("  EstimatedTurnOverTime: ").Append(EstimatedTurnOverTime).Append("\n");
            sb.Append("  UnreadMessageCount: ").Append(UnreadMessageCount).Append("\n");
            
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
            return this.Equals(obj as WaitingItem);
        }

        /// <summary>
        /// Returns true if WaitingItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Closed == other.Closed ||
                    this.Closed != null &&
                    this.Closed.Equals(other.Closed)
                ) && 
                (
                    this.PhoneId == other.PhoneId ||
                    this.PhoneId != null &&
                    this.PhoneId.Equals(other.PhoneId)
                ) && 
                (
                    this.ConfirmationCode == other.ConfirmationCode ||
                    this.ConfirmationCode != null &&
                    this.ConfirmationCode.Equals(other.ConfirmationCode)
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
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.RegistrationMethod == other.RegistrationMethod ||
                    this.RegistrationMethod != null &&
                    this.RegistrationMethod.Equals(other.RegistrationMethod)
                ) && 
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    this.NotificationUrl == other.NotificationUrl ||
                    this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(other.NotificationUrl)
                ) && 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.Equals(other.Areas)
                ) && 
                (
                    this.ExpectedTime == other.ExpectedTime ||
                    this.ExpectedTime != null &&
                    this.ExpectedTime.Equals(other.ExpectedTime)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
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
                    this.StatusTime == other.StatusTime ||
                    this.StatusTime != null &&
                    this.StatusTime.Equals(other.StatusTime)
                ) && 
                (
                    this.RestaurantId == other.RestaurantId ||
                    this.RestaurantId != null &&
                    this.RestaurantId.Equals(other.RestaurantId)
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
                ) && 
                (
                    this.OnHoldMode == other.OnHoldMode ||
                    this.OnHoldMode != null &&
                    this.OnHoldMode.Equals(other.OnHoldMode)
                ) && 
                (
                    this.OnHoldTime == other.OnHoldTime ||
                    this.OnHoldTime != null &&
                    this.OnHoldTime.Equals(other.OnHoldTime)
                ) && 
                (
                    this.OnHoldEndTime == other.OnHoldEndTime ||
                    this.OnHoldEndTime != null &&
                    this.OnHoldEndTime.Equals(other.OnHoldEndTime)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) && 
                (
                    this.Membership == other.Membership ||
                    this.Membership != null &&
                    this.Membership.Equals(other.Membership)
                ) && 
                (
                    this.Reservation == other.Reservation ||
                    this.Reservation != null &&
                    this.Reservation.Equals(other.Reservation)
                ) && 
                (
                    this.EstimatedTurnOverTime == other.EstimatedTurnOverTime ||
                    this.EstimatedTurnOverTime != null &&
                    this.EstimatedTurnOverTime.Equals(other.EstimatedTurnOverTime)
                ) && 
                (
                    this.UnreadMessageCount == other.UnreadMessageCount ||
                    this.UnreadMessageCount != null &&
                    this.UnreadMessageCount.Equals(other.UnreadMessageCount)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                
                if (this.Closed != null)
                    hash = hash * 59 + this.Closed.GetHashCode();
                
                if (this.PhoneId != null)
                    hash = hash * 59 + this.PhoneId.GetHashCode();
                
                if (this.ConfirmationCode != null)
                    hash = hash * 59 + this.ConfirmationCode.GetHashCode();
                
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                
                if (this.GroupSize != null)
                    hash = hash * 59 + this.GroupSize.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.RegistrationMethod != null)
                    hash = hash * 59 + this.RegistrationMethod.GetHashCode();
                
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                
                if (this.NotificationUrl != null)
                    hash = hash * 59 + this.NotificationUrl.GetHashCode();
                
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                
                if (this.ExpectedTime != null)
                    hash = hash * 59 + this.ExpectedTime.GetHashCode();
                
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                
                if (this.StatusTime != null)
                    hash = hash * 59 + this.StatusTime.GetHashCode();
                
                if (this.RestaurantId != null)
                    hash = hash * 59 + this.RestaurantId.GetHashCode();
                
                if (this.HighChair != null)
                    hash = hash * 59 + this.HighChair.GetHashCode();
                
                if (this.Stroller != null)
                    hash = hash * 59 + this.Stroller.GetHashCode();
                
                if (this.OnHoldMode != null)
                    hash = hash * 59 + this.OnHoldMode.GetHashCode();
                
                if (this.OnHoldTime != null)
                    hash = hash * 59 + this.OnHoldTime.GetHashCode();
                
                if (this.OnHoldEndTime != null)
                    hash = hash * 59 + this.OnHoldEndTime.GetHashCode();
                
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                
                if (this.Membership != null)
                    hash = hash * 59 + this.Membership.GetHashCode();
                
                if (this.Reservation != null)
                    hash = hash * 59 + this.Reservation.GetHashCode();
                
                if (this.EstimatedTurnOverTime != null)
                    hash = hash * 59 + this.EstimatedTurnOverTime.GetHashCode();
                
                if (this.UnreadMessageCount != null)
                    hash = hash * 59 + this.UnreadMessageCount.GetHashCode();
                
                return hash;
            }
        }

    }


}
