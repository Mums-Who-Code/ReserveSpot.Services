// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

namespace ReserveSpot.Services.Infrastructure.Build
{
    internal class program
    {
        static void Main(string[] args)
        {
            var adotNetClient = new ADotNetClient();

            var githubPipeline = new GithubPipeline()
            {
                Name = ".Net",

                OnEvents = new Events
                {
                    Push = new PushEvent
                    {
                        Branches = new String[] { "master" }
                    },

                    PullRequest = new PullRequestEvent
                    {
                        Branches = new String[] { "master" }
                    }
                },

                Jobs = new Jobs
                {
                    Build = new BuildJob
                    {
                        RunsOn = BuildMachines.Windows2019,

                        Steps = new List<GithubTask>
                        {
                            new CheckoutTaskV2
                            {
                                Name = "Check Out"
                            },

                            new SetupDotNetTaskV1
                            {
                                Name = "Setup Dot Net Version",

                                TargetDotNetVersion = new TargetDotNetVersion
                                {
                                    DotNetVersion = "7.0.0-preview.1",
                                    IncludePrerelease = true
                                }
                            },

                            new RestoreTask
                            {
                                Name = "Restore"
                            },

                            new DotNetBuildTask
                            {
                                Name = "Build"
                            },

                            new TestTask
                            {
                                Name =  "Test"
                            }
                        }
                    }
                }
            };

            adotNetClient.SerializeAndWriteToFile(githubPipeline, "../../../../.github/workflows/dotnet.yml");
        }
    }
}

