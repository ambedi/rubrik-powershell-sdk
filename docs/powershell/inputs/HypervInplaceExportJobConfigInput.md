### HypervInplaceExportJobConfigInput
Supported in v9.1+

- exportVmPath: System.String
  - Supported in v9.1+
      Location to save the Hyper-V Virtual Machine copy on the target host.
- hostId: System.String
  - Supported in v9.1+
      ID of the in-place recovery target host.
- shouldKeepHypervVmCopyAfterRecovery: System.Boolean
  - Supported in v9.1+
      Indicates whether to retain the Hyper-V exported copy on the target server after completing the in-place recovery. Use `true` to keep the snapshot after in-place recovery. Use `false` to delete the snapshot after in-place recovery.
