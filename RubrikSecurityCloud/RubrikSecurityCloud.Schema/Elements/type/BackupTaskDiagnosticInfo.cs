// BackupTaskDiagnosticInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region BackupTaskDiagnosticInfo
    public class BackupTaskDiagnosticInfo: BaseType
    {
        #region members

        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        [JsonProperty("taskStatus")]
        public DiagnosticTaskStatus? TaskStatus { get; set; }

        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        [JsonProperty("expectedEndTime")]
        public DateTime? ExpectedEndTime { get; set; }

        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        [JsonProperty("queueTime")]
        public DateTime? QueueTime { get; set; }


        #endregion

    #region methods

    public BackupTaskDiagnosticInfo Set(
        DiagnosticTaskStatus? TaskStatus = null,
        DateTime? ExpectedEndTime = null,
        DateTime? QueueTime = null
    ) 
    {
        if ( TaskStatus != null ) {
            this.TaskStatus = TaskStatus;
        }
        if ( ExpectedEndTime != null ) {
            this.ExpectedEndTime = ExpectedEndTime;
        }
        if ( QueueTime != null ) {
            this.QueueTime = QueueTime;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        if (this.TaskStatus != null) {
            s += ind + "taskStatus\n" ;
        }
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        if (this.ExpectedEndTime != null) {
            s += ind + "expectedEndTime\n" ;
        }
        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        if (this.QueueTime != null) {
            s += ind + "queueTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        if (this.TaskStatus == null && Exploration.Includes(parent + ".taskStatus", true))
        {
            this.TaskStatus = new DiagnosticTaskStatus();
        }
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        if (this.ExpectedEndTime == null && Exploration.Includes(parent + ".expectedEndTime", true))
        {
            this.ExpectedEndTime = new DateTime();
        }
        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        if (this.QueueTime == null && Exploration.Includes(parent + ".queueTime", true))
        {
            this.QueueTime = new DateTime();
        }
    }


    #endregion

    } // class BackupTaskDiagnosticInfo
    
    #endregion

    public static class ListBackupTaskDiagnosticInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<BackupTaskDiagnosticInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BackupTaskDiagnosticInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupTaskDiagnosticInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types