### K8sAppManifest
Response of the query that retrieves the Kubernetes app manifest.

- version: System.String
  - Kubernetes Rubrik Backup Service version.
- isSuccessful: System.Boolean
  - Specifies the success or failure status.
- toApply: AppManifestInfo
  - Manifest information to apply the new version.
- toDelete: AppManifestInfo
  - Manifest information to delete the old version.
