﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.Batch.Test.ScenarioTests
{
    public class BatchAccountTests : WindowsAzure.Commands.Test.Utilities.Common.RMTestBase
    {
        [Fact]
        public void TestGetNonExistingBatchAccount()
        {
            BatchController.NewInstance.RunPsTest("Test-GetNonExistingBatchAccount");
        }

        [Fact]
        public void TestCreatesNewBatchAccount()
        {
            BatchController.NewInstance.RunPsTest("Test-CreatesNewBatchAccount");
        }

        [Fact]
        public void TestCreateExistingBatchAccount()
        {
            BatchController.NewInstance.RunPsTest("Test-CreateExistingBatchAccount");
        }

        [Fact]
        public void TestUpdatesExistingBatchAccount()
        {
            BatchController.NewInstance.RunPsTest("Test-UpdatesExistingBatchAccount");
        }

        [Fact]
        public void TestGetBatchAccountsUnderResourceGroups()
        {
            BatchController.NewInstance.RunPsTest("Test-GetBatchAccountsUnderResourceGroups");
        }

        [Fact]
        public void TestCreateAndRemoveBatchAccountViaPiping()
        {
            BatchController.NewInstance.RunPsTest("Test-CreateAndRemoveBatchAccountViaPiping");
        }

        [Fact]
        public void TestBatchAccountKeys()
        {
            BatchController.NewInstance.RunPsTest("Test-BatchAccountKeys");
        }

        [Fact]
        public void TestBatchAccountWithAutoStorage()
        {

            BatchController.NewInstance.RunPsTest("Test-CreateNewBatchAccountWithAutoStorage", Environment.GetEnvironmentVariable(ScenarioTestHelpers.StorageAccountEnvVar));
        }

        [Fact]
        public void TestUpdateBatchAccountWithAutoStorage()
        {
            string accountName = ScenarioTestHelpers.BatchAccountName;
            string storageId = Environment.GetEnvironmentVariable(ScenarioTestHelpers.StorageResourceId);

            BatchController.NewInstance.RunPsTest(string.Format("Test-UpdateBatchAccountWithAutoStorage '{0}' '{1}'", accountName, storageId));
        }
    }
}
