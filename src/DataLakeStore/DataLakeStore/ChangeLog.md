<!--
    Please leave this section at the top of the change log.

    Changes for the upcoming release should go under the section titled "Upcoming Release", and should adhere to the following format:

    ## Upcoming Release
    * Overview of change #1
        - Additional information about change #1
    * Overview of change #2
        - Additional information about change #2
        - Additional information about change #2
    * Overview of change #3
    * Overview of change #4
        - Additional information about change #4

    ## YYYY.MM.DD - Version X.Y.Z (Previous Release)
    * Overview of change #1
        - Additional information about change #1
-->
## Upcoming Release

## Version 1.0.1
* Update the sdk version of dataplane to 1.1.14 for SDK fixes.
    - Fix handling of negative acesstime and modificationtime for getfilestatus and liststatus, Fix async cancellation token

## Version 1.0.0
* General availability of `Az.DataLakeStore` module
* Update the sdk version of dataplane to 1.1.13
* Change the type of Encoding parameter to system.Encoding for commandlets: New-AzureRmDataLakeStoreItem, Add-AzureRmDataLakeStoreItemContent, Get-AzureRmDataLakeStoreItemContent to make it compatible to .netcore
* Removed deprecated -Tags alias from New/Set-AzDataLakeStoreAccount
* Removed deprecated properties from PSDataLakeStoreAccountBasic model