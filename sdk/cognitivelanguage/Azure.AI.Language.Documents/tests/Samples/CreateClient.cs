// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
#region Snippet:DocumentAnalysisClient_Namespace
using Azure.AI.Language.Documents;
#endregion
using Azure.AI.Language.Documents.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;
#region Snippet:Documents_Identity_Namespace
using Azure.Identity;
#endregion

namespace Azure.AI.Language.TextAnalytics.Tests.Samples
{
    public partial class CreateClient : SamplesBase<DocumentAnalysisClientTestEnvironment>
    {
        [Test]
        public void CreateDocumentAnalysisClientForSpecificApiVersion()
        {
            #region Snippet:CreateDocumentAnalysisClientForSpecificApiVersion
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
            AzureKeyCredential credential = new("your apikey");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
            credential = new(TestEnvironment.ApiKey);
#endif
            DocumentAnalysisClientOptions options = new DocumentAnalysisClientOptions(DocumentAnalysisClientOptions.ServiceVersion.V2023_04_01);
            var client = new DocumentAnalysisClient(endpoint, credential, options);
            #endregion
        }

        [Test]
        public void CreateTextClient()
        {
            #region Snippet:CreateDocumentAnalysisClient
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
            AzureKeyCredential credential = new("your apikey");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
            credential = new(TestEnvironment.ApiKey);
#endif
            DocumentAnalysisClient client = new DocumentAnalysisClient(endpoint, credential);
            #endregion
        }

        [Test]
        public void DocumentAnalysisClient_CreateWithDefaultAzureCredential()
        {
            #region Snippet:DocumentAnalysisClient_CreateWithDefaultAzureCredential
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
#endif
            DefaultAzureCredential credential = new DefaultAzureCredential();
            DocumentAnalysisClient client = new DocumentAnalysisClient(endpoint, credential);
            #endregion
        }

        [Test]
        public void BadArgument()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
            DocumentAnalysisClient client = new DocumentAnalysisClient(endpoint, credential);

            #region Snippet:DocumentAnalysisClient_BadRequest
            try
            {
                string textA =
                "We love this trail and make the trip every year. The views are breathtaking and well worth the hike!"
                + " Yesterday was foggy though, so we missed the spectacular views. We tried again today and it was"
                + " amazing. Everyone in my family liked the trail although it was too challenging for the less"
                + " athletic among us. Not necessarily recommended for small children. A hotel close to the trail"
                + " offers services for childcare in case you want that.";

                AnalyzeTextInput body = new TextEntityRecognitionInput()
                {
                    TextInput = new MultiLanguageTextInput()
                    {
                        MultiLanguageInputs =
                        {
                            new MultiLanguageInput("D", textA),
                        }
                    },
                    ActionContent = new EntitiesActionContent()
                    {
                        ModelVersion = "NotValid", // Invalid model version will is a bad request.
                    }
                };

                Response<AnalyzeTextResult> response = client.AnalyzeText(body);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
