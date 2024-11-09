using './cache.module.bicep'

param cache_volumes_0_storage = '{{ .Env.SERVICE_CACHE_VOLUME_AZURECONTAINERAPPSAPPHOSTA01EC9BC8DCACHEDATA_NAME }}'
param outputs_azure_container_apps_environment_id = '{{ .Env.AZURE_CONTAINER_APPS_ENVIRONMENT_ID }}'
param outputs_azure_container_registry_managed_identity_id = '{{ .Env.AZURE_CONTAINER_REGISTRY_MANAGED_IDENTITY_ID }}'
