#Requires -Version 3
function Get-RscInfo {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding(
        # ___ Example ___
        # DefaultParameterSetName = "Id"
    )]
    Param(
        # ___ Example ___
        # Id parameter set:
        # [Parameter(
        #     ParameterSetName = "Id",
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [String]$Id,
        
        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }
        Write-Host "Get-RscInfo: $inputProfile"
        Write-Host "hello"
        $result = New-Object -TypeName PSObject
        $clusterCount = (Invoke-RscQueryCluster -List).Count
        $result | Add-Member -MemberType NoteProperty -Name "ClusterCount" -Value $clusterCount

        (Invoke-RscQueryCluster -List -Patch "nodes.cdmupgradeinfo").Nodes.CdmUpgradeInfo.ClusterJobStatus
        
        $result

        # ___ Example ___
        #
        # Retrieve input objects:
        #
        # $in = (___INVOKE_CMDLET___ -InputProfile $inputProfile -GetInput)
        #
        # Customize input:
        #
        # $in.Arg.clusterUuid = $Id
        #
        # Invoke GraphQL operation:
        #
        # $result = ___INVOKE_CMDLET___ -Input $in
        #
        # Filter results:
        #
        # if ( $PSCmdlet.ParameterSetName -eq "List" ) {
        #   $result = $result.Nodes
        # }
        #
        # Filter out null values:
        # $result | Remove-NullProperties
        #
    } 
}
