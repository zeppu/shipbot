using System;
using System.Threading.Tasks;
using Orleans;
using Shipbot.Controller.Core.Apps.Models;
using Shipbot.Controller.Core.Deployments.GrainState;
using Shipbot.Controller.Core.Deployments.Models;
using Shipbot.Controller.Core.Models;

namespace Shipbot.Controller.Core.Deployments.Grains
{
    public interface IDeploymentActionGrain : IGrainWithStringKey
    {
        Task<DeploymentActionStatus> GetStatus();

        Task SetStatus(DeploymentActionStatus status);


        Task SetParentDeploymentKey(DeploymentKey deploymentKey);
        Task Configure(Image image, string currentTag, string targetTag);
        Task<Image> GetImage();
        Task<string> GetTargetTag();
        Task<string> GetCurrentTag();
    }
}