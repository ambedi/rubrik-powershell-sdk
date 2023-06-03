// UpdateVsphereAdvancedTagReply.cs
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
    #region UpdateVsphereAdvancedTagReply
    public class UpdateVsphereAdvancedTagReply: BaseType
    {
        #region members

        //      C# -> FilterCreateResponse? Output
        // GraphQL -> output: FilterCreateResponse (type)
        [JsonProperty("output")]
        public FilterCreateResponse? Output { get; set; }


        #endregion

    #region methods

    public UpdateVsphereAdvancedTagReply Set(
        FilterCreateResponse? Output = null
    ) 
    {
        if ( Output != null ) {
            this.Output = Output;
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
        //      C# -> FilterCreateResponse? Output
        // GraphQL -> output: FilterCreateResponse (type)
        if (this.Output != null) {
            s += ind + "output {\n" + this.Output.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FilterCreateResponse? Output
        // GraphQL -> output: FilterCreateResponse (type)
        if (this.Output == null && Exploration.Includes(parent + ".output"))
        {
            this.Output = new FilterCreateResponse();
            this.Output.ApplyExploratoryFieldSpec(parent + ".output");
        }
    }


    #endregion

    } // class UpdateVsphereAdvancedTagReply
    
    #endregion

    public static class ListUpdateVsphereAdvancedTagReplyExtensions
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
            this List<UpdateVsphereAdvancedTagReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateVsphereAdvancedTagReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateVsphereAdvancedTagReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types