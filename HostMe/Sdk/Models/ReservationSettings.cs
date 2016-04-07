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
    public partial class ReservationSettings :  IEquatable<ReservationSettings>
    { 
    
        /// <summary>
        /// Gets or Sets AvailabilityMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityMethodEnum {
            
            [EnumMember(Value = "Cover")]
            Cover,
            
            [EnumMember(Value = "Table")]
            Table,
            
            [EnumMember(Value = "Default")]
            Default
        }

    
        /// <summary>
        /// Gets or Sets AvailabilityMethod
        /// </summary>
        [DataMember(Name="availabilityMethod", EmitDefaultValue=false)]
        public AvailabilityMethodEnum? AvailabilityMethod { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationSettings" /> class.
        /// Initializes a new instance of the <see cref="ReservationSettings" />class.
        /// </summary>
        /// <param name="AvailabilityMethod">AvailabilityMethod.</param>
        /// <param name="ConfirmationMessageRequestTemplate">ConfirmationMessageRequestTemplate.</param>
        /// <param name="CoversAvailableForWait">CoversAvailableForWait.</param>
        /// <param name="CoversAvaliableForReservation">CoversAvaliableForReservation.</param>
        /// <param name="DefaultMaxCoversPerSlot">DefaultMaxCoversPerSlot.</param>
        /// <param name="EnableAutoScheduling">EnableAutoScheduling.</param>
        /// <param name="IsEnabled">IsEnabled.</param>
        /// <param name="MaxCoversPerSlotExceptions">MaxCoversPerSlotExceptions.</param>
        /// <param name="MaxMinutesLate">MaxMinutesLate.</param>
        /// <param name="MaxPartySize">MaxPartySize.</param>
        /// <param name="MiniutesToConfirm">MiniutesToConfirm.</param>
        /// <param name="MinPartySize">MinPartySize.</param>
        /// <param name="MinutesToNotifyManager">MinutesToNotifyManager.</param>
        /// <param name="RequireReservationConfirmation">RequireReservationConfirmation.</param>
        /// <param name="ReservationEmail">ReservationEmail.</param>
        /// <param name="ReservationHours">ReservationHours.</param>
        /// <param name="ReservationHoursStep">ReservationHoursStep.</param>
        /// <param name="ReservationInboxEmail">ReservationInboxEmail.</param>
        /// <param name="StatusMessages">StatusMessages.</param>
        /// <param name="TableTurnOver">TableTurnOver.</param>
        /// <param name="TableTurnOverByGroup">TableTurnOverByGroup.</param>
        /// <param name="TotalCovers">TotalCovers.</param>

        public ReservationSettings(AvailabilityMethodEnum? AvailabilityMethod = null, string ConfirmationMessageRequestTemplate = null, int? CoversAvailableForWait = null, int? CoversAvaliableForReservation = null, int? DefaultMaxCoversPerSlot = null, bool? EnableAutoScheduling = null, bool? IsEnabled = null, List<SlotSetting> MaxCoversPerSlotExceptions = null, int? MaxMinutesLate = null, int? MaxPartySize = null, int? MiniutesToConfirm = null, int? MinPartySize = null, int? MinutesToNotifyManager = null, bool? RequireReservationConfirmation = null, string ReservationEmail = null, List<WeekDayOpenHours> ReservationHours = null, int? ReservationHoursStep = null, string ReservationInboxEmail = null, List<StatusMessage> StatusMessages = null, double? TableTurnOver = null, List<double?> TableTurnOverByGroup = null, int? TotalCovers = null)
        {
            this.AvailabilityMethod = AvailabilityMethod;
            this.ConfirmationMessageRequestTemplate = ConfirmationMessageRequestTemplate;
            this.CoversAvailableForWait = CoversAvailableForWait;
            this.CoversAvaliableForReservation = CoversAvaliableForReservation;
            this.DefaultMaxCoversPerSlot = DefaultMaxCoversPerSlot;
            this.EnableAutoScheduling = EnableAutoScheduling;
            this.IsEnabled = IsEnabled;
            this.MaxCoversPerSlotExceptions = MaxCoversPerSlotExceptions;
            this.MaxMinutesLate = MaxMinutesLate;
            this.MaxPartySize = MaxPartySize;
            this.MiniutesToConfirm = MiniutesToConfirm;
            this.MinPartySize = MinPartySize;
            this.MinutesToNotifyManager = MinutesToNotifyManager;
            this.RequireReservationConfirmation = RequireReservationConfirmation;
            this.ReservationEmail = ReservationEmail;
            this.ReservationHours = ReservationHours;
            this.ReservationHoursStep = ReservationHoursStep;
            this.ReservationInboxEmail = ReservationInboxEmail;
            this.StatusMessages = StatusMessages;
            this.TableTurnOver = TableTurnOver;
            this.TableTurnOverByGroup = TableTurnOverByGroup;
            this.TotalCovers = TotalCovers;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ConfirmationMessageRequestTemplate
        /// </summary>
        [DataMember(Name="confirmationMessageRequestTemplate", EmitDefaultValue=false)]
        public string ConfirmationMessageRequestTemplate { get; set; }
    
        /// <summary>
        /// Gets or Sets CoversAvailableForWait
        /// </summary>
        [DataMember(Name="coversAvailableForWait", EmitDefaultValue=false)]
        public int? CoversAvailableForWait { get; set; }
    
        /// <summary>
        /// Gets or Sets CoversAvaliableForReservation
        /// </summary>
        [DataMember(Name="coversAvaliableForReservation", EmitDefaultValue=false)]
        public int? CoversAvaliableForReservation { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultMaxCoversPerSlot
        /// </summary>
        [DataMember(Name="defaultMaxCoversPerSlot", EmitDefaultValue=false)]
        public int? DefaultMaxCoversPerSlot { get; set; }
    
        /// <summary>
        /// Gets or Sets EnableAutoScheduling
        /// </summary>
        [DataMember(Name="enableAutoScheduling", EmitDefaultValue=false)]
        public bool? EnableAutoScheduling { get; set; }
    
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxCoversPerSlotExceptions
        /// </summary>
        [DataMember(Name="maxCoversPerSlotExceptions", EmitDefaultValue=false)]
        public List<SlotSetting> MaxCoversPerSlotExceptions { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxMinutesLate
        /// </summary>
        [DataMember(Name="maxMinutesLate", EmitDefaultValue=false)]
        public int? MaxMinutesLate { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxPartySize
        /// </summary>
        [DataMember(Name="maxPartySize", EmitDefaultValue=false)]
        public int? MaxPartySize { get; set; }
    
        /// <summary>
        /// Gets or Sets MiniutesToConfirm
        /// </summary>
        [DataMember(Name="miniutesToConfirm", EmitDefaultValue=false)]
        public int? MiniutesToConfirm { get; set; }
    
        /// <summary>
        /// Gets or Sets MinPartySize
        /// </summary>
        [DataMember(Name="minPartySize", EmitDefaultValue=false)]
        public int? MinPartySize { get; set; }
    
        /// <summary>
        /// Gets or Sets MinutesToNotifyManager
        /// </summary>
        [DataMember(Name="minutesToNotifyManager", EmitDefaultValue=false)]
        public int? MinutesToNotifyManager { get; set; }
    
        /// <summary>
        /// Gets or Sets RequireReservationConfirmation
        /// </summary>
        [DataMember(Name="requireReservationConfirmation", EmitDefaultValue=false)]
        public bool? RequireReservationConfirmation { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationEmail
        /// </summary>
        [DataMember(Name="reservationEmail", EmitDefaultValue=false)]
        public string ReservationEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationHours
        /// </summary>
        [DataMember(Name="reservationHours", EmitDefaultValue=false)]
        public List<WeekDayOpenHours> ReservationHours { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationHoursStep
        /// </summary>
        [DataMember(Name="reservationHoursStep", EmitDefaultValue=false)]
        public int? ReservationHoursStep { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationInboxEmail
        /// </summary>
        [DataMember(Name="reservationInboxEmail", EmitDefaultValue=false)]
        public string ReservationInboxEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusMessages
        /// </summary>
        [DataMember(Name="statusMessages", EmitDefaultValue=false)]
        public List<StatusMessage> StatusMessages { get; set; }
    
        /// <summary>
        /// Gets or Sets TableTurnOver
        /// </summary>
        [DataMember(Name="tableTurnOver", EmitDefaultValue=false)]
        public double? TableTurnOver { get; set; }
    
        /// <summary>
        /// Gets or Sets TableTurnOverByGroup
        /// </summary>
        [DataMember(Name="tableTurnOverByGroup", EmitDefaultValue=false)]
        public List<double?> TableTurnOverByGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalCovers
        /// </summary>
        [DataMember(Name="totalCovers", EmitDefaultValue=false)]
        public int? TotalCovers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservationSettings {\n");
            sb.Append("  AvailabilityMethod: ").Append(AvailabilityMethod).Append("\n");
            sb.Append("  ConfirmationMessageRequestTemplate: ").Append(ConfirmationMessageRequestTemplate).Append("\n");
            sb.Append("  CoversAvailableForWait: ").Append(CoversAvailableForWait).Append("\n");
            sb.Append("  CoversAvaliableForReservation: ").Append(CoversAvaliableForReservation).Append("\n");
            sb.Append("  DefaultMaxCoversPerSlot: ").Append(DefaultMaxCoversPerSlot).Append("\n");
            sb.Append("  EnableAutoScheduling: ").Append(EnableAutoScheduling).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  MaxCoversPerSlotExceptions: ").Append(MaxCoversPerSlotExceptions).Append("\n");
            sb.Append("  MaxMinutesLate: ").Append(MaxMinutesLate).Append("\n");
            sb.Append("  MaxPartySize: ").Append(MaxPartySize).Append("\n");
            sb.Append("  MiniutesToConfirm: ").Append(MiniutesToConfirm).Append("\n");
            sb.Append("  MinPartySize: ").Append(MinPartySize).Append("\n");
            sb.Append("  MinutesToNotifyManager: ").Append(MinutesToNotifyManager).Append("\n");
            sb.Append("  RequireReservationConfirmation: ").Append(RequireReservationConfirmation).Append("\n");
            sb.Append("  ReservationEmail: ").Append(ReservationEmail).Append("\n");
            sb.Append("  ReservationHours: ").Append(ReservationHours).Append("\n");
            sb.Append("  ReservationHoursStep: ").Append(ReservationHoursStep).Append("\n");
            sb.Append("  ReservationInboxEmail: ").Append(ReservationInboxEmail).Append("\n");
            sb.Append("  StatusMessages: ").Append(StatusMessages).Append("\n");
            sb.Append("  TableTurnOver: ").Append(TableTurnOver).Append("\n");
            sb.Append("  TableTurnOverByGroup: ").Append(TableTurnOverByGroup).Append("\n");
            sb.Append("  TotalCovers: ").Append(TotalCovers).Append("\n");
            
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
            return this.Equals(obj as ReservationSettings);
        }

        /// <summary>
        /// Returns true if ReservationSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservationSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AvailabilityMethod == other.AvailabilityMethod ||
                    this.AvailabilityMethod != null &&
                    this.AvailabilityMethod.Equals(other.AvailabilityMethod)
                ) && 
                (
                    this.ConfirmationMessageRequestTemplate == other.ConfirmationMessageRequestTemplate ||
                    this.ConfirmationMessageRequestTemplate != null &&
                    this.ConfirmationMessageRequestTemplate.Equals(other.ConfirmationMessageRequestTemplate)
                ) && 
                (
                    this.CoversAvailableForWait == other.CoversAvailableForWait ||
                    this.CoversAvailableForWait != null &&
                    this.CoversAvailableForWait.Equals(other.CoversAvailableForWait)
                ) && 
                (
                    this.CoversAvaliableForReservation == other.CoversAvaliableForReservation ||
                    this.CoversAvaliableForReservation != null &&
                    this.CoversAvaliableForReservation.Equals(other.CoversAvaliableForReservation)
                ) && 
                (
                    this.DefaultMaxCoversPerSlot == other.DefaultMaxCoversPerSlot ||
                    this.DefaultMaxCoversPerSlot != null &&
                    this.DefaultMaxCoversPerSlot.Equals(other.DefaultMaxCoversPerSlot)
                ) && 
                (
                    this.EnableAutoScheduling == other.EnableAutoScheduling ||
                    this.EnableAutoScheduling != null &&
                    this.EnableAutoScheduling.Equals(other.EnableAutoScheduling)
                ) && 
                (
                    this.IsEnabled == other.IsEnabled ||
                    this.IsEnabled != null &&
                    this.IsEnabled.Equals(other.IsEnabled)
                ) && 
                (
                    this.MaxCoversPerSlotExceptions == other.MaxCoversPerSlotExceptions ||
                    this.MaxCoversPerSlotExceptions != null &&
                    this.MaxCoversPerSlotExceptions.SequenceEqual(other.MaxCoversPerSlotExceptions)
                ) && 
                (
                    this.MaxMinutesLate == other.MaxMinutesLate ||
                    this.MaxMinutesLate != null &&
                    this.MaxMinutesLate.Equals(other.MaxMinutesLate)
                ) && 
                (
                    this.MaxPartySize == other.MaxPartySize ||
                    this.MaxPartySize != null &&
                    this.MaxPartySize.Equals(other.MaxPartySize)
                ) && 
                (
                    this.MiniutesToConfirm == other.MiniutesToConfirm ||
                    this.MiniutesToConfirm != null &&
                    this.MiniutesToConfirm.Equals(other.MiniutesToConfirm)
                ) && 
                (
                    this.MinPartySize == other.MinPartySize ||
                    this.MinPartySize != null &&
                    this.MinPartySize.Equals(other.MinPartySize)
                ) && 
                (
                    this.MinutesToNotifyManager == other.MinutesToNotifyManager ||
                    this.MinutesToNotifyManager != null &&
                    this.MinutesToNotifyManager.Equals(other.MinutesToNotifyManager)
                ) && 
                (
                    this.RequireReservationConfirmation == other.RequireReservationConfirmation ||
                    this.RequireReservationConfirmation != null &&
                    this.RequireReservationConfirmation.Equals(other.RequireReservationConfirmation)
                ) && 
                (
                    this.ReservationEmail == other.ReservationEmail ||
                    this.ReservationEmail != null &&
                    this.ReservationEmail.Equals(other.ReservationEmail)
                ) && 
                (
                    this.ReservationHours == other.ReservationHours ||
                    this.ReservationHours != null &&
                    this.ReservationHours.SequenceEqual(other.ReservationHours)
                ) && 
                (
                    this.ReservationHoursStep == other.ReservationHoursStep ||
                    this.ReservationHoursStep != null &&
                    this.ReservationHoursStep.Equals(other.ReservationHoursStep)
                ) && 
                (
                    this.ReservationInboxEmail == other.ReservationInboxEmail ||
                    this.ReservationInboxEmail != null &&
                    this.ReservationInboxEmail.Equals(other.ReservationInboxEmail)
                ) && 
                (
                    this.StatusMessages == other.StatusMessages ||
                    this.StatusMessages != null &&
                    this.StatusMessages.SequenceEqual(other.StatusMessages)
                ) && 
                (
                    this.TableTurnOver == other.TableTurnOver ||
                    this.TableTurnOver != null &&
                    this.TableTurnOver.Equals(other.TableTurnOver)
                ) && 
                (
                    this.TableTurnOverByGroup == other.TableTurnOverByGroup ||
                    this.TableTurnOverByGroup != null &&
                    this.TableTurnOverByGroup.SequenceEqual(other.TableTurnOverByGroup)
                ) && 
                (
                    this.TotalCovers == other.TotalCovers ||
                    this.TotalCovers != null &&
                    this.TotalCovers.Equals(other.TotalCovers)
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
                
                if (this.AvailabilityMethod != null)
                    hash = hash * 59 + this.AvailabilityMethod.GetHashCode();
                
                if (this.ConfirmationMessageRequestTemplate != null)
                    hash = hash * 59 + this.ConfirmationMessageRequestTemplate.GetHashCode();
                
                if (this.CoversAvailableForWait != null)
                    hash = hash * 59 + this.CoversAvailableForWait.GetHashCode();
                
                if (this.CoversAvaliableForReservation != null)
                    hash = hash * 59 + this.CoversAvaliableForReservation.GetHashCode();
                
                if (this.DefaultMaxCoversPerSlot != null)
                    hash = hash * 59 + this.DefaultMaxCoversPerSlot.GetHashCode();
                
                if (this.EnableAutoScheduling != null)
                    hash = hash * 59 + this.EnableAutoScheduling.GetHashCode();
                
                if (this.IsEnabled != null)
                    hash = hash * 59 + this.IsEnabled.GetHashCode();
                
                if (this.MaxCoversPerSlotExceptions != null)
                    hash = hash * 59 + this.MaxCoversPerSlotExceptions.GetHashCode();
                
                if (this.MaxMinutesLate != null)
                    hash = hash * 59 + this.MaxMinutesLate.GetHashCode();
                
                if (this.MaxPartySize != null)
                    hash = hash * 59 + this.MaxPartySize.GetHashCode();
                
                if (this.MiniutesToConfirm != null)
                    hash = hash * 59 + this.MiniutesToConfirm.GetHashCode();
                
                if (this.MinPartySize != null)
                    hash = hash * 59 + this.MinPartySize.GetHashCode();
                
                if (this.MinutesToNotifyManager != null)
                    hash = hash * 59 + this.MinutesToNotifyManager.GetHashCode();
                
                if (this.RequireReservationConfirmation != null)
                    hash = hash * 59 + this.RequireReservationConfirmation.GetHashCode();
                
                if (this.ReservationEmail != null)
                    hash = hash * 59 + this.ReservationEmail.GetHashCode();
                
                if (this.ReservationHours != null)
                    hash = hash * 59 + this.ReservationHours.GetHashCode();
                
                if (this.ReservationHoursStep != null)
                    hash = hash * 59 + this.ReservationHoursStep.GetHashCode();
                
                if (this.ReservationInboxEmail != null)
                    hash = hash * 59 + this.ReservationInboxEmail.GetHashCode();
                
                if (this.StatusMessages != null)
                    hash = hash * 59 + this.StatusMessages.GetHashCode();
                
                if (this.TableTurnOver != null)
                    hash = hash * 59 + this.TableTurnOver.GetHashCode();
                
                if (this.TableTurnOverByGroup != null)
                    hash = hash * 59 + this.TableTurnOverByGroup.GetHashCode();
                
                if (this.TotalCovers != null)
                    hash = hash * 59 + this.TotalCovers.GetHashCode();
                
                return hash;
            }
        }

    }


}
