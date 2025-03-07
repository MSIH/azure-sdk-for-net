// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Mab container-specific backup policy. </summary>
    public partial class MabProtectionPolicy : BackupGenericProtectionPolicy
    {
        /// <summary> Initializes a new instance of MabProtectionPolicy. </summary>
        public MabProtectionPolicy()
        {
            BackupManagementType = "MAB";
        }

        /// <summary> Initializes a new instance of MabProtectionPolicy. </summary>
        /// <param name="protectedItemsCount"> Number of items associated with this policy. </param>
        /// <param name="backupManagementType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="schedulePolicy">
        /// Backup schedule of backup policy.
        /// Please note <see cref="BackupSchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </param>
        /// <param name="retentionPolicy">
        /// Retention policy details.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </param>
        internal MabProtectionPolicy(int? protectedItemsCount, string backupManagementType, IList<string> resourceGuardOperationRequests, BackupSchedulePolicy schedulePolicy, BackupRetentionPolicy retentionPolicy) : base(protectedItemsCount, backupManagementType, resourceGuardOperationRequests)
        {
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            BackupManagementType = backupManagementType ?? "MAB";
        }

        /// <summary>
        /// Backup schedule of backup policy.
        /// Please note <see cref="BackupSchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </summary>
        public BackupSchedulePolicy SchedulePolicy { get; set; }
        /// <summary>
        /// Retention policy details.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </summary>
        public BackupRetentionPolicy RetentionPolicy { get; set; }
    }
}
